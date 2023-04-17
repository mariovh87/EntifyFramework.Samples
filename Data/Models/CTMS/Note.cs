using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Note
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? EntityId { get; set; }

    public int EntityType { get; set; }

    public string Message { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ICollection<NoteRecipient> NoteRecipients { get; set; } = new List<NoteRecipient>();
}
