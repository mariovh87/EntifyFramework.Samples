﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerApiScopeProperty
{
    public Guid ApiScopeId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual IdentityServerApiScope ApiScope { get; set; } = null!;
}
