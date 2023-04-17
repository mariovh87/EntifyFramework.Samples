using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ParticipantVisitProcedure
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public int StatusId { get; set; }

    public Guid ParticipantVisitId { get; set; }

    public Guid? EconomicMemoryProcedureId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int ActivityTypeId { get; set; }

    public bool? IsBillable { get; set; }

    public int Units { get; set; }

    public Guid ProcedureTypeId { get; set; }

    public DateTime RelatedDate { get; set; }

    public string? Remarks { get; set; }

    public virtual EconomicMemoryProcedure? EconomicMemoryProcedure { get; set; }

    public virtual ParticipantVisit ParticipantVisit { get; set; } = null!;

    public virtual ProcedureCost ProcedureType { get; set; } = null!;
}
