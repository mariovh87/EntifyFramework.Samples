using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Person
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string PersonIdentifier { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string FirstSurname { get; set; } = null!;

    public string? SecondSurname { get; set; }

    public string? DocumentNumber { get; set; }

    public DateTime? Birthday { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? PostalCode { get; set; }

    public int? Sex { get; set; }

    public int? Volunteer { get; set; }

    public string? Remarks { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? MigrationId { get; set; }

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
