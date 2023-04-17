using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ProcedureCost
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Cost1 { get; set; }

    public decimal? Cost2 { get; set; }

    public decimal? Cost3 { get; set; }

    public decimal? Cost4 { get; set; }

    public decimal? Cost5 { get; set; }

    public decimal? Cost6 { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ICollection<EconomicMemoryProcedure> EconomicMemoryProcedures { get; set; } = new List<EconomicMemoryProcedure>();

    public virtual ICollection<ParticipantVisitProcedure> ParticipantVisitProcedures { get; set; } = new List<ParticipantVisitProcedure>();

    public virtual ICollection<ProcedureCostSite> ProcedureCostSites { get; set; } = new List<ProcedureCostSite>();
}
