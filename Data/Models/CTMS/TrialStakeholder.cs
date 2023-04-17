using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class TrialStakeholder
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public Guid StakeholderId { get; set; }

    public DateTime From { get; set; }

    public DateTime? To { get; set; }

    public Guid? ContactPersonId { get; set; }

    public int? ExternalAccess { get; set; }

    public int? MigrationId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public Guid InQualityOfId { get; set; }

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual ContactPerson? ContactPerson { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual InQualitiesOf InQualityOf { get; set; } = null!;

    public virtual Contact Stakeholder { get; set; } = null!;
}
