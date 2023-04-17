using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerIdentityResourceClaim
{
    public string Type { get; set; } = null!;

    public Guid IdentityResourceId { get; set; }

    public virtual IdentityServerIdentityResource IdentityResource { get; set; } = null!;
}
