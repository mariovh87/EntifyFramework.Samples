using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class IdentityServerApiResource
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? Description { get; set; }

    public bool Enabled { get; set; }

    public string? AllowedAccessTokenSigningAlgorithms { get; set; }

    public bool ShowInDiscoveryDocument { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ICollection<IdentityServerApiResourceClaim> IdentityServerApiResourceClaims { get; set; } = new List<IdentityServerApiResourceClaim>();

    public virtual ICollection<IdentityServerApiResourceProperty> IdentityServerApiResourceProperties { get; set; } = new List<IdentityServerApiResourceProperty>();

    public virtual ICollection<IdentityServerApiResourceScope> IdentityServerApiResourceScopes { get; set; } = new List<IdentityServerApiResourceScope>();

    public virtual ICollection<IdentityServerApiResourceSecret> IdentityServerApiResourceSecrets { get; set; } = new List<IdentityServerApiResourceSecret>();
}
