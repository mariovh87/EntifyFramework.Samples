using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class Arm
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ClinicalTrialId { get; set; }

    public string Description { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public Guid? ContractId { get; set; }

    public int Type { get; set; }

    public Guid? ClinicalTrialArmId { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public bool? IsActive { get; set; }

    public int? MigrationId { get; set; }

    public virtual ClinicalTrial ClinicalTrial { get; set; } = null!;

    public virtual Arm? ClinicalTrialArm { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual ICollection<EconomicMemoryProcedure> EconomicMemoryProcedures { get; set; } = new List<EconomicMemoryProcedure>();

    public virtual ICollection<EconomicMemoryVisit> EconomicMemoryVisits { get; set; } = new List<EconomicMemoryVisit>();

    public virtual ICollection<Arm> InverseClinicalTrialArm { get; set; } = new List<Arm>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
