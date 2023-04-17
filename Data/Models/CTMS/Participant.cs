using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Participant
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public string? SecondaryIdentifier { get; set; }

    public string ParticipantIdentifier { get; set; } = null!;

    public string? RandomizationCode { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? PlanningStartDate { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public Guid? ClinicalTrialArmId { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public bool? IsActive { get; set; }

    public Guid? PersonId { get; set; }

    public DateTime? LastDoseDate { get; set; }

    public Guid? StateId { get; set; }

    public int? MigrationId { get; set; }

    public string? SyncId { get; set; }

    public Guid? ContractId { get; set; }

    public int? PlanningStatusId { get; set; }

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual Arm? ClinicalTrialArm { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual ICollection<ParticipantAdverseEvent> ParticipantAdverseEvents { get; set; } = new List<ParticipantAdverseEvent>();

    public virtual ICollection<ParticipantHistoryEvent> ParticipantHistoryEvents { get; set; } = new List<ParticipantHistoryEvent>();

    public virtual ICollection<ParticipantVisit> ParticipantVisits { get; set; } = new List<ParticipantVisit>();

    public virtual Person? Person { get; set; }

    public virtual ParticipantState? State { get; set; }
}
