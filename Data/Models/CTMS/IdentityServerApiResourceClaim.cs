using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerApiResourceClaim
{
    public string Type { get; set; } = null!;

    public Guid ApiResourceId { get; set; }

    public virtual IdentityServerApiResource ApiResource { get; set; } = null!;
}
