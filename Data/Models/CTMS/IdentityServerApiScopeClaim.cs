using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerApiScopeClaim
{
    public string Type { get; set; } = null!;

    public Guid ApiScopeId { get; set; }

    public virtual IdentityServerApiScope ApiScope { get; set; } = null!;
}
