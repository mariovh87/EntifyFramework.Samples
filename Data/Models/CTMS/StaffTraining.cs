using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class StaffTraining
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public string? Title { get; set; }

    public Guid StaffId { get; set; }

    public Guid TrainingTypeId { get; set; }

    public string? Center { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? HoursNumber { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public virtual Staff Staff { get; set; } = null!;

    public virtual PersonalTraining TrainingType { get; set; } = null!;
}
