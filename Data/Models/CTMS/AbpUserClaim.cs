﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class AbpUserClaim
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid? TenantId { get; set; }

    public string ClaimType { get; set; } = null!;

    public string? ClaimValue { get; set; }

    public virtual AbpUser User { get; set; } = null!;
}
