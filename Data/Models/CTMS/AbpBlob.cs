using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class AbpBlob
{
    public Guid Id { get; set; }

    public Guid ContainerId { get; set; }

    public Guid? TenantId { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? Content { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual AbpBlobContainer Container { get; set; } = null!;
}
