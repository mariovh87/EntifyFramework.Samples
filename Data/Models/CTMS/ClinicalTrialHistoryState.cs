using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ClinicalTrialHistoryState
{
    public Guid Id { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public Guid StateId { get; set; }

    public string? Reason { get; set; }

    public DateTime StateDate { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public string? CreatorFullName { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public Guid? TenantId { get; set; }

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual ClinicalTrialState State { get; set; } = null!;
}
