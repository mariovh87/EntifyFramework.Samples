using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ParticipantAdverseEvent
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ParticipantId { get; set; }

    public string AdverseEventDescription { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public DateTime? EventHour { get; set; }

    public DateTime? KnowledgeDate { get; set; }

    public DateTime? ReportDate { get; set; }

    public Guid? SeverityId { get; set; }

    public Guid? SeverityCriterionId { get; set; }

    public Guid? InterventionRelationshipId { get; set; }

    public Guid? AdverseEventStateId { get; set; }

    public Guid? AdminRouteId { get; set; }

    public Guid? ActionTakenId { get; set; }

    public Guid? OutcomeId { get; set; }

    public string? Medicine { get; set; }

    public string? Dose { get; set; }

    public DateTime? MedicationFromDate { get; set; }

    public DateTime? MedicationToDate { get; set; }

    public string? Comment { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public string? CreatorFullName { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ActionsTaken? ActionTaken { get; set; }

    public virtual AdminRoute? AdminRoute { get; set; }

    public virtual AdverseEventState? AdverseEventState { get; set; }

    public virtual InterventionRelationship? InterventionRelationship { get; set; }

    public virtual Outcome? Outcome { get; set; }

    public virtual Participant Participant { get; set; } = null!;

    public virtual Severity? Severity { get; set; }

    public virtual SeverityCriterion? SeverityCriterion { get; set; }
}
