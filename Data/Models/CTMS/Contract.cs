using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Contract
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string Description { get; set; } = null!;

    public DateTime From { get; set; }

    public DateTime? To { get; set; }

    public int Currency { get; set; }

    public int BillingPeriod { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public int BillingType { get; set; }

    public float RetentionRate { get; set; }

    public string? Remarks { get; set; }

    public int ToCompleteActivity { get; set; }

    public int ToReviewInvoice { get; set; }

    public int ToInvoice { get; set; }

    public int ToCharge { get; set; }

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

    public Guid? CostCenterId { get; set; }

    public Guid? TrialStakeholderId { get; set; }

    public virtual ICollection<Arm> Arms { get; set; } = new List<Arm>();

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual CostCenter? CostCenter { get; set; }

    public virtual ICollection<EconomicSummaryMilestoneBillingItem> EconomicSummaryMilestoneBillingItems { get; set; } = new List<EconomicSummaryMilestoneBillingItem>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public virtual TrialStakeholder? TrialStakeholder { get; set; }
}
