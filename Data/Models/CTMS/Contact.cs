using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Contact
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public string? Name { get; set; }

    public string? FirstSurname { get; set; }

    public string? SecondSurname { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public string? SocialReason { get; set; }

    public int Type { get; set; }

    public string? Nationality { get; set; }

    public string? Remarks { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? LeavingDate { get; set; }

    public Guid? ContactTypeId { get; set; }

    public Guid? ImageId { get; set; }

    public string? ContactAddressAddress { get; set; }

    public string? ContactAddressPopulation { get; set; }

    public string? ContactAddressPostalCode { get; set; }

    public string? ContactAddressProvince { get; set; }

    public string? ContactAddressCountry { get; set; }

    public string? ContactAddressEmail { get; set; }

    public string? ContactAddressPhone { get; set; }

    public string? ContactAddressMobilePhone { get; set; }

    public string? ContactAddressWebsite { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ICollection<ContactPerson> ContactPeople { get; set; } = new List<ContactPerson>();

    public virtual ContactType? ContactType { get; set; }

    public virtual ICollection<TrialStakeholder> TrialStakeholders { get; set; } = new List<TrialStakeholder>();
}
