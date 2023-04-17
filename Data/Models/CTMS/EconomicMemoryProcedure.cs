using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class EconomicMemoryProcedure
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid ProcedureId { get; set; }

    public int Offset { get; set; }

    public int Quantity { get; set; }

    public decimal Cost1 { get; set; }

    public decimal Cost2 { get; set; }

    public decimal Cost3 { get; set; }

    public decimal Cost4 { get; set; }

    public decimal Cost5 { get; set; }

    public decimal Cost6 { get; set; }

    public decimal Cost { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Price { get; set; }

    public string? Remarks { get; set; }

    public int Type { get; set; }

    public Guid? VisitId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public Guid? ContractArmId { get; set; }

    public int? MigrationId { get; set; }

    public int OrderMemory { get; set; }

    public Guid? BillableToId { get; set; }

    public virtual EconomicMemoryBillableTo? BillableTo { get; set; }

    public virtual Arm? ContractArm { get; set; }

    public virtual ICollection<ParticipantVisitProcedure> ParticipantVisitProcedures { get; set; } = new List<ParticipantVisitProcedure>();

    public virtual ProcedureCost Procedure { get; set; } = null!;

    public virtual EconomicMemoryVisit? Visit { get; set; }
}
