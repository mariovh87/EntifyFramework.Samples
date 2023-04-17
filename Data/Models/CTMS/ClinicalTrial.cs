using System;
using System.Collections.Generic;

namespace EntityFramework.Samples.Data.Models.CTMS;

public partial class ClinicalTrial
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public string Identifier { get; set; } = null!;

    public string? ProtocolCode { get; set; }

    public string? Euct { get; set; }

    public string? EudraCt { get; set; }

    public string? CommitteeCode { get; set; }

    public string? NctCode { get; set; }

    public string? Acronym { get; set; }

    public string? Objectives { get; set; }

    public string Title { get; set; } = null!;

    public Guid StudyTypeId { get; set; }

    public Guid? StudySubtypeId { get; set; }

    public Guid? ConsiderationId { get; set; }

    public string? Remarks { get; set; }

    public Guid? PhaseId { get; set; }

    public Guid? SiteTypeId { get; set; }

    public int? Randomization { get; set; }

    public Guid? ControlId { get; set; }

    public Guid? ComparerId { get; set; }

    public DateTime? StartVisitDate { get; set; }

    public DateTime? EndRecruitmentDate { get; set; }

    public DateTime? FirstParticipantInclusionDate { get; set; }

    public DateTime? ClosingVisitDate { get; set; }

    public string? ExtraProperties { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid? CreatorId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsDeleted { get; set; }

    public Guid? DeleterId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? InactiveReason { get; set; }

    public bool? IsActive { get; set; }

    public int EstimatedRecruitment { get; set; }

    public Guid StateId { get; set; }

    public int? MigrationId { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public Guid? ServiceId { get; set; }

    public Guid? SiteId { get; set; }

    public Guid? MaskingId { get; set; }

    public DateTime? StartDate { get; set; }

    public Guid? CalendarId { get; set; }

    public virtual ICollection<Arm> Arms { get; set; } = new List<Arm>();

    public virtual Calendar? Calendar { get; set; }

    public virtual ICollection<ClinicalTrialHistoryState> ClinicalTrialHistoryStates { get; set; } = new List<ClinicalTrialHistoryState>();

    public virtual Comparer? Comparer { get; set; }

    public virtual Consideration? Consideration { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Control? Control { get; set; }

    public virtual ICollection<Drug> Drugs { get; set; } = new List<Drug>();

    public virtual ClinicalTrialMasking? Masking { get; set; }

    public virtual AbpOrganizationUnit? OrganizationUnit { get; set; }

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public virtual Phase? Phase { get; set; }

    public virtual SitesService? Service { get; set; }

    public virtual SitesService? Site { get; set; }

    public virtual SiteType? SiteType { get; set; }

    public virtual ClinicalTrialState State { get; set; } = null!;

    public virtual StudyType? StudySubtype { get; set; }

    public virtual StudyType StudyType { get; set; } = null!;

    public virtual ICollection<TrialPathology> TrialPathologies { get; set; } = new List<TrialPathology>();

    public virtual ICollection<TrialPopulationGroup> TrialPopulationGroups { get; set; } = new List<TrialPopulationGroup>();

    public virtual ICollection<TrialStakeholder> TrialStakeholders { get; set; } = new List<TrialStakeholder>();

    public virtual ICollection<TrialStudyField> TrialStudyFields { get; set; } = new List<TrialStudyField>();
}
