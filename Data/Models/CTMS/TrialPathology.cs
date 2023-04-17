using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class TrialPathology
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid PathologyId { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual Pathology Pathology { get; set; } = null!;
}
