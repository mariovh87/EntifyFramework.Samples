using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstEFCoreConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstEFCoreConsoleApp.Repositories
{
    public class AuthorsRepository
    {
        private readonly LibraryContext _context;

        public AuthorsRepository(LibraryContext context)
        {
            _context = context;;
        }

        public async Task<ICollection<Author?>> GetAll()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<ICollection<string>> GetAllNames()
        {
            return await _context.Authors
                .Select(a=>a.Name)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ICollection<Author?>> GetAllOrdered()
        {
            return await _context.Authors
                .OrderBy(a=>a.Name)
                .ThenBy(a=>a.LastName)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Author?> GetFirstWithBooksCountryAndAuditEntries()
        {
            return await _context.Authors
                .Include(b=>b.Books.Where(bf=>bf.Title=="LibroPrueba"))
                .Include(c=>c.Country)
                .ThenInclude(c=>c.AuditEntries)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// With traking change in author Name reflected in authors memory collection
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesDemoWithTraking()
        {
            var authors = await _context.Authors.ToListAsync();
            var author = await _context.Authors.FirstOrDefaultAsync();
            if (author != null) author.Name = "Mario";
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesDemoWithoutTraking()
        {
            var authors = await GetAll();
            authors.First()!.Name = "Mario";
            await _context.SaveChangesAsync();

            var author = await _context.Authors.FirstOrDefaultAsync();
        }

        public async Task<ICollection<Author>> IgnoreQueryFilters()
        {
            return await _context.Authors.IgnoreQueryFilters().ToListAsync();
        }

        public async Task<ICollection<Author>> SqlRawQuery()
        {
            var name = "Mario";
            var authors = await _context.Authors.FromSqlInterpolated($"Select * from Authors where Name={name}").ToListAsync();
            return await _context.Authors.FromSqlRaw("Select * from Authors").ToListAsync(); 
        }

        public async Task Transaction()
        {
            var transaction = await _context.Database.BeginTransactionAsync();
            //do changes
            await _context.SaveChangesAsync();
            //do changes
            try
            {
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {

            }
            
        }


    }
}
