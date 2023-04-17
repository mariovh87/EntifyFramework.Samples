﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class AbpRole
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public string Name { get; set; } = null!;

    public string NormalizedName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public bool IsStatic { get; set; }

    public bool IsPublic { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; } = new List<AbpOrganizationUnitRole>();

    public virtual ICollection<AbpRoleClaim> AbpRoleClaims { get; set; } = new List<AbpRoleClaim>();

    public virtual ICollection<AbpUserRole> AbpUserRoles { get; set; } = new List<AbpUserRole>();
}
