using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class InterventionRelationship
{
    public Guid Id { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public Guid? TenantId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public bool IsDefault { get; set; }

    public int? SystemId { get; set; }

    public string? SyncId { get; set; }

    public virtual ICollection<ParticipantAdverseEvent> ParticipantAdverseEvents { get; set; } = new List<ParticipantAdverseEvent>();
}
