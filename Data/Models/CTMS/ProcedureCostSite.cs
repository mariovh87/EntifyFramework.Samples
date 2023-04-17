using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ProcedureCostSite
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid SiteId { get; set; }

    public Guid ProcedureCostId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ProcedureCost ProcedureCost { get; set; } = null!;

    public virtual SitesService Site { get; set; } = null!;
}
