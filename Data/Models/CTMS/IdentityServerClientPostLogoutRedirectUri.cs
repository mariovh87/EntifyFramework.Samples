using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientPostLogoutRedirectUri
{
    public Guid ClientId { get; set; }

    public string PostLogoutRedirectUri { get; set; } = null!;

    public virtual IdentityServerClient Client { get; set; } = null!;
}
