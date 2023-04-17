using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ParticipantVisit
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public int StatusId { get; set; }

    public DateTime RelatedDate { get; set; }

    public Guid ParticipantId { get; set; }

    public Guid? EconomicMemoryVisitId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? Description { get; set; }

    public string? Comments { get; set; }

    public Guid? MonitoringId { get; set; }

    public Guid? CalendarEventId { get; set; }

    public virtual CalendarEvent? CalendarEvent { get; set; }

    public virtual EconomicMemoryVisit? EconomicMemoryVisit { get; set; }

    public virtual Monitoring? Monitoring { get; set; }

    public virtual Participant Participant { get; set; } = null!;

    public virtual ICollection<ParticipantVisitExpense> ParticipantVisitExpenses { get; set; } = new List<ParticipantVisitExpense>();

    public virtual ICollection<ParticipantVisitProcedure> ParticipantVisitProcedures { get; set; } = new List<ParticipantVisitProcedure>();
}
