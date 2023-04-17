﻿using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class AbpEntityChange
{
    public Guid Id { get; set; }

    public Guid AuditLogId { get; set; }

    public Guid? TenantId { get; set; }

    public DateTime ChangeTime { get; set; }

    public byte ChangeType { get; set; }

    public Guid? EntityTenantId { get; set; }

    public string EntityId { get; set; } = null!;

    public string EntityTypeFullName { get; set; } = null!;

    public string? ExtraProperties { get; set; }

    public virtual ICollection<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; } = new List<AbpEntityPropertyChange>();

    public virtual AbpAuditLog AuditLog { get; set; } = null!;
}
