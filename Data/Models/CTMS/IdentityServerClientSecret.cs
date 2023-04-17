﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientSecret
{
    public string Type { get; set; } = null!;

    public string Value { get; set; } = null!;

    public Guid ClientId { get; set; }

    public string? Description { get; set; }

    public DateTime? Expiration { get; set; }

    public virtual IdentityServerClient Client { get; set; } = null!;
}
