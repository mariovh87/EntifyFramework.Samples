using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ParticipantVisitExpense
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid VisitId { get; set; }

    public Guid TypeId { get; set; }

    public string? ReceiptNumber { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public string Description { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public virtual ExpenseType Type { get; set; } = null!;

    public virtual ParticipantVisit Visit { get; set; } = null!;
}
