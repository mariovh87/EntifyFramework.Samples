using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientScope
{
    public Guid ClientId { get; set; }

    public string Scope { get; set; } = null!;

    public virtual IdentityServerClient Client { get; set; } = null!;
}
