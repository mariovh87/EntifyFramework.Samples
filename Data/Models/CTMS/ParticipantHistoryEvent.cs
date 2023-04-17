﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ParticipantHistoryEvent
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ParticipantId { get; set; }

    public DateTime RelatedDate { get; set; }

    public string EntityId { get; set; } = null!;

    public string? Reason { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public string? CreatorFullName { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int EventTypeId { get; set; }

    public virtual Participant Participant { get; set; } = null!;
}
