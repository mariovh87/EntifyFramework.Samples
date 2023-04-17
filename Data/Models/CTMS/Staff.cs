using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Staff
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid UserId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string? IdentityCardNumber { get; set; }

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

    public virtual ICollection<StaffProfessionalSkill> StaffProfessionalSkills { get; set; } = new List<StaffProfessionalSkill>();

    public virtual ICollection<StaffTraining> StaffTrainings { get; set; } = new List<StaffTraining>();

    public virtual AbpUser User { get; set; } = null!;
}
