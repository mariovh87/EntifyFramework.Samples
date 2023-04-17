using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class SitesService
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string Code { get; set; } = null!;

    public int? MigrationId { get; set; }

    public virtual ICollection<ClinicalTrial> ClinicalTrialServices { get; set; } = new List<ClinicalTrial>();

    public virtual ICollection<ClinicalTrial> ClinicalTrialSites { get; set; } = new List<ClinicalTrial>();

    public virtual ICollection<SitesService> InverseParent { get; set; } = new List<SitesService>();

    public virtual SitesService? Parent { get; set; }

    public virtual ICollection<ProcedureCostSite> ProcedureCostSites { get; set; } = new List<ProcedureCostSite>();
}
