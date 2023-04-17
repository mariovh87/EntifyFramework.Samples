using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ContactPerson
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid RelatedEntityId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? SecondSurname { get; set; }

    public Guid ContactPositionId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumber2 { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ContactPosition ContactPosition { get; set; } = null!;

    public virtual Contact RelatedEntity { get; set; } = null!;

    public virtual ICollection<TrialStakeholder> TrialStakeholders { get; set; } = new List<TrialStakeholder>();
}
