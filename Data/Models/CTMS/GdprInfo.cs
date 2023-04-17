using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class GdprInfo
{
    public Guid Id { get; set; }

    public Guid RequestId { get; set; }

    public string Data { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public virtual GdprRequest Request { get; set; } = null!;
}
