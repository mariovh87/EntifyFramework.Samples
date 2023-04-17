using System;
using System.Collections.Generic;
using EntityFramework.Samples.Data.Models.CTMS;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Samples.Data.Data;

public partial class CtmsContext : DbContext
{
    public CtmsContext()
    {
    }

    public CtmsContext(DbContextOptions<CtmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbpAuditLog> AbpAuditLogs { get; set; }

    public virtual DbSet<AbpAuditLogAction> AbpAuditLogActions { get; set; }

    public virtual DbSet<AbpBackgroundJob> AbpBackgroundJobs { get; set; }

    public virtual DbSet<AbpBlob> AbpBlobs { get; set; }

    public virtual DbSet<AbpBlobContainer> AbpBlobContainers { get; set; }

    public virtual DbSet<AbpClaimType> AbpClaimTypes { get; set; }

    public virtual DbSet<AbpEntityChange> AbpEntityChanges { get; set; }

    public virtual DbSet<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }

    public virtual DbSet<AbpFeatureValue> AbpFeatureValues { get; set; }

    public virtual DbSet<AbpLanguage> AbpLanguages { get; set; }

    public virtual DbSet<AbpLanguageText> AbpLanguageTexts { get; set; }

    public virtual DbSet<AbpLinkUser> AbpLinkUsers { get; set; }

    public virtual DbSet<AbpOrganizationUnit> AbpOrganizationUnits { get; set; }

    public virtual DbSet<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }

    public virtual DbSet<AbpPermissionGrant> AbpPermissionGrants { get; set; }

    public virtual DbSet<AbpRole> AbpRoles { get; set; }

    public virtual DbSet<AbpRoleClaim> AbpRoleClaims { get; set; }

    public virtual DbSet<AbpSecurityLog> AbpSecurityLogs { get; set; }

    public virtual DbSet<AbpSetting> AbpSettings { get; set; }

    public virtual DbSet<AbpTextTemplateContent> AbpTextTemplateContents { get; set; }

    public virtual DbSet<AbpUser> AbpUsers { get; set; }

    public virtual DbSet<AbpUserClaim> AbpUserClaims { get; set; }

    public virtual DbSet<AbpUserLogin> AbpUserLogins { get; set; }

    public virtual DbSet<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }

    public virtual DbSet<AbpUserRole> AbpUserRoles { get; set; }

    public virtual DbSet<AbpUserToken> AbpUserTokens { get; set; }

    public virtual DbSet<ActionsTaken> ActionsTakens { get; set; }

    public virtual DbSet<AdminRoute> AdminRoutes { get; set; }

    public virtual DbSet<AdverseEventState> AdverseEventStates { get; set; }

    public virtual DbSet<Arm> Arms { get; set; }

    public virtual DbSet<BillingIncomeConcept> BillingIncomeConcepts { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<ClinicalTrial> ClinicalTrials { get; set; }

    public virtual DbSet<ClinicalTrialHistoryState> ClinicalTrialHistoryStates { get; set; }

    public virtual DbSet<ClinicalTrialMasking> ClinicalTrialMaskings { get; set; }

    public virtual DbSet<ClinicalTrialState> ClinicalTrialStates { get; set; }

    public virtual DbSet<Comparer> Comparers { get; set; }

    public virtual DbSet<Consideration> Considerations { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactPerson> ContactPeople { get; set; }

    public virtual DbSet<ContactPosition> ContactPositions { get; set; }

    public virtual DbSet<ContactType> ContactTypes { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContributionType> ContributionTypes { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<CostCenter> CostCenters { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<DrugTerm> DrugTerms { get; set; }

    public virtual DbSet<EconomicMemoryBillableTo> EconomicMemoryBillableTos { get; set; }

    public virtual DbSet<EconomicMemoryProcedure> EconomicMemoryProcedures { get; set; }

    public virtual DbSet<EconomicMemoryVisit> EconomicMemoryVisits { get; set; }

    public virtual DbSet<EconomicSummaryMilestoneBillingItem> EconomicSummaryMilestoneBillingItems { get; set; }

    public virtual DbSet<EventBusSubscription> EventBusSubscriptions { get; set; }

    public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }

    public virtual DbSet<GdprInfo> GdprInfos { get; set; }

    public virtual DbSet<GdprRequest> GdprRequests { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<IdentityServerApiResource> IdentityServerApiResources { get; set; }

    public virtual DbSet<IdentityServerApiResourceClaim> IdentityServerApiResourceClaims { get; set; }

    public virtual DbSet<IdentityServerApiResourceProperty> IdentityServerApiResourceProperties { get; set; }

    public virtual DbSet<IdentityServerApiResourceScope> IdentityServerApiResourceScopes { get; set; }

    public virtual DbSet<IdentityServerApiResourceSecret> IdentityServerApiResourceSecrets { get; set; }

    public virtual DbSet<IdentityServerApiScope> IdentityServerApiScopes { get; set; }

    public virtual DbSet<IdentityServerApiScopeClaim> IdentityServerApiScopeClaims { get; set; }

    public virtual DbSet<IdentityServerApiScopeProperty> IdentityServerApiScopeProperties { get; set; }

    public virtual DbSet<IdentityServerClient> IdentityServerClients { get; set; }

    public virtual DbSet<IdentityServerClientClaim> IdentityServerClientClaims { get; set; }

    public virtual DbSet<IdentityServerClientCorsOrigin> IdentityServerClientCorsOrigins { get; set; }

    public virtual DbSet<IdentityServerClientGrantType> IdentityServerClientGrantTypes { get; set; }

    public virtual DbSet<IdentityServerClientIdPrestriction> IdentityServerClientIdPrestrictions { get; set; }

    public virtual DbSet<IdentityServerClientPostLogoutRedirectUri> IdentityServerClientPostLogoutRedirectUris { get; set; }

    public virtual DbSet<IdentityServerClientProperty> IdentityServerClientProperties { get; set; }

    public virtual DbSet<IdentityServerClientRedirectUri> IdentityServerClientRedirectUris { get; set; }

    public virtual DbSet<IdentityServerClientScope> IdentityServerClientScopes { get; set; }

    public virtual DbSet<IdentityServerClientSecret> IdentityServerClientSecrets { get; set; }

    public virtual DbSet<IdentityServerDeviceFlowCode> IdentityServerDeviceFlowCodes { get; set; }

    public virtual DbSet<IdentityServerIdentityResource> IdentityServerIdentityResources { get; set; }

    public virtual DbSet<IdentityServerIdentityResourceClaim> IdentityServerIdentityResourceClaims { get; set; }

    public virtual DbSet<IdentityServerIdentityResourceProperty> IdentityServerIdentityResourceProperties { get; set; }

    public virtual DbSet<IdentityServerPersistedGrant> IdentityServerPersistedGrants { get; set; }

    public virtual DbSet<InQualitiesOf> InQualitiesOfs { get; set; }

    public virtual DbSet<InterventionRelationship> InterventionRelationships { get; set; }

    public virtual DbSet<Monitoring> Monitorings { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NoteRecipient> NoteRecipients { get; set; }

    public virtual DbSet<Outcome> Outcomes { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<ParticipantAdverseEvent> ParticipantAdverseEvents { get; set; }

    public virtual DbSet<ParticipantHistoryEvent> ParticipantHistoryEvents { get; set; }

    public virtual DbSet<ParticipantState> ParticipantStates { get; set; }

    public virtual DbSet<ParticipantVisit> ParticipantVisits { get; set; }

    public virtual DbSet<ParticipantVisitExpense> ParticipantVisitExpenses { get; set; }

    public virtual DbSet<ParticipantVisitProcedure> ParticipantVisitProcedures { get; set; }

    public virtual DbSet<Pathology> Pathologies { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<PersonalRole> PersonalRoles { get; set; }

    public virtual DbSet<PersonalTraining> PersonalTrainings { get; set; }

    public virtual DbSet<Phase> Phases { get; set; }

    public virtual DbSet<PopulationGroup> PopulationGroups { get; set; }

    public virtual DbSet<ProcedureCost> ProcedureCosts { get; set; }

    public virtual DbSet<ProcedureCostException> ProcedureCostExceptions { get; set; }

    public virtual DbSet<ProcedureCostSite> ProcedureCostSites { get; set; }

    public virtual DbSet<ProfessionalSkill> ProfessionalSkills { get; set; }

    public virtual DbSet<SaasEdition> SaasEditions { get; set; }

    public virtual DbSet<SaasTenant> SaasTenants { get; set; }

    public virtual DbSet<SaasTenantConnectionString> SaasTenantConnectionStrings { get; set; }

    public virtual DbSet<SecuredEntityUser> SecuredEntityUsers { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<Severity> Severities { get; set; }

    public virtual DbSet<SeverityCriterion> SeverityCriteria { get; set; }

    public virtual DbSet<SiteType> SiteTypes { get; set; }

    public virtual DbSet<SitesService> SitesServices { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffProfessionalSkill> StaffProfessionalSkills { get; set; }

    public virtual DbSet<StaffTraining> StaffTrainings { get; set; }

    public virtual DbSet<StudyField> StudyFields { get; set; }

    public virtual DbSet<StudyType> StudyTypes { get; set; }

    public virtual DbSet<TrialPathology> TrialPathologies { get; set; }

    public virtual DbSet<TrialPopulationGroup> TrialPopulationGroups { get; set; }

    public virtual DbSet<TrialStakeholder> TrialStakeholders { get; set; }

    public virtual DbSet<TrialStudyField> TrialStudyFields { get; set; }

    public virtual DbSet<UserFilter> UserFilters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ctms;Integrated Security=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbpAuditLog>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_ExecutionTime");

            entity.HasIndex(e => new { e.TenantId, e.UserId, e.ExecutionTime }, "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ApplicationName).HasMaxLength(96);
            entity.Property(e => e.BrowserInfo).HasMaxLength(512);
            entity.Property(e => e.ClientId).HasMaxLength(64);
            entity.Property(e => e.ClientIpAddress).HasMaxLength(64);
            entity.Property(e => e.ClientName).HasMaxLength(128);
            entity.Property(e => e.Comments).HasMaxLength(256);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.CorrelationId).HasMaxLength(64);
            entity.Property(e => e.HttpMethod).HasMaxLength(16);
            entity.Property(e => e.ImpersonatorTenantName).HasMaxLength(64);
            entity.Property(e => e.ImpersonatorUserName).HasMaxLength(256);
            entity.Property(e => e.TenantName).HasMaxLength(64);
            entity.Property(e => e.Url).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AbpAuditLogAction>(entity =>
        {
            entity.HasIndex(e => e.AuditLogId, "IX_AbpAuditLogActions_AuditLogId");

            entity.HasIndex(e => new { e.TenantId, e.ServiceName, e.MethodName, e.ExecutionTime }, "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MethodName).HasMaxLength(128);
            entity.Property(e => e.Parameters).HasMaxLength(2000);
            entity.Property(e => e.ServiceName).HasMaxLength(256);

            entity.HasOne(d => d.AuditLog).WithMany(p => p.AbpAuditLogActions).HasForeignKey(d => d.AuditLogId);
        });

        modelBuilder.Entity<AbpBackgroundJob>(entity =>
        {
            entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime }, "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.IsAbandoned)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.JobName).HasMaxLength(128);
            entity.Property(e => e.Priority).HasDefaultValueSql("(CONVERT([tinyint],(15)))");
            entity.Property(e => e.TryCount).HasDefaultValueSql("(CONVERT([smallint],(0)))");
        });

        modelBuilder.Entity<AbpBlob>(entity =>
        {
            entity.HasIndex(e => e.ContainerId, "IX_AbpBlobs_ContainerId");

            entity.HasIndex(e => new { e.TenantId, e.ContainerId, e.Name }, "IX_AbpBlobs_TenantId_ContainerId_Name");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.Container).WithMany(p => p.AbpBlobs).HasForeignKey(d => d.ContainerId);
        });

        modelBuilder.Entity<AbpBlobContainer>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_AbpBlobContainers_TenantId_Name");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        modelBuilder.Entity<AbpClaimType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Regex).HasMaxLength(512);
            entity.Property(e => e.RegexDescription).HasMaxLength(128);
        });

        modelBuilder.Entity<AbpEntityChange>(entity =>
        {
            entity.HasIndex(e => e.AuditLogId, "IX_AbpEntityChanges_AuditLogId");

            entity.HasIndex(e => new { e.TenantId, e.EntityTypeFullName, e.EntityId }, "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EntityId).HasMaxLength(128);
            entity.Property(e => e.EntityTypeFullName).HasMaxLength(128);

            entity.HasOne(d => d.AuditLog).WithMany(p => p.AbpEntityChanges).HasForeignKey(d => d.AuditLogId);
        });

        modelBuilder.Entity<AbpEntityPropertyChange>(entity =>
        {
            entity.HasIndex(e => e.EntityChangeId, "IX_AbpEntityPropertyChanges_EntityChangeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NewValue).HasMaxLength(512);
            entity.Property(e => e.OriginalValue).HasMaxLength(512);
            entity.Property(e => e.PropertyName).HasMaxLength(128);
            entity.Property(e => e.PropertyTypeFullName).HasMaxLength(64);

            entity.HasOne(d => d.EntityChange).WithMany(p => p.AbpEntityPropertyChanges).HasForeignKey(d => d.EntityChangeId);
        });

        modelBuilder.Entity<AbpFeatureValue>(entity =>
        {
            entity.HasIndex(e => new { e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpFeatureValues_Name_ProviderName_ProviderKey")
                .IsUnique()
                .HasFilter("([ProviderName] IS NOT NULL AND [ProviderKey] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(64);
            entity.Property(e => e.ProviderName).HasMaxLength(64);
            entity.Property(e => e.Value).HasMaxLength(128);
        });

        modelBuilder.Entity<AbpLanguage>(entity =>
        {
            entity.HasIndex(e => e.CultureName, "IX_AbpLanguages_CultureName").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.CultureName).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(32);
            entity.Property(e => e.FlagIcon).HasMaxLength(48);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.UiCultureName).HasMaxLength(10);
        });

        modelBuilder.Entity<AbpLanguageText>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.ResourceName, e.CultureName }, "IX_AbpLanguageTexts_TenantId_ResourceName_CultureName");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CultureName).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(512);
            entity.Property(e => e.ResourceName).HasMaxLength(128);
        });

        modelBuilder.Entity<AbpLinkUser>(entity =>
        {
            entity.HasIndex(e => new { e.SourceUserId, e.SourceTenantId, e.TargetUserId, e.TargetTenantId }, "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_TargetTenantId")
                .IsUnique()
                .HasFilter("([SourceTenantId] IS NOT NULL AND [TargetTenantId] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AbpOrganizationUnit>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_AbpOrganizationUnits_Code");

            entity.HasIndex(e => e.ParentId, "IX_AbpOrganizationUnits_ParentId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(95);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<AbpOrganizationUnitRole>(entity =>
        {
            entity.HasKey(e => new { e.OrganizationUnitId, e.RoleId });

            entity.HasIndex(e => new { e.RoleId, e.OrganizationUnitId }, "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.AbpOrganizationUnitRoles).HasForeignKey(d => d.OrganizationUnitId);

            entity.HasOne(d => d.Role).WithMany(p => p.AbpOrganizationUnitRoles).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AbpPermissionGrant>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpPermissionGrants_TenantId_Name_ProviderName_ProviderKey")
                .IsUnique()
                .HasFilter("([TenantId] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(64);
            entity.Property(e => e.ProviderName).HasMaxLength(64);
        });

        modelBuilder.Entity<AbpRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_AbpRoles_NormalizedName");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AbpRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AbpRoleClaims_RoleId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClaimType).HasMaxLength(256);
            entity.Property(e => e.ClaimValue).HasMaxLength(1024);

            entity.HasOne(d => d.Role).WithMany(p => p.AbpRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AbpSecurityLog>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Action }, "IX_AbpSecurityLogs_TenantId_Action");

            entity.HasIndex(e => new { e.TenantId, e.ApplicationName }, "IX_AbpSecurityLogs_TenantId_ApplicationName");

            entity.HasIndex(e => new { e.TenantId, e.Identity }, "IX_AbpSecurityLogs_TenantId_Identity");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AbpSecurityLogs_TenantId_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Action).HasMaxLength(96);
            entity.Property(e => e.ApplicationName).HasMaxLength(96);
            entity.Property(e => e.BrowserInfo).HasMaxLength(512);
            entity.Property(e => e.ClientId).HasMaxLength(64);
            entity.Property(e => e.ClientIpAddress).HasMaxLength(64);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.CorrelationId).HasMaxLength(64);
            entity.Property(e => e.Identity).HasMaxLength(96);
            entity.Property(e => e.TenantName).HasMaxLength(64);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AbpSetting>(entity =>
        {
            entity.HasIndex(e => new { e.Name, e.ProviderName, e.ProviderKey }, "IX_AbpSettings_Name_ProviderName_ProviderKey")
                .IsUnique()
                .HasFilter("([ProviderName] IS NOT NULL AND [ProviderKey] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(64);
            entity.Property(e => e.ProviderName).HasMaxLength(64);
            entity.Property(e => e.Value).HasMaxLength(2048);
        });

        modelBuilder.Entity<AbpTextTemplateContent>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.CultureName).HasMaxLength(10);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(128);
        });

        modelBuilder.Entity<AbpUser>(entity =>
        {
            entity.HasIndex(e => e.Email, "IX_AbpUsers_Email");

            entity.HasIndex(e => e.NormalizedEmail, "IX_AbpUsers_NormalizedEmail");

            entity.HasIndex(e => e.NormalizedUserName, "IX_AbpUsers_NormalizedUserName");

            entity.HasIndex(e => e.UserName, "IX_AbpUsers_UserName");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ApiKeyName).HasMaxLength(256);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmailConfirmed)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsExternal)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.LockoutEnabled)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.PasswordHash).HasMaxLength(256);
            entity.Property(e => e.PhoneNumber).HasMaxLength(16);
            entity.Property(e => e.PhoneNumberConfirmed)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SecurityStamp).HasMaxLength(256);
            entity.Property(e => e.Surname).HasMaxLength(64);
            entity.Property(e => e.TwoFactorEnabled)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AbpUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AbpUserClaims_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClaimType).HasMaxLength(256);
            entity.Property(e => e.ClaimValue).HasMaxLength(1024);

            entity.HasOne(d => d.User).WithMany(p => p.AbpUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AbpUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider });

            entity.HasIndex(e => new { e.LoginProvider, e.ProviderKey }, "IX_AbpUserLogins_LoginProvider_ProviderKey");

            entity.Property(e => e.LoginProvider).HasMaxLength(64);
            entity.Property(e => e.ProviderDisplayName).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(196);

            entity.HasOne(d => d.User).WithMany(p => p.AbpUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AbpUserOrganizationUnit>(entity =>
        {
            entity.HasKey(e => new { e.OrganizationUnitId, e.UserId });

            entity.HasIndex(e => new { e.UserId, e.OrganizationUnitId }, "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId");

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.AbpUserOrganizationUnits).HasForeignKey(d => d.OrganizationUnitId);

            entity.HasOne(d => d.User).WithMany(p => p.AbpUserOrganizationUnits).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AbpUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_AbpUserRoles_RoleId_UserId");

            entity.HasOne(d => d.Role).WithMany(p => p.AbpUserRoles).HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User).WithMany(p => p.AbpUserRoles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AbpUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(64);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AbpUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<ActionsTaken>(entity =>
        {
            entity.ToTable("ActionsTaken");

            entity.HasIndex(e => e.TenantId, "IX_ActionsTaken_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<AdminRoute>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_AdminRoutes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<AdverseEventState>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_AdverseEventStates_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Arm>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialArmId, "IX_Arms_ClinicalTrialArmId");

            entity.HasIndex(e => e.ClinicalTrialId, "IX_Arms_ClinicalTrialId");

            entity.HasIndex(e => e.ContractId, "IX_Arms_ContractId");

            entity.HasIndex(e => e.TenantId, "IX_Arms_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Remarks).HasMaxLength(2048);

            entity.HasOne(d => d.ClinicalTrialArm).WithMany(p => p.InverseClinicalTrialArm).HasForeignKey(d => d.ClinicalTrialArmId);

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.Arms).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.Contract).WithMany(p => p.Arms).HasForeignKey(d => d.ContractId);
        });

        modelBuilder.Entity<BillingIncomeConcept>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_BillingIncomeConcepts_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Calendars_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Color).HasMaxLength(32);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.HasIndex(e => e.CalendarId, "IX_CalendarEvents_CalendarId");

            entity.HasIndex(e => e.TenantId, "IX_CalendarEvents_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.OwnerName).HasMaxLength(256);
            entity.Property(e => e.Title).HasMaxLength(512);
            entity.Property(e => e.Type).HasMaxLength(64);

            entity.HasOne(d => d.Calendar).WithMany(p => p.CalendarEvents).HasForeignKey(d => d.CalendarId);
        });

        modelBuilder.Entity<ClinicalTrial>(entity =>
        {
            entity.HasIndex(e => e.CalendarId, "IX_ClinicalTrials_CalendarId");

            entity.HasIndex(e => e.ComparerId, "IX_ClinicalTrials_ComparerId");

            entity.HasIndex(e => e.ConsiderationId, "IX_ClinicalTrials_ConsiderationId");

            entity.HasIndex(e => e.ControlId, "IX_ClinicalTrials_ControlId");

            entity.HasIndex(e => e.MaskingId, "IX_ClinicalTrials_MaskingId");

            entity.HasIndex(e => e.OrganizationUnitId, "IX_ClinicalTrials_OrganizationUnitId");

            entity.HasIndex(e => e.PhaseId, "IX_ClinicalTrials_PhaseId");

            entity.HasIndex(e => e.ServiceId, "IX_ClinicalTrials_ServiceId");

            entity.HasIndex(e => e.SiteId, "IX_ClinicalTrials_SiteId");

            entity.HasIndex(e => e.SiteTypeId, "IX_ClinicalTrials_SiteTypeId");

            entity.HasIndex(e => e.StateId, "IX_ClinicalTrials_StateId");

            entity.HasIndex(e => e.StudySubtypeId, "IX_ClinicalTrials_StudySubtypeId");

            entity.HasIndex(e => e.StudyTypeId, "IX_ClinicalTrials_StudyTypeId");

            entity.HasIndex(e => e.TenantId, "IX_ClinicalTrials_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.CalendarId);

            entity.HasOne(d => d.Comparer).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.ComparerId);

            entity.HasOne(d => d.Consideration).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.ConsiderationId);

            entity.HasOne(d => d.Control).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.ControlId);

            entity.HasOne(d => d.Masking).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.MaskingId);

            entity.HasOne(d => d.OrganizationUnit).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.OrganizationUnitId);

            entity.HasOne(d => d.Phase).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.PhaseId);

            entity.HasOne(d => d.Service).WithMany(p => p.ClinicalTrialServices).HasForeignKey(d => d.ServiceId);

            entity.HasOne(d => d.Site).WithMany(p => p.ClinicalTrialSites).HasForeignKey(d => d.SiteId);

            entity.HasOne(d => d.SiteType).WithMany(p => p.ClinicalTrials).HasForeignKey(d => d.SiteTypeId);

            entity.HasOne(d => d.State).WithMany(p => p.ClinicalTrials)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.StudySubtype).WithMany(p => p.ClinicalTrialStudySubtypes).HasForeignKey(d => d.StudySubtypeId);

            entity.HasOne(d => d.StudyType).WithMany(p => p.ClinicalTrialStudyTypes).HasForeignKey(d => d.StudyTypeId);
        });

        modelBuilder.Entity<ClinicalTrialHistoryState>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_ClinicalTrialHistoryStates_ClinicalTrialId");

            entity.HasIndex(e => e.StateId, "IX_ClinicalTrialHistoryStates_StateId");

            entity.HasIndex(e => e.TenantId, "IX_ClinicalTrialHistoryStates_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatorFullName).HasMaxLength(256);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Reason).HasMaxLength(1024);

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.ClinicalTrialHistoryStates).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.State).WithMany(p => p.ClinicalTrialHistoryStates).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<ClinicalTrialMasking>(entity =>
        {
            entity.ToTable("ClinicalTrialMasking");

            entity.HasIndex(e => e.TenantId, "IX_ClinicalTrialMasking_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<ClinicalTrialState>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ClinicalTrialStates_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Comparer>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Comparers_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Consideration>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Considerations_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasIndex(e => e.ContactTypeId, "IX_Contacts_ContactTypeId");

            entity.HasIndex(e => e.TenantId, "IX_Contacts_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ContactAddressAddress).HasColumnName("ContactAddress_Address");
            entity.Property(e => e.ContactAddressCountry).HasColumnName("ContactAddress_Country");
            entity.Property(e => e.ContactAddressEmail).HasColumnName("ContactAddress_Email");
            entity.Property(e => e.ContactAddressMobilePhone).HasColumnName("ContactAddress_MobilePhone");
            entity.Property(e => e.ContactAddressPhone).HasColumnName("ContactAddress_Phone");
            entity.Property(e => e.ContactAddressPopulation).HasColumnName("ContactAddress_Population");
            entity.Property(e => e.ContactAddressPostalCode).HasColumnName("ContactAddress_PostalCode");
            entity.Property(e => e.ContactAddressProvince).HasColumnName("ContactAddress_Province");
            entity.Property(e => e.ContactAddressWebsite).HasColumnName("ContactAddress_Website");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Remarks).HasMaxLength(2048);

            entity.HasOne(d => d.ContactType).WithMany(p => p.Contacts).HasForeignKey(d => d.ContactTypeId);
        });

        modelBuilder.Entity<ContactPerson>(entity =>
        {
            entity.ToTable("ContactPerson");

            entity.HasIndex(e => e.ContactPositionId, "IX_ContactPerson_ContactPositionId");

            entity.HasIndex(e => e.RelatedEntityId, "IX_ContactPerson_RelatedEntityId");

            entity.HasIndex(e => e.TenantId, "IX_ContactPerson_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SecondSurname).HasMaxLength(256);
            entity.Property(e => e.Surname).HasMaxLength(256);

            entity.HasOne(d => d.ContactPosition).WithMany(p => p.ContactPeople).HasForeignKey(d => d.ContactPositionId);

            entity.HasOne(d => d.RelatedEntity).WithMany(p => p.ContactPeople).HasForeignKey(d => d.RelatedEntityId);
        });

        modelBuilder.Entity<ContactPosition>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ContactPositions_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<ContactType>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ContactTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_Contracts_ClinicalTrialId");

            entity.HasIndex(e => e.CostCenterId, "IX_Contracts_CostCenterId");

            entity.HasIndex(e => e.TenantId, "IX_Contracts_TenantId");

            entity.HasIndex(e => e.TrialStakeholderId, "IX_Contracts_TrialStakeholderId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BillingType).HasDefaultValueSql("((1))");
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Remarks).HasMaxLength(2048);

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.Contracts).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.CostCenter).WithMany(p => p.Contracts).HasForeignKey(d => d.CostCenterId);

            entity.HasOne(d => d.TrialStakeholder).WithMany(p => p.Contracts).HasForeignKey(d => d.TrialStakeholderId);
        });

        modelBuilder.Entity<ContributionType>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ContributionTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Controls_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<CostCenter>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_CostCenters_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_Drugs_ClinicalTrialId");

            entity.HasIndex(e => e.ContributionTypeId, "IX_Drugs_ContributionTypeId");

            entity.HasIndex(e => e.DrugTermId, "IX_Drugs_DrugTermId");

            entity.HasIndex(e => e.TenantId, "IX_Drugs_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.TradeName).HasMaxLength(1024);

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.Drugs).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.ContributionType).WithMany(p => p.Drugs).HasForeignKey(d => d.ContributionTypeId);

            entity.HasOne(d => d.DrugTerm).WithMany(p => p.Drugs).HasForeignKey(d => d.DrugTermId);
        });

        modelBuilder.Entity<DrugTerm>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_DrugTerms_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<EconomicMemoryBillableTo>(entity =>
        {
            entity.ToTable("EconomicMemoryBillableTo");

            entity.HasIndex(e => e.TenantId, "IX_EconomicMemoryBillableTo_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<EconomicMemoryProcedure>(entity =>
        {
            entity.HasIndex(e => e.BillableToId, "IX_EconomicMemoryProcedures_BillableToId");

            entity.HasIndex(e => e.ContractArmId, "IX_EconomicMemoryProcedures_ContractArmId");

            entity.HasIndex(e => e.ProcedureId, "IX_EconomicMemoryProcedures_ProcedureId");

            entity.HasIndex(e => e.TenantId, "IX_EconomicMemoryProcedures_TenantId");

            entity.HasIndex(e => e.VisitId, "IX_EconomicMemoryProcedures_VisitId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(2048);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BillableTo).WithMany(p => p.EconomicMemoryProcedures).HasForeignKey(d => d.BillableToId);

            entity.HasOne(d => d.ContractArm).WithMany(p => p.EconomicMemoryProcedures).HasForeignKey(d => d.ContractArmId);

            entity.HasOne(d => d.Procedure).WithMany(p => p.EconomicMemoryProcedures).HasForeignKey(d => d.ProcedureId);

            entity.HasOne(d => d.Visit).WithMany(p => p.EconomicMemoryProcedures)
                .HasForeignKey(d => d.VisitId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<EconomicMemoryVisit>(entity =>
        {
            entity.HasIndex(e => e.BillableToId, "IX_EconomicMemoryVisits_BillableToId");

            entity.HasIndex(e => e.BillingIncomeConceptId, "IX_EconomicMemoryVisits_BillingIncomeConceptId");

            entity.HasIndex(e => e.ContractArmId, "IX_EconomicMemoryVisits_ContractArmId");

            entity.HasIndex(e => e.GroupId, "IX_EconomicMemoryVisits_GroupId");

            entity.HasIndex(e => e.TenantId, "IX_EconomicMemoryVisits_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(2048);
            entity.Property(e => e.Title).HasMaxLength(1024);

            entity.HasOne(d => d.BillableTo).WithMany(p => p.EconomicMemoryVisits).HasForeignKey(d => d.BillableToId);

            entity.HasOne(d => d.BillingIncomeConcept).WithMany(p => p.EconomicMemoryVisits).HasForeignKey(d => d.BillingIncomeConceptId);

            entity.HasOne(d => d.ContractArm).WithMany(p => p.EconomicMemoryVisits).HasForeignKey(d => d.ContractArmId);

            entity.HasOne(d => d.Group).WithMany(p => p.EconomicMemoryVisits).HasForeignKey(d => d.GroupId);
        });

        modelBuilder.Entity<EconomicSummaryMilestoneBillingItem>(entity =>
        {
            entity.HasIndex(e => e.ContractId, "IX_EconomicSummaryMilestoneBillingItems_ContractId");

            entity.HasIndex(e => e.TenantId, "IX_EconomicSummaryMilestoneBillingItems_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Contract).WithMany(p => p.EconomicSummaryMilestoneBillingItems).HasForeignKey(d => d.ContractId);
        });

        modelBuilder.Entity<EventBusSubscription>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_EventBusSubscriptions_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FilteredEvent).HasMaxLength(256);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<ExpenseType>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ExpenseTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<GdprInfo>(entity =>
        {
            entity.ToTable("GdprInfo");

            entity.HasIndex(e => e.RequestId, "IX_GdprInfo_RequestId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Provider).HasMaxLength(256);

            entity.HasOne(d => d.Request).WithMany(p => p.GdprInfos).HasForeignKey(d => d.RequestId);
        });

        modelBuilder.Entity<GdprRequest>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_GdprRequests_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Groups_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<IdentityServerApiResource>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AllowedAccessTokenSigningAlgorithms).HasMaxLength(100);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<IdentityServerApiResourceClaim>(entity =>
        {
            entity.HasKey(e => new { e.ApiResourceId, e.Type });

            entity.Property(e => e.Type).HasMaxLength(200);

            entity.HasOne(d => d.ApiResource).WithMany(p => p.IdentityServerApiResourceClaims).HasForeignKey(d => d.ApiResourceId);
        });

        modelBuilder.Entity<IdentityServerApiResourceProperty>(entity =>
        {
            entity.HasKey(e => new { e.ApiResourceId, e.Key, e.Value });

            entity.Property(e => e.Key).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.ApiResource).WithMany(p => p.IdentityServerApiResourceProperties).HasForeignKey(d => d.ApiResourceId);
        });

        modelBuilder.Entity<IdentityServerApiResourceScope>(entity =>
        {
            entity.HasKey(e => new { e.ApiResourceId, e.Scope });

            entity.Property(e => e.Scope).HasMaxLength(200);

            entity.HasOne(d => d.ApiResource).WithMany(p => p.IdentityServerApiResourceScopes).HasForeignKey(d => d.ApiResourceId);
        });

        modelBuilder.Entity<IdentityServerApiResourceSecret>(entity =>
        {
            entity.HasKey(e => new { e.ApiResourceId, e.Type, e.Value });

            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(4000);
            entity.Property(e => e.Description).HasMaxLength(1000);

            entity.HasOne(d => d.ApiResource).WithMany(p => p.IdentityServerApiResourceSecrets).HasForeignKey(d => d.ApiResourceId);
        });

        modelBuilder.Entity<IdentityServerApiScope>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<IdentityServerApiScopeClaim>(entity =>
        {
            entity.HasKey(e => new { e.ApiScopeId, e.Type });

            entity.Property(e => e.Type).HasMaxLength(200);

            entity.HasOne(d => d.ApiScope).WithMany(p => p.IdentityServerApiScopeClaims).HasForeignKey(d => d.ApiScopeId);
        });

        modelBuilder.Entity<IdentityServerApiScopeProperty>(entity =>
        {
            entity.HasKey(e => new { e.ApiScopeId, e.Key, e.Value });

            entity.Property(e => e.Key).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.ApiScope).WithMany(p => p.IdentityServerApiScopeProperties).HasForeignKey(d => d.ApiScopeId);
        });

        modelBuilder.Entity<IdentityServerClient>(entity =>
        {
            entity.HasIndex(e => e.ClientId, "IX_IdentityServerClients_ClientId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AllowedIdentityTokenSigningAlgorithms).HasMaxLength(100);
            entity.Property(e => e.BackChannelLogoutUri).HasMaxLength(2000);
            entity.Property(e => e.ClientClaimsPrefix).HasMaxLength(200);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ClientName).HasMaxLength(200);
            entity.Property(e => e.ClientUri).HasMaxLength(2000);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.FrontChannelLogoutUri).HasMaxLength(2000);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.LogoUri).HasMaxLength(2000);
            entity.Property(e => e.PairWiseSubjectSalt).HasMaxLength(200);
            entity.Property(e => e.ProtocolType).HasMaxLength(200);
            entity.Property(e => e.UserCodeType).HasMaxLength(100);
        });

        modelBuilder.Entity<IdentityServerClientClaim>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Type, e.Value });

            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(250);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientClaims).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientCorsOrigin>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Origin });

            entity.Property(e => e.Origin).HasMaxLength(150);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientCorsOrigins).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientGrantType>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.GrantType });

            entity.Property(e => e.GrantType).HasMaxLength(250);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientGrantTypes).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientIdPrestriction>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Provider });

            entity.ToTable("IdentityServerClientIdPRestrictions");

            entity.Property(e => e.Provider).HasMaxLength(200);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientIdPrestrictions).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientPostLogoutRedirectUri>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.PostLogoutRedirectUri });

            entity.Property(e => e.PostLogoutRedirectUri).HasMaxLength(2000);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientPostLogoutRedirectUris).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientProperty>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Key, e.Value });

            entity.Property(e => e.Key).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientProperties).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientRedirectUri>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.RedirectUri });

            entity.Property(e => e.RedirectUri).HasMaxLength(2000);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientRedirectUris).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientScope>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Scope });

            entity.Property(e => e.Scope).HasMaxLength(200);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientScopes).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerClientSecret>(entity =>
        {
            entity.HasKey(e => new { e.ClientId, e.Type, e.Value });

            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(4000);
            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.HasOne(d => d.Client).WithMany(p => p.IdentityServerClientSecrets).HasForeignKey(d => d.ClientId);
        });

        modelBuilder.Entity<IdentityServerDeviceFlowCode>(entity =>
        {
            entity.HasIndex(e => e.DeviceCode, "IX_IdentityServerDeviceFlowCodes_DeviceCode").IsUnique();

            entity.HasIndex(e => e.Expiration, "IX_IdentityServerDeviceFlowCodes_Expiration");

            entity.HasIndex(e => e.UserCode, "IX_IdentityServerDeviceFlowCodes_UserCode");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DeviceCode).HasMaxLength(200);
            entity.Property(e => e.SessionId).HasMaxLength(100);
            entity.Property(e => e.SubjectId).HasMaxLength(200);
            entity.Property(e => e.UserCode).HasMaxLength(200);
        });

        modelBuilder.Entity<IdentityServerIdentityResource>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<IdentityServerIdentityResourceClaim>(entity =>
        {
            entity.HasKey(e => new { e.IdentityResourceId, e.Type });

            entity.Property(e => e.Type).HasMaxLength(200);

            entity.HasOne(d => d.IdentityResource).WithMany(p => p.IdentityServerIdentityResourceClaims).HasForeignKey(d => d.IdentityResourceId);
        });

        modelBuilder.Entity<IdentityServerIdentityResourceProperty>(entity =>
        {
            entity.HasKey(e => new { e.IdentityResourceId, e.Key, e.Value });

            entity.Property(e => e.Key).HasMaxLength(250);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.IdentityResource).WithMany(p => p.IdentityServerIdentityResourceProperties).HasForeignKey(d => d.IdentityResourceId);
        });

        modelBuilder.Entity<IdentityServerPersistedGrant>(entity =>
        {
            entity.HasKey(e => e.Key);

            entity.HasIndex(e => e.Expiration, "IX_IdentityServerPersistedGrants_Expiration");

            entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_IdentityServerPersistedGrants_SubjectId_ClientId_Type");

            entity.HasIndex(e => new { e.SubjectId, e.SessionId, e.Type }, "IX_IdentityServerPersistedGrants_SubjectId_SessionId_Type");

            entity.Property(e => e.Key).HasMaxLength(200);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.SessionId).HasMaxLength(100);
            entity.Property(e => e.SubjectId).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<InQualitiesOf>(entity =>
        {
            entity.ToTable("InQualitiesOf");

            entity.HasIndex(e => e.TenantId, "IX_InQualitiesOf_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<InterventionRelationship>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_InterventionRelationships_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Monitoring>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Monitorings_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Notes_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.EntityId, e.EntityType }, "IX_Notes_TenantId_EntityId_EntityType");

            entity.HasIndex(e => new { e.TenantId, e.EntityId, e.EntityType, e.ProjectId }, "IX_Notes_TenantId_EntityId_EntityType_ProjectId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Message).HasMaxLength(1024);
        });

        modelBuilder.Entity<NoteRecipient>(entity =>
        {
            entity.HasKey(e => new { e.RecipientId, e.NoteId, e.Type });

            entity.ToTable("NoteRecipient");

            entity.HasIndex(e => e.NoteId, "IX_NoteRecipient_NoteId");

            entity.HasOne(d => d.Note).WithMany(p => p.NoteRecipients).HasForeignKey(d => d.NoteId);
        });

        modelBuilder.Entity<Outcome>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Outcomes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialArmId, "IX_Participants_ClinicalTrialArmId");

            entity.HasIndex(e => e.ClinicalTrialId, "IX_Participants_ClinicalTrialId");

            entity.HasIndex(e => e.ContractId, "IX_Participants_ContractId");

            entity.HasIndex(e => e.PersonId, "IX_Participants_PersonId");

            entity.HasIndex(e => e.StateId, "IX_Participants_StateId");

            entity.HasIndex(e => e.TenantId, "IX_Participants_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.StartDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.SyncId).HasMaxLength(1024);

            entity.HasOne(d => d.ClinicalTrialArm).WithMany(p => p.Participants).HasForeignKey(d => d.ClinicalTrialArmId);

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.Participants).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.Contract).WithMany(p => p.Participants).HasForeignKey(d => d.ContractId);

            entity.HasOne(d => d.Person).WithMany(p => p.Participants).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.State).WithMany(p => p.Participants).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<ParticipantAdverseEvent>(entity =>
        {
            entity.HasIndex(e => e.ActionTakenId, "IX_ParticipantAdverseEvents_ActionTakenId");

            entity.HasIndex(e => e.AdminRouteId, "IX_ParticipantAdverseEvents_AdminRouteId");

            entity.HasIndex(e => e.AdverseEventStateId, "IX_ParticipantAdverseEvents_AdverseEventStateId");

            entity.HasIndex(e => e.InterventionRelationshipId, "IX_ParticipantAdverseEvents_InterventionRelationshipId");

            entity.HasIndex(e => e.OutcomeId, "IX_ParticipantAdverseEvents_OutcomeId");

            entity.HasIndex(e => e.ParticipantId, "IX_ParticipantAdverseEvents_ParticipantId");

            entity.HasIndex(e => e.SeverityCriterionId, "IX_ParticipantAdverseEvents_SeverityCriterionId");

            entity.HasIndex(e => e.SeverityId, "IX_ParticipantAdverseEvents_SeverityId");

            entity.HasIndex(e => e.TenantId, "IX_ParticipantAdverseEvents_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AdverseEventDescription).HasMaxLength(1024);
            entity.Property(e => e.Comment).HasMaxLength(1024);
            entity.Property(e => e.CreatorFullName).HasMaxLength(256);
            entity.Property(e => e.Dose).HasMaxLength(256);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Medicine).HasMaxLength(256);

            entity.HasOne(d => d.ActionTaken).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.ActionTakenId);

            entity.HasOne(d => d.AdminRoute).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.AdminRouteId);

            entity.HasOne(d => d.AdverseEventState).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.AdverseEventStateId);

            entity.HasOne(d => d.InterventionRelationship).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.InterventionRelationshipId);

            entity.HasOne(d => d.Outcome).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.OutcomeId);

            entity.HasOne(d => d.Participant).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.ParticipantId);

            entity.HasOne(d => d.SeverityCriterion).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.SeverityCriterionId);

            entity.HasOne(d => d.Severity).WithMany(p => p.ParticipantAdverseEvents).HasForeignKey(d => d.SeverityId);
        });

        modelBuilder.Entity<ParticipantHistoryEvent>(entity =>
        {
            entity.HasIndex(e => e.ParticipantId, "IX_ParticipantHistoryEvents_ParticipantId");

            entity.HasIndex(e => e.TenantId, "IX_ParticipantHistoryEvents_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatorFullName).HasMaxLength(256);
            entity.Property(e => e.EntityId).HasMaxLength(256);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Reason).HasMaxLength(1024);

            entity.HasOne(d => d.Participant).WithMany(p => p.ParticipantHistoryEvents).HasForeignKey(d => d.ParticipantId);
        });

        modelBuilder.Entity<ParticipantState>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_ParticipantStates_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<ParticipantVisit>(entity =>
        {
            entity.HasIndex(e => e.CalendarEventId, "IX_ParticipantVisits_CalendarEventId");

            entity.HasIndex(e => e.EconomicMemoryVisitId, "IX_ParticipantVisits_EconomicMemoryVisitId");

            entity.HasIndex(e => e.MonitoringId, "IX_ParticipantVisits_MonitoringId");

            entity.HasIndex(e => e.ParticipantId, "IX_ParticipantVisits_ParticipantId");

            entity.HasIndex(e => e.TenantId, "IX_ParticipantVisits_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comments).HasMaxLength(1024);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.CalendarEvent).WithMany(p => p.ParticipantVisits).HasForeignKey(d => d.CalendarEventId);

            entity.HasOne(d => d.EconomicMemoryVisit).WithMany(p => p.ParticipantVisits).HasForeignKey(d => d.EconomicMemoryVisitId);

            entity.HasOne(d => d.Monitoring).WithMany(p => p.ParticipantVisits).HasForeignKey(d => d.MonitoringId);

            entity.HasOne(d => d.Participant).WithMany(p => p.ParticipantVisits).HasForeignKey(d => d.ParticipantId);
        });

        modelBuilder.Entity<ParticipantVisitExpense>(entity =>
        {
            entity.ToTable("ParticipantVisitExpense");

            entity.HasIndex(e => e.TypeId, "IX_ParticipantVisitExpense_TypeId");

            entity.HasIndex(e => e.VisitId, "IX_ParticipantVisitExpense_VisitId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ReceiptNumber).HasMaxLength(256);
            entity.Property(e => e.Remarks).HasMaxLength(2048);

            entity.HasOne(d => d.Type).WithMany(p => p.ParticipantVisitExpenses).HasForeignKey(d => d.TypeId);

            entity.HasOne(d => d.Visit).WithMany(p => p.ParticipantVisitExpenses).HasForeignKey(d => d.VisitId);
        });

        modelBuilder.Entity<ParticipantVisitProcedure>(entity =>
        {
            entity.ToTable("ParticipantVisitProcedure");

            entity.HasIndex(e => e.EconomicMemoryProcedureId, "IX_ParticipantVisitProcedure_EconomicMemoryProcedureId");

            entity.HasIndex(e => e.ParticipantVisitId, "IX_ParticipantVisitProcedure_ParticipantVisitId");

            entity.HasIndex(e => e.ProcedureTypeId, "IX_ParticipantVisitProcedure_ProcedureTypeId");

            entity.HasIndex(e => e.TenantId, "IX_ParticipantVisitProcedure_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsBillable)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.RelatedDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.Remarks).HasMaxLength(2048);

            entity.HasOne(d => d.EconomicMemoryProcedure).WithMany(p => p.ParticipantVisitProcedures).HasForeignKey(d => d.EconomicMemoryProcedureId);

            entity.HasOne(d => d.ParticipantVisit).WithMany(p => p.ParticipantVisitProcedures).HasForeignKey(d => d.ParticipantVisitId);

            entity.HasOne(d => d.ProcedureType).WithMany(p => p.ParticipantVisitProcedures).HasForeignKey(d => d.ProcedureTypeId);
        });

        modelBuilder.Entity<Pathology>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Pathologies_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Persons_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.DocumentNumber).HasMaxLength(64);
            entity.Property(e => e.Email).HasMaxLength(32);
            entity.Property(e => e.FirstSurname).HasMaxLength(64);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.PersonIdentifier).HasMaxLength(32);
            entity.Property(e => e.PhoneNumber).HasMaxLength(32);
            entity.Property(e => e.Remarks).HasMaxLength(2048);
            entity.Property(e => e.SecondSurname).HasMaxLength(64);
        });

        modelBuilder.Entity<PersonalRole>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_PersonalRoles_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<PersonalTraining>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_PersonalTrainings_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<Phase>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Phases_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<PopulationGroup>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_PopulationGroups_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<ProcedureCost>(entity =>
        {
            entity.ToTable("ProcedureCost");

            entity.HasIndex(e => e.TenantId, "IX_ProcedureCost_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Cost1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<ProcedureCostException>(entity =>
        {
            entity.ToTable("ProcedureCostException");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.Cost1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cost6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<ProcedureCostSite>(entity =>
        {
            entity.HasIndex(e => e.ProcedureCostId, "IX_ProcedureCostSites_ProcedureCostId");

            entity.HasIndex(e => e.SiteId, "IX_ProcedureCostSites_SiteId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.ProcedureCost).WithMany(p => p.ProcedureCostSites).HasForeignKey(d => d.ProcedureCostId);

            entity.HasOne(d => d.Site).WithMany(p => p.ProcedureCostSites).HasForeignKey(d => d.SiteId);
        });

        modelBuilder.Entity<ProfessionalSkill>(entity =>
        {
            entity.ToTable("ProfessionalSkill");

            entity.HasIndex(e => e.TenantId, "IX_ProfessionalSkill_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<SaasEdition>(entity =>
        {
            entity.HasIndex(e => e.DisplayName, "IX_SaasEditions_DisplayName");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<SaasTenant>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_SaasTenants_Name");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(64);
        });

        modelBuilder.Entity<SaasTenantConnectionString>(entity =>
        {
            entity.HasKey(e => new { e.TenantId, e.Name });

            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.Value).HasMaxLength(1024);

            entity.HasOne(d => d.Tenant).WithMany(p => p.SaasTenantConnectionStrings).HasForeignKey(d => d.TenantId);
        });

        modelBuilder.Entity<SecuredEntityUser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Series_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.InactiveReason).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Pattern).HasMaxLength(256);
        });

        modelBuilder.Entity<Severity>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Severities_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<SeverityCriterion>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_SeverityCriteria_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<SiteType>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_SiteTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<SitesService>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_SitesServices_ParentId");

            entity.HasIndex(e => e.TenantId, "IX_SitesServices_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'01')");
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.InactiveReason).HasMaxLength(1024);
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_Staff_TenantId");

            entity.HasIndex(e => e.UserId, "IX_Staff_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(40);
            entity.Property(e => e.IdentityCardNumber).HasMaxLength(64);
            entity.Property(e => e.InactiveReason).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Remarks).HasMaxLength(1024);

            entity.HasOne(d => d.User).WithMany(p => p.Staff).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<StaffProfessionalSkill>(entity =>
        {
            entity.HasIndex(e => e.ProfessionalSkillId, "IX_StaffProfessionalSkills_ProfessionalSkillId");

            entity.HasIndex(e => e.StaffId, "IX_StaffProfessionalSkills_StaffId");

            entity.HasIndex(e => e.TenantId, "IX_StaffProfessionalSkills_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ProfessionalSkill).WithMany(p => p.StaffProfessionalSkills).HasForeignKey(d => d.ProfessionalSkillId);

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffProfessionalSkills).HasForeignKey(d => d.StaffId);
        });

        modelBuilder.Entity<StaffTraining>(entity =>
        {
            entity.HasIndex(e => e.StaffId, "IX_StaffTrainings_StaffId");

            entity.HasIndex(e => e.TenantId, "IX_StaffTrainings_TenantId");

            entity.HasIndex(e => e.TrainingTypeId, "IX_StaffTrainings_TrainingTypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffTrainings).HasForeignKey(d => d.StaffId);

            entity.HasOne(d => d.TrainingType).WithMany(p => p.StaffTrainings).HasForeignKey(d => d.TrainingTypeId);
        });

        modelBuilder.Entity<StudyField>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_StudyFields_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);
        });

        modelBuilder.Entity<StudyType>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_StudyTypes_ParentId");

            entity.HasIndex(e => e.TenantId, "IX_StudyTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.IsDefault)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SyncId).HasMaxLength(1024);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<TrialPathology>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_TrialPathologies_ClinicalTrialId");

            entity.HasIndex(e => e.PathologyId, "IX_TrialPathologies_PathologyId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.TrialPathologies).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.Pathology).WithMany(p => p.TrialPathologies).HasForeignKey(d => d.PathologyId);
        });

        modelBuilder.Entity<TrialPopulationGroup>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_TrialPopulationGroups_ClinicalTrialId");

            entity.HasIndex(e => e.PopulationGroupId, "IX_TrialPopulationGroups_PopulationGroupId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.TrialPopulationGroups).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.PopulationGroup).WithMany(p => p.TrialPopulationGroups).HasForeignKey(d => d.PopulationGroupId);
        });

        modelBuilder.Entity<TrialStakeholder>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_TrialStakeholders_ClinicalTrialId");

            entity.HasIndex(e => e.ContactPersonId, "IX_TrialStakeholders_ContactPersonId");

            entity.HasIndex(e => e.InQualityOfId, "IX_TrialStakeholders_InQualityOfId");

            entity.HasIndex(e => e.StakeholderId, "IX_TrialStakeholders_StakeholderId");

            entity.HasIndex(e => e.TenantId, "IX_TrialStakeholders_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.TrialStakeholders).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.ContactPerson).WithMany(p => p.TrialStakeholders).HasForeignKey(d => d.ContactPersonId);

            entity.HasOne(d => d.InQualityOf).WithMany(p => p.TrialStakeholders).HasForeignKey(d => d.InQualityOfId);

            entity.HasOne(d => d.Stakeholder).WithMany(p => p.TrialStakeholders).HasForeignKey(d => d.StakeholderId);
        });

        modelBuilder.Entity<TrialStudyField>(entity =>
        {
            entity.HasIndex(e => e.ClinicalTrialId, "IX_TrialStudyFields_ClinicalTrialId");

            entity.HasIndex(e => e.StudyFieldId, "IX_TrialStudyFields_StudyFieldId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.ClinicalTrial).WithMany(p => p.TrialStudyFields).HasForeignKey(d => d.ClinicalTrialId);

            entity.HasOne(d => d.StudyField).WithMany(p => p.TrialStudyFields).HasForeignKey(d => d.StudyFieldId);
        });

        modelBuilder.Entity<UserFilter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
