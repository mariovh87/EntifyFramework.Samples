using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class CalendarEvent
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid CalendarId { get; set; }

    public string Type { get; set; } = null!;

    public Guid? OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public Guid? RelatedEntityId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public bool IsFullDayEvent { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual Calendar Calendar { get; set; } = null!;

    public virtual ICollection<ParticipantVisit> ParticipantVisits { get; set; } = new List<ParticipantVisit>();
}
