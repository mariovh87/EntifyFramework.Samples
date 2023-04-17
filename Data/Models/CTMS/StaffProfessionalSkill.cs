using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class StaffProfessionalSkill
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public DateTime ObtainedDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public Guid StaffId { get; set; }

    public Guid ProfessionalSkillId { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public virtual ProfessionalSkill ProfessionalSkill { get; set; } = null!;

    public virtual Staff Staff { get; set; } = null!;
}
