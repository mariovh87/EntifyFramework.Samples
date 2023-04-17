﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerClientGrantType
{
    public Guid ClientId { get; set; }

    public string GrantType { get; set; } = null!;

    public virtual IdentityServerClient Client { get; set; } = null!;
}
