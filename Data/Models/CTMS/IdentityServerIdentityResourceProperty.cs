using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerIdentityResourceProperty
{
    public Guid IdentityResourceId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual IdentityServerIdentityResource IdentityResource { get; set; } = null!;
}
