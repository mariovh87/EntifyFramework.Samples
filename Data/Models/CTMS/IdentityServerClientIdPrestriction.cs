using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientIdPrestriction
{
    public Guid ClientId { get; set; }

    public string Provider { get; set; } = null!;

    public virtual IdentityServerClient Client { get; set; } = null!;
}
