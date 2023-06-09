﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstEFCoreConsoleApp.Model
{
    [Comment("Tabla para almacenar los libros existentes en la biblioteca")]
    public partial class BookWithProxies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        //To proxy be able to overwrite. Only when get is call, it obtains related entity. Carga diferida UseLazyLoadingProxies
        public virtual Author Author { get; set; }
        public string Title { get; set; }
        public string Sinopsis { get; set; }
    }
}
