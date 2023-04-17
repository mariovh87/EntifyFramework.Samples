using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class SaasTenantConnectionString
{
    public Guid TenantId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual SaasTenant Tenant { get; set; } = null!;
}
