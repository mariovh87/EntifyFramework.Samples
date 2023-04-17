using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class GdprRequest
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime ReadyTime { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<GdprInfo> GdprInfos { get; set; } = new List<GdprInfo>();
}
