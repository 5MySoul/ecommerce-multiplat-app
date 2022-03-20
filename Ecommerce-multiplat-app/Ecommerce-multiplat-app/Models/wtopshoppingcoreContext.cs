using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecommerce_multiplat_app.Models
{
    public partial class wtopshoppingcoreContext : DbContext
    {
        public wtopshoppingcoreContext()
        {
        }

        public wtopshoppingcoreContext(DbContextOptions<wtopshoppingcoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ReportExecution> ReportExecutions { get; set; } = null!;
        public virtual DbSet<ReportGroup> ReportGroups { get; set; } = null!;
        public virtual DbSet<ReportReport> ReportReports { get; set; } = null!;
        public virtual DbSet<ReportTemplate> ReportTemplates { get; set; } = null!;
        public virtual DbSet<SecConstraint> SecConstraints { get; set; } = null!;
        public virtual DbSet<SecEntityLog> SecEntityLogs { get; set; } = null!;
        public virtual DbSet<SecFilter> SecFilters { get; set; } = null!;
        public virtual DbSet<SecGroup> SecGroups { get; set; } = null!;
        public virtual DbSet<SecGroupHierarchy> SecGroupHierarchies { get; set; } = null!;
        public virtual DbSet<SecLocalizedConstraintMsg> SecLocalizedConstraintMsgs { get; set; } = null!;
        public virtual DbSet<SecLoggedAttr> SecLoggedAttrs { get; set; } = null!;
        public virtual DbSet<SecLoggedEntity> SecLoggedEntities { get; set; } = null!;
        public virtual DbSet<SecPermission> SecPermissions { get; set; } = null!;
        public virtual DbSet<SecPresentation> SecPresentations { get; set; } = null!;
        public virtual DbSet<SecRememberMe> SecRememberMes { get; set; } = null!;
        public virtual DbSet<SecRole> SecRoles { get; set; } = null!;
        public virtual DbSet<SecScreenHistory> SecScreenHistories { get; set; } = null!;
        public virtual DbSet<SecSearchFolder> SecSearchFolders { get; set; } = null!;
        public virtual DbSet<SecSessionAttr> SecSessionAttrs { get; set; } = null!;
        public virtual DbSet<SecSessionLog> SecSessionLogs { get; set; } = null!;
        public virtual DbSet<SecUser> SecUsers { get; set; } = null!;
        public virtual DbSet<SecUserRole> SecUserRoles { get; set; } = null!;
        public virtual DbSet<SecUserSetting> SecUserSettings { get; set; } = null!;
        public virtual DbSet<SecUserSubstitution> SecUserSubstitutions { get; set; } = null!;
        public virtual DbSet<SysAccessToken> SysAccessTokens { get; set; } = null!;
        public virtual DbSet<SysAppFolder> SysAppFolders { get; set; } = null!;
        public virtual DbSet<SysAttrValue> SysAttrValues { get; set; } = null!;
        public virtual DbSet<SysCategory> SysCategories { get; set; } = null!;
        public virtual DbSet<SysCategoryAttr> SysCategoryAttrs { get; set; } = null!;
        public virtual DbSet<SysConfig> SysConfigs { get; set; } = null!;
        public virtual DbSet<SysDbChangelog> SysDbChangelogs { get; set; } = null!;
        public virtual DbSet<SysEntitySnapshot> SysEntitySnapshots { get; set; } = null!;
        public virtual DbSet<SysEntityStatistic> SysEntityStatistics { get; set; } = null!;
        public virtual DbSet<SysFile> SysFiles { get; set; } = null!;
        public virtual DbSet<SysFolder> SysFolders { get; set; } = null!;
        public virtual DbSet<SysFtsQueue> SysFtsQueues { get; set; } = null!;
        public virtual DbSet<SysJmxInstance> SysJmxInstances { get; set; } = null!;
        public virtual DbSet<SysLockConfig> SysLockConfigs { get; set; } = null!;
        public virtual DbSet<SysQueryResult> SysQueryResults { get; set; } = null!;
        public virtual DbSet<SysRefreshToken> SysRefreshTokens { get; set; } = null!;
        public virtual DbSet<SysScheduledExecution> SysScheduledExecutions { get; set; } = null!;
        public virtual DbSet<SysScheduledTask> SysScheduledTasks { get; set; } = null!;
        public virtual DbSet<SysSendingAttachment> SysSendingAttachments { get; set; } = null!;
        public virtual DbSet<SysSendingMessage> SysSendingMessages { get; set; } = null!;
        public virtual DbSet<SysServer> SysServers { get; set; } = null!;
        public virtual DbSet<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; } = null!;
        public virtual DbSet<WcbcoreBienBanGiaoNhanHangHoaVoiNcc> WcbcoreBienBanGiaoNhanHangHoaVoiNccs { get; set; } = null!;
        public virtual DbSet<WcbcoreBieuGhiLuuTruTonKho> WcbcoreBieuGhiLuuTruTonKhos { get; set; } = null!;
        public virtual DbSet<WcbcoreBieuGhiTonKho> WcbcoreBieuGhiTonKhos { get; set; } = null!;
        public virtual DbSet<WcbcoreChucVu> WcbcoreChucVus { get; set; } = null!;
        public virtual DbSet<WcbcoreChuongTrinhKhuyenMai> WcbcoreChuongTrinhKhuyenMais { get; set; } = null!;
        public virtual DbSet<WcbcoreDaPhuongTien> WcbcoreDaPhuongTiens { get; set; } = null!;
        public virtual DbSet<WcbcoreDiaChiGiaoDich> WcbcoreDiaChiGiaoDiches { get; set; } = null!;
        public virtual DbSet<WcbcoreDonHangBanLe> WcbcoreDonHangBanLes { get; set; } = null!;
        public virtual DbSet<WcbcoreDonViTinh> WcbcoreDonViTinhs { get; set; } = null!;
        public virtual DbSet<WcbcoreDonViVanChuyen> WcbcoreDonViVanChuyens { get; set; } = null!;
        public virtual DbSet<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangs { get; set; } = null!;
        public virtual DbSet<WcbcoreHangSanXuat> WcbcoreHangSanXuats { get; set; } = null!;
        public virtual DbSet<WcbcoreKhachHang> WcbcoreKhachHangs { get; set; } = null!;
        public virtual DbSet<WcbcoreKhoHang> WcbcoreKhoHangs { get; set; } = null!;
        public virtual DbSet<WcbcoreLichSuThayDoiPxk> WcbcoreLichSuThayDoiPxks { get; set; } = null!;
        public virtual DbSet<WcbcoreLichSuThayDoiTrangThaiDhbl> WcbcoreLichSuThayDoiTrangThaiDhbls { get; set; } = null!;
        public virtual DbSet<WcbcoreLoaiBaoHanh> WcbcoreLoaiBaoHanhs { get; set; } = null!;
        public virtual DbSet<WcbcoreLoaiGiaoDich> WcbcoreLoaiGiaoDiches { get; set; } = null!;
        public virtual DbSet<WcbcoreMenuInfo> WcbcoreMenuInfos { get; set; } = null!;
        public virtual DbSet<WcbcoreNhaCungCap> WcbcoreNhaCungCaps { get; set; } = null!;
        public virtual DbSet<WcbcoreNhapSoDuDauKy> WcbcoreNhapSoDuDauKies { get; set; } = null!;
        public virtual DbSet<WcbcoreNhomNcc> WcbcoreNhomNccs { get; set; } = null!;
        public virtual DbSet<WcbcoreNhomSanPham> WcbcoreNhomSanPhams { get; set; } = null!;
        public virtual DbSet<WcbcoreNhomTinTuc> WcbcoreNhomTinTucs { get; set; } = null!;
        public virtual DbSet<WcbcorePhieuBaoHanhCuaBbgn> WcbcorePhieuBaoHanhCuaBbgns { get; set; } = null!;
        public virtual DbSet<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhos { get; set; } = null!;
        public virtual DbSet<WcbcorePhuongThucVanChuyen> WcbcorePhuongThucVanChuyens { get; set; } = null!;
        public virtual DbSet<WcbcoreQuanHuyen> WcbcoreQuanHuyens { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPham> WcbcoreSanPhams { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaBbgn> WcbcoreSanPhamCuaBbgns { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckms { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaDhbl> WcbcoreSanPhamCuaDhbls { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaPxk> WcbcoreSanPhamCuaPxks { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaSoDuDauKy> WcbcoreSanPhamCuaSoDuDauKies { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamCuaTiepNhanHangHoa> WcbcoreSanPhamCuaTiepNhanHangHoas { get; set; } = null!;
        public virtual DbSet<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhbls { get; set; } = null!;
        public virtual DbSet<WcbcoreTepDinhKemDaPhuongTien> WcbcoreTepDinhKemDaPhuongTiens { get; set; } = null!;
        public virtual DbSet<WcbcoreTepDinhKemSanPham> WcbcoreTepDinhKemSanPhams { get; set; } = null!;
        public virtual DbSet<WcbcoreTepDinhKemTinTuc> WcbcoreTepDinhKemTinTucs { get; set; } = null!;
        public virtual DbSet<WcbcoreThongBao> WcbcoreThongBaos { get; set; } = null!;
        public virtual DbSet<WcbcoreThuocTinhSanPham> WcbcoreThuocTinhSanPhams { get; set; } = null!;
        public virtual DbSet<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoas { get; set; } = null!;
        public virtual DbSet<WcbcoreTinTuc> WcbcoreTinTucs { get; set; } = null!;
        public virtual DbSet<WcbcoreTinhThanh> WcbcoreTinhThanhs { get; set; } = null!;
        public virtual DbSet<WcbcoreXaPhuong> WcbcoreXaPhuongs { get; set; } = null!;
        public virtual DbSet<WcbcoreXacThucThongTinTaiKhoan> WcbcoreXacThucThongTinTaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=wtopshoppingcore;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportExecution>(entity =>
            {
                entity.ToTable("REPORT_EXECUTION");

                entity.HasIndex(e => e.ReportId, "IDX_REPORT_EXECUTION_REPORT_ID");

                entity.HasIndex(e => e.StartTime, "IDX_REPORT_EXECUTION_START_TIME");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cancelled)
                    .HasColumnName("CANCELLED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.ErrorMessage).HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("FINISH_TIME");

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("IS_SUCCESS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutputDocumentId).HasColumnName("OUTPUT_DOCUMENT_ID");

                entity.Property(e => e.Params).HasColumnName("PARAMS");

                entity.Property(e => e.ReportCode)
                    .HasMaxLength(255)
                    .HasColumnName("REPORT_CODE");

                entity.Property(e => e.ReportId).HasColumnName("REPORT_ID");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(255)
                    .HasColumnName("REPORT_NAME");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SERVER_ID");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("START_TIME");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.OutputDocument)
                    .WithMany(p => p.ReportExecutions)
                    .HasForeignKey(d => d.OutputDocumentId)
                    .HasConstraintName("FK_REPORT_EXECUTION_TO_DOCUMENT");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportExecutions)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_REPORT_EXECUTION_TO_REPORT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportExecutions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORT_EXECUTION_TO_USER");
            });

            modelBuilder.Entity<ReportGroup>(entity =>
            {
                entity.ToTable("REPORT_GROUP");

                entity.HasIndex(e => new { e.Title, e.SysTenantId, e.DeleteTs }, "IDX_REPORT_GROUP_UNIQ_TITLE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.LocaleNames)
                    .HasMaxLength(1000)
                    .HasColumnName("LOCALE_NAMES");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("TITLE");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ReportReport>(entity =>
            {
                entity.ToTable("REPORT_REPORT");

                entity.HasIndex(e => new { e.Name, e.SysTenantId, e.DeleteTs }, "IDX_REPORT_REPORT_UNIQ_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DefaultTemplateId).HasColumnName("DEFAULT_TEMPLATE_ID");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.InputEntityTypesIdx)
                    .HasMaxLength(1000)
                    .HasColumnName("INPUT_ENTITY_TYPES_IDX");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocaleNames)
                    .HasMaxLength(1000)
                    .HasColumnName("LOCALE_NAMES");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.ReportType).HasColumnName("REPORT_TYPE");

                entity.Property(e => e.RestAccess)
                    .HasColumnName("REST_ACCESS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RolesIdx)
                    .HasMaxLength(1000)
                    .HasColumnName("ROLES_IDX");

                entity.Property(e => e.ScreensIdx)
                    .HasMaxLength(1000)
                    .HasColumnName("SCREENS_IDX");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Xml).HasColumnName("XML");

                entity.HasOne(d => d.DefaultTemplate)
                    .WithMany(p => p.ReportReports)
                    .HasForeignKey(d => d.DefaultTemplateId)
                    .HasConstraintName("FK_REPORT_REPORT_TO_DEF_TEMPLATE");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ReportReports)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORT_REPORT_TO_REPORT_GROUP");
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.ToTable("REPORT_TEMPLATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("CODE");

                entity.Property(e => e.Content)
                    .HasColumnType("image")
                    .HasColumnName("CONTENT");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CustomClass).HasColumnName("CUSTOM_CLASS");

                entity.Property(e => e.CustomDefinedBy)
                    .HasColumnName("CUSTOM_DEFINED_BY")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.IsAlterableOutput)
                    .HasColumnName("IS_ALTERABLE_OUTPUT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("IS_CUSTOM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("IS_DEFAULT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGroovy)
                    .HasColumnName("IS_GROOVY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");

                entity.Property(e => e.OutputNamePattern)
                    .HasMaxLength(255)
                    .HasColumnName("OUTPUT_NAME_PATTERN");

                entity.Property(e => e.OutputType).HasColumnName("OUTPUT_TYPE");

                entity.Property(e => e.ReportId).HasColumnName("REPORT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportTemplates)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_REPORT_TEMPLATE_TO_REPORT");
            });

            modelBuilder.Entity<SecConstraint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_CONS__3214EC26F3F7D038")
                    .IsClustered(false);

                entity.ToTable("SEC_CONSTRAINT");

                entity.HasIndex(e => e.GroupId, "IDX_SEC_CONSTRAINT_GROUP")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CHECK_TYPE")
                    .HasDefaultValueSql("('db')");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(255)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.FilterXml).HasColumnName("FILTER_XML");

                entity.Property(e => e.GroovyScript).HasColumnName("GROOVY_SCRIPT");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("IS_ACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinClause)
                    .HasMaxLength(500)
                    .HasColumnName("JOIN_CLAUSE");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_TYPE")
                    .HasDefaultValueSql("('read')");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(1000)
                    .HasColumnName("WHERE_CLAUSE");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SecConstraints)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("SEC_CONSTRAINT_GROUP");
            });

            modelBuilder.Entity<SecEntityLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_ENTI__3214EC26190D2B37")
                    .IsClustered(false);

                entity.ToTable("SEC_ENTITY_LOG");

                entity.HasIndex(e => e.EntityId, "IDX_SEC_ENTITY_LOG_ENTITY_ID");

                entity.HasIndex(e => e.EventTs, "IDX_SEC_ENTITY_LOG_EVENT_TS")
                    .IsClustered();

                entity.HasIndex(e => e.IntEntityId, "IDX_SEC_ENTITY_LOG_IENTITY_ID");

                entity.HasIndex(e => e.LongEntityId, "IDX_SEC_ENTITY_LOG_LENTITY_ID");

                entity.HasIndex(e => e.StringEntityId, "IDX_SEC_ENTITY_LOG_SENTITY_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChangeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.Changes).HasColumnName("CHANGES");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Entity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityInstanceName)
                    .HasMaxLength(1000)
                    .HasColumnName("ENTITY_INSTANCE_NAME");

                entity.Property(e => e.EventTs)
                    .HasColumnType("datetime")
                    .HasColumnName("EVENT_TS");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecEntityLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SEC_ENTITY_LOG_USER");
            });

            modelBuilder.Entity<SecFilter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_FILT__3214EC268A8391CB")
                    .IsClustered(false);

                entity.ToTable("SEC_FILTER");

                entity.HasIndex(e => new { e.Component, e.UserId }, "IDX_SEC_FILTER_COMPONENT_USER")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .HasColumnName("CODE");

                entity.Property(e => e.Component)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMPONENT");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.GlobalDefault).HasColumnName("GLOBAL_DEFAULT");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Xml).HasColumnName("XML");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecFilters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SEC_FILTER_USER");
            });

            modelBuilder.Entity<SecGroup>(entity =>
            {
                entity.ToTable("SEC_GROUP");

                entity.HasIndex(e => new { e.Name, e.SysTenantId, e.DeleteTs }, "IDX_SEC_GROUP_UNIQ_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("SEC_GROUP_PARENT");
            });

            modelBuilder.Entity<SecGroupHierarchy>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_GROU__3214EC262BEC3BF6")
                    .IsClustered(false);

                entity.ToTable("SEC_GROUP_HIERARCHY");

                entity.HasIndex(e => e.GroupId, "IDX_SEC_GROUP_HIERARCHY_GROUP_ID")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.HierarchyLevel).HasColumnName("HIERARCHY_LEVEL");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SecGroupHierarchyGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("SEC_GROUP_HIERARCHY_GROUP");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SecGroupHierarchyParents)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("SEC_GROUP_HIERARCHY_PARENT");
            });

            modelBuilder.Entity<SecLocalizedConstraintMsg>(entity =>
            {
                entity.ToTable("SEC_LOCALIZED_CONSTRAINT_MSG");

                entity.HasIndex(e => new { e.EntityName, e.OperationType, e.DeleteTs }, "IDX_SEC_LOC_CNSTRNT_MSG_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(255)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATION_TYPE");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Values).HasColumnName("VALUES_");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SecLoggedAttr>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_LOGG__3214EC26F9CDE608")
                    .IsClustered(false);

                entity.ToTable("SEC_LOGGED_ATTR");

                entity.HasIndex(e => e.EntityId, "IDX_SEC_LOGGED_ATTR_ENTITY")
                    .IsClustered();

                entity.HasIndex(e => new { e.EntityId, e.Name }, "SEC_LOGGED_ATTR_UNIQ_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.SecLoggedAttrs)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_SEC_LOGGED_ATTR_ENTITY");
            });

            modelBuilder.Entity<SecLoggedEntity>(entity =>
            {
                entity.ToTable("SEC_LOGGED_ENTITY");

                entity.HasIndex(e => e.Name, "SEC_LOGGED_ENTITY_UNIQ_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Auto).HasColumnName("AUTO");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Manual).HasColumnName("MANUAL");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SecPermission>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_PERM__3214EC26DD0FDE1B")
                    .IsClustered(false);

                entity.ToTable("SEC_PERMISSION");

                entity.HasIndex(e => e.RoleId, "IDX_SEC_PERMISSION_ROLE")
                    .IsClustered();

                entity.HasIndex(e => new { e.RoleId, e.PermissionType, e.Target, e.DeleteTs }, "IDX_SEC_PERMISSION_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.PermissionType).HasColumnName("PERMISSION_TYPE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.Target)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TARGET");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Value).HasColumnName("VALUE_");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SecPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("SEC_PERMISSION_ROLE");
            });

            modelBuilder.Entity<SecPresentation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_PRES__3214EC26756C5F71")
                    .IsClustered(false);

                entity.ToTable("SEC_PRESENTATION");

                entity.HasIndex(e => new { e.Component, e.UserId }, "IDX_SEC_PRESENTATION_COMPONENT_USER")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Component)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMPONENT");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.IsAutoSave).HasColumnName("IS_AUTO_SAVE");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Xml)
                    .HasMaxLength(7000)
                    .IsUnicode(false)
                    .HasColumnName("XML");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecPresentations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("SEC_PRESENTATION_USER");
            });

            modelBuilder.Entity<SecRememberMe>(entity =>
            {
                entity.ToTable("SEC_REMEMBER_ME");

                entity.HasIndex(e => e.Token, "IDX_SEC_REMEMBER_ME_TOKEN");

                entity.HasIndex(e => e.UserId, "IDX_SEC_REMEMBER_ME_USER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Token)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("TOKEN");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecRememberMes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEC_REMEMBER_ME_USER");
            });

            modelBuilder.Entity<SecRole>(entity =>
            {
                entity.ToTable("SEC_ROLE");

                entity.HasIndex(e => new { e.Name, e.SysTenantId, e.DeleteTs }, "IDX_SEC_ROLE_UNIQ_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsDefaultRole).HasColumnName("IS_DEFAULT_ROLE");

                entity.Property(e => e.LocName)
                    .HasMaxLength(255)
                    .HasColumnName("LOC_NAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.RoleType).HasColumnName("ROLE_TYPE");

                entity.Property(e => e.SecurityScope)
                    .HasMaxLength(255)
                    .HasColumnName("SECURITY_SCOPE");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SecScreenHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_SCRE__3214EC26FE2E674A")
                    .IsClustered(false);

                entity.ToTable("SEC_SCREEN_HISTORY");

                entity.HasIndex(e => e.CreateTs, "IDX_SEC_SCREEN_HISTORY_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => e.EntityId, "IDX_SEC_SCREEN_HISTORY_ENTITY_ID");

                entity.HasIndex(e => e.IntEntityId, "IDX_SEC_SCREEN_HISTORY_IENTITY_ID");

                entity.HasIndex(e => e.LongEntityId, "IDX_SEC_SCREEN_HISTORY_LENTITY_ID");

                entity.HasIndex(e => e.StringEntityId, "IDX_SEC_SCREEN_HISTORY_SENTITY_ID");

                entity.HasIndex(e => e.UserId, "IDX_SEC_SCREEN_HISTORY_USER");

                entity.HasIndex(e => e.SubstitutedUserId, "IDX_SEC_SCREEN_HIST_SUB_USER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Caption)
                    .HasMaxLength(255)
                    .HasColumnName("CAPTION");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");

                entity.Property(e => e.SubstitutedUserId).HasColumnName("SUBSTITUTED_USER_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.SubstitutedUser)
                    .WithMany(p => p.SecScreenHistorySubstitutedUsers)
                    .HasForeignKey(d => d.SubstitutedUserId)
                    .HasConstraintName("FK_SEC_HISTORY_SUBSTITUTED_USER");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecScreenHistoryUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SEC_HISTORY_USER");
            });

            modelBuilder.Entity<SecSearchFolder>(entity =>
            {
                entity.HasKey(e => e.FolderId)
                    .HasName("PK__SEC_SEAR__92AB9ADC8E9967E3");

                entity.ToTable("SEC_SEARCH_FOLDER");

                entity.HasIndex(e => e.UserId, "IDX_SEC_SEARCH_FOLDER_USER");

                entity.Property(e => e.FolderId)
                    .ValueGeneratedNever()
                    .HasColumnName("FOLDER_ID");

                entity.Property(e => e.ApplyDefault).HasColumnName("APPLY_DEFAULT");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_TYPE");

                entity.Property(e => e.FilterComponent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_COMPONENT");

                entity.Property(e => e.FilterXml)
                    .HasMaxLength(7000)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_XML");

                entity.Property(e => e.IsSet).HasColumnName("IS_SET");

                entity.Property(e => e.PresentationId).HasColumnName("PRESENTATION_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Folder)
                    .WithOne(p => p.SecSearchFolder)
                    .HasForeignKey<SecSearchFolder>(d => d.FolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEC_SEARCH_FOLDER_FOLDER");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.SecSearchFolders)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SEC_SEARCH_FOLDER_PRESENTATION");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecSearchFolders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SEC_SEARCH_FOLDER_USER");
            });

            modelBuilder.Entity<SecSessionAttr>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_SESS__3214EC264972EE97")
                    .IsClustered(false);

                entity.ToTable("SEC_SESSION_ATTR");

                entity.HasIndex(e => e.GroupId, "IDX_SEC_SESSION_ATTR_GROUP")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Datatype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DATATYPE");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.StrValue)
                    .HasMaxLength(1000)
                    .HasColumnName("STR_VALUE");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SecSessionAttrs)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("SEC_SESSION_ATTR_GROUP");
            });

            modelBuilder.Entity<SecSessionLog>(entity =>
            {
                entity.ToTable("SEC_SESSION_LOG");

                entity.HasIndex(e => e.SessionId, "IDX_SESSION_LOG_ENTRY_SESSION");

                entity.HasIndex(e => e.SubstitutedUserId, "IDX_SESSION_LOG_ENTRY_SUBUSER");

                entity.HasIndex(e => e.UserId, "IDX_SESSION_LOG_ENTRY_USER");

                entity.HasIndex(e => e.StartedTs, "IDX_SESSION_LOG_STARTED_TS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.ClientInfo)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_INFO");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TYPE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.FinishedTs)
                    .HasColumnType("datetime")
                    .HasColumnName("FINISHED_TS");

                entity.Property(e => e.LastAction).HasColumnName("LAST_ACTION");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("SERVER_ID");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

                entity.Property(e => e.StartedTs)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTED_TS");

                entity.Property(e => e.SubstitutedUserId).HasColumnName("SUBSTITUTED_USER_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserData).HasColumnName("USER_DATA");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SubstitutedUser)
                    .WithMany(p => p.SecSessionLogSubstitutedUsers)
                    .HasForeignKey(d => d.SubstitutedUserId)
                    .HasConstraintName("FK_SESSION_LOG_ENTRY_SUBUSER");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecSessionLogUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESSION_LOG_ENTRY_USER");
            });

            modelBuilder.Entity<SecUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_USER__3214EC26D84D1704")
                    .IsClustered(false);

                entity.ToTable("SEC_USER");

                entity.HasIndex(e => e.LoginLc, "IDX_SEC_USER_LOGIN")
                    .IsClustered();

                entity.HasIndex(e => e.QuanHuyenId, "IDX_SEC_USER_ON_QUAN_HUYEN");

                entity.HasIndex(e => e.TinhThanhId, "IDX_SEC_USER_ON_TINH_THANH");

                entity.HasIndex(e => e.XaPhuongId, "IDX_SEC_USER_ON_XA_PHUONG");

                entity.HasIndex(e => new { e.LoginLc, e.SysTenantId, e.DeleteTs }, "IDX_SEC_USER_UNIQ_LOGIN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.AnhCmnd)
                    .HasMaxLength(1024)
                    .HasColumnName("ANH_CMND");

                entity.Property(e => e.ChangePasswordAtLogon).HasColumnName("CHANGE_PASSWORD_AT_LOGON");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(50)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.Dtype)
                    .HasMaxLength(31)
                    .HasColumnName("DTYPE");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(255)
                    .HasColumnName("FACEBOOK_ID");

                entity.Property(e => e.Fanpage)
                    .HasMaxLength(255)
                    .HasColumnName("FANPAGE");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.GioiThieu)
                    .HasMaxLength(4000)
                    .HasColumnName("GIOI_THIEU");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(50)
                    .HasColumnName("GIOI_TINH");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.GroupNames)
                    .HasMaxLength(255)
                    .HasColumnName("GROUP_NAMES");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HinhAnhKhac)
                    .HasMaxLength(4000)
                    .HasColumnName("HINH_ANH_KHAC");

                entity.Property(e => e.IpMask)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IP_MASK");

                entity.Property(e => e.LaQuanTriHeThong).HasColumnName("LA_QUAN_TRI_HE_THONG");

                entity.Property(e => e.Language)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LANGUAGE_");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.LoaiGiayToTuyThan).HasColumnName("LOAI_GIAY_TO_TUY_THAN");

                entity.Property(e => e.LoaiTaiKhoan).HasColumnName("LOAI_TAI_KHOAN");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.LoginLc)
                    .HasMaxLength(50)
                    .HasColumnName("LOGIN_LC");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("MA_SO_THUE");

                entity.Property(e => e.MaTaiKhoan)
                    .HasMaxLength(255)
                    .HasColumnName("MA_TAI_KHOAN");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(50)
                    .HasColumnName("NGAY_SINH");

                entity.Property(e => e.NguoiXacThuc)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_XAC_THUC");

                entity.Property(e => e.NoiDungXacThuc)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG_XAC_THUC");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PasswordEncryption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD_ENCRYPTION");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .HasColumnName("POSITION_");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QUAN_HUYEN_ID");

                entity.Property(e => e.SoGiayToTuyThan)
                    .HasMaxLength(50)
                    .HasColumnName("SO_GIAY_TO_TUY_THAN");

                entity.Property(e => e.SoTaiKhoanNganHang)
                    .HasMaxLength(50)
                    .HasColumnName("SO_TAI_KHOAN_NGAN_HANG");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.TenNganHang)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NGAN_HANG");

                entity.Property(e => e.TenTaiKhoanNganHang)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_TAI_KHOAN_NGAN_HANG");

                entity.Property(e => e.ThoiGianXacThuc).HasColumnName("THOI_GIAN_XAC_THUC");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIME_ZONE");

                entity.Property(e => e.TimeZoneAuto).HasColumnName("TIME_ZONE_AUTO");

                entity.Property(e => e.TinhThanhId).HasColumnName("TINH_THANH_ID");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.VaiTro)
                    .HasMaxLength(400)
                    .HasColumnName("VAI_TRO");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .HasColumnName("WEBSITE");

                entity.Property(e => e.XaPhuongId).HasColumnName("XA_PHUONG_ID");

                entity.Property(e => e.XacThucEmail).HasColumnName("XAC_THUC_EMAIL");

                entity.Property(e => e.XacThucSoDienThoai).HasColumnName("XAC_THUC_SO_DIEN_THOAI");

                entity.Property(e => e.Youtube)
                    .HasMaxLength(255)
                    .HasColumnName("YOUTUBE");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SecUsers)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("SEC_USER_GROUP");

                entity.HasOne(d => d.QuanHuyen)
                    .WithMany(p => p.SecUsers)
                    .HasForeignKey(d => d.QuanHuyenId)
                    .HasConstraintName("FK_SEC_USER_ON_QUAN_HUYEN");

                entity.HasOne(d => d.TinhThanh)
                    .WithMany(p => p.SecUsers)
                    .HasForeignKey(d => d.TinhThanhId)
                    .HasConstraintName("FK_SEC_USER_ON_TINH_THANH");

                entity.HasOne(d => d.XaPhuong)
                    .WithMany(p => p.SecUsers)
                    .HasForeignKey(d => d.XaPhuongId)
                    .HasConstraintName("FK_SEC_USER_ON_XA_PHUONG");
            });

            modelBuilder.Entity<SecUserRole>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_USER__3214EC26E5AFF65F")
                    .IsClustered(false);

                entity.ToTable("SEC_USER_ROLE");

                entity.HasIndex(e => new { e.UserId, e.RoleId, e.RoleName, e.DeleteTs }, "IDX_SEC_USER_ROLE_UNIQ_ROLE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "IDX_SEC_USER_ROLE_USER")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("ROLE_NAME");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SecUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("SEC_USER_ROLE_ROLE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("SEC_USER_ROLE_PROFILE");
            });

            modelBuilder.Entity<SecUserSetting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_USER__3214EC2677CE4CE4")
                    .IsClustered(false);

                entity.ToTable("SEC_USER_SETTING");

                entity.HasIndex(e => e.CreateTs, "IDX_SEC_USER_SETTING_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.Name, e.ClientType }, "SEC_USER_SETTING_UNIQ")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CLIENT_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Value).HasColumnName("VALUE_");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecUserSettings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("SEC_USER_SETTING_USER");
            });

            modelBuilder.Entity<SecUserSubstitution>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SEC_USER__3214EC264551E185")
                    .IsClustered(false);

                entity.ToTable("SEC_USER_SUBSTITUTION");

                entity.HasIndex(e => e.UserId, "IDX_SEC_USER_SUBSTITUTION_USER")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.SubstitutedUserId).HasColumnName("SUBSTITUTED_USER_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SubstitutedUser)
                    .WithMany(p => p.SecUserSubstitutionSubstitutedUsers)
                    .HasForeignKey(d => d.SubstitutedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEC_USER_SUBSTITUTION_SUBSTITUTED_USER");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SecUserSubstitutionUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEC_USER_SUBSTITUTION_USER");
            });

            modelBuilder.Entity<SysAccessToken>(entity =>
            {
                entity.ToTable("SYS_ACCESS_TOKEN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AuthenticationBytes)
                    .HasColumnType("image")
                    .HasColumnName("AUTHENTICATION_BYTES");

                entity.Property(e => e.AuthenticationKey)
                    .HasMaxLength(255)
                    .HasColumnName("AUTHENTICATION_KEY");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.Expiry)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPIRY");

                entity.Property(e => e.Locale)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LOCALE");

                entity.Property(e => e.RefreshTokenValue)
                    .HasMaxLength(255)
                    .HasColumnName("REFRESH_TOKEN_VALUE");

                entity.Property(e => e.TokenBytes)
                    .HasColumnType("image")
                    .HasColumnName("TOKEN_BYTES");

                entity.Property(e => e.TokenValue)
                    .HasMaxLength(255)
                    .HasColumnName("TOKEN_VALUE");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_LOGIN");
            });

            modelBuilder.Entity<SysAppFolder>(entity =>
            {
                entity.HasKey(e => e.FolderId)
                    .HasName("PK__SYS_APP___92AB9ADC2D97E2A8");

                entity.ToTable("SYS_APP_FOLDER");

                entity.Property(e => e.FolderId)
                    .ValueGeneratedNever()
                    .HasColumnName("FOLDER_ID");

                entity.Property(e => e.ApplyDefault).HasColumnName("APPLY_DEFAULT");

                entity.Property(e => e.FilterComponent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_COMPONENT");

                entity.Property(e => e.FilterXml)
                    .HasMaxLength(7000)
                    .IsUnicode(false)
                    .HasColumnName("FILTER_XML");

                entity.Property(e => e.QuantityScript).HasColumnName("QUANTITY_SCRIPT");

                entity.Property(e => e.VisibilityScript).HasColumnName("VISIBILITY_SCRIPT");

                entity.HasOne(d => d.Folder)
                    .WithOne(p => p.SysAppFolder)
                    .HasForeignKey<SysAppFolder>(d => d.FolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_APP_FOLDER_FOLDER");
            });

            modelBuilder.Entity<SysAttrValue>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_ATTR__3214EC26A4F73E8B")
                    .IsClustered(false);

                entity.ToTable("SYS_ATTR_VALUE");

                entity.HasIndex(e => e.EntityId, "IDX_SYS_ATTR_VALUE_ENTITY")
                    .IsClustered();

                entity.HasIndex(e => e.IntEntityId, "IDX_SYS_ATTR_VALUE_IENTITY");

                entity.HasIndex(e => e.LongEntityId, "IDX_SYS_ATTR_VALUE_LENTITY");

                entity.HasIndex(e => e.StringEntityId, "IDX_SYS_ATTR_VALUE_SENTITY");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BooleanValue).HasColumnName("BOOLEAN_VALUE");

                entity.Property(e => e.CategoryAttrId).HasColumnName("CATEGORY_ATTR_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DateValue)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_VALUE");

                entity.Property(e => e.DateWoTimeValue)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_WO_TIME_VALUE");

                entity.Property(e => e.DecimalValue)
                    .HasColumnType("numeric(36, 10)")
                    .HasColumnName("DECIMAL_VALUE");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DoubleValue)
                    .HasColumnType("numeric(36, 6)")
                    .HasColumnName("DOUBLE_VALUE");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityValue).HasColumnName("ENTITY_VALUE");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.IntEntityValue).HasColumnName("INT_ENTITY_VALUE");

                entity.Property(e => e.IntegerValue).HasColumnName("INTEGER_VALUE");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.LongEntityValue).HasColumnName("LONG_ENTITY_VALUE");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");

                entity.Property(e => e.StringEntityValue)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_VALUE");

                entity.Property(e => e.StringValue).HasColumnName("STRING_VALUE");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CategoryAttr)
                    .WithMany(p => p.SysAttrValues)
                    .HasForeignKey(d => d.CategoryAttrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_ATTR_VALUE_CATEGORY_ATTR_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("SYS_ATTR_VALUE_ATTR_VALUE_PARENT_ID");
            });

            modelBuilder.Entity<SysCategory>(entity =>
            {
                entity.ToTable("SYS_CATEGORY");

                entity.HasIndex(e => new { e.Name, e.EntityType, e.DeleteTs }, "IDX_SYS_CATEGORY_UNIQ_NAME_ENTITY_TYPE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Discriminator).HasColumnName("DISCRIMINATOR");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_TYPE");

                entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

                entity.Property(e => e.LocaleNames)
                    .HasMaxLength(1000)
                    .HasColumnName("LOCALE_NAMES");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Special)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPECIAL");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysCategoryAttr>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_CATE__3214EC26004446F3")
                    .IsClustered(false);

                entity.ToTable("SYS_CATEGORY_ATTR");

                entity.HasIndex(e => new { e.CategoryEntityType, e.Code, e.DeleteTs }, "IDX_CAT_ATTR_ENT_TYPE_AND_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.CategoryId, "IDX_SYS_CATEGORY_ATTR_CATEGORY")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttributeConfigurationJson).HasColumnName("ATTRIBUTE_CONFIGURATION_JSON");

                entity.Property(e => e.CategoryEntityType)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_ENTITY_TYPE");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("CODE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DataType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DATA_TYPE");

                entity.Property(e => e.DefaultBoolean).HasColumnName("DEFAULT_BOOLEAN");

                entity.Property(e => e.DefaultDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEFAULT_DATE");

                entity.Property(e => e.DefaultDateIsCurrent).HasColumnName("DEFAULT_DATE_IS_CURRENT");

                entity.Property(e => e.DefaultDateWoTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DEFAULT_DATE_WO_TIME");

                entity.Property(e => e.DefaultDecimal)
                    .HasColumnType("numeric(36, 10)")
                    .HasColumnName("DEFAULT_DECIMAL");

                entity.Property(e => e.DefaultDouble)
                    .HasColumnType("numeric(36, 6)")
                    .HasColumnName("DEFAULT_DOUBLE");

                entity.Property(e => e.DefaultEntityValue).HasColumnName("DEFAULT_ENTITY_VALUE");

                entity.Property(e => e.DefaultInt).HasColumnName("DEFAULT_INT");

                entity.Property(e => e.DefaultIntEntityValue).HasColumnName("DEFAULT_INT_ENTITY_VALUE");

                entity.Property(e => e.DefaultLongEntityValue).HasColumnName("DEFAULT_LONG_ENTITY_VALUE");

                entity.Property(e => e.DefaultStrEntityValue)
                    .HasMaxLength(255)
                    .HasColumnName("DEFAULT_STR_ENTITY_VALUE");

                entity.Property(e => e.DefaultString).HasColumnName("DEFAULT_STRING");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EntityClass)
                    .HasMaxLength(500)
                    .HasColumnName("ENTITY_CLASS");

                entity.Property(e => e.Enumeration)
                    .HasMaxLength(500)
                    .HasColumnName("ENUMERATION");

                entity.Property(e => e.EnumerationLocales)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ENUMERATION_LOCALES");

                entity.Property(e => e.FilterXml).HasColumnName("FILTER_XML");

                entity.Property(e => e.IsCollection).HasColumnName("IS_COLLECTION");

                entity.Property(e => e.JoinClause)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("JOIN_CLAUSE");

                entity.Property(e => e.LocaleDescriptions)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("LOCALE_DESCRIPTIONS");

                entity.Property(e => e.LocaleNames)
                    .HasMaxLength(1000)
                    .HasColumnName("LOCALE_NAMES");

                entity.Property(e => e.Lookup).HasColumnName("LOOKUP");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.OrderNo).HasColumnName("ORDER_NO");

                entity.Property(e => e.Required).HasColumnName("REQUIRED");

                entity.Property(e => e.RowsCount).HasColumnName("ROWS_COUNT");

                entity.Property(e => e.Screen)
                    .HasMaxLength(255)
                    .HasColumnName("SCREEN");

                entity.Property(e => e.TargetScreens)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("TARGET_SCREENS");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("WHERE_CLAUSE");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("WIDTH");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SysCategoryAttrs)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_CATEGORY_ATTR_CATEGORY_ID");
            });

            modelBuilder.Entity<SysConfig>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_CONF__3214EC2699FEF704")
                    .IsClustered(false);

                entity.ToTable("SYS_CONFIG");

                entity.HasIndex(e => e.Name, "IDX_SYS_CONFIG_UNIQ_NAME")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Value).HasColumnName("VALUE_");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysDbChangelog>(entity =>
            {
                entity.HasKey(e => e.ScriptName)
                    .HasName("PK__SYS_DB_C__F86F49D65095C64B");

                entity.ToTable("SYS_DB_CHANGELOG");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(300)
                    .HasColumnName("SCRIPT_NAME");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsInit)
                    .HasColumnName("IS_INIT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SysEntitySnapshot>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_ENTI__3214EC2611DE1BBD")
                    .IsClustered(false);

                entity.ToTable("SYS_ENTITY_SNAPSHOT");

                entity.HasIndex(e => e.CreateTs, "IDX_SYS_ENTITY_SNAPSHOT_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => e.EntityId, "IDX_SYS_ENTITY_SNAPSHOT_ENTITY_ID");

                entity.HasIndex(e => e.IntEntityId, "IDX_SYS_ENTITY_SNAPSHOT_IENTITY_ID");

                entity.HasIndex(e => e.LongEntityId, "IDX_SYS_ENTITY_SNAPSHOT_LENTITY_ID");

                entity.HasIndex(e => e.StringEntityId, "IDX_SYS_ENTITY_SNAPSHOT_SENTITY_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AuthorId).HasColumnName("AUTHOR_ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityMetaClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENTITY_META_CLASS");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.SnapshotDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SNAPSHOT_DATE");

                entity.Property(e => e.SnapshotXml).HasColumnName("SNAPSHOT_XML");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.ViewXml).HasColumnName("VIEW_XML");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.SysEntitySnapshots)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_ENTITY_SNAPSHOT_AUTHOR_ID");
            });

            modelBuilder.Entity<SysEntityStatistic>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_ENTI__3214EC26F04947A9")
                    .IsClustered(false);

                entity.ToTable("SYS_ENTITY_STATISTICS");

                entity.HasIndex(e => e.Name, "IDX_SYS_ENTITY_STATISTICS_UNIQ_NAME")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.FetchUi).HasColumnName("FETCH_UI");

                entity.Property(e => e.InstanceCount).HasColumnName("INSTANCE_COUNT");

                entity.Property(e => e.LazyCollectionThreshold).HasColumnName("LAZY_COLLECTION_THRESHOLD");

                entity.Property(e => e.LookupScreenThreshold).HasColumnName("LOOKUP_SCREEN_THRESHOLD");

                entity.Property(e => e.MaxFetchUi).HasColumnName("MAX_FETCH_UI");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");
            });

            modelBuilder.Entity<SysFile>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_FILE__3214EC26FA58970F")
                    .IsClustered(false);

                entity.ToTable("SYS_FILE");

                entity.HasIndex(e => e.CreateDate, "IDX_SYS_FILE_CREATE_DATE")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Ext)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EXT");

                entity.Property(e => e.FileSize).HasColumnName("FILE_SIZE");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysFolder>(entity =>
            {
                entity.ToTable("SYS_FOLDER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.FolderType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FOLDER_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.SortOrder).HasColumnName("SORT_ORDER");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.TabName)
                    .HasMaxLength(100)
                    .HasColumnName("TAB_NAME");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SYS_FOLDER_PARENT");
            });

            modelBuilder.Entity<SysFtsQueue>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_FTS___3214EC267DEA1A57")
                    .IsClustered(false);

                entity.ToTable("SYS_FTS_QUEUE");

                entity.HasIndex(e => e.CreateTs, "IDX_SYS_FTS_QUEUE_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => new { e.IndexingHost, e.CreateTs }, "IDX_SYS_FTS_QUEUE_IDXHOST_CRTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChangeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHANGE_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(200)
                    .HasColumnName("ENTITY_NAME");

                entity.Property(e => e.Fake).HasColumnName("FAKE");

                entity.Property(e => e.IndexingHost)
                    .HasMaxLength(255)
                    .HasColumnName("INDEXING_HOST");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.SourceHost)
                    .HasMaxLength(255)
                    .HasColumnName("SOURCE_HOST");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");
            });

            modelBuilder.Entity<SysJmxInstance>(entity =>
            {
                entity.ToTable("SYS_JMX_INSTANCE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.NodeName)
                    .HasMaxLength(255)
                    .HasColumnName("NODE_NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SysLockConfig>(entity =>
            {
                entity.ToTable("SYS_LOCK_CONFIG");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.TimeoutSec).HasColumnName("TIMEOUT_SEC");
            });

            modelBuilder.Entity<SysQueryResult>(entity =>
            {
                entity.ToTable("SYS_QUERY_RESULT");

                entity.HasIndex(e => new { e.EntityId, e.SessionId, e.QueryKey }, "IDX_SYS_QUERY_RESULT_ENTITY_SESSION_KEY");

                entity.HasIndex(e => new { e.IntEntityId, e.SessionId, e.QueryKey }, "IDX_SYS_QUERY_RESULT_IENTITY_SESSION_KEY");

                entity.HasIndex(e => new { e.LongEntityId, e.SessionId, e.QueryKey }, "IDX_SYS_QUERY_RESULT_LENTITY_SESSION_KEY");

                entity.HasIndex(e => new { e.StringEntityId, e.SessionId, e.QueryKey }, "IDX_SYS_QUERY_RESULT_SENTITY_SESSION_KEY");

                entity.HasIndex(e => new { e.SessionId, e.QueryKey }, "IDX_SYS_QUERY_RESULT_SESSION_KEY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.Property(e => e.IntEntityId).HasColumnName("INT_ENTITY_ID");

                entity.Property(e => e.LongEntityId).HasColumnName("LONG_ENTITY_ID");

                entity.Property(e => e.QueryKey).HasColumnName("QUERY_KEY");

                entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");

                entity.Property(e => e.StringEntityId)
                    .HasMaxLength(255)
                    .HasColumnName("STRING_ENTITY_ID");
            });

            modelBuilder.Entity<SysRefreshToken>(entity =>
            {
                entity.ToTable("SYS_REFRESH_TOKEN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AuthenticationBytes)
                    .HasColumnType("image")
                    .HasColumnName("AUTHENTICATION_BYTES");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.Expiry)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPIRY");

                entity.Property(e => e.TokenBytes)
                    .HasColumnType("image")
                    .HasColumnName("TOKEN_BYTES");

                entity.Property(e => e.TokenValue)
                    .HasMaxLength(255)
                    .HasColumnName("TOKEN_VALUE");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_LOGIN");
            });

            modelBuilder.Entity<SysScheduledExecution>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_SCHE__3214EC2616C7CF4D")
                    .IsClustered(false);

                entity.ToTable("SYS_SCHEDULED_EXECUTION");

                entity.HasIndex(e => e.CreateTs, "IDX_SYS_SCHEDULED_EXECUTION_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => new { e.TaskId, e.FinishTime }, "IDX_SYS_SCHEDULED_EXECUTION_TASK_FINISH_TIME");

                entity.HasIndex(e => new { e.TaskId, e.StartTime }, "IDX_SYS_SCHEDULED_EXECUTION_TASK_START_TIME");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("FINISH_TIME");

                entity.Property(e => e.Result).HasColumnName("RESULT");

                entity.Property(e => e.Server)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("SERVER");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("START_TIME");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.TaskId).HasColumnName("TASK_ID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.SysScheduledExecutions)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("SYS_SCHEDULED_EXECUTION_TASK");
            });

            modelBuilder.Entity<SysScheduledTask>(entity =>
            {
                entity.ToTable("SYS_SCHEDULED_TASK");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BeanName)
                    .HasMaxLength(50)
                    .HasColumnName("BEAN_NAME");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(500)
                    .HasColumnName("CLASS_NAME");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Cron)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CRON");

                entity.Property(e => e.DefinedBy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEFINED_BY")
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.IsSingleton).HasColumnName("IS_SINGLETON");

                entity.Property(e => e.LastStartServer)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("LAST_START_SERVER");

                entity.Property(e => e.LastStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("LAST_START_TIME");

                entity.Property(e => e.LogFinish).HasColumnName("LOG_FINISH");

                entity.Property(e => e.LogStart).HasColumnName("LOG_START");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(50)
                    .HasColumnName("METHOD_NAME");

                entity.Property(e => e.MethodParams)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("METHOD_PARAMS");

                entity.Property(e => e.Period).HasColumnName("PERIOD_");

                entity.Property(e => e.PermittedServers)
                    .HasMaxLength(4096)
                    .IsUnicode(false)
                    .HasColumnName("PERMITTED_SERVERS");

                entity.Property(e => e.SchedulingType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SCHEDULING_TYPE")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(500)
                    .HasColumnName("SCRIPT_NAME");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.StartDelay).HasColumnName("START_DELAY");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.TimeFrame).HasColumnName("TIME_FRAME");

                entity.Property(e => e.Timeout).HasColumnName("TIMEOUT");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<SysSendingAttachment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_SEND__3214EC26CFC85AF9")
                    .IsClustered(false);

                entity.ToTable("SYS_SENDING_ATTACHMENT");

                entity.HasIndex(e => e.CreateTs, "IDX_SYS_SENDING_ATTACHMENT_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => e.MessageId, "SYS_SENDING_ATTACHMENT_MESSAGE_IDX");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnType("image")
                    .HasColumnName("CONTENT");

                entity.Property(e => e.ContentFileId).HasColumnName("CONTENT_FILE_ID");

                entity.Property(e => e.ContentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONTENT_ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.Disposition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISPOSITION");

                entity.Property(e => e.MessageId).HasColumnName("MESSAGE_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.TextEncoding)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEXT_ENCODING");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContentFile)
                    .WithMany(p => p.SysSendingAttachments)
                    .HasForeignKey(d => d.ContentFileId)
                    .HasConstraintName("FK_SYS_SENDING_ATTACHMENT_CONTENT_FILE");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.SysSendingAttachments)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_SYS_SENDING_ATTACHMENT_SENDING_MESSAGE");
            });

            modelBuilder.Entity<SysSendingMessage>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_SEND__3214EC26597988C3")
                    .IsClustered(false);

                entity.ToTable("SYS_SENDING_MESSAGE");

                entity.HasIndex(e => e.CreateTs, "IDX_SYS_SENDING_MESSAGE_CREATE_TS")
                    .IsClustered();

                entity.HasIndex(e => e.DateSent, "IDX_SYS_SENDING_MESSAGE_DATE_SENT");

                entity.HasIndex(e => e.Status, "IDX_SYS_SENDING_MESSAGE_STATUS");

                entity.HasIndex(e => e.UpdateTs, "IDX_SYS_SENDING_MESSAGE_UPDATE_TS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddressBcc).HasColumnName("ADDRESS_BCC");

                entity.Property(e => e.AddressCc).HasColumnName("ADDRESS_CC");

                entity.Property(e => e.AddressFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_FROM");

                entity.Property(e => e.AddressTo).HasColumnName("ADDRESS_TO");

                entity.Property(e => e.AttachmentsName).HasColumnName("ATTACHMENTS_NAME");

                entity.Property(e => e.AttemptsCount).HasColumnName("ATTEMPTS_COUNT");

                entity.Property(e => e.AttemptsMade).HasColumnName("ATTEMPTS_MADE");

                entity.Property(e => e.BodyContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BODY_CONTENT_TYPE");

                entity.Property(e => e.Caption)
                    .HasMaxLength(500)
                    .HasColumnName("CAPTION");

                entity.Property(e => e.ContentText).HasColumnName("CONTENT_TEXT");

                entity.Property(e => e.ContentTextFileId).HasColumnName("CONTENT_TEXT_FILE_ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DateSent)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_SENT");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("DEADLINE");

                entity.Property(e => e.DeleteTs)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.EmailHeaders)
                    .HasMaxLength(500)
                    .HasColumnName("EMAIL_HEADERS");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.SysTenantId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_TENANT_ID");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContentTextFile)
                    .WithMany(p => p.SysSendingMessages)
                    .HasForeignKey(d => d.ContentTextFileId)
                    .HasConstraintName("FK_SYS_SENDING_MESSAGE_CONTENT_FILE");
            });

            modelBuilder.Entity<SysServer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SYS_SERV__3214EC26BB61F59C")
                    .IsClustered(false);

                entity.ToTable("SYS_SERVER");

                entity.HasIndex(e => e.Name, "IDX_SYS_SERVER_UNIQ_NAME")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Data).HasColumnName("DATA");

                entity.Property(e => e.IsRunning).HasColumnName("IS_RUNNING");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.UpdateTs)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");
            });

            modelBuilder.Entity<WcbcoreBaoHanh>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26982245A2")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_BAO_HANH");

                entity.HasIndex(e => e.DonHangBanLeId, "IDX_WCBCORE_BAO_HANH_ON_DON_HANG_BAN_LE");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_BAO_HANH_ON_DON_VI_TINH");

                entity.HasIndex(e => e.DuLieuXuatKhoId, "IDX_WCBCORE_BAO_HANH_ON_DU_LIEU_XUAT_KHO");

                entity.HasIndex(e => e.KhachHangMuaId, "IDX_WCBCORE_BAO_HANH_ON_KHACH_HANG_MUA");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_BAO_HANH_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NguoiMuaQuanHuyenId, "IDX_WCBCORE_BAO_HANH_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasIndex(e => e.NguoiMuaTinhThanhId, "IDX_WCBCORE_BAO_HANH_ON_NGUOI_MUA_TINH_THANH");

                entity.HasIndex(e => e.NguoiMuaXaPhuongId, "IDX_WCBCORE_BAO_HANH_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasIndex(e => e.NhaCungCapId, "IDX_WCBCORE_BAO_HANH_ON_NHA_CUNG_CAP");

                entity.HasIndex(e => e.PhieuXuatKhoId, "IDX_WCBCORE_BAO_HANH_ON_PHIEU_XUAT_KHO");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_BAO_HANH_ON_SAN_PHAM");

                entity.HasIndex(e => e.TaiKhoanCapNhatId, "IDX_WCBCORE_BAO_HANH_ON_TAI_KHOAN_CAP_NHAT");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_BAO_HANH_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaoHanh).HasColumnName("BAO_HANH");

                entity.Property(e => e.BienBanBanGiao)
                    .HasMaxLength(255)
                    .HasColumnName("BIEN_BAN_BAN_GIAO");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DaBanGiaoNcc).HasColumnName("DA_BAN_GIAO_NCC");

                entity.Property(e => e.DonHangBanLeId).HasColumnName("DON_HANG_BAN_LE_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.DuLieuXuatKhoId).HasColumnName("DU_LIEU_XUAT_KHO_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.KhachHangMuaId).HasColumnName("KHACH_HANG_MUA_ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MoTaSanPham).HasColumnName("MO_TA_SAN_PHAM");

                entity.Property(e => e.NgayHenTra).HasColumnName("NGAY_HEN_TRA");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NgayMuaHang).HasColumnName("NGAY_MUA_HANG");

                entity.Property(e => e.NguoiCapNhat)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_CAP_NHAT");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NguoiMuaDiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIA_CHI");

                entity.Property(e => e.NguoiMuaDienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIEN_THOAI");

                entity.Property(e => e.NguoiMuaEmail)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_EMAIL");

                entity.Property(e => e.NguoiMuaHoTen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_HO_TEN");

                entity.Property(e => e.NguoiMuaQuanHuyenId).HasColumnName("NGUOI_MUA_QUAN_HUYEN_ID");

                entity.Property(e => e.NguoiMuaTenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_QUAN_HUYEN");

                entity.Property(e => e.NguoiMuaTenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_TINH_THANH");

                entity.Property(e => e.NguoiMuaTenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_XA_PHUONG");

                entity.Property(e => e.NguoiMuaTinhThanhId).HasColumnName("NGUOI_MUA_TINH_THANH_ID");

                entity.Property(e => e.NguoiMuaXaPhuongId).HasColumnName("NGUOI_MUA_XA_PHUONG_ID");

                entity.Property(e => e.NhaCungCapId).HasColumnName("NHA_CUNG_CAP_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.PhiDichVu)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("PHI_DICH_VU");

                entity.Property(e => e.PhieuXuatKhoId).HasColumnName("PHIEU_XUAT_KHO_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TaiKhoanCapNhatId).HasColumnName("TAI_KHOAN_CAP_NHAT_ID");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenNhaCungCap)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHA_CUNG_CAP");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThoiGianCapNhat).HasColumnName("THOI_GIAN_CAP_NHAT");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHangBanLe)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.DonHangBanLeId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_DON_HANG_BAN_LE");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_DON_VI_TINH");

                entity.HasOne(d => d.DuLieuXuatKho)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.DuLieuXuatKhoId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_DU_LIEU_XUAT_KHO");

                entity.HasOne(d => d.KhachHangMua)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.KhachHangMuaId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_KHACH_HANG_MUA");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreBaoHanhNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_NGUOI_LAP");

                entity.HasOne(d => d.NguoiMuaQuanHuyen)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.NguoiMuaQuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasOne(d => d.NguoiMuaTinhThanh)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.NguoiMuaTinhThanhId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_NGUOI_MUA_TINH_THANH");

                entity.HasOne(d => d.NguoiMuaXaPhuong)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.NguoiMuaXaPhuongId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasOne(d => d.NhaCungCap)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.NhaCungCapId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_NHA_CUNG_CAP");

                entity.HasOne(d => d.PhieuXuatKho)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.PhieuXuatKhoId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_PHIEU_XUAT_KHO");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_SAN_PHAM");

                entity.HasOne(d => d.TaiKhoanCapNhat)
                    .WithMany(p => p.WcbcoreBaoHanhTaiKhoanCapNhats)
                    .HasForeignKey(d => d.TaiKhoanCapNhatId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_TAI_KHOAN_CAP_NHAT");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreBaoHanhs)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_BAO_HANH_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreBienBanGiaoNhanHangHoaVoiNcc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC264368B411")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NhaCungCapId, "IDX_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_NHA_CUNG_CAP");

                entity.HasIndex(e => e.TaiKhoanCapNhatId, "IDX_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_TAI_KHOAN_CAP_NHAT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiCapNhat)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_CAP_NHAT");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NhaCungCapId).HasColumnName("NHA_CUNG_CAP_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(1024)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.SoLuong).HasColumnName("SO_LUONG");

                entity.Property(e => e.TaiKhoanCapNhatId).HasColumnName("TAI_KHOAN_CAP_NHAT_ID");

                entity.Property(e => e.TenNhaCungCap)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHA_CUNG_CAP");

                entity.Property(e => e.ThoiGianCapNhat).HasColumnName("THOI_GIAN_CAP_NHAT");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreBienBanGiaoNhanHangHoaVoiNccNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .HasConstraintName("FK_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_NGUOI_LAP");

                entity.HasOne(d => d.NhaCungCap)
                    .WithMany(p => p.WcbcoreBienBanGiaoNhanHangHoaVoiNccs)
                    .HasForeignKey(d => d.NhaCungCapId)
                    .HasConstraintName("FK_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_NHA_CUNG_CAP");

                entity.HasOne(d => d.TaiKhoanCapNhat)
                    .WithMany(p => p.WcbcoreBienBanGiaoNhanHangHoaVoiNccTaiKhoanCapNhats)
                    .HasForeignKey(d => d.TaiKhoanCapNhatId)
                    .HasConstraintName("FK_WCBCORE_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ON_TAI_KHOAN_CAP_NHAT");
            });

            modelBuilder.Entity<WcbcoreBieuGhiLuuTruTonKho>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26AD4279A9")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_DON_VI_TINH");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_KHO_HANG");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.Huong).HasColumnName("HUONG");

                entity.Property(e => e.IdChungTu)
                    .HasMaxLength(50)
                    .HasColumnName("ID_CHUNG_TU");

                entity.Property(e => e.IdTongHop)
                    .HasMaxLength(50)
                    .HasColumnName("ID_TONG_HOP");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Loai).HasColumnName("LOAI");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.SoTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_TIEN");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThoiGian).HasColumnName("THOI_GIAN");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TongSoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_SO_LUONG");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreBieuGhiLuuTruTonKhos)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_DON_VI_TINH");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcoreBieuGhiLuuTruTonKhos)
                    .HasForeignKey(d => d.KhoHangId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_KHO_HANG");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreBieuGhiLuuTruTonKhos)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreBieuGhiLuuTruTonKhos)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_LUU_TRU_TON_KHO_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreBieuGhiTonKho>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC260FE4D09C")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_BIEU_GHI_TON_KHO");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_BIEU_GHI_TON_KHO_ON_DON_VI_TINH");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_BIEU_GHI_TON_KHO_ON_KHO_HANG");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_BIEU_GHI_TON_KHO_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_BIEU_GHI_TON_KHO_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaoHanh).HasColumnName("BAO_HANH");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.Huong).HasColumnName("HUONG");

                entity.Property(e => e.IdChungTu)
                    .HasMaxLength(50)
                    .HasColumnName("ID_CHUNG_TU");

                entity.Property(e => e.IdChungTuGoc)
                    .HasMaxLength(50)
                    .HasColumnName("ID_CHUNG_TU_GOC");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Loai).HasColumnName("LOAI");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.SoTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_TIEN");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThoiGian).HasColumnName("THOI_GIAN");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TongSoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_SO_LUONG");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreBieuGhiTonKhos)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_TON_KHO_ON_DON_VI_TINH");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcoreBieuGhiTonKhos)
                    .HasForeignKey(d => d.KhoHangId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_TON_KHO_ON_KHO_HANG");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreBieuGhiTonKhos)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_TON_KHO_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreBieuGhiTonKhos)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_BIEU_GHI_TON_KHO_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreChucVu>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC265FD6F69F")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_CHUC_VU");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreChuongTrinhKhuyenMai>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2665FC9DF4")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_CHUONG_TRINH_KHUYEN_MAI");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_CHUONG_TRINH_KHUYEN_MAI_ON_NGUOI_LAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BatDau).HasColumnName("BAT_DAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.KetThuc).HasColumnName("KET_THUC");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreChuongTrinhKhuyenMais)
                    .HasForeignKey(d => d.NguoiLapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_CHUONG_TRINH_KHUYEN_MAI_ON_NGUOI_LAP");
            });

            modelBuilder.Entity<WcbcoreDaPhuongTien>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC263F4AC58F")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_DA_PHUONG_TIEN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DuaVaoTrangChu).HasColumnName("DUA_VAO_TRANG_CHU");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LienKetNgoai).HasColumnName("LIEN_KET_NGOAI");

                entity.Property(e => e.Loai).HasColumnName("LOAI");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.NgayCapNhat).HasColumnName("NGAY_CAP_NHAT");

                entity.Property(e => e.NoiBat).HasColumnName("NOI_BAT");

                entity.Property(e => e.SoLuongKhongThich).HasColumnName("SO_LUONG_KHONG_THICH");

                entity.Property(e => e.SoLuongThich).HasColumnName("SO_LUONG_THICH");

                entity.Property(e => e.SoLuongXem).HasColumnName("SO_LUONG_XEM");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.TacGia)
                    .HasMaxLength(255)
                    .HasColumnName("TAC_GIA");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE");

                entity.Property(e => e.TieuDeNn)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE_NN");

                entity.Property(e => e.TuKhoa)
                    .HasMaxLength(255)
                    .HasColumnName("TU_KHOA");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreDiaChiGiaoDich>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC269E0911D1")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_DIA_CHI_GIAO_DICH");

                entity.HasIndex(e => e.QuanHuyenId, "IDX_WCBCORE_DIA_CHI_GIAO_DICH_ON_QUAN_HUYEN");

                entity.HasIndex(e => e.TaiKhoanId, "IDX_WCBCORE_DIA_CHI_GIAO_DICH_ON_TAI_KHOAN");

                entity.HasIndex(e => e.TinhThanhId, "IDX_WCBCORE_DIA_CHI_GIAO_DICH_ON_TINH_THANH");

                entity.HasIndex(e => e.XaPhuongId, "IDX_WCBCORE_DIA_CHI_GIAO_DICH_ON_XA_PHUONG");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs).HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .HasColumnName("HO_TEN");

                entity.Property(e => e.Loai).HasColumnName("LOAI");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QUAN_HUYEN_ID");

                entity.Property(e => e.TaiKhoanId).HasColumnName("TAI_KHOAN_ID");

                entity.Property(e => e.TenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_XA_PHUONG");

                entity.Property(e => e.ThoiGian).HasColumnName("THOI_GIAN");

                entity.Property(e => e.TinhThanhId).HasColumnName("TINH_THANH_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.XaPhuongId).HasColumnName("XA_PHUONG_ID");

                entity.HasOne(d => d.QuanHuyen)
                    .WithMany(p => p.WcbcoreDiaChiGiaoDiches)
                    .HasForeignKey(d => d.QuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_DIA_CHI_GIAO_DICH_ON_QUAN_HUYEN");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.WcbcoreDiaChiGiaoDiches)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_WCBCORE_DIA_CHI_GIAO_DICH_ON_TAI_KHOAN");

                entity.HasOne(d => d.TinhThanh)
                    .WithMany(p => p.WcbcoreDiaChiGiaoDiches)
                    .HasForeignKey(d => d.TinhThanhId)
                    .HasConstraintName("FK_WCBCORE_DIA_CHI_GIAO_DICH_ON_TINH_THANH");

                entity.HasOne(d => d.XaPhuong)
                    .WithMany(p => p.WcbcoreDiaChiGiaoDiches)
                    .HasForeignKey(d => d.XaPhuongId)
                    .HasConstraintName("FK_WCBCORE_DIA_CHI_GIAO_DICH_ON_XA_PHUONG");
            });

            modelBuilder.Entity<WcbcoreDonHangBanLe>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC264729103E")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_DON_HANG_BAN_LE");

                entity.HasIndex(e => e.DonViVanChuyenId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_DON_VI_VAN_CHUYEN");

                entity.HasIndex(e => e.KhachHangMuaId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_KHACH_HANG_MUA");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_KHO_HANG");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NguoiMuaQuanHuyenId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasIndex(e => e.NguoiMuaTaiKhoanId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_TAI_KHOAN");

                entity.HasIndex(e => e.NguoiMuaTinhThanhId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_TINH_THANH");

                entity.HasIndex(e => e.NguoiMuaXaPhuongId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasIndex(e => e.NguoiNhanQuanHuyenId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_QUAN_HUYEN");

                entity.HasIndex(e => e.NguoiNhanTinhThanhId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_TINH_THANH");

                entity.HasIndex(e => e.NguoiNhanXaPhuongId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_XA_PHUONG");

                entity.HasIndex(e => e.PhuongThucVanChuyenId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_PHUONG_THUC_VAN_CHUYEN");

                entity.HasIndex(e => e.TaiKhoanCapNhatId, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_TAI_KHOAN_CAP_NHAT");

                entity.HasIndex(e => e.TaiKhoanCapNhat2Id, "IDX_WCBCORE_DON_HANG_BAN_LE_ON_TAI_KHOAN_CAP_NHAT2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViVanChuyenId).HasColumnName("DON_VI_VAN_CHUYEN_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhThucThanhToan).HasColumnName("HINH_THUC_THANH_TOAN");

                entity.Property(e => e.KhachHangMuaId).HasColumnName("KHACH_HANG_MUA_ID");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MoTaSanPham).HasColumnName("MO_TA_SAN_PHAM");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiCapNhat)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_CAP_NHAT");

                entity.Property(e => e.NguoiCapNhat2)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_CAP_NHAT2");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NguoiMuaDiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIA_CHI");

                entity.Property(e => e.NguoiMuaDienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIEN_THOAI");

                entity.Property(e => e.NguoiMuaEmail)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_EMAIL");

                entity.Property(e => e.NguoiMuaHoTen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_HO_TEN");

                entity.Property(e => e.NguoiMuaQuanHuyenId).HasColumnName("NGUOI_MUA_QUAN_HUYEN_ID");

                entity.Property(e => e.NguoiMuaTaiKhoanId).HasColumnName("NGUOI_MUA_TAI_KHOAN_ID");

                entity.Property(e => e.NguoiMuaTenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_QUAN_HUYEN");

                entity.Property(e => e.NguoiMuaTenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_TINH_THANH");

                entity.Property(e => e.NguoiMuaTenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_XA_PHUONG");

                entity.Property(e => e.NguoiMuaTinhThanhId).HasColumnName("NGUOI_MUA_TINH_THANH_ID");

                entity.Property(e => e.NguoiMuaXaPhuongId).HasColumnName("NGUOI_MUA_XA_PHUONG_ID");

                entity.Property(e => e.NguoiNhanDiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_DIA_CHI");

                entity.Property(e => e.NguoiNhanDienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_DIEN_THOAI");

                entity.Property(e => e.NguoiNhanEmail)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_EMAIL");

                entity.Property(e => e.NguoiNhanHoTen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_HO_TEN");

                entity.Property(e => e.NguoiNhanQuanHuyenId).HasColumnName("NGUOI_NHAN_QUAN_HUYEN_ID");

                entity.Property(e => e.NguoiNhanTenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_QUAN_HUYEN");

                entity.Property(e => e.NguoiNhanTenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_TINH_THANH");

                entity.Property(e => e.NguoiNhanTenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_XA_PHUONG");

                entity.Property(e => e.NguoiNhanTinhThanhId).HasColumnName("NGUOI_NHAN_TINH_THANH_ID");

                entity.Property(e => e.NguoiNhanXaPhuongId).HasColumnName("NGUOI_NHAN_XA_PHUONG_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.NoiDungThanhToan)
                    .HasMaxLength(4000)
                    .HasColumnName("NOI_DUNG_THANH_TOAN");

                entity.Property(e => e.PhuongThucVanChuyenId).HasColumnName("PHUONG_THUC_VAN_CHUYEN_ID");

                entity.Property(e => e.SoLuongSanPham).HasColumnName("SO_LUONG_SAN_PHAM");

                entity.Property(e => e.TaiKhoanCapNhat2Id).HasColumnName("TAI_KHOAN_CAP_NHAT2_ID");

                entity.Property(e => e.TaiKhoanCapNhatId).HasColumnName("TAI_KHOAN_CAP_NHAT_ID");

                entity.Property(e => e.TenDonViVanChuyen)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_VAN_CHUYEN");

                entity.Property(e => e.TenPhuongThucVanChuyen)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_PHUONG_THUC_VAN_CHUYEN");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThoiGianCapNhat).HasColumnName("THOI_GIAN_CAP_NHAT");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.TrangThaiThanhToan).HasColumnName("TRANG_THAI_THANH_TOAN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViVanChuyen)
                    .WithMany(p => p.WcbcoreDonHangBanLes)
                    .HasForeignKey(d => d.DonViVanChuyenId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_DON_VI_VAN_CHUYEN");

                entity.HasOne(d => d.KhachHangMua)
                    .WithMany(p => p.WcbcoreDonHangBanLes)
                    .HasForeignKey(d => d.KhachHangMuaId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_KHACH_HANG_MUA");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcoreDonHangBanLes)
                    .HasForeignKey(d => d.KhoHangId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_KHO_HANG");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_LAP");

                entity.HasOne(d => d.NguoiMuaQuanHuyen)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiMuaQuanHuyens)
                    .HasForeignKey(d => d.NguoiMuaQuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasOne(d => d.NguoiMuaTaiKhoan)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiMuaTaiKhoans)
                    .HasForeignKey(d => d.NguoiMuaTaiKhoanId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_TAI_KHOAN");

                entity.HasOne(d => d.NguoiMuaTinhThanh)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiMuaTinhThanhs)
                    .HasForeignKey(d => d.NguoiMuaTinhThanhId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_TINH_THANH");

                entity.HasOne(d => d.NguoiMuaXaPhuong)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiMuaXaPhuongs)
                    .HasForeignKey(d => d.NguoiMuaXaPhuongId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasOne(d => d.NguoiNhanQuanHuyen)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiNhanQuanHuyens)
                    .HasForeignKey(d => d.NguoiNhanQuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_QUAN_HUYEN");

                entity.HasOne(d => d.NguoiNhanTinhThanh)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiNhanTinhThanhs)
                    .HasForeignKey(d => d.NguoiNhanTinhThanhId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_TINH_THANH");

                entity.HasOne(d => d.NguoiNhanXaPhuong)
                    .WithMany(p => p.WcbcoreDonHangBanLeNguoiNhanXaPhuongs)
                    .HasForeignKey(d => d.NguoiNhanXaPhuongId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_NGUOI_NHAN_XA_PHUONG");

                entity.HasOne(d => d.PhuongThucVanChuyen)
                    .WithMany(p => p.WcbcoreDonHangBanLes)
                    .HasForeignKey(d => d.PhuongThucVanChuyenId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_PHUONG_THUC_VAN_CHUYEN");

                entity.HasOne(d => d.TaiKhoanCapNhat2)
                    .WithMany(p => p.WcbcoreDonHangBanLeTaiKhoanCapNhat2s)
                    .HasForeignKey(d => d.TaiKhoanCapNhat2Id)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_TAI_KHOAN_CAP_NHAT2");

                entity.HasOne(d => d.TaiKhoanCapNhat)
                    .WithMany(p => p.WcbcoreDonHangBanLeTaiKhoanCapNhats)
                    .HasForeignKey(d => d.TaiKhoanCapNhatId)
                    .HasConstraintName("FK_WCBCORE_DON_HANG_BAN_LE_ON_TAI_KHOAN_CAP_NHAT");
            });

            modelBuilder.Entity<WcbcoreDonViTinh>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26782342D2")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_DON_VI_TINH");

                entity.HasIndex(e => e.Ma, "IDX_WCBCORE_DON_VI_TINH_UNIQ_MA")
                    .IsUnique();

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_DON_VI_TINH_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreDonViVanChuyen>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26128B9E51")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_DON_VI_VAN_CHUYEN");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_DON_VI_VAN_CHUYEN_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .HasColumnName("WEBSITE");
            });

            modelBuilder.Entity<WcbcoreGiaoDichVoiKhachHang>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26DCEF4F9F")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_GIAO_DICH_VOI_KHACH_HANG");

                entity.HasIndex(e => e.DonHangId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_DON_HANG");

                entity.HasIndex(e => e.KhachHangId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_KHACH_HANG");

                entity.HasIndex(e => e.LoaiId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_LOAI");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NguoiThucHienId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_NGUOI_THUC_HIEN");

                entity.HasIndex(e => e.PhieuXuatKhoId, "IDX_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_PHIEU_XUAT_KHO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs).HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.DonHangId).HasColumnName("DON_HANG_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.KhachHangId).HasColumnName("KHACH_HANG_ID");

                entity.Property(e => e.LoaiId).HasColumnName("LOAI_ID");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(255)
                    .HasColumnName("MA_DON_HANG");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(255)
                    .HasColumnName("MA_KHACH_HANG");

                entity.Property(e => e.MaPhieuXuatKho)
                    .HasMaxLength(255)
                    .HasColumnName("MA_PHIEU_XUAT_KHO");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NguoiThucHienId).HasColumnName("NGUOI_THUC_HIEN_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(4000)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.NoiDungDonHang)
                    .HasMaxLength(1024)
                    .HasColumnName("NOI_DUNG_DON_HANG");

                entity.Property(e => e.PhanHoi)
                    .HasMaxLength(4000)
                    .HasColumnName("PHAN_HOI");

                entity.Property(e => e.PhieuXuatKhoId).HasColumnName("PHIEU_XUAT_KHO_ID");

                entity.Property(e => e.TenKhachHang)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_KHACH_HANG");

                entity.Property(e => e.TenLoai)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_LOAI");

                entity.Property(e => e.ThoiGianThucHien).HasColumnName("THOI_GIAN_THUC_HIEN");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHang)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangs)
                    .HasForeignKey(d => d.DonHangId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_DON_HANG");

                entity.HasOne(d => d.KhachHang)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangs)
                    .HasForeignKey(d => d.KhachHangId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_KHACH_HANG");

                entity.HasOne(d => d.Loai)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangs)
                    .HasForeignKey(d => d.LoaiId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_LOAI");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_NGUOI_LAP");

                entity.HasOne(d => d.NguoiThucHien)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangNguoiThucHiens)
                    .HasForeignKey(d => d.NguoiThucHienId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_NGUOI_THUC_HIEN");

                entity.HasOne(d => d.PhieuXuatKho)
                    .WithMany(p => p.WcbcoreGiaoDichVoiKhachHangs)
                    .HasForeignKey(d => d.PhieuXuatKhoId)
                    .HasConstraintName("FK_WCBCORE_GIAO_DICH_VOI_KHACH_HANG_ON_PHIEU_XUAT_KHO");
            });

            modelBuilder.Entity<WcbcoreHangSanXuat>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26602676AC")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_HANG_SAN_XUAT");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_HANG_SAN_XUAT_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.SeoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("SEO_URL");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreKhachHang>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC267A2D0497")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_KHACH_HANG");

                entity.HasIndex(e => e.QuanHuyenId, "IDX_WCBCORE_KHACH_HANG_ON_QUAN_HUYEN");

                entity.HasIndex(e => e.TinhThanhId, "IDX_WCBCORE_KHACH_HANG_ON_TINH_THANH");

                entity.HasIndex(e => e.XaPhuongId, "IDX_WCBCORE_KHACH_HANG_ON_XA_PHUONG");

                entity.HasIndex(e => e.Ma, "IDX_WCBCORE_KHACH_HANG_UNIQ_MA")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoVaTen)
                    .HasMaxLength(255)
                    .HasColumnName("HO_VA_TEN");

                entity.Property(e => e.Ma)
                    .HasMaxLength(50)
                    .HasColumnName("MA");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QUAN_HUYEN_ID");

                entity.Property(e => e.TenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_QUAN_HUYEN");

                entity.Property(e => e.TenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_TINH_THANH");

                entity.Property(e => e.TenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_XA_PHUONG");

                entity.Property(e => e.TinhThanhId).HasColumnName("TINH_THANH_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.XaPhuongId).HasColumnName("XA_PHUONG_ID");

                entity.HasOne(d => d.QuanHuyen)
                    .WithMany(p => p.WcbcoreKhachHangs)
                    .HasForeignKey(d => d.QuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_KHACH_HANG_ON_QUAN_HUYEN");

                entity.HasOne(d => d.TinhThanh)
                    .WithMany(p => p.WcbcoreKhachHangs)
                    .HasForeignKey(d => d.TinhThanhId)
                    .HasConstraintName("FK_WCBCORE_KHACH_HANG_ON_TINH_THANH");

                entity.HasOne(d => d.XaPhuong)
                    .WithMany(p => p.WcbcoreKhachHangs)
                    .HasForeignKey(d => d.XaPhuongId)
                    .HasConstraintName("FK_WCBCORE_KHACH_HANG_ON_XA_PHUONG");
            });

            modelBuilder.Entity<WcbcoreKhoHang>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26E86CC55C")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_KHO_HANG");

                entity.HasIndex(e => e.Ma, "IDX_WCBCORE_KHO_HANG_UNIQ_MA")
                    .IsUnique();

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_KHO_HANG_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LaKhoMacDinh).HasColumnName("LA_KHO_MAC_DINH");

                entity.Property(e => e.Ma)
                    .HasMaxLength(50)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreLichSuThayDoiPxk>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26401DAEC9")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_LICH_SU_THAY_DOI_PXK");

                entity.HasIndex(e => e.TaiKhoanId, "IDX_WCBCORE_LICH_SU_THAY_DOI_PXK_ON_TAI_KHOAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonHangId).HasColumnName("DON_HANG_ID");

                entity.Property(e => e.TaiKhoanId).HasColumnName("TAI_KHOAN_ID");

                entity.Property(e => e.ThoiGian).HasColumnName("THOI_GIAN");

                entity.Property(e => e.TrangThaiCu).HasColumnName("TRANG_THAI_CU");

                entity.Property(e => e.TrangThaiMoi).HasColumnName("TRANG_THAI_MOI");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.WcbcoreLichSuThayDoiPxks)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_WCBCORE_LICH_SU_THAY_DOI_PXK_ON_TAI_KHOAN");
            });

            modelBuilder.Entity<WcbcoreLichSuThayDoiTrangThaiDhbl>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26C543A7AC")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_LICH_SU_THAY_DOI_TRANG_THAI_DHBL");

                entity.HasIndex(e => e.TaiKhoanId, "IDX_WCBCORE_LICH_SU_THAY_DOI_TRANG_THAI_DHBL_ON_TAI_KHOAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonHangId).HasColumnName("DON_HANG_ID");

                entity.Property(e => e.TaiKhoanId).HasColumnName("TAI_KHOAN_ID");

                entity.Property(e => e.ThoiGian).HasColumnName("THOI_GIAN");

                entity.Property(e => e.TrangThaiCu).HasColumnName("TRANG_THAI_CU");

                entity.Property(e => e.TrangThaiMoi).HasColumnName("TRANG_THAI_MOI");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.WcbcoreLichSuThayDoiTrangThaiDhbls)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_WCBCORE_LICH_SU_THAY_DOI_TRANG_THAI_DHBL_ON_TAI_KHOAN");
            });

            modelBuilder.Entity<WcbcoreLoaiBaoHanh>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26D10D6DB2")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_LOAI_BAO_HANH");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_LOAI_BAO_HANH_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreLoaiGiaoDich>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC269DC0FCC4")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_LOAI_GIAO_DICH");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_LOAI_GIAO_DICH_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreMenuInfo>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC267D003E1A")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_MENU_INFO");

                entity.HasIndex(e => e.LopTrenId, "IDX_WCBCORE_MENU_INFO_ON_LOP_TREN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LoaiMenu)
                    .HasMaxLength(50)
                    .HasColumnName("LOAI_MENU");

                entity.Property(e => e.LopTrenId).HasColumnName("LOP_TREN_ID");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.NoiDung).HasColumnName("NOI_DUNG");

                entity.Property(e => e.NoiDungNn).HasColumnName("NOI_DUNG_NN");

                entity.Property(e => e.SoLuongKhongThich).HasColumnName("SO_LUONG_KHONG_THICH");

                entity.Property(e => e.SoLuongThich).HasColumnName("SO_LUONG_THICH");

                entity.Property(e => e.SoLuongXem).HasColumnName("SO_LUONG_XEM");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.ThamSoLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("THAM_SO_LIEN_KET");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE");

                entity.Property(e => e.TieuDeNn)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE_NN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.LopTren)
                    .WithMany(p => p.InverseLopTren)
                    .HasForeignKey(d => d.LopTrenId)
                    .HasConstraintName("FK_WCBCORE_MENU_INFO_ON_LOP_TREN");
            });

            modelBuilder.Entity<WcbcoreNhaCungCap>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26F217C2D0")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_NHA_CUNG_CAP");

                entity.HasIndex(e => e.ChucVuId, "IDX_WCBCORE_NHA_CUNG_CAP_ON_CHUC_VU");

                entity.HasIndex(e => e.NhomId, "IDX_WCBCORE_NHA_CUNG_CAP_ON_NHOM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChucVuId).HasColumnName("CHUC_VU_ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("DIA_CHI");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("DIEN_THOAI");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(50)
                    .HasColumnName("GIOI_TINH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("MA_SO_THUE");

                entity.Property(e => e.NgaySinh).HasColumnName("NGAY_SINH");

                entity.Property(e => e.NguoiDaiDien)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_DAI_DIEN");

                entity.Property(e => e.NguoiLienHe)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_LIEN_HE");

                entity.Property(e => e.NhomId).HasColumnName("NHOM_ID");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_CHUC_VU");

                entity.Property(e => e.TenHienThi)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_HIEN_THI");

                entity.Property(e => e.TenNhom)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHOM");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.Property(e => e.Website)
                    .HasMaxLength(255)
                    .HasColumnName("WEBSITE");

                entity.HasOne(d => d.ChucVu)
                    .WithMany(p => p.WcbcoreNhaCungCaps)
                    .HasForeignKey(d => d.ChucVuId)
                    .HasConstraintName("FK_WCBCORE_NHA_CUNG_CAP_ON_CHUC_VU");

                entity.HasOne(d => d.Nhom)
                    .WithMany(p => p.WcbcoreNhaCungCaps)
                    .HasForeignKey(d => d.NhomId)
                    .HasConstraintName("FK_WCBCORE_NHA_CUNG_CAP_ON_NHOM");
            });

            modelBuilder.Entity<WcbcoreNhapSoDuDauKy>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC267887F46E")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_NHAP_SO_DU_DAU_KY");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_NHAP_SO_DU_DAU_KY_ON_KHO_HANG");

                entity.HasIndex(e => e.NguoiKetChuyenId, "IDX_WCBCORE_NHAP_SO_DU_DAU_KY_ON_NGUOI_KET_CHUYEN");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_NHAP_SO_DU_DAU_KY_ON_NGUOI_LAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.NgayKetChuyen).HasColumnName("NGAY_KET_CHUYEN");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiKetChuyenId).HasColumnName("NGUOI_KET_CHUYEN_ID");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcoreNhapSoDuDauKies)
                    .HasForeignKey(d => d.KhoHangId)
                    .HasConstraintName("FK_WCBCORE_NHAP_SO_DU_DAU_KY_ON_KHO_HANG");

                entity.HasOne(d => d.NguoiKetChuyen)
                    .WithMany(p => p.WcbcoreNhapSoDuDauKyNguoiKetChuyens)
                    .HasForeignKey(d => d.NguoiKetChuyenId)
                    .HasConstraintName("FK_WCBCORE_NHAP_SO_DU_DAU_KY_ON_NGUOI_KET_CHUYEN");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreNhapSoDuDauKyNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_NHAP_SO_DU_DAU_KY_ON_NGUOI_LAP");
            });

            modelBuilder.Entity<WcbcoreNhomNcc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2604C73671")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_NHOM_NCC");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_NHOM_NCC_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreNhomSanPham>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2623395534")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_NHOM_SAN_PHAM");

                entity.HasIndex(e => e.LopTrenId, "IDX_WCBCORE_NHOM_SAN_PHAM_ON_LOP_TREN");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_NHOM_SAN_PHAM_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HienThiTrenTrangChu).HasColumnName("HIEN_THI_TREN_TRANG_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LopTrenId).HasColumnName("LOP_TREN_ID");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.SeoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("SEO_URL");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.TagId)
                    .HasMaxLength(255)
                    .HasColumnName("TAG_ID");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDayDu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU");

                entity.Property(e => e.TenLopTren)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_LOP_TREN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.LopTren)
                    .WithMany(p => p.InverseLopTren)
                    .HasForeignKey(d => d.LopTrenId)
                    .HasConstraintName("FK_WCBCORE_NHOM_SAN_PHAM_ON_LOP_TREN");
            });

            modelBuilder.Entity<WcbcoreNhomTinTuc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC262F25B9BA")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_NHOM_TIN_TUC");

                entity.HasIndex(e => e.LopTrenId, "IDX_WCBCORE_NHOM_TIN_TUC_ON_LOP_TREN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DuaVaoMenuTinTuc).HasColumnName("DUA_VAO_MENU_TIN_TUC");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LopTrenId).HasColumnName("LOP_TREN_ID");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDayDu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU");

                entity.Property(e => e.TenDayDuNn)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU_NN");

                entity.Property(e => e.TenNn)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.LopTren)
                    .WithMany(p => p.InverseLopTren)
                    .HasForeignKey(d => d.LopTrenId)
                    .HasConstraintName("FK_WCBCORE_NHOM_TIN_TUC_ON_LOP_TREN");
            });

            modelBuilder.Entity<WcbcorePhieuBaoHanhCuaBbgn>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2644A7CD7E")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_PHIEU_BAO_HANH_CUA_BBGN");

                entity.HasIndex(e => e.BaoHanhId, "IDX_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_BAO_HANH")
                    .IsUnique();

                entity.HasIndex(e => e.BienBanGiaoNhanHangHoaVoiNccId, "IDX_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_DON_VI_TINH");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaoHanhId).HasColumnName("BAO_HANH_ID");

                entity.Property(e => e.BienBanGiaoNhanHangHoaVoiNccId).HasColumnName("BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.BaoHanh)
                    .WithOne(p => p.WcbcorePhieuBaoHanhCuaBbgn)
                    .HasForeignKey<WcbcorePhieuBaoHanhCuaBbgn>(d => d.BaoHanhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_BAO_HANH");

                entity.HasOne(d => d.BienBanGiaoNhanHangHoaVoiNcc)
                    .WithMany(p => p.WcbcorePhieuBaoHanhCuaBbgns)
                    .HasForeignKey(d => d.BienBanGiaoNhanHangHoaVoiNccId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcorePhieuBaoHanhCuaBbgns)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_DON_VI_TINH");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcorePhieuBaoHanhCuaBbgns)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcorePhieuBaoHanhCuaBbgns)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_BAO_HANH_CUA_BBGN_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcorePhieuXuatKho>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2620C410DC")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_PHIEU_XUAT_KHO");

                entity.HasIndex(e => e.DonHangBanLeId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_DON_HANG_BAN_LE");

                entity.HasIndex(e => e.DonViVanChuyenId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_DON_VI_VAN_CHUYEN");

                entity.HasIndex(e => e.KhachHangMuaId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_KHACH_HANG_MUA");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_KHO_HANG");

                entity.HasIndex(e => e.NguoiKetChuyenId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_KET_CHUYEN");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NguoiMuaQuanHuyenId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasIndex(e => e.NguoiMuaTaiKhoanId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_TAI_KHOAN");

                entity.HasIndex(e => e.NguoiMuaTinhThanhId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_TINH_THANH");

                entity.HasIndex(e => e.NguoiMuaXaPhuongId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasIndex(e => e.NguoiNhanQuanHuyenId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_QUAN_HUYEN");

                entity.HasIndex(e => e.NguoiNhanTinhThanhId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_TINH_THANH");

                entity.HasIndex(e => e.NguoiNhanXaPhuongId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_XA_PHUONG");

                entity.HasIndex(e => e.PhuongThucVanChuyenId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_PHUONG_THUC_VAN_CHUYEN");

                entity.HasIndex(e => e.TaiKhoanCapNhatId, "IDX_WCBCORE_PHIEU_XUAT_KHO_ON_TAI_KHOAN_CAP_NHAT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonHangBanLeId).HasColumnName("DON_HANG_BAN_LE_ID");

                entity.Property(e => e.DonViVanChuyenId).HasColumnName("DON_VI_VAN_CHUYEN_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.KhachHangMuaId).HasColumnName("KHACH_HANG_MUA_ID");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MoTaSanPham).HasColumnName("MO_TA_SAN_PHAM");

                entity.Property(e => e.NgayKetChuyen).HasColumnName("NGAY_KET_CHUYEN");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiCapNhat)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_CAP_NHAT");

                entity.Property(e => e.NguoiKetChuyenId).HasColumnName("NGUOI_KET_CHUYEN_ID");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NguoiMuaDiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIA_CHI");

                entity.Property(e => e.NguoiMuaDienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_DIEN_THOAI");

                entity.Property(e => e.NguoiMuaEmail)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_EMAIL");

                entity.Property(e => e.NguoiMuaHoTen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_HO_TEN");

                entity.Property(e => e.NguoiMuaQuanHuyenId).HasColumnName("NGUOI_MUA_QUAN_HUYEN_ID");

                entity.Property(e => e.NguoiMuaTaiKhoanId).HasColumnName("NGUOI_MUA_TAI_KHOAN_ID");

                entity.Property(e => e.NguoiMuaTenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_QUAN_HUYEN");

                entity.Property(e => e.NguoiMuaTenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_TINH_THANH");

                entity.Property(e => e.NguoiMuaTenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_MUA_TEN_XA_PHUONG");

                entity.Property(e => e.NguoiMuaTinhThanhId).HasColumnName("NGUOI_MUA_TINH_THANH_ID");

                entity.Property(e => e.NguoiMuaXaPhuongId).HasColumnName("NGUOI_MUA_XA_PHUONG_ID");

                entity.Property(e => e.NguoiNhanDiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_DIA_CHI");

                entity.Property(e => e.NguoiNhanDienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_DIEN_THOAI");

                entity.Property(e => e.NguoiNhanEmail)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_EMAIL");

                entity.Property(e => e.NguoiNhanHoTen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_HO_TEN");

                entity.Property(e => e.NguoiNhanQuanHuyenId).HasColumnName("NGUOI_NHAN_QUAN_HUYEN_ID");

                entity.Property(e => e.NguoiNhanTenQuanHuyen)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_QUAN_HUYEN");

                entity.Property(e => e.NguoiNhanTenTinhThanh)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_TINH_THANH");

                entity.Property(e => e.NguoiNhanTenXaPhuong)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_NHAN_TEN_XA_PHUONG");

                entity.Property(e => e.NguoiNhanTinhThanhId).HasColumnName("NGUOI_NHAN_TINH_THANH_ID");

                entity.Property(e => e.NguoiNhanXaPhuongId).HasColumnName("NGUOI_NHAN_XA_PHUONG_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.PhuongThucVanChuyenId).HasColumnName("PHUONG_THUC_VAN_CHUYEN_ID");

                entity.Property(e => e.SoLuongSanPham).HasColumnName("SO_LUONG_SAN_PHAM");

                entity.Property(e => e.TaiKhoanCapNhatId).HasColumnName("TAI_KHOAN_CAP_NHAT_ID");

                entity.Property(e => e.TenDonViVanChuyen)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_VAN_CHUYEN");

                entity.Property(e => e.TenKho)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_KHO");

                entity.Property(e => e.TenPhuongThucVanChuyen)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_PHUONG_THUC_VAN_CHUYEN");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThoiGianCapNhat).HasColumnName("THOI_GIAN_CAP_NHAT");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.TrangThaiThanhToan).HasColumnName("TRANG_THAI_THANH_TOAN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHangBanLe)
                    .WithMany(p => p.WcbcorePhieuXuatKhos)
                    .HasForeignKey(d => d.DonHangBanLeId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_DON_HANG_BAN_LE");

                entity.HasOne(d => d.DonViVanChuyen)
                    .WithMany(p => p.WcbcorePhieuXuatKhos)
                    .HasForeignKey(d => d.DonViVanChuyenId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_DON_VI_VAN_CHUYEN");

                entity.HasOne(d => d.KhachHangMua)
                    .WithMany(p => p.WcbcorePhieuXuatKhos)
                    .HasForeignKey(d => d.KhachHangMuaId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_KHACH_HANG_MUA");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcorePhieuXuatKhos)
                    .HasForeignKey(d => d.KhoHangId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_KHO_HANG");

                entity.HasOne(d => d.NguoiKetChuyen)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiKetChuyens)
                    .HasForeignKey(d => d.NguoiKetChuyenId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_KET_CHUYEN");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_LAP");

                entity.HasOne(d => d.NguoiMuaQuanHuyen)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiMuaQuanHuyens)
                    .HasForeignKey(d => d.NguoiMuaQuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_QUAN_HUYEN");

                entity.HasOne(d => d.NguoiMuaTaiKhoan)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiMuaTaiKhoans)
                    .HasForeignKey(d => d.NguoiMuaTaiKhoanId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_TAI_KHOAN");

                entity.HasOne(d => d.NguoiMuaTinhThanh)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiMuaTinhThanhs)
                    .HasForeignKey(d => d.NguoiMuaTinhThanhId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_TINH_THANH");

                entity.HasOne(d => d.NguoiMuaXaPhuong)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiMuaXaPhuongs)
                    .HasForeignKey(d => d.NguoiMuaXaPhuongId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_MUA_XA_PHUONG");

                entity.HasOne(d => d.NguoiNhanQuanHuyen)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiNhanQuanHuyens)
                    .HasForeignKey(d => d.NguoiNhanQuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_QUAN_HUYEN");

                entity.HasOne(d => d.NguoiNhanTinhThanh)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiNhanTinhThanhs)
                    .HasForeignKey(d => d.NguoiNhanTinhThanhId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_TINH_THANH");

                entity.HasOne(d => d.NguoiNhanXaPhuong)
                    .WithMany(p => p.WcbcorePhieuXuatKhoNguoiNhanXaPhuongs)
                    .HasForeignKey(d => d.NguoiNhanXaPhuongId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_NGUOI_NHAN_XA_PHUONG");

                entity.HasOne(d => d.PhuongThucVanChuyen)
                    .WithMany(p => p.WcbcorePhieuXuatKhos)
                    .HasForeignKey(d => d.PhuongThucVanChuyenId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_PHUONG_THUC_VAN_CHUYEN");

                entity.HasOne(d => d.TaiKhoanCapNhat)
                    .WithMany(p => p.WcbcorePhieuXuatKhoTaiKhoanCapNhats)
                    .HasForeignKey(d => d.TaiKhoanCapNhatId)
                    .HasConstraintName("FK_WCBCORE_PHIEU_XUAT_KHO_ON_TAI_KHOAN_CAP_NHAT");
            });

            modelBuilder.Entity<WcbcorePhuongThucVanChuyen>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2620D9F20A")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_PHUONG_THUC_VAN_CHUYEN");

                entity.HasIndex(e => e.Ten, "IDX_WCBCORE_PHUONG_THUC_VAN_CHUYEN_UNIQ_TEN")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreQuanHuyen>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2631654A10")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_QUAN_HUYEN");

                entity.HasIndex(e => e.TinhThanhId, "IDX_WCBCORE_QUAN_HUYEN_ON_TINH_THANH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(100)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDayDu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU");

                entity.Property(e => e.TinhThanhId).HasColumnName("TINH_THANH_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.TinhThanh)
                    .WithMany(p => p.WcbcoreQuanHuyens)
                    .HasForeignKey(d => d.TinhThanhId)
                    .HasConstraintName("FK_WCBCORE_QUAN_HUYEN_ON_TINH_THANH");
            });

            modelBuilder.Entity<WcbcoreSanPham>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26229668CC")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM");

                entity.HasIndex(e => e.DonViCoSoId, "IDX_WCBCORE_SAN_PHAM_ON_DON_VI_CO_SO");

                entity.HasIndex(e => e.DonViQuyDoi1Id, "IDX_WCBCORE_SAN_PHAM_ON_DON_VI_QUY_DOI1");

                entity.HasIndex(e => e.DonViQuyDoi2Id, "IDX_WCBCORE_SAN_PHAM_ON_DON_VI_QUY_DOI2");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_ON_DON_VI_TINH");

                entity.HasIndex(e => e.HangSanXuatId, "IDX_WCBCORE_SAN_PHAM_ON_HANG_SAN_XUAT");

                entity.HasIndex(e => e.NhaCungCapId, "IDX_WCBCORE_SAN_PHAM_ON_NHA_CUNG_CAP");

                entity.HasIndex(e => e.NhomId, "IDX_WCBCORE_SAN_PHAM_ON_NHOM");

                entity.HasIndex(e => e.NhomChinhId, "IDX_WCBCORE_SAN_PHAM_ON_NHOM_CHINH");

                entity.HasIndex(e => e.Ma, "IDX_WCBCORE_SAN_PHAM_UNIQ_MA")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AnhHangSanXuat)
                    .HasMaxLength(255)
                    .HasColumnName("ANH_HANG_SAN_XUAT");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViCoSoId).HasColumnName("DON_VI_CO_SO_ID");

                entity.Property(e => e.DonViQuyDoi1Id).HasColumnName("DON_VI_QUY_DOI1_ID");

                entity.Property(e => e.DonViQuyDoi2Id).HasColumnName("DON_VI_QUY_DOI2_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.GiaBan)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("GIA_BAN");

                entity.Property(e => e.GiaMua)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("GIA_MUA");

                entity.Property(e => e.GiaTruocKm)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("GIA_TRUOC_KM");

                entity.Property(e => e.HangSanXuatId).HasColumnName("HANG_SAN_XUAT_ID");

                entity.Property(e => e.HeSoQuyDoi1)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("HE_SO_QUY_DOI1");

                entity.Property(e => e.HeSoQuyDoi2)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("HE_SO_QUY_DOI2");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HinhAnhKhac)
                    .HasMaxLength(1024)
                    .HasColumnName("HINH_ANH_KHAC");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.MaVach)
                    .HasMaxLength(255)
                    .HasColumnName("MA_VACH");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.NhaCungCapId).HasColumnName("NHA_CUNG_CAP_ID");

                entity.Property(e => e.NhomChinhId).HasColumnName("NHOM_CHINH_ID");

                entity.Property(e => e.NhomId).HasColumnName("NHOM_ID");

                entity.Property(e => e.NoiDung).HasColumnName("NOI_DUNG");

                entity.Property(e => e.PhanLoaiTheoThuocTinh).HasColumnName("PHAN_LOAI_THEO_THUOC_TINH");

                entity.Property(e => e.SeoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("SEO_URL");

                entity.Property(e => e.SoLuongKhongThich).HasColumnName("SO_LUONG_KHONG_THICH");

                entity.Property(e => e.SoLuongThich).HasColumnName("SO_LUONG_THICH");

                entity.Property(e => e.SoLuongToiDa)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG_TOI_DA");

                entity.Property(e => e.SoLuongToiThieu)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG_TOI_THIEU");

                entity.Property(e => e.SoLuongXem).HasColumnName("SO_LUONG_XEM");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDonViCoSo)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_CO_SO");

                entity.Property(e => e.TenDonViQuyDoi1)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_QUY_DOI1");

                entity.Property(e => e.TenDonViQuyDoi2)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_QUY_DOI2");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenHangSanXuat)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_HANG_SAN_XUAT");

                entity.Property(e => e.TenHienThi)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_HIEN_THI");

                entity.Property(e => e.TenKhuyenMai)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_KHUYEN_MAI");

                entity.Property(e => e.TenNhaCungCap)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHA_CUNG_CAP");

                entity.Property(e => e.TenNhom)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHOM");

                entity.Property(e => e.TenNhomChinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHOM_CHINH");

                entity.Property(e => e.ThoiGianBaoHanh).HasColumnName("THOI_GIAN_BAO_HANH");

                entity.Property(e => e.ThueGtgtBanLe).HasColumnName("THUE_GTGT_BAN_LE");

                entity.Property(e => e.ThueMoiTruong).HasColumnName("THUE_MOI_TRUONG");

                entity.Property(e => e.ThueTtdb).HasColumnName("THUE_TTDB");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViCoSo)
                    .WithMany(p => p.WcbcoreSanPhamDonViCoSos)
                    .HasForeignKey(d => d.DonViCoSoId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_DON_VI_CO_SO");

                entity.HasOne(d => d.DonViQuyDoi1)
                    .WithMany(p => p.WcbcoreSanPhamDonViQuyDoi1s)
                    .HasForeignKey(d => d.DonViQuyDoi1Id)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_DON_VI_QUY_DOI1");

                entity.HasOne(d => d.DonViQuyDoi2)
                    .WithMany(p => p.WcbcoreSanPhamDonViQuyDoi2s)
                    .HasForeignKey(d => d.DonViQuyDoi2Id)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_DON_VI_QUY_DOI2");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamDonViTinhs)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_DON_VI_TINH");

                entity.HasOne(d => d.HangSanXuat)
                    .WithMany(p => p.WcbcoreSanPhams)
                    .HasForeignKey(d => d.HangSanXuatId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_HANG_SAN_XUAT");

                entity.HasOne(d => d.NhaCungCap)
                    .WithMany(p => p.WcbcoreSanPhams)
                    .HasForeignKey(d => d.NhaCungCapId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_NHA_CUNG_CAP");

                entity.HasOne(d => d.NhomChinh)
                    .WithMany(p => p.WcbcoreSanPhamNhomChinhs)
                    .HasForeignKey(d => d.NhomChinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_NHOM_CHINH");

                entity.HasOne(d => d.Nhom)
                    .WithMany(p => p.WcbcoreSanPhamNhoms)
                    .HasForeignKey(d => d.NhomId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_ON_NHOM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaBbgn>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2659D80568")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_BBGN");

                entity.HasIndex(e => e.BienBanGiaoNhanHangHoaVoiNccId, "IDX_WCBCORE_SAN_PHAM_CUA_BBGN_ON_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_BBGN_ON_DON_VI_TINH");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_BBGN_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_BBGN_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BienBanGiaoNhanHangHoaVoiNccId).HasColumnName("BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC_ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.BienBanGiaoNhanHangHoaVoiNcc)
                    .WithMany(p => p.WcbcoreSanPhamCuaBbgns)
                    .HasForeignKey(d => d.BienBanGiaoNhanHangHoaVoiNccId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_BBGN_ON_BIEN_BAN_GIAO_NHAN_HANG_HOA_VOI_NCC");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaBbgns)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_BBGN_ON_DON_VI_TINH");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaBbgns)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_BBGN_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaBbgns)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_BBGN_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaCckm>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26E554880C")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_CCKM");

                entity.HasIndex(e => e.ChuongTrinhKhuyenMaiId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_CHUONG_TRINH_KHUYEN_MAI");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_DON_VI_TINH");

                entity.HasIndex(e => e.DonViTinhKmId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_DON_VI_TINH_KM");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_SAN_PHAM");

                entity.HasIndex(e => e.SanPhamKmId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_SAN_PHAM_KM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_THUOC_TINH_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamKmId, "IDX_WCBCORE_SAN_PHAM_CUA_CCKM_ON_THUOC_TINH_SAN_PHAM_KM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BatDau).HasColumnName("BAT_DAU");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.ChuongTrinhKhuyenMaiId).HasColumnName("CHUONG_TRINH_KHUYEN_MAI_ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.DonViTinhKmId).HasColumnName("DON_VI_TINH_KM_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.KetThuc).HasColumnName("KET_THUC");

                entity.Property(e => e.LoaiKhuyenMai).HasColumnName("LOAI_KHUYEN_MAI");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.MaSanPhamKm)
                    .HasMaxLength(255)
                    .HasColumnName("MA_SAN_PHAM_KM");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SanPhamKmId).HasColumnName("SAN_PHAM_KM_ID");

                entity.Property(e => e.SoLuongKm)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG_KM");

                entity.Property(e => e.SoLuongToiThieu)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG_TOI_THIEU");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.TenSanPhamKm)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM_KM");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.ThuocTinhSanPhamKmId).HasColumnName("THUOC_TINH_SAN_PHAM_KM_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.ChuongTrinhKhuyenMai)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckms)
                    .HasForeignKey(d => d.ChuongTrinhKhuyenMaiId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_CHUONG_TRINH_KHUYEN_MAI");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmDonViTinhs)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_DON_VI_TINH");

                entity.HasOne(d => d.DonViTinhKm)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmDonViTinhKms)
                    .HasForeignKey(d => d.DonViTinhKmId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_DON_VI_TINH_KM");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmSanPhams)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_SAN_PHAM");

                entity.HasOne(d => d.SanPhamKm)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmSanPhamKms)
                    .HasForeignKey(d => d.SanPhamKmId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_SAN_PHAM_KM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmThuocTinhSanPhams)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_THUOC_TINH_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPhamKm)
                    .WithMany(p => p.WcbcoreSanPhamCuaCckmThuocTinhSanPhamKms)
                    .HasForeignKey(d => d.ThuocTinhSanPhamKmId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_CCKM_ON_THUOC_TINH_SAN_PHAM_KM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaDhbl>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26D676A848")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_DHBL");

                entity.HasIndex(e => e.DonHangBanLeId, "IDX_WCBCORE_SAN_PHAM_CUA_DHBL_ON_DON_HANG_BAN_LE");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_DHBL_ON_DON_VI_TINH");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_DHBL_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_DHBL_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonHangBanLeId).HasColumnName("DON_HANG_BAN_LE_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHangBanLe)
                    .WithMany(p => p.WcbcoreSanPhamCuaDhbls)
                    .HasForeignKey(d => d.DonHangBanLeId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_DHBL_ON_DON_HANG_BAN_LE");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaDhbls)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_DHBL_ON_DON_VI_TINH");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaDhbls)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_DHBL_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaDhbls)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_DHBL_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaPxk>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2672690C26")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_PXK");

                entity.HasIndex(e => e.DonHangId, "IDX_WCBCORE_SAN_PHAM_CUA_PXK_ON_DON_HANG");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_PXK_ON_DON_VI_TINH");

                entity.HasIndex(e => e.PhieuXuatKhoId, "IDX_WCBCORE_SAN_PHAM_CUA_PXK_ON_PHIEU_XUAT_KHO");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_PXK_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_PXK_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaoHanh).HasColumnName("BAO_HANH");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonHangId).HasColumnName("DON_HANG_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.DongKhuyenMai).HasColumnName("DONG_KHUYEN_MAI");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.LaHangKhuyenMai).HasColumnName("LA_HANG_KHUYEN_MAI");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.NoiDungKhuyenMai)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG_KHUYEN_MAI");

                entity.Property(e => e.PhieuXuatKhoId).HasColumnName("PHIEU_XUAT_KHO_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHang)
                    .WithMany(p => p.WcbcoreSanPhamCuaPxks)
                    .HasForeignKey(d => d.DonHangId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_PXK_ON_DON_HANG");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaPxks)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_PXK_ON_DON_VI_TINH");

                entity.HasOne(d => d.PhieuXuatKho)
                    .WithMany(p => p.WcbcoreSanPhamCuaPxks)
                    .HasForeignKey(d => d.PhieuXuatKhoId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_PXK_ON_PHIEU_XUAT_KHO");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaPxks)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_PXK_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaPxks)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_PXK_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaSoDuDauKy>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC262AE3BD9F")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_DON_VI_TINH");

                entity.HasIndex(e => e.NhapSoDuDauKyId, "IDX_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_NHAP_SO_DU_DAU_KY");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_THUOC_TINH_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.NhapSoDuDauKyId).HasColumnName("NHAP_SO_DU_DAU_KY_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaSoDuDauKies)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_DON_VI_TINH");

                entity.HasOne(d => d.NhapSoDuDauKy)
                    .WithMany(p => p.WcbcoreSanPhamCuaSoDuDauKies)
                    .HasForeignKey(d => d.NhapSoDuDauKyId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_NHAP_SO_DU_DAU_KY");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaSoDuDauKies)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaSoDuDauKies)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_SO_DU_DAU_KY_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreSanPhamCuaTiepNhanHangHoa>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26556617BD")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_DON_VI_TINH");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_THUOC_TINH_SAN_PHAM");

                entity.HasIndex(e => e.TiepNhanHangHoaId, "IDX_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_TIEP_NHAN_HANG_HOA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TiepNhanHangHoaId).HasColumnName("TIEP_NHAN_HANG_HOA_ID");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamCuaTiepNhanHangHoas)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_DON_VI_TINH");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaTiepNhanHangHoas)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamCuaTiepNhanHangHoas)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_THUOC_TINH_SAN_PHAM");

                entity.HasOne(d => d.TiepNhanHangHoa)
                    .WithMany(p => p.WcbcoreSanPhamCuaTiepNhanHangHoas)
                    .HasForeignKey(d => d.TiepNhanHangHoaId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_CUA_TIEP_NHAN_HANG_HOA_ON_TIEP_NHAN_HANG_HOA");
            });

            modelBuilder.Entity<WcbcoreSanPhamKmDhbl>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26D3CBDEE0")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_SAN_PHAM_KM_DHBL");

                entity.HasIndex(e => e.DonHangBanLeId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_DON_HANG_BAN_LE");

                entity.HasIndex(e => e.DonViTinhId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_DON_VI_TINH");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_SAN_PHAM");

                entity.HasIndex(e => e.SanPhamGocId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_SAN_PHAM_GOC");

                entity.HasIndex(e => e.ThuocTinhSanPhamId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_THUOC_TINH_SAN_PHAM");

                entity.HasIndex(e => e.ThuocTinhSanPhamGocId, "IDX_WCBCORE_SAN_PHAM_KM_DHBL_ON_THUOC_TINH_SAN_PHAM_GOC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.DonHangBanLeId).HasColumnName("DON_HANG_BAN_LE_ID");

                entity.Property(e => e.DonViTinhId).HasColumnName("DON_VI_TINH_ID");

                entity.Property(e => e.DongDuLieuId).HasColumnName("DONG_DU_LIEU_ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("MA_SAN_PHAM");

                entity.Property(e => e.SanPhamGocId).HasColumnName("SAN_PHAM_GOC_ID");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("SO_LUONG");

                entity.Property(e => e.TenDonViTinh)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DON_VI_TINH");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_SAN_PHAM");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.ThuocTinhSanPhamGocId).HasColumnName("THUOC_TINH_SAN_PHAM_GOC_ID");

                entity.Property(e => e.ThuocTinhSanPhamId).HasColumnName("THUOC_TINH_SAN_PHAM_ID");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DonHangBanLe)
                    .WithMany(p => p.WcbcoreSanPhamKmDhbls)
                    .HasForeignKey(d => d.DonHangBanLeId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_DON_HANG_BAN_LE");

                entity.HasOne(d => d.DonViTinh)
                    .WithMany(p => p.WcbcoreSanPhamKmDhbls)
                    .HasForeignKey(d => d.DonViTinhId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_DON_VI_TINH");

                entity.HasOne(d => d.SanPhamGoc)
                    .WithMany(p => p.WcbcoreSanPhamKmDhblSanPhamGocs)
                    .HasForeignKey(d => d.SanPhamGocId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_SAN_PHAM_GOC");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreSanPhamKmDhblSanPhams)
                    .HasForeignKey(d => d.SanPhamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_SAN_PHAM");

                entity.HasOne(d => d.ThuocTinhSanPhamGoc)
                    .WithMany(p => p.WcbcoreSanPhamKmDhblThuocTinhSanPhamGocs)
                    .HasForeignKey(d => d.ThuocTinhSanPhamGocId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_THUOC_TINH_SAN_PHAM_GOC");

                entity.HasOne(d => d.ThuocTinhSanPham)
                    .WithMany(p => p.WcbcoreSanPhamKmDhblThuocTinhSanPhams)
                    .HasForeignKey(d => d.ThuocTinhSanPhamId)
                    .HasConstraintName("FK_WCBCORE_SAN_PHAM_KM_DHBL_ON_THUOC_TINH_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreTepDinhKemDaPhuongTien>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26F22E18DE")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TEP_DINH_KEM_DA_PHUONG_TIEN");

                entity.HasIndex(e => e.DaPhuongTienId, "IDX_WCBCORE_TEP_DINH_KEM_DA_PHUONG_TIEN_ON_DA_PHUONG_TIEN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DaPhuongTienId).HasColumnName("DA_PHUONG_TIEN_ID");

                entity.Property(e => e.DungLuong).HasColumnName("DUNG_LUONG");

                entity.Property(e => e.DuongDan)
                    .HasMaxLength(255)
                    .HasColumnName("DUONG_DAN");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.LienKet)
                    .HasMaxLength(255)
                    .HasColumnName("LIEN_KET");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.TenTep)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_TEP");

                entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.DaPhuongTien)
                    .WithMany(p => p.WcbcoreTepDinhKemDaPhuongTiens)
                    .HasForeignKey(d => d.DaPhuongTienId)
                    .HasConstraintName("FK_WCBCORE_TEP_DINH_KEM_DA_PHUONG_TIEN_ON_DA_PHUONG_TIEN");
            });

            modelBuilder.Entity<WcbcoreTepDinhKemSanPham>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26F500DF87")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TEP_DINH_KEM_SAN_PHAM");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_TEP_DINH_KEM_SAN_PHAM_ON_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DungLuong).HasColumnName("DUNG_LUONG");

                entity.Property(e => e.DuongDan)
                    .HasMaxLength(255)
                    .HasColumnName("DUONG_DAN");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.LienKet)
                    .HasMaxLength(255)
                    .HasColumnName("LIEN_KET");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.TenTep)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_TEP");

                entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreTepDinhKemSanPhams)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_WCBCORE_TEP_DINH_KEM_SAN_PHAM_ON_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreTepDinhKemTinTuc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC269DEE4122")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TEP_DINH_KEM_TIN_TUC");

                entity.HasIndex(e => e.TinTucId, "IDX_WCBCORE_TEP_DINH_KEM_TIN_TUC_ON_TIN_TUC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DungLuong).HasColumnName("DUNG_LUONG");

                entity.Property(e => e.DuongDan)
                    .HasMaxLength(255)
                    .HasColumnName("DUONG_DAN");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(255)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.TenTep)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_TEP");

                entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

                entity.Property(e => e.TinTucId).HasColumnName("TIN_TUC_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.TinTuc)
                    .WithMany(p => p.WcbcoreTepDinhKemTinTucs)
                    .HasForeignKey(d => d.TinTucId)
                    .HasConstraintName("FK_WCBCORE_TEP_DINH_KEM_TIN_TUC_ON_TIN_TUC");
            });

            modelBuilder.Entity<WcbcoreThongBao>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC265324F895")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_THONG_BAO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LienKetNgoai).HasColumnName("LIEN_KET_NGOAI");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.NgayCapNhat).HasColumnName("NGAY_CAP_NHAT");

                entity.Property(e => e.NoiBat).HasColumnName("NOI_BAT");

                entity.Property(e => e.NoiDung).HasColumnName("NOI_DUNG");

                entity.Property(e => e.NoiDungNn).HasColumnName("NOI_DUNG_NN");

                entity.Property(e => e.SoLuongKhongThich).HasColumnName("SO_LUONG_KHONG_THICH");

                entity.Property(e => e.SoLuongThich).HasColumnName("SO_LUONG_THICH");

                entity.Property(e => e.SoLuongXem).HasColumnName("SO_LUONG_XEM");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.TacGia)
                    .HasMaxLength(255)
                    .HasColumnName("TAC_GIA");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE");

                entity.Property(e => e.TieuDeNn)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE_NN");

                entity.Property(e => e.TuKhoa)
                    .HasMaxLength(255)
                    .HasColumnName("TU_KHOA");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreThuocTinhSanPham>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2601521DB4")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_THUOC_TINH_SAN_PHAM");

                entity.HasIndex(e => e.SanPhamId, "IDX_WCBCORE_THUOC_TINH_SAN_PHAM_ON_SAN_PHAM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("DON_GIA");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.SanPhamId).HasColumnName("SAN_PHAM_ID");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.WcbcoreThuocTinhSanPhams)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_WCBCORE_THUOC_TINH_SAN_PHAM_ON_SAN_PHAM");
            });

            modelBuilder.Entity<WcbcoreTiepNhanHangHoa>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC2657D80BD3")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TIEP_NHAN_HANG_HOA");

                entity.HasIndex(e => e.KhoHangId, "IDX_WCBCORE_TIEP_NHAN_HANG_HOA_ON_KHO_HANG");

                entity.HasIndex(e => e.NguoiKetChuyenId, "IDX_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_KET_CHUYEN");

                entity.HasIndex(e => e.NguoiLapId, "IDX_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_LAP");

                entity.HasIndex(e => e.NguoiTiepNhanId, "IDX_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_TIEP_NHAN");

                entity.HasIndex(e => e.NhaCungCapId, "IDX_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NHA_CUNG_CAP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChietKhau)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("CHIET_KHAU");

                entity.Property(e => e.ChungTuGoc)
                    .HasMaxLength(255)
                    .HasColumnName("CHUNG_TU_GOC");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.KhoHangId).HasColumnName("KHO_HANG_ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.NgayKetChuyen).HasColumnName("NGAY_KET_CHUYEN");

                entity.Property(e => e.NgayLap).HasColumnName("NGAY_LAP");

                entity.Property(e => e.NguoiKetChuyenId).HasColumnName("NGUOI_KET_CHUYEN_ID");

                entity.Property(e => e.NguoiLapId).HasColumnName("NGUOI_LAP_ID");

                entity.Property(e => e.NguoiLienHe)
                    .HasMaxLength(255)
                    .HasColumnName("NGUOI_LIEN_HE");

                entity.Property(e => e.NguoiTiepNhanId).HasColumnName("NGUOI_TIEP_NHAN_ID");

                entity.Property(e => e.NhaCungCapId).HasColumnName("NHA_CUNG_CAP_ID");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(255)
                    .HasColumnName("NOI_DUNG");

                entity.Property(e => e.PhiVanChuyen)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("PHI_VAN_CHUYEN");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THANH_TIEN");

                entity.Property(e => e.ThueGtgt)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("THUE_GTGT");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("TONG_TIEN");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.KhoHang)
                    .WithMany(p => p.WcbcoreTiepNhanHangHoas)
                    .HasForeignKey(d => d.KhoHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_TIEP_NHAN_HANG_HOA_ON_KHO_HANG");

                entity.HasOne(d => d.NguoiKetChuyen)
                    .WithMany(p => p.WcbcoreTiepNhanHangHoaNguoiKetChuyens)
                    .HasForeignKey(d => d.NguoiKetChuyenId)
                    .HasConstraintName("FK_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_KET_CHUYEN");

                entity.HasOne(d => d.NguoiLap)
                    .WithMany(p => p.WcbcoreTiepNhanHangHoaNguoiLaps)
                    .HasForeignKey(d => d.NguoiLapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_LAP");

                entity.HasOne(d => d.NguoiTiepNhan)
                    .WithMany(p => p.WcbcoreTiepNhanHangHoaNguoiTiepNhans)
                    .HasForeignKey(d => d.NguoiTiepNhanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NGUOI_TIEP_NHAN");

                entity.HasOne(d => d.NhaCungCap)
                    .WithMany(p => p.WcbcoreTiepNhanHangHoas)
                    .HasForeignKey(d => d.NhaCungCapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCBCORE_TIEP_NHAN_HANG_HOA_ON_NHA_CUNG_CAP");
            });

            modelBuilder.Entity<WcbcoreTinTuc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26925A99A9")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TIN_TUC");

                entity.HasIndex(e => e.NhomId, "IDX_WCBCORE_TIN_TUC_ON_NHOM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .HasColumnName("HINH_ANH");

                entity.Property(e => e.HoatDong).HasColumnName("HOAT_DONG");

                entity.Property(e => e.LienKetNgoai).HasColumnName("LIEN_KET_NGOAI");

                entity.Property(e => e.MoTa)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA");

                entity.Property(e => e.MoTaNn)
                    .HasMaxLength(1024)
                    .HasColumnName("MO_TA_NN");

                entity.Property(e => e.NgayCapNhat).HasColumnName("NGAY_CAP_NHAT");

                entity.Property(e => e.NhomId).HasColumnName("NHOM_ID");

                entity.Property(e => e.NoiBat).HasColumnName("NOI_BAT");

                entity.Property(e => e.NoiDung).HasColumnName("NOI_DUNG");

                entity.Property(e => e.NoiDungNn).HasColumnName("NOI_DUNG_NN");

                entity.Property(e => e.SoLuongKhongThich).HasColumnName("SO_LUONG_KHONG_THICH");

                entity.Property(e => e.SoLuongThich).HasColumnName("SO_LUONG_THICH");

                entity.Property(e => e.SoLuongXem).HasColumnName("SO_LUONG_XEM");

                entity.Property(e => e.SoThuTu).HasColumnName("SO_THU_TU");

                entity.Property(e => e.TacGia)
                    .HasMaxLength(255)
                    .HasColumnName("TAC_GIA");

                entity.Property(e => e.TenNhom)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHOM");

                entity.Property(e => e.TenNhomNn)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_NHOM_NN");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE");

                entity.Property(e => e.TieuDeNn)
                    .HasMaxLength(255)
                    .HasColumnName("TIEU_DE_NN");

                entity.Property(e => e.TuKhoa)
                    .HasMaxLength(255)
                    .HasColumnName("TU_KHOA");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.Nhom)
                    .WithMany(p => p.WcbcoreTinTucs)
                    .HasForeignKey(d => d.NhomId)
                    .HasConstraintName("FK_WCBCORE_TIN_TUC_ON_NHOM");
            });

            modelBuilder.Entity<WcbcoreTinhThanh>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC267A562BE7")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_TINH_THANH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(100)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDayDu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            modelBuilder.Entity<WcbcoreXaPhuong>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC26D9BAB257")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_XA_PHUONG");

                entity.HasIndex(e => e.QuanHuyenId, "IDX_WCBCORE_XA_PHUONG_ON_QUAN_HUYEN");

                entity.HasIndex(e => e.TinhThanhId, "IDX_WCBCORE_XA_PHUONG_ON_TINH_THANH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("GHI_CHU");

                entity.Property(e => e.Ma)
                    .HasMaxLength(255)
                    .HasColumnName("MA");

                entity.Property(e => e.MaLienKet)
                    .HasMaxLength(255)
                    .HasColumnName("MA_LIEN_KET");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(100)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.QuanHuyenId).HasColumnName("QUAN_HUYEN_ID");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");

                entity.Property(e => e.TenDayDu)
                    .HasMaxLength(255)
                    .HasColumnName("TEN_DAY_DU");

                entity.Property(e => e.TinhThanhId).HasColumnName("TINH_THANH_ID");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");

                entity.HasOne(d => d.QuanHuyen)
                    .WithMany(p => p.WcbcoreXaPhuongs)
                    .HasForeignKey(d => d.QuanHuyenId)
                    .HasConstraintName("FK_WCBCORE_XA_PHUONG_ON_QUAN_HUYEN");

                entity.HasOne(d => d.TinhThanh)
                    .WithMany(p => p.WcbcoreXaPhuongs)
                    .HasForeignKey(d => d.TinhThanhId)
                    .HasConstraintName("FK_WCBCORE_XA_PHUONG_ON_TINH_THANH");
            });

            modelBuilder.Entity<WcbcoreXacThucThongTinTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__WCBCORE___3214EC268082A31A")
                    .IsClustered(false);

                entity.ToTable("WCBCORE_XAC_THUC_THONG_TIN_TAI_KHOAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateTs).HasColumnName("CREATE_TS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.DeleteTs).HasColumnName("DELETE_TS");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("DELETED_BY");

                entity.Property(e => e.DuLieu)
                    .HasMaxLength(255)
                    .HasColumnName("DU_LIEU");

                entity.Property(e => e.Loai).HasColumnName("LOAI");

                entity.Property(e => e.MaXacThuc)
                    .HasMaxLength(50)
                    .HasColumnName("MA_XAC_THUC");

                entity.Property(e => e.SoLanXacThuc).HasColumnName("SO_LAN_XAC_THUC");

                entity.Property(e => e.TaiKhoanId)
                    .HasMaxLength(50)
                    .HasColumnName("TAI_KHOAN_ID");

                entity.Property(e => e.ThoiGianHetHan).HasColumnName("THOI_GIAN_HET_HAN");

                entity.Property(e => e.ThoiGianTao).HasColumnName("THOI_GIAN_TAO");

                entity.Property(e => e.ThoiGianXacThuc).HasColumnName("THOI_GIAN_XAC_THUC");

                entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

                entity.Property(e => e.UpdateTs).HasColumnName("UPDATE_TS");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Version).HasColumnName("VERSION");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
