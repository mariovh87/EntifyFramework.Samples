using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class UserFilter
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public string ScopeKey { get; set; } = null!;

    public string Name { get; set; } = null!;

    public Guid UserId { get; set; }

    public string? Filter { get; set; }

    public bool IsPublic { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }
}
