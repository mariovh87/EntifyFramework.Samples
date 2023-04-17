using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class EconomicMemoryVisit
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ContractArmId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? BillingIncomeConceptId { get; set; }

    public int PlanningTypeId { get; set; }

    public string Title { get; set; } = null!;

    public int Day { get; set; }

    public int Window { get; set; }

    public decimal Price { get; set; }

    public decimal Cost { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? MigrationId { get; set; }

    public int OrderMemory { get; set; }

    public Guid? BillableToId { get; set; }

    public virtual EconomicMemoryBillableTo? BillableTo { get; set; }

    public virtual BillingIncomeConcept? BillingIncomeConcept { get; set; }

    public virtual Arm ContractArm { get; set; } = null!;

    public virtual ICollection<EconomicMemoryProcedure> EconomicMemoryProcedures { get; set; } = new List<EconomicMemoryProcedure>();

    public virtual Group? Group { get; set; }

    public virtual ICollection<ParticipantVisit> ParticipantVisits { get; set; } = new List<ParticipantVisit>();
}
