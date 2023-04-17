using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientCorsOrigin
{
    public Guid ClientId { get; set; }

    public string Origin { get; set; } = null!;

    public virtual IdentityServerClient Client { get; set; } = null!;
}
