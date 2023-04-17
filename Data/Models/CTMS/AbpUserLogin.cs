﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class AbpUserLogin
{
    public Guid UserId { get; set; }

    public string LoginProvider { get; set; } = null!;

    public Guid? TenantId { get; set; }

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public virtual AbpUser User { get; set; } = null!;
}
