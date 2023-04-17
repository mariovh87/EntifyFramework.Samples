using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerApiResourceScope
{
    public Guid ApiResourceId { get; set; }

    public string Scope { get; set; } = null!;

    public virtual IdentityServerApiResource ApiResource { get; set; } = null!;
}
