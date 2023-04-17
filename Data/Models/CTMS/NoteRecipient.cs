using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class NoteRecipient
{
    public Guid NoteId { get; set; }

    public Guid RecipientId { get; set; }

    public int Type { get; set; }

    public virtual Note Note { get; set; } = null!;
}
