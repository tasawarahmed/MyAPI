using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyAPI.Models
{
    public partial class baitulnoorContext : DbContext
    {
        public baitulnoorContext()
        {
        }

        public baitulnoorContext(DbContextOptions<baitulnoorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccAssociation> TblAccAssociations { get; set; } = null!;
        public virtual DbSet<TblAccTransaction> TblAccTransactions { get; set; } = null!;
        public virtual DbSet<TblAccTransactionsOld> TblAccTransactionsOlds { get; set; } = null!;
        public virtual DbSet<TblAccTransactionsTemp> TblAccTransactionsTemps { get; set; } = null!;
        public virtual DbSet<TblAccType> TblAccTypes { get; set; } = null!;
        public virtual DbSet<TblAccount> TblAccounts { get; set; } = null!;
        public virtual DbSet<TblAccountFeeVoucher> TblAccountFeeVouchers { get; set; } = null!;
        public virtual DbSet<TblAccountFeeVouchersNew> TblAccountFeeVouchersNews { get; set; } = null!;
        public virtual DbSet<TblAccountTmpFeeVoucher> TblAccountTmpFeeVouchers { get; set; } = null!;
        public virtual DbSet<TblActivationInfo> TblActivationInfos { get; set; } = null!;
        public virtual DbSet<TblAnswerSheet> TblAnswerSheets { get; set; } = null!;
        public virtual DbSet<TblBmpabc> TblBmpabcs { get; set; } = null!;
        public virtual DbSet<TblBmpaction> TblBmpactions { get; set; } = null!;
        public virtual DbSet<TblClassTeacher> TblClassTeachers { get; set; } = null!;
        public virtual DbSet<TblClassesAndSection> TblClassesAndSections { get; set; } = null!;
        public virtual DbSet<TblClassesPromotionScheme> TblClassesPromotionSchemes { get; set; } = null!;
        public virtual DbSet<TblExamGrade> TblExamGrades { get; set; } = null!;
        public virtual DbSet<TblExamStandardMark> TblExamStandardMarks { get; set; } = null!;
        public virtual DbSet<TblExamSubjectsAssociationWithTeacher> TblExamSubjectsAssociationWithTeachers { get; set; } = null!;
        public virtual DbSet<TblFeeInstallment> TblFeeInstallments { get; set; } = null!;
        public virtual DbSet<TblGenAcademicCalendar> TblGenAcademicCalendars { get; set; } = null!;
        public virtual DbSet<TblGenAdvType> TblGenAdvTypes { get; set; } = null!;
        public virtual DbSet<TblGenAnnouncement> TblGenAnnouncements { get; set; } = null!;
        public virtual DbSet<TblGenAttributesAndValue> TblGenAttributesAndValues { get; set; } = null!;
        public virtual DbSet<TblGenBehIssue> TblGenBehIssues { get; set; } = null!;
        public virtual DbSet<TblGenBool> TblGenBools { get; set; } = null!;
        public virtual DbSet<TblGenCast> TblGenCasts { get; set; } = null!;
        public virtual DbSet<TblGenClass> TblGenClasses { get; set; } = null!;
        public virtual DbSet<TblGenEntity> TblGenEntities { get; set; } = null!;
        public virtual DbSet<TblGenEvent> TblGenEvents { get; set; } = null!;
        public virtual DbSet<TblGenFeeType> TblGenFeeTypes { get; set; } = null!;
        public virtual DbSet<TblGenFund> TblGenFunds { get; set; } = null!;
        public virtual DbSet<TblGenMarginalRelief> TblGenMarginalReliefs { get; set; } = null!;
        public virtual DbSet<TblGenMonth> TblGenMonths { get; set; } = null!;
        public virtual DbSet<TblGenNotice> TblGenNotices { get; set; } = null!;
        public virtual DbSet<TblGenOccupation> TblGenOccupations { get; set; } = null!;
        public virtual DbSet<TblGenParticular> TblGenParticulars { get; set; } = null!;
        public virtual DbSet<TblGenParty> TblGenParties { get; set; } = null!;
        public virtual DbSet<TblGenPrize> TblGenPrizes { get; set; } = null!;
        public virtual DbSet<TblGenReasonsOfLeave> TblGenReasonsOfLeaves { get; set; } = null!;
        public virtual DbSet<TblGenReligion> TblGenReligions { get; set; } = null!;
        public virtual DbSet<TblGenSession> TblGenSessions { get; set; } = null!;
        public virtual DbSet<TblGenSubEvent> TblGenSubEvents { get; set; } = null!;
        public virtual DbSet<TblGenSyllabusWarning> TblGenSyllabusWarnings { get; set; } = null!;
        public virtual DbSet<TblGenTaxSlab> TblGenTaxSlabs { get; set; } = null!;
        public virtual DbSet<TblGenTerm> TblGenTerms { get; set; } = null!;
        public virtual DbSet<TblGenTown> TblGenTowns { get; set; } = null!;
        public virtual DbSet<TblGenWing> TblGenWings { get; set; } = null!;
        public virtual DbSet<TblGenYear> TblGenYears { get; set; } = null!;
        public virtual DbSet<TblHifzEnrollemnt> TblHifzEnrollemnts { get; set; } = null!;
        public virtual DbSet<TblHifzStuStatus> TblHifzStuStatuses { get; set; } = null!;
        public virtual DbSet<TblHifzSyllabus> TblHifzSyllabi { get; set; } = null!;
        public virtual DbSet<TblHifzSyllabusProgress> TblHifzSyllabusProgresses { get; set; } = null!;
        public virtual DbSet<TblInventoryCategory> TblInventoryCategories { get; set; } = null!;
        public virtual DbSet<TblInventoryItem> TblInventoryItems { get; set; } = null!;
        public virtual DbSet<TblInventoryItemValue> TblInventoryItemValues { get; set; } = null!;
        public virtual DbSet<TblInventoryLocation> TblInventoryLocations { get; set; } = null!;
        public virtual DbSet<TblInventoryTransaction> TblInventoryTransactions { get; set; } = null!;
        public virtual DbSet<TblMngtDocument> TblMngtDocuments { get; set; } = null!;
        public virtual DbSet<TblMngtMeeting> TblMngtMeetings { get; set; } = null!;
        public virtual DbSet<TblMngtNotice> TblMngtNotices { get; set; } = null!;
        public virtual DbSet<TblMngtPolicy> TblMngtPolicies { get; set; } = null!;
        public virtual DbSet<TblMngtSop> TblMngtSops { get; set; } = null!;
        public virtual DbSet<TblMngtStaffDevelopment> TblMngtStaffDevelopments { get; set; } = null!;
        public virtual DbSet<TblMngtWorkshop> TblMngtWorkshops { get; set; } = null!;
        public virtual DbSet<TblQuestionPaper> TblQuestionPapers { get; set; } = null!;
        public virtual DbSet<TblQuestionsBank> TblQuestionsBanks { get; set; } = null!;
        public virtual DbSet<TblQuestionsCategory> TblQuestionsCategories { get; set; } = null!;
        public virtual DbSet<TblQuestionsCategoryAssociation> TblQuestionsCategoryAssociations { get; set; } = null!;
        public virtual DbSet<TblRptAcademicCalendar> TblRptAcademicCalendars { get; set; } = null!;
        public virtual DbSet<TblRptAcademyAggregate> TblRptAcademyAggregates { get; set; } = null!;
        public virtual DbSet<TblRptAcademyFiveHbfb> TblRptAcademyFiveHbfbs { get; set; } = null!;
        public virtual DbSet<TblRptAcademyResult> TblRptAcademyResults { get; set; } = null!;
        public virtual DbSet<TblRptAcademyThreePlusThree> TblRptAcademyThreePlusThrees { get; set; } = null!;
        public virtual DbSet<TblRptAccountStatement> TblRptAccountStatements { get; set; } = null!;
        public virtual DbSet<TblRptAggregateResult> TblRptAggregateResults { get; set; } = null!;
        public virtual DbSet<TblRptApproxCompletionDate> TblRptApproxCompletionDates { get; set; } = null!;
        public virtual DbSet<TblRptAttendanceRegister> TblRptAttendanceRegisters { get; set; } = null!;
        public virtual DbSet<TblRptCombinedResult> TblRptCombinedResults { get; set; } = null!;
        public virtual DbSet<TblRptDatesheet> TblRptDatesheets { get; set; } = null!;
        public virtual DbSet<TblRptMarksList> TblRptMarksLists { get; set; } = null!;
        public virtual DbSet<TblRptStudentPaymentHistory> TblRptStudentPaymentHistories { get; set; } = null!;
        public virtual DbSet<TblRptStudentProgressRemark> TblRptStudentProgressRemarks { get; set; } = null!;
        public virtual DbSet<TblRptSyllabusProgress> TblRptSyllabusProgresses { get; set; } = null!;
        public virtual DbSet<TblRptTestSeries> TblRptTestSeries { get; set; } = null!;
        public virtual DbSet<TblRptTrialBalance> TblRptTrialBalances { get; set; } = null!;
        public virtual DbSet<TblService> TblServices { get; set; } = null!;
        public virtual DbSet<TblStaffAdvType> TblStaffAdvTypes { get; set; } = null!;
        public virtual DbSet<TblStaffAdvance> TblStaffAdvances { get; set; } = null!;
        public virtual DbSet<TblStaffOtherDeduction> TblStaffOtherDeductions { get; set; } = null!;
        public virtual DbSet<TblStuAggResult> TblStuAggResults { get; set; } = null!;
        public virtual DbSet<TblStuAggResultApplicability> TblStuAggResultApplicabilities { get; set; } = null!;
        public virtual DbSet<TblStuAggResultWeight> TblStuAggResultWeights { get; set; } = null!;
        public virtual DbSet<TblStuAggResultsMark> TblStuAggResultsMarks { get; set; } = null!;
        public virtual DbSet<TblStuAttendance> TblStuAttendances { get; set; } = null!;
        public virtual DbSet<TblStuBehavior> TblStuBehaviors { get; set; } = null!;
        public virtual DbSet<TblStuClasswiseFeeDetail> TblStuClasswiseFeeDetails { get; set; } = null!;
        public virtual DbSet<TblStuDailyDiary> TblStuDailyDiaries { get; set; } = null!;
        public virtual DbSet<TblStuDiscType> TblStuDiscTypes { get; set; } = null!;
        public virtual DbSet<TblStuEventStanding> TblStuEventStandings { get; set; } = null!;
        public virtual DbSet<TblStuExam> TblStuExams { get; set; } = null!;
        public virtual DbSet<TblStuExamAssociationWithSubject> TblStuExamAssociationWithSubjects { get; set; } = null!;
        public virtual DbSet<TblStuExamResult> TblStuExamResults { get; set; } = null!;
        public virtual DbSet<TblStuExamResultsOld> TblStuExamResultsOlds { get; set; } = null!;
        public virtual DbSet<TblStuExamType> TblStuExamTypes { get; set; } = null!;
        public virtual DbSet<TblStuFeeAdvance> TblStuFeeAdvances { get; set; } = null!;
        public virtual DbSet<TblStuFeeDueAndReceived> TblStuFeeDueAndReceiveds { get; set; } = null!;
        public virtual DbSet<TblStuInquiry> TblStuInquiries { get; set; } = null!;
        public virtual DbSet<TblStuMain> TblStuMains { get; set; } = null!;
        public virtual DbSet<TblStuReasonsOfWithDrawal> TblStuReasonsOfWithDrawals { get; set; } = null!;
        public virtual DbSet<TblStuStatus> TblStuStatuses { get; set; } = null!;
        public virtual DbSet<TblStuSubject> TblStuSubjects { get; set; } = null!;
        public virtual DbSet<TblStuSubjectAssociationWithClass> TblStuSubjectAssociationWithClasses { get; set; } = null!;
        public virtual DbSet<TblStuSyllabusBook> TblStuSyllabusBooks { get; set; } = null!;
        public virtual DbSet<TblStuUnpaidFeeStatus> TblStuUnpaidFeeStatuses { get; set; } = null!;
        public virtual DbSet<TblStudentPortfolio> TblStudentPortfolios { get; set; } = null!;
        public virtual DbSet<TblStudentWithService> TblStudentWithServices { get; set; } = null!;
        public virtual DbSet<TblSubjectStandardMark> TblSubjectStandardMarks { get; set; } = null!;
        public virtual DbSet<TblSyllabus> TblSyllabi { get; set; } = null!;
        public virtual DbSet<TblSyllabusBreakup> TblSyllabusBreakups { get; set; } = null!;
        public virtual DbSet<TblSyllabusProgress> TblSyllabusProgresses { get; set; } = null!;
        public virtual DbSet<TblSyllabusSection> TblSyllabusSections { get; set; } = null!;
        public virtual DbSet<TblTeacherAllowance> TblTeacherAllowances { get; set; } = null!;
        public virtual DbSet<TblTeacherAssociationWithSubject> TblTeacherAssociationWithSubjects { get; set; } = null!;
        public virtual DbSet<TblTeacherAttendance> TblTeacherAttendances { get; set; } = null!;
        public virtual DbSet<TblTeacherBehavior> TblTeacherBehaviors { get; set; } = null!;
        public virtual DbSet<TblTeacherDeductionType> TblTeacherDeductionTypes { get; set; } = null!;
        public virtual DbSet<TblTeacherDuty> TblTeacherDuties { get; set; } = null!;
        public virtual DbSet<TblTeacherEmploymentRecord> TblTeacherEmploymentRecords { get; set; } = null!;
        public virtual DbSet<TblTeacherLeavesSanctioned> TblTeacherLeavesSanctioneds { get; set; } = null!;
        public virtual DbSet<TblTeacherLeavesSanctionedOld> TblTeacherLeavesSanctionedOlds { get; set; } = null!;
        public virtual DbSet<TblTeacherMain> TblTeacherMains { get; set; } = null!;
        public virtual DbSet<TblTeacherSalDeduction> TblTeacherSalDeductions { get; set; } = null!;
        public virtual DbSet<TblTeacherSalarySheet> TblTeacherSalarySheets { get; set; } = null!;
        public virtual DbSet<TblTeacherSyllabusWarning> TblTeacherSyllabusWarnings { get; set; } = null!;
        public virtual DbSet<TblTmpDate> TblTmpDates { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<ViewAcademyResult> ViewAcademyResults { get; set; } = null!;
        public virtual DbSet<ViewAcademyResultForSm> ViewAcademyResultForSms { get; set; } = null!;
        public virtual DbSet<ViewAccountStatement> ViewAccountStatements { get; set; } = null!;
        public virtual DbSet<ViewAccountStatement1> ViewAccountStatements1 { get; set; } = null!;
        public virtual DbSet<ViewActiveStudentsContact> ViewActiveStudentsContacts { get; set; } = null!;
        public virtual DbSet<ViewActiveTeacher> ViewActiveTeachers { get; set; } = null!;
        public virtual DbSet<ViewActiveTeachersInfo> ViewActiveTeachersInfos { get; set; } = null!;
        public virtual DbSet<ViewActualCashReceiving> ViewActualCashReceivings { get; set; } = null!;
        public virtual DbSet<ViewActualPayableFee> ViewActualPayableFees { get; set; } = null!;
        public virtual DbSet<ViewAdmissionChargesCollected> ViewAdmissionChargesCollecteds { get; set; } = null!;
        public virtual DbSet<ViewAdmissionSlip> ViewAdmissionSlips { get; set; } = null!;
        public virtual DbSet<ViewAdvanceFeeCollected> ViewAdvanceFeeCollecteds { get; set; } = null!;
        public virtual DbSet<ViewAggregateResult> ViewAggregateResults { get; set; } = null!;
        public virtual DbSet<ViewAnnualChargesCollected> ViewAnnualChargesCollecteds { get; set; } = null!;
        public virtual DbSet<ViewAnswerSheet> ViewAnswerSheets { get; set; } = null!;
        public virtual DbSet<ViewAppointmentLetter> ViewAppointmentLetters { get; set; } = null!;
        public virtual DbSet<ViewBankStatement> ViewBankStatements { get; set; } = null!;
        public virtual DbSet<ViewBehavioralIssue> ViewBehavioralIssues { get; set; } = null!;
        public virtual DbSet<ViewCashReport> ViewCashReports { get; set; } = null!;
        public virtual DbSet<ViewClassTeacher> ViewClassTeachers { get; set; } = null!;
        public virtual DbSet<ViewClasswiseFeeStructure> ViewClasswiseFeeStructures { get; set; } = null!;
        public virtual DbSet<ViewCombinedResult> ViewCombinedResults { get; set; } = null!;
        public virtual DbSet<ViewDefaulter> ViewDefaulters { get; set; } = null!;
        public virtual DbSet<ViewExamResult> ViewExamResults { get; set; } = null!;
        public virtual DbSet<ViewExamSubject> ViewExamSubjects { get; set; } = null!;
        public virtual DbSet<ViewFeeReceivable> ViewFeeReceivables { get; set; } = null!;
        public virtual DbSet<ViewFeeReceivableInactiveStudent> ViewFeeReceivableInactiveStudents { get; set; } = null!;
        public virtual DbSet<ViewFeeVoucher> ViewFeeVouchers { get; set; } = null!;
        public virtual DbSet<ViewFeeVouchersNew> ViewFeeVouchersNews { get; set; } = null!;
        public virtual DbSet<ViewGeographicalDistOfStudent> ViewGeographicalDistOfStudents { get; set; } = null!;
        public virtual DbSet<ViewInquiry> ViewInquiries { get; set; } = null!;
        public virtual DbSet<ViewMarksList> ViewMarksLists { get; set; } = null!;
        public virtual DbSet<ViewOldStaff> ViewOldStaffs { get; set; } = null!;
        public virtual DbSet<ViewPotentialTeacher> ViewPotentialTeachers { get; set; } = null!;
        public virtual DbSet<ViewQuestionCategoryAssociation> ViewQuestionCategoryAssociations { get; set; } = null!;
        public virtual DbSet<ViewQuestionsSummary> ViewQuestionsSummaries { get; set; } = null!;
        public virtual DbSet<ViewResultTestSeries> ViewResultTestSeries { get; set; } = null!;
        public virtual DbSet<ViewSalarySheet> ViewSalarySheets { get; set; } = null!;
        public virtual DbSet<ViewSalarySheetRdlc> ViewSalarySheetRdlcs { get; set; } = null!;
        public virtual DbSet<ViewSchoolLeavingCertificate> ViewSchoolLeavingCertificates { get; set; } = null!;
        public virtual DbSet<ViewStaffContactList> ViewStaffContactLists { get; set; } = null!;
        public virtual DbSet<ViewStandardMark> ViewStandardMarks { get; set; } = null!;
        public virtual DbSet<ViewStudent> ViewStudents { get; set; } = null!;
        public virtual DbSet<ViewStudentExamResult> ViewStudentExamResults { get; set; } = null!;
        public virtual DbSet<ViewStudentPaymentHistory> ViewStudentPaymentHistories { get; set; } = null!;
        public virtual DbSet<ViewStudentPaymentRecord> ViewStudentPaymentRecords { get; set; } = null!;
        public virtual DbSet<ViewStudentStrengthClassWiseWingWise> ViewStudentStrengthClassWiseWingWises { get; set; } = null!;
        public virtual DbSet<ViewStudentsAttendance> ViewStudentsAttendances { get; set; } = null!;
        public virtual DbSet<ViewStudentsBehavior> ViewStudentsBehaviors { get; set; } = null!;
        public virtual DbSet<ViewStudentsCampaignEffect> ViewStudentsCampaignEffects { get; set; } = null!;
        public virtual DbSet<ViewStudentsFatherOccupation> ViewStudentsFatherOccupations { get; set; } = null!;
        public virtual DbSet<ViewSubjectsAndClass> ViewSubjectsAndClasses { get; set; } = null!;
        public virtual DbSet<ViewSyllabus> ViewSyllabi { get; set; } = null!;
        public virtual DbSet<ViewSyllabusCompletionDate> ViewSyllabusCompletionDates { get; set; } = null!;
        public virtual DbSet<ViewSyllabusProgress> ViewSyllabusProgresses { get; set; } = null!;
        public virtual DbSet<ViewTeacherAttendance> ViewTeacherAttendances { get; set; } = null!;
        public virtual DbSet<ViewTeacherBehaviorDescription> ViewTeacherBehaviorDescriptions { get; set; } = null!;
        public virtual DbSet<ViewTeacherDailyDiary> ViewTeacherDailyDiaries { get; set; } = null!;
        public virtual DbSet<ViewTotalActiveStudent> ViewTotalActiveStudents { get; set; } = null!;
        public virtual DbSet<ViewTotalAdmission> ViewTotalAdmissions { get; set; } = null!;
        public virtual DbSet<ViewTotalExpense> ViewTotalExpenses { get; set; } = null!;
        public virtual DbSet<ViewTotalFeeCollectedOfAllType> ViewTotalFeeCollectedOfAllTypes { get; set; } = null!;
        public virtual DbSet<ViewTotalFeeReceivableStudentWise> ViewTotalFeeReceivableStudentWises { get; set; } = null!;
        public virtual DbSet<ViewTotalIncome> ViewTotalIncomes { get; set; } = null!;
        public virtual DbSet<ViewTotalWithdrawal> ViewTotalWithdrawals { get; set; } = null!;
        public virtual DbSet<ViewTrialBalance> ViewTrialBalances { get; set; } = null!;
        public virtual DbSet<ViewTuitionFeeCollected> ViewTuitionFeeCollecteds { get; set; } = null!;
        public virtual DbSet<ViewWithdrawnStudentsContact> ViewWithdrawnStudentsContacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("workstation id=baitulnoor.mssql.somee.com;packet size=4096;user id=baitulnoor_SQLLogin_1;pwd=4zfvg7xwa8;data source=baitulnoor.mssql.somee.com;persist security info=False;initial catalog=baitulnoor;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAccAssociation>(entity =>
            {
                entity.HasKey(e => e.AccountAssociationId);

                entity.ToTable("tblAccAssociations");

                entity.Property(e => e.AccountAssociationId).HasColumnName("accountAssociationID");

                entity.Property(e => e.AccountAssociationName)
                    .IsUnicode(false)
                    .HasColumnName("accountAssociationName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblAccTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("tblAccTransactions");

                entity.Property(e => e.TransactionId).HasColumnName("transactionID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("creditAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("debitAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TransactionDesc)
                    .IsUnicode(false)
                    .HasColumnName("transactionDesc");
            });

            modelBuilder.Entity<TblAccTransactionsOld>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("tblAccTransactions_Old");

                entity.Property(e => e.TransactionId).HasColumnName("transactionID");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("creditAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("debitAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TransactionDesc)
                    .IsUnicode(false)
                    .HasColumnName("transactionDesc");
            });

            modelBuilder.Entity<TblAccTransactionsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccTransactionsTemp");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.ControlField).HasColumnName("controlField");

                entity.Property(e => e.CreditAmount).HasColumnName("creditAmount");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DebitAmount).HasColumnName("debitAmount");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TransactionDesc)
                    .IsUnicode(false)
                    .HasColumnName("transactionDesc");
            });

            modelBuilder.Entity<TblAccType>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId);

                entity.ToTable("tblAccTypes");

                entity.Property(e => e.AccountTypeId).HasColumnName("accountTypeID");

                entity.Property(e => e.AccountTypeName)
                    .IsUnicode(false)
                    .HasColumnName("accountTypeName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("tblAccounts");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.AccountAssociationId).HasColumnName("accountAssociationID");

                entity.Property(e => e.AccountName)
                    .IsUnicode(false)
                    .HasColumnName("accountName");

                entity.Property(e => e.AccountTypeId).HasColumnName("accountTypeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblAccountFeeVoucher>(entity =>
            {
                entity.HasKey(e => e.FeeVoucherId);

                entity.ToTable("tblAccountFeeVouchers");

                entity.Property(e => e.FeeVoucherId).HasColumnName("feeVoucherID");

                entity.Property(e => e.AnnualChargesDue).HasColumnName("annualChargesDue");

                entity.Property(e => e.ArrearsOfFee).HasColumnName("arrearsOfFee");

                entity.Property(e => e.CurrentFeeDue).HasColumnName("currentFeeDue");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("feeMonth");

                entity.Property(e => e.FeeNotice)
                    .IsUnicode(false)
                    .HasColumnName("feeNotice");

                entity.Property(e => e.FeeUnpaidMonths)
                    .IsUnicode(false)
                    .HasColumnName("feeUnpaidMonths");

                entity.Property(e => e.FeeYear)
                    .IsUnicode(false)
                    .HasColumnName("feeYear");

                entity.Property(e => e.OtherNotices)
                    .IsUnicode(false)
                    .HasColumnName("otherNotices");

                entity.Property(e => e.StudentClass)
                    .IsUnicode(false)
                    .HasColumnName("studentClass");

                entity.Property(e => e.StudentId)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.Property(e => e.StudentName)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.TotalFeeDue)
                    .HasColumnName("totalFeeDue")
                    .HasComputedColumnSql("(([currentFeeDue]+[annualChargesDue])+[arrearsOfFee])", true);
            });

            modelBuilder.Entity<TblAccountFeeVouchersNew>(entity =>
            {
                entity.HasKey(e => e.FeeVoucherId);

                entity.ToTable("tblAccountFeeVouchersNew");

                entity.Property(e => e.FeeVoucherId).HasColumnName("feeVoucherID");

                entity.Property(e => e.AcchargesDue).HasColumnName("ACChargesDue");

                entity.Property(e => e.AnnualChargesDue).HasColumnName("annualChargesDue");

                entity.Property(e => e.ArrearsOfFee).HasColumnName("arrearsOfFee");

                entity.Property(e => e.CurrentFeeDue).HasColumnName("currentFeeDue");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("feeMonth");

                entity.Property(e => e.FeeNotice)
                    .IsUnicode(false)
                    .HasColumnName("feeNotice");

                entity.Property(e => e.FeeUnpaidMonths)
                    .IsUnicode(false)
                    .HasColumnName("feeUnpaidMonths");

                entity.Property(e => e.FeeYear)
                    .IsUnicode(false)
                    .HasColumnName("feeYear");

                entity.Property(e => e.OtherNotices)
                    .IsUnicode(false)
                    .HasColumnName("otherNotices");

                entity.Property(e => e.StudentClass)
                    .IsUnicode(false)
                    .HasColumnName("studentClass");

                entity.Property(e => e.StudentId)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.Property(e => e.StudentName)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.TotalFeeDue)
                    .HasColumnName("totalFeeDue")
                    .HasComputedColumnSql("(((([currentFeeDue]+[annualChargesDue])+[TestSessionFeeDue])+[ACChargesDue])+[arrearsOfFee])", true);
            });

            modelBuilder.Entity<TblAccountTmpFeeVoucher>(entity =>
            {
                entity.HasKey(e => e.FeeVoucherId);

                entity.ToTable("tblAccountTmpFeeVouchers");

                entity.Property(e => e.FeeVoucherId).HasColumnName("feeVoucherID");

                entity.Property(e => e.AnnualChargesDue).HasColumnName("annualChargesDue");

                entity.Property(e => e.ArrearsOfFee).HasColumnName("arrearsOfFee");

                entity.Property(e => e.CurrentFeeDue).HasColumnName("currentFeeDue");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("feeMonth");

                entity.Property(e => e.FeeNotice)
                    .IsUnicode(false)
                    .HasColumnName("feeNotice");

                entity.Property(e => e.FeeUnpaidMonths)
                    .IsUnicode(false)
                    .HasColumnName("feeUnpaidMonths");

                entity.Property(e => e.FeeYear)
                    .IsUnicode(false)
                    .HasColumnName("feeYear");

                entity.Property(e => e.OtherNotices)
                    .IsUnicode(false)
                    .HasColumnName("otherNotices");

                entity.Property(e => e.StudentClass)
                    .IsUnicode(false)
                    .HasColumnName("studentClass");

                entity.Property(e => e.StudentId)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.Property(e => e.StudentName)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.TotalFeeDue)
                    .HasColumnName("totalFeeDue")
                    .HasComputedColumnSql("(([currentFeeDue]+[annualChargesDue])+[arrearsOfFee])", true);
            });

            modelBuilder.Entity<TblActivationInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblActivationInfo");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Modules).HasColumnName("modules");

                entity.Property(e => e.SchoolAddress).HasColumnName("schoolAddress");

                entity.Property(e => e.SchoolName).HasColumnName("schoolName");
            });

            modelBuilder.Entity<TblAnswerSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAnswerSheets");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.DateIssued)
                    .HasColumnType("date")
                    .HasColumnName("dateIssued");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("date")
                    .HasColumnName("dateReceived");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ReceivedBack).HasColumnName("receivedBack");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.WingId).HasColumnName("wingID");
            });

            modelBuilder.Entity<TblBmpabc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBMPABC");

                entity.Property(e => e.Antecedent).HasColumnName("antecedent");

                entity.Property(e => e.Behavior).HasColumnName("behavior");

                entity.Property(e => e.Consequence).HasColumnName("consequence");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblBmpaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBMPAction");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblClassTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblClassTeachers");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblClassesAndSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblClassesAndSections");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.SectionAlias)
                    .IsUnicode(false)
                    .HasColumnName("sectionAlias");
            });

            modelBuilder.Entity<TblClassesPromotionScheme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblClassesPromotionScheme");

                entity.Property(e => e.ExistingClassId).HasColumnName("existingClassID");

                entity.Property(e => e.NewClassId).HasColumnName("newClassID");
            });

            modelBuilder.Entity<TblExamGrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblExamGrades");

                entity.Property(e => e.GradeLetter)
                    .IsUnicode(false)
                    .HasColumnName("gradeLetter");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LowerLimit).HasColumnName("lowerLimit");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblExamStandardMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblExamStandardMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblExamSubjectsAssociationWithTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblExamSubjectsAssociationWithTeachers");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblFeeInstallment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblFeeInstallments");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InstallmentAmount).HasColumnName("installmentAmount");

                entity.Property(e => e.InstallmentCount).HasColumnName("installmentCount");

                entity.Property(e => e.InstallmentDate)
                    .HasColumnType("date")
                    .HasColumnName("installmentDate");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblGenAcademicCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenAcademicCalendar");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("day");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StudentDev)
                    .IsUnicode(false)
                    .HasColumnName("studentDev");

                entity.Property(e => e.TeacherDev)
                    .IsUnicode(false)
                    .HasColumnName("teacherDev");

                entity.Property(e => e.Term)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("term");
            });

            modelBuilder.Entity<TblGenAdvType>(entity =>
            {
                entity.HasKey(e => e.AdvTypeId);

                entity.ToTable("tblGenAdvTypes");

                entity.Property(e => e.AdvTypeId).HasColumnName("advTypeID");

                entity.Property(e => e.AdvTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("advTypeDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenAnnouncement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenAnnouncements");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<TblGenAttributesAndValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenAttributesAndValues");

                entity.Property(e => e.AttName)
                    .IsUnicode(false)
                    .HasColumnName("attName");

                entity.Property(e => e.AttValue)
                    .IsUnicode(false)
                    .HasColumnName("attValue");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenBehIssue>(entity =>
            {
                entity.HasKey(e => e.BehIssueId);

                entity.ToTable("tblGenBehIssues");

                entity.Property(e => e.BehIssueId).HasColumnName("behIssueId");

                entity.Property(e => e.BehIssueDesc)
                    .IsUnicode(false)
                    .HasColumnName("behIssueDesc");

                entity.Property(e => e.PertainsTo).HasColumnName("pertainsTo");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenBool>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenBool");

                entity.Property(e => e.BoolDescription)
                    .IsUnicode(false)
                    .HasColumnName("boolDescription");

                entity.Property(e => e.BoolId).HasColumnName("boolID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenCast>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenCast");

                entity.Property(e => e.CastId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("castID");

                entity.Property(e => e.CastName)
                    .IsUnicode(false)
                    .HasColumnName("castName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("tblGenClasses");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenEntity>(entity =>
            {
                entity.HasKey(e => e.EntityId);

                entity.ToTable("tblGenEntities");

                entity.Property(e => e.EntityId).HasColumnName("entityID");

                entity.Property(e => e.EntityDesc)
                    .IsUnicode(false)
                    .HasColumnName("entityDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenEvents");

                entity.Property(e => e.EventId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("eventID");

                entity.Property(e => e.EventName)
                    .IsUnicode(false)
                    .HasColumnName("eventName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");
            });

            modelBuilder.Entity<TblGenFeeType>(entity =>
            {
                entity.HasKey(e => e.FeeTypeId);

                entity.ToTable("tblGenFeeTypes");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.FeeTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("feeTypeDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(10)
                    .HasColumnName("serviceType")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblGenFund>(entity =>
            {
                entity.HasKey(e => e.FundsId);

                entity.ToTable("tblGenFunds");

                entity.Property(e => e.FundsId).HasColumnName("fundsID");

                entity.Property(e => e.FundAmount).HasColumnName("fundAmount");

                entity.Property(e => e.FundDesc)
                    .IsUnicode(false)
                    .HasColumnName("fundDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenMarginalRelief>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenMarginalRelief");

                entity.Property(e => e.LowerLimit).HasColumnName("lowerLimit");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.UpperLimit).HasColumnName("upperLimit");
            });

            modelBuilder.Entity<TblGenMonth>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.ToTable("tblGenMonths");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.MonthName)
                    .IsUnicode(false)
                    .HasColumnName("monthName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenNotice>(entity =>
            {
                entity.HasKey(e => e.NoticeId);

                entity.ToTable("tblGenNotices");

                entity.Property(e => e.NoticeId).HasColumnName("noticeID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenOccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId);

                entity.ToTable("tblGenOccupations");

                entity.Property(e => e.OccupationId).HasColumnName("occupationID");

                entity.Property(e => e.OccupationDesc)
                    .IsUnicode(false)
                    .HasColumnName("occupationDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenParticular>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenParticulars");

                entity.Property(e => e.Contact).HasColumnName("contact");

                entity.Property(e => e.EmailAddress).HasColumnName("emailAddress");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Website).HasColumnName("website");
            });

            modelBuilder.Entity<TblGenParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenParties");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NameAddress)
                    .IsUnicode(false)
                    .HasColumnName("nameAddress");

                entity.Property(e => e.PhoneNumber)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<TblGenPrize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenPrizes");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.NameofPrize)
                    .IsUnicode(false)
                    .HasColumnName("nameofPrize");

                entity.Property(e => e.PrizeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("prizeID");
            });

            modelBuilder.Entity<TblGenReasonsOfLeave>(entity =>
            {
                entity.HasKey(e => e.ReasonOfLeaveId);

                entity.ToTable("tblGenReasonsOfLeave");

                entity.Property(e => e.ReasonOfLeaveId).HasColumnName("reasonOfLeaveID");

                entity.Property(e => e.ReasonOfLeaveDesc)
                    .IsUnicode(false)
                    .HasColumnName("reasonOfLeaveDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenReligion");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ReligionName)
                    .IsUnicode(false)
                    .HasColumnName("religionName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblGenSession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("tblGenSessions");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionDesc)
                    .IsUnicode(false)
                    .HasColumnName("sessionDesc");
            });

            modelBuilder.Entity<TblGenSubEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenSubEvents");

                entity.Property(e => e.EventId).HasColumnName("eventID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SubEventName)
                    .IsUnicode(false)
                    .HasColumnName("subEventName");
            });

            modelBuilder.Entity<TblGenSyllabusWarning>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenSyllabusWarnings");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SyllabusWarningId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("syllabusWarningID");

                entity.Property(e => e.WarningDescription)
                    .IsUnicode(false)
                    .HasColumnName("warningDescription");
            });

            modelBuilder.Entity<TblGenTaxSlab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenTaxSlabs");

                entity.Property(e => e.LowerLimit).HasColumnName("lowerLimit");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.UpperLimit).HasColumnName("upperLimit");
            });

            modelBuilder.Entity<TblGenTerm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenTerms");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TermId).HasColumnName("termID");

                entity.Property(e => e.TermName)
                    .IsUnicode(false)
                    .HasColumnName("termName");
            });

            modelBuilder.Entity<TblGenTown>(entity =>
            {
                entity.HasKey(e => e.TownId);

                entity.ToTable("tblGenTowns");

                entity.Property(e => e.TownId).HasColumnName("TownID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("townName");
            });

            modelBuilder.Entity<TblGenWing>(entity =>
            {
                entity.HasKey(e => e.WingId);

                entity.ToTable("tblGenWings");

                entity.Property(e => e.WingId).HasColumnName("wingID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.WingDesc)
                    .IsUnicode(false)
                    .HasColumnName("wingDesc");
            });

            modelBuilder.Entity<TblGenYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGenYears");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TblHifzEnrollemnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHifzEnrollemnts");

                entity.Property(e => e.DateOfEnrollment)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfEnrollment");

                entity.Property(e => e.DateOfWithdrawal)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfWithdrawal");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuStatus).HasColumnName("stuStatus");
            });

            modelBuilder.Entity<TblHifzStuStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHifzStuStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ManzilSituation).HasColumnName("manzilSituation");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SabaqQuantity).HasColumnName("sabaqQuantity");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblHifzSyllabus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHifzSyllabus");

                entity.Property(e => e.AyahText)
                    .HasMaxLength(255)
                    .HasColumnName("ayahText");

                entity.Property(e => e.ParaCount).HasColumnName("paraCount");

                entity.Property(e => e.ParaName).HasMaxLength(255);

                entity.Property(e => e.SurahCount).HasColumnName("surahCount");

                entity.Property(e => e.SurahName).HasMaxLength(255);
            });

            modelBuilder.Entity<TblHifzSyllabusProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHifzSyllabusProgress");

                entity.Property(e => e.AyahCount).HasColumnName("ayahCount");

                entity.Property(e => e.AyahDoneOn)
                    .HasColumnType("datetime")
                    .HasColumnName("ayahDoneOn");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ParaCount).HasColumnName("paraCount");

                entity.Property(e => e.ParaDoneOn)
                    .HasColumnType("datetime")
                    .HasColumnName("paraDoneOn");

                entity.Property(e => e.ParaStartedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("paraStartedOn");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.SurahCount).HasColumnName("surahCount");

                entity.Property(e => e.SurahDoneOn)
                    .HasColumnType("datetime")
                    .HasColumnName("surahDoneOn");

                entity.Property(e => e.SurahStartedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("surahStartedOn");
            });

            modelBuilder.Entity<TblInventoryCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblInventoryCategories");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblInventoryItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblInventoryItems");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.ImageSize)
                    .IsUnicode(false)
                    .HasColumnName("imageSize");

                entity.Property(e => e.ImageType)
                    .IsUnicode(false)
                    .HasColumnName("imageType");

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblInventoryItemValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblInventoryItemValues");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CostValue).HasColumnName("costValue");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.MarketValue).HasColumnName("marketValue");
            });

            modelBuilder.Entity<TblInventoryLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblInventoryLocations");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblInventoryTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblInventoryTransactions");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IssueQuantity).HasColumnName("issueQuantity");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ItemLocation).HasColumnName("itemLocation");

                entity.Property(e => e.ReceiptQuantity).HasColumnName("receiptQuantity");
            });

            modelBuilder.Entity<TblMngtDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtDocuments");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.DocumentName).HasColumnName("documentName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<TblMngtMeeting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtMeetings");

                entity.Property(e => e.Actions)
                    .IsUnicode(false)
                    .HasColumnName("actions");

                entity.Property(e => e.Agenda)
                    .IsUnicode(false)
                    .HasColumnName("agenda");

                entity.Property(e => e.Date)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Minutes)
                    .IsUnicode(false)
                    .HasColumnName("minutes");

                entity.Property(e => e.Participants)
                    .IsUnicode(false)
                    .HasColumnName("participants");

                entity.Property(e => e.Venue)
                    .IsUnicode(false)
                    .HasColumnName("venue");
            });

            modelBuilder.Entity<TblMngtNotice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtNotices");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Topic)
                    .IsUnicode(false)
                    .HasColumnName("topic");
            });

            modelBuilder.Entity<TblMngtPolicy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtPolicy");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MonitoringArea)
                    .IsUnicode(false)
                    .HasColumnName("monitoringArea");

                entity.Property(e => e.SubArea)
                    .IsUnicode(false)
                    .HasColumnName("subArea");
            });

            modelBuilder.Entity<TblMngtSop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtSOP");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Target)
                    .IsUnicode(false)
                    .HasColumnName("target");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblMngtStaffDevelopment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtStaffDevelopment");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Topic)
                    .IsUnicode(false)
                    .HasColumnName("topic");
            });

            modelBuilder.Entity<TblMngtWorkshop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMngtWorkshops");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Organizer)
                    .IsUnicode(false)
                    .HasColumnName("organizer");

                entity.Property(e => e.Topic)
                    .IsUnicode(false)
                    .HasColumnName("topic");
            });

            modelBuilder.Entity<TblQuestionPaper>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblQuestionPapers");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamName)
                    .IsUnicode(false)
                    .HasColumnName("examName");

                entity.Property(e => e.Question).HasColumnName("question");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblQuestionsBank>(entity =>
            {
                entity.ToTable("tblQuestionsBank");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookId).HasColumnName("bookID");

                entity.Property(e => e.ChapterDescription).HasColumnName("chapterDescription");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.QuestionCategoryId).HasColumnName("questionCategoryID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblQuestionsCategory>(entity =>
            {
                entity.ToTable("tblQuestionsCategories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<TblQuestionsCategoryAssociation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblQuestionsCategoryAssociation");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.QuestionCategoryId).HasColumnName("questionCategoryID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblRptAcademicCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAcademicCalendar");

                entity.Property(e => e.Days).IsUnicode(false);
            });

            modelBuilder.Entity<TblRptAcademyAggregate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAcademyAggregate");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.GradeAggregate).HasColumnName("Grade_Aggregate");

                entity.Property(e => e.GradeSec2Slot1).HasColumnName("Grade_Sec2_Slot1");

                entity.Property(e => e.GradeSlot1).HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2).HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3).HasColumnName("Grade_Slot3");

                entity.Property(e => e.Paper10AggregateObtained).HasColumnName("Paper10_Aggregate_Obtained");

                entity.Property(e => e.Paper10AggregateTotal).HasColumnName("Paper10_Aggregate_Total");

                entity.Property(e => e.Paper10Name).HasColumnName("Paper10_Name");

                entity.Property(e => e.Paper10Sec2Slot1).HasColumnName("Paper10_Sec2_Slot1");

                entity.Property(e => e.Paper10Sec2Total).HasColumnName("Paper10_Sec2_Total");

                entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");

                entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");

                entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");

                entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");

                entity.Property(e => e.Paper11AggregateObtained).HasColumnName("Paper11_Aggregate_Obtained");

                entity.Property(e => e.Paper11AggregateTotal).HasColumnName("Paper11_Aggregate_Total");

                entity.Property(e => e.Paper11Name).HasColumnName("Paper11_Name");

                entity.Property(e => e.Paper11Sec2Slot1).HasColumnName("Paper11_Sec2_Slot1");

                entity.Property(e => e.Paper11Sec2Total).HasColumnName("Paper11_Sec2_Total");

                entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");

                entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");

                entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");

                entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");

                entity.Property(e => e.Paper12AggregateObtained).HasColumnName("Paper12_Aggregate_Obtained");

                entity.Property(e => e.Paper12AggregateTotal).HasColumnName("Paper12_Aggregate_Total");

                entity.Property(e => e.Paper12Name).HasColumnName("Paper12_Name");

                entity.Property(e => e.Paper12Sec2Slot1).HasColumnName("Paper12_Sec2_Slot1");

                entity.Property(e => e.Paper12Sec2Total).HasColumnName("Paper12_Sec2_Total");

                entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");

                entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");

                entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");

                entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");

                entity.Property(e => e.Paper13AggregateObtained).HasColumnName("Paper13_Aggregate_Obtained");

                entity.Property(e => e.Paper13AggregateTotal).HasColumnName("Paper13_Aggregate_Total");

                entity.Property(e => e.Paper13Name).HasColumnName("Paper13_Name");

                entity.Property(e => e.Paper13Sec2Slot1).HasColumnName("Paper13_Sec2_Slot1");

                entity.Property(e => e.Paper13Sec2Total).HasColumnName("Paper13_Sec2_Total");

                entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");

                entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");

                entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");

                entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");

                entity.Property(e => e.Paper14AggregateObtained).HasColumnName("Paper14_Aggregate_Obtained");

                entity.Property(e => e.Paper14AggregateTotal).HasColumnName("Paper14_Aggregate_Total");

                entity.Property(e => e.Paper14Name).HasColumnName("Paper14_Name");

                entity.Property(e => e.Paper14Sec2Slot1).HasColumnName("Paper14_Sec2_Slot1");

                entity.Property(e => e.Paper14Sec2Total).HasColumnName("Paper14_Sec2_Total");

                entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");

                entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");

                entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");

                entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");

                entity.Property(e => e.Paper1AggregateObtained).HasColumnName("Paper1_Aggregate_Obtained");

                entity.Property(e => e.Paper1AggregateTotal).HasColumnName("Paper1_Aggregate_Total");

                entity.Property(e => e.Paper1Name).HasColumnName("Paper1_Name");

                entity.Property(e => e.Paper1Sec2Slot1).HasColumnName("Paper1_Sec2_Slot1");

                entity.Property(e => e.Paper1Sec2Total).HasColumnName("Paper1_Sec2_Total");

                entity.Property(e => e.Paper1Slot1).HasColumnName("Paper1_Slot1");

                entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");

                entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");

                entity.Property(e => e.Paper1Total).HasColumnName("Paper1_Total");

                entity.Property(e => e.Paper2AggregateObtained).HasColumnName("Paper2_Aggregate_Obtained");

                entity.Property(e => e.Paper2AggregateTotal).HasColumnName("Paper2_Aggregate_Total");

                entity.Property(e => e.Paper2Name).HasColumnName("Paper2_Name");

                entity.Property(e => e.Paper2Sec2Slot1).HasColumnName("Paper2_Sec2_Slot1");

                entity.Property(e => e.Paper2Sec2Total).HasColumnName("Paper2_Sec2_Total");

                entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");

                entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");

                entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");

                entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");

                entity.Property(e => e.Paper3AggregateObtained).HasColumnName("Paper3_Aggregate_Obtained");

                entity.Property(e => e.Paper3AggregateTotal).HasColumnName("Paper3_Aggregate_Total");

                entity.Property(e => e.Paper3Name).HasColumnName("Paper3_Name");

                entity.Property(e => e.Paper3Sec2Slot1).HasColumnName("Paper3_Sec2_Slot1");

                entity.Property(e => e.Paper3Sec2Total).HasColumnName("Paper3_Sec2_Total");

                entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");

                entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");

                entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");

                entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");

                entity.Property(e => e.Paper4AggregateObtained).HasColumnName("Paper4_Aggregate_Obtained");

                entity.Property(e => e.Paper4AggregateTotal).HasColumnName("Paper4_Aggregate_Total");

                entity.Property(e => e.Paper4Name).HasColumnName("Paper4_Name");

                entity.Property(e => e.Paper4Sec2Slot1).HasColumnName("Paper4_Sec2_Slot1");

                entity.Property(e => e.Paper4Sec2Total).HasColumnName("Paper4_Sec2_Total");

                entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");

                entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");

                entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");

                entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");

                entity.Property(e => e.Paper5AggregateObtained).HasColumnName("Paper5_Aggregate_Obtained");

                entity.Property(e => e.Paper5AggregateTotal).HasColumnName("Paper5_Aggregate_Total");

                entity.Property(e => e.Paper5Name).HasColumnName("Paper5_Name");

                entity.Property(e => e.Paper5Sec2Slot1).HasColumnName("Paper5_Sec2_Slot1");

                entity.Property(e => e.Paper5Sec2Total).HasColumnName("Paper5_Sec2_Total");

                entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");

                entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");

                entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");

                entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");

                entity.Property(e => e.Paper6AggregateObtained).HasColumnName("Paper6_Aggregate_Obtained");

                entity.Property(e => e.Paper6AggregateTotal).HasColumnName("Paper6_Aggregate_Total");

                entity.Property(e => e.Paper6Name).HasColumnName("Paper6_Name");

                entity.Property(e => e.Paper6Sec2Slot1).HasColumnName("Paper6_Sec2_Slot1");

                entity.Property(e => e.Paper6Sec2Total).HasColumnName("Paper6_Sec2_Total");

                entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");

                entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");

                entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");

                entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");

                entity.Property(e => e.Paper7AggregateObtained).HasColumnName("Paper7_Aggregate_Obtained");

                entity.Property(e => e.Paper7AggregateTotal).HasColumnName("Paper7_Aggregate_Total");

                entity.Property(e => e.Paper7Name).HasColumnName("Paper7_Name");

                entity.Property(e => e.Paper7Sec2Slot1).HasColumnName("Paper7_Sec2_Slot1");

                entity.Property(e => e.Paper7Sec2Total).HasColumnName("Paper7_Sec2_Total");

                entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");

                entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");

                entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");

                entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");

                entity.Property(e => e.Paper8AggregateObtained).HasColumnName("Paper8_Aggregate_Obtained");

                entity.Property(e => e.Paper8AggregateTotal).HasColumnName("Paper8_Aggregate_Total");

                entity.Property(e => e.Paper8Name).HasColumnName("Paper8_Name");

                entity.Property(e => e.Paper8Sec2Slot1).HasColumnName("Paper8_Sec2_Slot1");

                entity.Property(e => e.Paper8Sec2Total).HasColumnName("Paper8_Sec2_Total");

                entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");

                entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");

                entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");

                entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");

                entity.Property(e => e.Paper9AggregateObtained).HasColumnName("Paper9_Aggregate_Obtained");

                entity.Property(e => e.Paper9AggregateTotal).HasColumnName("Paper9_Aggregate_Total");

                entity.Property(e => e.Paper9Name).HasColumnName("Paper9_Name");

                entity.Property(e => e.Paper9Sec2Slot1).HasColumnName("Paper9_Sec2_Slot1");

                entity.Property(e => e.Paper9Sec2Total).HasColumnName("Paper9_Sec2_Total");

                entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");

                entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");

                entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");

                entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");

                entity.Property(e => e.PositionAggregate)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Aggregate");

                entity.Property(e => e.PositionSec2Slot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Sec2_Slot1");

                entity.Property(e => e.PositionSlot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot3");

                entity.Property(e => e.Section).HasColumnName("section");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.TotalAggregate).HasColumnName("Total_Aggregate");

                entity.Property(e => e.TotalAggregateObtained).HasColumnName("Total_Aggregate_Obtained");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSec2Marks).HasColumnName("Total_Sec2_Marks");

                entity.Property(e => e.TotalSec2Slot1).HasColumnName("Total_Sec2_Slot1");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");
            });

            modelBuilder.Entity<TblRptAcademyFiveHbfb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAcademyFiveHBFB");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.GradeFb)
                    .IsUnicode(false)
                    .HasColumnName("Grade_FB");

                entity.Property(e => e.GradeHb1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HB1");

                entity.Property(e => e.GradeHb2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HB2");

                entity.Property(e => e.GradeSlot1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.GradeSlot4)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot4");

                entity.Property(e => e.GradeSlot5)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot5");

                entity.Property(e => e.Paper10Fb).HasColumnName("Paper10_FB");

                entity.Property(e => e.Paper10Hb1).HasColumnName("Paper10_HB1");

                entity.Property(e => e.Paper10Hb2).HasColumnName("Paper10_HB2");

                entity.Property(e => e.Paper10Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper10_Name");

                entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");

                entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");

                entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");

                entity.Property(e => e.Paper10Slot4).HasColumnName("Paper10_Slot4");

                entity.Property(e => e.Paper10Slot5).HasColumnName("Paper10_Slot5");

                entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");

                entity.Property(e => e.Paper11Fb).HasColumnName("Paper11_FB");

                entity.Property(e => e.Paper11Hb1).HasColumnName("Paper11_HB1");

                entity.Property(e => e.Paper11Hb2).HasColumnName("Paper11_HB2");

                entity.Property(e => e.Paper11Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper11_Name");

                entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");

                entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");

                entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");

                entity.Property(e => e.Paper11Slot4).HasColumnName("Paper11_Slot4");

                entity.Property(e => e.Paper11Slot5).HasColumnName("Paper11_Slot5");

                entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");

                entity.Property(e => e.Paper12Fb).HasColumnName("Paper12_FB");

                entity.Property(e => e.Paper12Hb1).HasColumnName("Paper12_HB1");

                entity.Property(e => e.Paper12Hb2).HasColumnName("Paper12_HB2");

                entity.Property(e => e.Paper12Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper12_Name");

                entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");

                entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");

                entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");

                entity.Property(e => e.Paper12Slot4).HasColumnName("Paper12_Slot4");

                entity.Property(e => e.Paper12Slot5).HasColumnName("Paper12_Slot5");

                entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");

                entity.Property(e => e.Paper13Fb).HasColumnName("Paper13_FB");

                entity.Property(e => e.Paper13Hb1).HasColumnName("Paper13_HB1");

                entity.Property(e => e.Paper13Hb2).HasColumnName("Paper13_HB2");

                entity.Property(e => e.Paper13Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper13_Name");

                entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");

                entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");

                entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");

                entity.Property(e => e.Paper13Slot4).HasColumnName("Paper13_Slot4");

                entity.Property(e => e.Paper13Slot5).HasColumnName("Paper13_Slot5");

                entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");

                entity.Property(e => e.Paper14Fb).HasColumnName("Paper14_FB");

                entity.Property(e => e.Paper14Hb1).HasColumnName("Paper14_HB1");

                entity.Property(e => e.Paper14Hb2).HasColumnName("Paper14_HB2");

                entity.Property(e => e.Paper14Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper14_Name");

                entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");

                entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");

                entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");

                entity.Property(e => e.Paper14Slot4).HasColumnName("Paper14_Slot4");

                entity.Property(e => e.Paper14Slot5).HasColumnName("Paper14_Slot5");

                entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");

                entity.Property(e => e.Paper1Fb).HasColumnName("Paper1_FB");

                entity.Property(e => e.Paper1Hb1).HasColumnName("Paper1_HB1");

                entity.Property(e => e.Paper1Hb2).HasColumnName("Paper1_HB2");

                entity.Property(e => e.Paper1Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper1_Name");

                entity.Property(e => e.Paper1Slot1).HasColumnName("Paper1_Slot1");

                entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");

                entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");

                entity.Property(e => e.Paper1Slot4).HasColumnName("Paper1_Slot4");

                entity.Property(e => e.Paper1Slot5).HasColumnName("Paper1_Slot5");

                entity.Property(e => e.Paper1Total).HasColumnName("Paper1_Total");

                entity.Property(e => e.Paper2Fb).HasColumnName("Paper2_FB");

                entity.Property(e => e.Paper2Hb1).HasColumnName("Paper2_HB1");

                entity.Property(e => e.Paper2Hb2).HasColumnName("Paper2_HB2");

                entity.Property(e => e.Paper2Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper2_Name");

                entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");

                entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");

                entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");

                entity.Property(e => e.Paper2Slot4).HasColumnName("Paper2_Slot4");

                entity.Property(e => e.Paper2Slot5).HasColumnName("Paper2_Slot5");

                entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");

                entity.Property(e => e.Paper3Fb).HasColumnName("Paper3_FB");

                entity.Property(e => e.Paper3Hb1).HasColumnName("Paper3_HB1");

                entity.Property(e => e.Paper3Hb2).HasColumnName("Paper3_HB2");

                entity.Property(e => e.Paper3Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper3_Name");

                entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");

                entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");

                entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");

                entity.Property(e => e.Paper3Slot4).HasColumnName("Paper3_Slot4");

                entity.Property(e => e.Paper3Slot5).HasColumnName("Paper3_Slot5");

                entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");

                entity.Property(e => e.Paper4Fb).HasColumnName("Paper4_FB");

                entity.Property(e => e.Paper4Hb1).HasColumnName("Paper4_HB1");

                entity.Property(e => e.Paper4Hb2).HasColumnName("Paper4_HB2");

                entity.Property(e => e.Paper4Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper4_Name");

                entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");

                entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");

                entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");

                entity.Property(e => e.Paper4Slot4).HasColumnName("Paper4_Slot4");

                entity.Property(e => e.Paper4Slot5).HasColumnName("Paper4_Slot5");

                entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");

                entity.Property(e => e.Paper5Fb).HasColumnName("Paper5_FB");

                entity.Property(e => e.Paper5Hb1).HasColumnName("Paper5_HB1");

                entity.Property(e => e.Paper5Hb2).HasColumnName("Paper5_HB2");

                entity.Property(e => e.Paper5Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper5_Name");

                entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");

                entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");

                entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");

                entity.Property(e => e.Paper5Slot4).HasColumnName("Paper5_Slot4");

                entity.Property(e => e.Paper5Slot5).HasColumnName("Paper5_Slot5");

                entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");

                entity.Property(e => e.Paper6Fb).HasColumnName("Paper6_FB");

                entity.Property(e => e.Paper6Hb1).HasColumnName("Paper6_HB1");

                entity.Property(e => e.Paper6Hb2).HasColumnName("Paper6_HB2");

                entity.Property(e => e.Paper6Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper6_Name");

                entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");

                entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");

                entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");

                entity.Property(e => e.Paper6Slot4).HasColumnName("Paper6_Slot4");

                entity.Property(e => e.Paper6Slot5).HasColumnName("Paper6_Slot5");

                entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");

                entity.Property(e => e.Paper7Fb).HasColumnName("Paper7_FB");

                entity.Property(e => e.Paper7Hb1).HasColumnName("Paper7_HB1");

                entity.Property(e => e.Paper7Hb2).HasColumnName("Paper7_HB2");

                entity.Property(e => e.Paper7Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper7_Name");

                entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");

                entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");

                entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");

                entity.Property(e => e.Paper7Slot4).HasColumnName("Paper7_Slot4");

                entity.Property(e => e.Paper7Slot5).HasColumnName("Paper7_Slot5");

                entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");

                entity.Property(e => e.Paper8Fb).HasColumnName("Paper8_FB");

                entity.Property(e => e.Paper8Hb1).HasColumnName("Paper8_HB1");

                entity.Property(e => e.Paper8Hb2).HasColumnName("Paper8_HB2");

                entity.Property(e => e.Paper8Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper8_Name");

                entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");

                entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");

                entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");

                entity.Property(e => e.Paper8Slot4).HasColumnName("Paper8_Slot4");

                entity.Property(e => e.Paper8Slot5).HasColumnName("Paper8_Slot5");

                entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");

                entity.Property(e => e.Paper9Fb).HasColumnName("Paper9_FB");

                entity.Property(e => e.Paper9Hb1).HasColumnName("Paper9_HB1");

                entity.Property(e => e.Paper9Hb2).HasColumnName("Paper9_HB2");

                entity.Property(e => e.Paper9Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper9_Name");

                entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");

                entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");

                entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");

                entity.Property(e => e.Paper9Slot4).HasColumnName("Paper9_Slot4");

                entity.Property(e => e.Paper9Slot5).HasColumnName("Paper9_Slot5");

                entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.TotalFb2).HasColumnName("Total_FB2");

                entity.Property(e => e.TotalHb1).HasColumnName("Total_HB1");

                entity.Property(e => e.TotalHb2).HasColumnName("Total_HB2");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");

                entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");

                entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");
            });

            modelBuilder.Entity<TblRptAcademyResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAcademyResult");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.GradeSlot1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.GradeSlot4)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot4");

                entity.Property(e => e.GradeSlot5)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot5");

                entity.Property(e => e.GradeSlot6)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot6");

                entity.Property(e => e.GradeSlot7)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot7");

                entity.Property(e => e.Paper10Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper10_Name");

                entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");

                entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");

                entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");

                entity.Property(e => e.Paper10Slot4).HasColumnName("Paper10_Slot4");

                entity.Property(e => e.Paper10Slot5).HasColumnName("Paper10_Slot5");

                entity.Property(e => e.Paper10Slot6).HasColumnName("Paper10_Slot6");

                entity.Property(e => e.Paper10Slot7).HasColumnName("Paper10_Slot7");

                entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");

                entity.Property(e => e.Paper11Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper11_Name");

                entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");

                entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");

                entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");

                entity.Property(e => e.Paper11Slot4).HasColumnName("Paper11_Slot4");

                entity.Property(e => e.Paper11Slot5).HasColumnName("Paper11_Slot5");

                entity.Property(e => e.Paper11Slot6).HasColumnName("Paper11_Slot6");

                entity.Property(e => e.Paper11Slot7).HasColumnName("Paper11_Slot7");

                entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");

                entity.Property(e => e.Paper12Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper12_Name");

                entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");

                entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");

                entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");

                entity.Property(e => e.Paper12Slot4).HasColumnName("Paper12_Slot4");

                entity.Property(e => e.Paper12Slot5).HasColumnName("Paper12_Slot5");

                entity.Property(e => e.Paper12Slot6).HasColumnName("Paper12_Slot6");

                entity.Property(e => e.Paper12Slot7).HasColumnName("Paper12_Slot7");

                entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");

                entity.Property(e => e.Paper13Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper13_Name");

                entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");

                entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");

                entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");

                entity.Property(e => e.Paper13Slot4).HasColumnName("Paper13_Slot4");

                entity.Property(e => e.Paper13Slot5).HasColumnName("Paper13_Slot5");

                entity.Property(e => e.Paper13Slot6).HasColumnName("Paper13_Slot6");

                entity.Property(e => e.Paper13Slot7).HasColumnName("Paper13_Slot7");

                entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");

                entity.Property(e => e.Paper14Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper14_Name");

                entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");

                entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");

                entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");

                entity.Property(e => e.Paper14Slot4).HasColumnName("Paper14_Slot4");

                entity.Property(e => e.Paper14Slot5).HasColumnName("Paper14_Slot5");

                entity.Property(e => e.Paper14Slot6).HasColumnName("Paper14_Slot6");

                entity.Property(e => e.Paper14Slot7).HasColumnName("Paper14_Slot7");

                entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");

                entity.Property(e => e.Paper1Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper1_Name");

                entity.Property(e => e.Paper1Slot1)
                    .HasColumnName("Paper1_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");

                entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");

                entity.Property(e => e.Paper1Slot4).HasColumnName("Paper1_Slot4");

                entity.Property(e => e.Paper1Slot5).HasColumnName("Paper1_Slot5");

                entity.Property(e => e.Paper1Slot6).HasColumnName("Paper1_Slot6");

                entity.Property(e => e.Paper1Slot7).HasColumnName("Paper1_Slot7");

                entity.Property(e => e.Paper1Total)
                    .HasColumnName("Paper1_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paper2Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper2_Name");

                entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");

                entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");

                entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");

                entity.Property(e => e.Paper2Slot4).HasColumnName("Paper2_Slot4");

                entity.Property(e => e.Paper2Slot5).HasColumnName("Paper2_Slot5");

                entity.Property(e => e.Paper2Slot6).HasColumnName("Paper2_Slot6");

                entity.Property(e => e.Paper2Slot7).HasColumnName("Paper2_Slot7");

                entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");

                entity.Property(e => e.Paper3Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper3_Name");

                entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");

                entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");

                entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");

                entity.Property(e => e.Paper3Slot4).HasColumnName("Paper3_Slot4");

                entity.Property(e => e.Paper3Slot5).HasColumnName("Paper3_Slot5");

                entity.Property(e => e.Paper3Slot6).HasColumnName("Paper3_Slot6");

                entity.Property(e => e.Paper3Slot7).HasColumnName("Paper3_Slot7");

                entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");

                entity.Property(e => e.Paper4Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper4_Name");

                entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");

                entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");

                entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");

                entity.Property(e => e.Paper4Slot4).HasColumnName("Paper4_Slot4");

                entity.Property(e => e.Paper4Slot5).HasColumnName("Paper4_Slot5");

                entity.Property(e => e.Paper4Slot6).HasColumnName("Paper4_Slot6");

                entity.Property(e => e.Paper4Slot7).HasColumnName("Paper4_Slot7");

                entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");

                entity.Property(e => e.Paper5Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper5_Name");

                entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");

                entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");

                entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");

                entity.Property(e => e.Paper5Slot4).HasColumnName("Paper5_Slot4");

                entity.Property(e => e.Paper5Slot5).HasColumnName("Paper5_Slot5");

                entity.Property(e => e.Paper5Slot6).HasColumnName("Paper5_Slot6");

                entity.Property(e => e.Paper5Slot7).HasColumnName("Paper5_Slot7");

                entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");

                entity.Property(e => e.Paper6Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper6_Name");

                entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");

                entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");

                entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");

                entity.Property(e => e.Paper6Slot4).HasColumnName("Paper6_Slot4");

                entity.Property(e => e.Paper6Slot5).HasColumnName("Paper6_Slot5");

                entity.Property(e => e.Paper6Slot6).HasColumnName("Paper6_Slot6");

                entity.Property(e => e.Paper6Slot7).HasColumnName("Paper6_Slot7");

                entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");

                entity.Property(e => e.Paper7Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper7_Name");

                entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");

                entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");

                entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");

                entity.Property(e => e.Paper7Slot4).HasColumnName("Paper7_Slot4");

                entity.Property(e => e.Paper7Slot5).HasColumnName("Paper7_Slot5");

                entity.Property(e => e.Paper7Slot6).HasColumnName("Paper7_Slot6");

                entity.Property(e => e.Paper7Slot7).HasColumnName("Paper7_Slot7");

                entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");

                entity.Property(e => e.Paper8Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper8_Name");

                entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");

                entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");

                entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");

                entity.Property(e => e.Paper8Slot4).HasColumnName("Paper8_Slot4");

                entity.Property(e => e.Paper8Slot5).HasColumnName("Paper8_Slot5");

                entity.Property(e => e.Paper8Slot6).HasColumnName("Paper8_Slot6");

                entity.Property(e => e.Paper8Slot7).HasColumnName("Paper8_Slot7");

                entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");

                entity.Property(e => e.Paper9Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper9_Name");

                entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");

                entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");

                entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");

                entity.Property(e => e.Paper9Slot4).HasColumnName("Paper9_Slot4");

                entity.Property(e => e.Paper9Slot5).HasColumnName("Paper9_Slot5");

                entity.Property(e => e.Paper9Slot6).HasColumnName("Paper9_Slot6");

                entity.Property(e => e.Paper9Slot7).HasColumnName("Paper9_Slot7");

                entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");

                entity.Property(e => e.PercSlot1).HasColumnName("Perc_Slot1");

                entity.Property(e => e.PercSlot2).HasColumnName("Perc_Slot2");

                entity.Property(e => e.PercSlot3).HasColumnName("Perc_Slot3");

                entity.Property(e => e.PercSlot4).HasColumnName("Perc_Slot4");

                entity.Property(e => e.PercSlot5).HasColumnName("Perc_Slot5");

                entity.Property(e => e.PercSlot6).HasColumnName("Perc_Slot6");

                entity.Property(e => e.PercSlot7).HasColumnName("Perc_Slot7");

                entity.Property(e => e.PositionSlot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot3");

                entity.Property(e => e.PositionSlot4)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot4");

                entity.Property(e => e.PositionSlot5)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot5");

                entity.Property(e => e.PositionSlot6)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot6");

                entity.Property(e => e.PositionSlot7)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot7");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");

                entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");

                entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");

                entity.Property(e => e.TotalSlot6).HasColumnName("Total_Slot6");

                entity.Property(e => e.TotalSlot7).HasColumnName("Total_Slot7");
            });

            modelBuilder.Entity<TblRptAcademyThreePlusThree>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAcademyThreePlusThree");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.GradeSec2Slot1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Sec2_Slot1");

                entity.Property(e => e.GradeSec2Slot2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Sec2_Slot2");

                entity.Property(e => e.GradeSec2Slot3)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Sec2_Slot3");

                entity.Property(e => e.GradeSlot1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.Paper10Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper10_Name");

                entity.Property(e => e.Paper10Sec2Slot1).HasColumnName("Paper10_Sec2_Slot1");

                entity.Property(e => e.Paper10Sec2Slot2).HasColumnName("Paper10_Sec2_Slot2");

                entity.Property(e => e.Paper10Sec2Slot3).HasColumnName("Paper10_Sec2_Slot3");

                entity.Property(e => e.Paper10Sec2Total).HasColumnName("Paper10_Sec2_Total");

                entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");

                entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");

                entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");

                entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");

                entity.Property(e => e.Paper11Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper11_Name");

                entity.Property(e => e.Paper11Sec2Slot1).HasColumnName("Paper11_Sec2_Slot1");

                entity.Property(e => e.Paper11Sec2Slot2).HasColumnName("Paper11_Sec2_Slot2");

                entity.Property(e => e.Paper11Sec2Slot3).HasColumnName("Paper11_Sec2_Slot3");

                entity.Property(e => e.Paper11Sec2Total).HasColumnName("Paper11_Sec2_Total");

                entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");

                entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");

                entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");

                entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");

                entity.Property(e => e.Paper12Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper12_Name");

                entity.Property(e => e.Paper12Sec2Slot1).HasColumnName("Paper12_Sec2_Slot1");

                entity.Property(e => e.Paper12Sec2Slot2).HasColumnName("Paper12_Sec2_Slot2");

                entity.Property(e => e.Paper12Sec2Slot3).HasColumnName("Paper12_Sec2_Slot3");

                entity.Property(e => e.Paper12Sec2Total).HasColumnName("Paper12_Sec2_Total");

                entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");

                entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");

                entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");

                entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");

                entity.Property(e => e.Paper13Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper13_Name");

                entity.Property(e => e.Paper13Sec2Slot1).HasColumnName("Paper13_Sec2_Slot1");

                entity.Property(e => e.Paper13Sec2Slot2).HasColumnName("Paper13_Sec2_Slot2");

                entity.Property(e => e.Paper13Sec2Slot3).HasColumnName("Paper13_Sec2_Slot3");

                entity.Property(e => e.Paper13Sec2Total).HasColumnName("Paper13_Sec2_Total");

                entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");

                entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");

                entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");

                entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");

                entity.Property(e => e.Paper14Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper14_Name");

                entity.Property(e => e.Paper14Sec2Slot1).HasColumnName("Paper14_Sec2_Slot1");

                entity.Property(e => e.Paper14Sec2Slot2).HasColumnName("Paper14_Sec2_Slot2");

                entity.Property(e => e.Paper14Sec2Slot3).HasColumnName("Paper14_Sec2_Slot3");

                entity.Property(e => e.Paper14Sec2Total).HasColumnName("Paper14_Sec2_Total");

                entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");

                entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");

                entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");

                entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");

                entity.Property(e => e.Paper1Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper1_Name");

                entity.Property(e => e.Paper1Sec2Slot1).HasColumnName("Paper1_Sec2_Slot1");

                entity.Property(e => e.Paper1Sec2Slot2).HasColumnName("Paper1_Sec2_Slot2");

                entity.Property(e => e.Paper1Sec2Slot3).HasColumnName("Paper1_Sec2_Slot3");

                entity.Property(e => e.Paper1Sec2Total).HasColumnName("Paper1_Sec2_Total");

                entity.Property(e => e.Paper1Slot1).HasColumnName("Paper1_Slot1");

                entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");

                entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");

                entity.Property(e => e.Paper1Total).HasColumnName("Paper1_Total");

                entity.Property(e => e.Paper2Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper2_Name");

                entity.Property(e => e.Paper2Sec2Slot1).HasColumnName("Paper2_Sec2_Slot1");

                entity.Property(e => e.Paper2Sec2Slot2).HasColumnName("Paper2_Sec2_Slot2");

                entity.Property(e => e.Paper2Sec2Slot3).HasColumnName("Paper2_Sec2_Slot3");

                entity.Property(e => e.Paper2Sec2Total).HasColumnName("Paper2_Sec2_Total");

                entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");

                entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");

                entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");

                entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");

                entity.Property(e => e.Paper3Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper3_Name");

                entity.Property(e => e.Paper3Sec2Slot1).HasColumnName("Paper3_Sec2_Slot1");

                entity.Property(e => e.Paper3Sec2Slot2).HasColumnName("Paper3_Sec2_Slot2");

                entity.Property(e => e.Paper3Sec2Slot3).HasColumnName("Paper3_Sec2_Slot3");

                entity.Property(e => e.Paper3Sec2Total).HasColumnName("Paper3_Sec2_Total");

                entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");

                entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");

                entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");

                entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");

                entity.Property(e => e.Paper4Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper4_Name");

                entity.Property(e => e.Paper4Sec2Slot1).HasColumnName("Paper4_Sec2_Slot1");

                entity.Property(e => e.Paper4Sec2Slot2).HasColumnName("Paper4_Sec2_Slot2");

                entity.Property(e => e.Paper4Sec2Slot3).HasColumnName("Paper4_Sec2_Slot3");

                entity.Property(e => e.Paper4Sec2Total).HasColumnName("Paper4_Sec2_Total");

                entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");

                entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");

                entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");

                entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");

                entity.Property(e => e.Paper5Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper5_Name");

                entity.Property(e => e.Paper5Sec2Slot1).HasColumnName("Paper5_Sec2_Slot1");

                entity.Property(e => e.Paper5Sec2Slot2).HasColumnName("Paper5_Sec2_Slot2");

                entity.Property(e => e.Paper5Sec2Slot3).HasColumnName("Paper5_Sec2_Slot3");

                entity.Property(e => e.Paper5Sec2Total).HasColumnName("Paper5_Sec2_Total");

                entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");

                entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");

                entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");

                entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");

                entity.Property(e => e.Paper6Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper6_Name");

                entity.Property(e => e.Paper6Sec2Slot1).HasColumnName("Paper6_Sec2_Slot1");

                entity.Property(e => e.Paper6Sec2Slot2).HasColumnName("Paper6_Sec2_Slot2");

                entity.Property(e => e.Paper6Sec2Slot3).HasColumnName("Paper6_Sec2_Slot3");

                entity.Property(e => e.Paper6Sec2Total).HasColumnName("Paper6_Sec2_Total");

                entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");

                entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");

                entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");

                entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");

                entity.Property(e => e.Paper7Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper7_Name");

                entity.Property(e => e.Paper7Sec2Slot1).HasColumnName("Paper7_Sec2_Slot1");

                entity.Property(e => e.Paper7Sec2Slot2).HasColumnName("Paper7_Sec2_Slot2");

                entity.Property(e => e.Paper7Sec2Slot3).HasColumnName("Paper7_Sec2_Slot3");

                entity.Property(e => e.Paper7Sec2Total).HasColumnName("Paper7_Sec2_Total");

                entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");

                entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");

                entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");

                entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");

                entity.Property(e => e.Paper8Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper8_Name");

                entity.Property(e => e.Paper8Sec2Slot1).HasColumnName("Paper8_Sec2_Slot1");

                entity.Property(e => e.Paper8Sec2Slot2).HasColumnName("Paper8_Sec2_Slot2");

                entity.Property(e => e.Paper8Sec2Slot3).HasColumnName("Paper8_Sec2_Slot3");

                entity.Property(e => e.Paper8Sec2Total).HasColumnName("Paper8_Sec2_Total");

                entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");

                entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");

                entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");

                entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");

                entity.Property(e => e.Paper9Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper9_Name");

                entity.Property(e => e.Paper9Sec2Slot1).HasColumnName("Paper9_Sec2_Slot1");

                entity.Property(e => e.Paper9Sec2Slot2).HasColumnName("Paper9_Sec2_Slot2");

                entity.Property(e => e.Paper9Sec2Slot3).HasColumnName("Paper9_Sec2_Slot3");

                entity.Property(e => e.Paper9Sec2Total).HasColumnName("Paper9_Sec2_Total");

                entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");

                entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");

                entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");

                entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");

                entity.Property(e => e.PositionSec2Slot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Sec2_Slot1");

                entity.Property(e => e.PositionSec2Slot2)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Sec2_Slot2");

                entity.Property(e => e.PositionSec2Slot3)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Sec2_Slot3");

                entity.Property(e => e.PositionSlot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot3");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSec2Marks).HasColumnName("Total_Sec2_Marks");

                entity.Property(e => e.TotalSec2Slot1).HasColumnName("Total_Sec2_Slot1");

                entity.Property(e => e.TotalSec2Slot2).HasColumnName("Total_Sec2_Slot2");

                entity.Property(e => e.TotalSec2Slot3).HasColumnName("Total_Sec2_Slot3");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");
            });

            modelBuilder.Entity<TblRptAccountStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAccountStatement");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.AccountType).HasColumnName("accountType");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ReportingOrder)
                    .HasColumnName("reportingOrder")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RunningBalance).HasColumnName("runningBalance");
            });

            modelBuilder.Entity<TblRptAggregateResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAggregateResult");

                entity.Property(e => e.AggregateObtained).HasColumnName("Aggregate_Obtained");

                entity.Property(e => e.AggregateTotal).HasColumnName("Aggregate_Total");

                entity.Property(e => e.AgriHeconomicsAggregate)
                    .HasColumnName("AgriHEconomics_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsAggregateTotal)
                    .HasColumnName("AgriHEconomics_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsSlot1)
                    .HasColumnName("AgriHEconomics_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsSlot2)
                    .HasColumnName("AgriHEconomics_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsSlot3)
                    .HasColumnName("AgriHEconomics_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsTerm)
                    .HasColumnName("AgriHEconomics_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsTermTotal)
                    .HasColumnName("AgriHEconomics_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsTotal)
                    .HasColumnName("AgriHEconomics_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicAggregate)
                    .HasColumnName("Arabic_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicAggregateTotal)
                    .HasColumnName("Arabic_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicSlot1)
                    .HasColumnName("Arabic_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicSlot2)
                    .HasColumnName("Arabic_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicSlot3)
                    .HasColumnName("Arabic_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicTerm)
                    .HasColumnName("Arabic_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicTermTotal)
                    .HasColumnName("Arabic_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicTotal)
                    .HasColumnName("Arabic_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorAggregate)
                    .HasColumnName("Behavior_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorAggregateTotal)
                    .HasColumnName("Behavior_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorSlot1)
                    .HasColumnName("Behavior_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorSlot2)
                    .HasColumnName("Behavior_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorSlot3)
                    .HasColumnName("Behavior_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorTerm)
                    .HasColumnName("Behavior_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorTermTotal)
                    .HasColumnName("Behavior_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BehaviorTotal)
                    .HasColumnName("Behavior_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologyAggregate)
                    .HasColumnName("Biology_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologyAggregateTotal)
                    .HasColumnName("Biology_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologySlot1)
                    .HasColumnName("Biology_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologySlot2)
                    .HasColumnName("Biology_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologySlot3)
                    .HasColumnName("Biology_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologyTerm)
                    .HasColumnName("Biology_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologyTermTotal)
                    .HasColumnName("Biology_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BiologyTotal)
                    .HasColumnName("Biology_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistryAggregate)
                    .HasColumnName("Chemistry_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistryAggregateTotal)
                    .HasColumnName("Chemistry_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistrySlot1)
                    .HasColumnName("Chemistry_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistrySlot2)
                    .HasColumnName("Chemistry_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistrySlot3)
                    .HasColumnName("Chemistry_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistryTerm)
                    .HasColumnName("Chemistry_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistryTermTotal)
                    .HasColumnName("Chemistry_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChemistryTotal)
                    .HasColumnName("Chemistry_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ComputerAggregate)
                    .HasColumnName("Computer_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerAggregateTotal)
                    .HasColumnName("Computer_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerSlot1)
                    .HasColumnName("Computer_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerSlot2)
                    .HasColumnName("Computer_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerSlot3)
                    .HasColumnName("Computer_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerTerm)
                    .HasColumnName("Computer_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerTermTotal)
                    .HasColumnName("Computer_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerTotal)
                    .HasColumnName("Computer_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishAggregate)
                    .HasColumnName("English_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishAggregateTotal)
                    .HasColumnName("English_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishSlot1)
                    .HasColumnName("English_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishSlot2)
                    .HasColumnName("English_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishSlot3)
                    .HasColumnName("English_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishTerm)
                    .HasColumnName("English_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishTermTotal)
                    .HasColumnName("English_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnglishTotal)
                    .HasColumnName("English_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IslamiatAggregate)
                    .HasColumnName("Islamiat_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatAggregateTotal)
                    .HasColumnName("Islamiat_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatSlot1)
                    .HasColumnName("Islamiat_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatSlot2)
                    .HasColumnName("Islamiat_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatSlot3)
                    .HasColumnName("Islamiat_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatTerm)
                    .HasColumnName("Islamiat_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatTermTotal)
                    .HasColumnName("Islamiat_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslamiatTotal)
                    .HasColumnName("Islamiat_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsAggregate)
                    .HasColumnName("Mathematics_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsAggregateTotal)
                    .HasColumnName("Mathematics_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsSlot1)
                    .HasColumnName("Mathematics_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsSlot2)
                    .HasColumnName("Mathematics_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsSlot3)
                    .HasColumnName("Mathematics_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsTerm)
                    .HasColumnName("Mathematics_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsTermTotal)
                    .HasColumnName("Mathematics_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MathematicsTotal)
                    .HasColumnName("Mathematics_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsAggregate)
                    .HasColumnName("Physics_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsAggregateTotal)
                    .HasColumnName("Physics_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsSlot1)
                    .HasColumnName("Physics_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsSlot2)
                    .HasColumnName("Physics_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsSlot3)
                    .HasColumnName("Physics_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsTerm)
                    .HasColumnName("Physics_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsTermTotal)
                    .HasColumnName("Physics_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhysicsTotal)
                    .HasColumnName("Physics_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionClass).HasColumnName("Position_Class");

                entity.Property(e => e.PositionOverall).HasColumnName("Position_Overall");

                entity.Property(e => e.QuranAggregate)
                    .HasColumnName("Quran_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranAggregateTotal)
                    .HasColumnName("Quran_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranSlot1)
                    .HasColumnName("Quran_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranSlot2)
                    .HasColumnName("Quran_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranSlot3)
                    .HasColumnName("Quran_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranTerm)
                    .HasColumnName("Quran_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranTermTotal)
                    .HasColumnName("Quran_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuranTotal)
                    .HasColumnName("Quran_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScienceAggregate)
                    .HasColumnName("Science_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceAggregateTotal)
                    .HasColumnName("Science_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceSlot1)
                    .HasColumnName("Science_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceSlot2)
                    .HasColumnName("Science_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceSlot3)
                    .HasColumnName("Science_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceTerm)
                    .HasColumnName("Science_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceTermTotal)
                    .HasColumnName("Science_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScienceTotal)
                    .HasColumnName("Science_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesAggregate)
                    .HasColumnName("SocialStudies_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesAggregateTotal)
                    .HasColumnName("SocialStudies_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesSlot1)
                    .HasColumnName("SocialStudies_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesSlot2)
                    .HasColumnName("SocialStudies_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesSlot3)
                    .HasColumnName("SocialStudies_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesTerm)
                    .HasColumnName("SocialStudies_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesTermTotal)
                    .HasColumnName("SocialStudies_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SocialStudiesTotal)
                    .HasColumnName("SocialStudies_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.UrduAggregate)
                    .HasColumnName("Urdu_Aggregate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduAggregateTotal)
                    .HasColumnName("Urdu_Aggregate_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduSlot1)
                    .HasColumnName("Urdu_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduSlot2)
                    .HasColumnName("Urdu_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduSlot3)
                    .HasColumnName("Urdu_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduTerm)
                    .HasColumnName("Urdu_Term")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduTermTotal)
                    .HasColumnName("Urdu_Term_Total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduTotal)
                    .HasColumnName("Urdu_Total")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblRptApproxCompletionDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptApproxCompletionDate");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.DaysAvailable).HasColumnName("daysAvailable");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.SubjecId).HasColumnName("subjecID");

                entity.Property(e => e.TermId).HasColumnName("termID");

                entity.Property(e => e.WorkLoadDays).HasColumnName("workLoadDays");
            });

            modelBuilder.Entity<TblRptAttendanceRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptAttendanceRegister");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Month).IsUnicode(false);

                entity.Property(e => e.Year).IsUnicode(false);

                entity.Property(e => e._1)
                    .IsUnicode(false)
                    .HasColumnName("1")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._10)
                    .IsUnicode(false)
                    .HasColumnName("10")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._11)
                    .IsUnicode(false)
                    .HasColumnName("11")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._12)
                    .IsUnicode(false)
                    .HasColumnName("12")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._13)
                    .IsUnicode(false)
                    .HasColumnName("13")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._14)
                    .IsUnicode(false)
                    .HasColumnName("14")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._15)
                    .IsUnicode(false)
                    .HasColumnName("15")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._16)
                    .IsUnicode(false)
                    .HasColumnName("16")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._17)
                    .IsUnicode(false)
                    .HasColumnName("17")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._18)
                    .IsUnicode(false)
                    .HasColumnName("18")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._19)
                    .IsUnicode(false)
                    .HasColumnName("19")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._2)
                    .IsUnicode(false)
                    .HasColumnName("2")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._20)
                    .IsUnicode(false)
                    .HasColumnName("20")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._21)
                    .IsUnicode(false)
                    .HasColumnName("21")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._22)
                    .IsUnicode(false)
                    .HasColumnName("22")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._23)
                    .IsUnicode(false)
                    .HasColumnName("23")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._24)
                    .IsUnicode(false)
                    .HasColumnName("24")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._25)
                    .IsUnicode(false)
                    .HasColumnName("25")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._26)
                    .IsUnicode(false)
                    .HasColumnName("26")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._27)
                    .IsUnicode(false)
                    .HasColumnName("27")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._28)
                    .IsUnicode(false)
                    .HasColumnName("28")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._29)
                    .IsUnicode(false)
                    .HasColumnName("29")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._3)
                    .IsUnicode(false)
                    .HasColumnName("3")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._30)
                    .IsUnicode(false)
                    .HasColumnName("30")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._31)
                    .IsUnicode(false)
                    .HasColumnName("31")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._4)
                    .IsUnicode(false)
                    .HasColumnName("4")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._5)
                    .IsUnicode(false)
                    .HasColumnName("5")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._6)
                    .IsUnicode(false)
                    .HasColumnName("6")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._7)
                    .IsUnicode(false)
                    .HasColumnName("7")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._8)
                    .IsUnicode(false)
                    .HasColumnName("8")
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e._9)
                    .IsUnicode(false)
                    .HasColumnName("9")
                    .HasDefaultValueSql("('P')");
            });

            modelBuilder.Entity<TblRptCombinedResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptCombinedResult");

                entity.Property(e => e.AgriHeconomicsSlot1).HasColumnName("AgriHEconomics_Slot1");

                entity.Property(e => e.AgriHeconomicsSlot2).HasColumnName("AgriHEconomics_Slot2");

                entity.Property(e => e.AgriHeconomicsSlot3).HasColumnName("AgriHEconomics_Slot3");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.ArabicSlot1).HasColumnName("Arabic_Slot1");

                entity.Property(e => e.ArabicSlot2).HasColumnName("Arabic_Slot2");

                entity.Property(e => e.ArabicSlot3).HasColumnName("Arabic_Slot3");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.BehaviorSlot1).HasColumnName("Behavior_Slot1");

                entity.Property(e => e.BehaviorSlot2).HasColumnName("Behavior_Slot2");

                entity.Property(e => e.BehaviorSlot3).HasColumnName("Behavior_Slot3");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BiologySlot1).HasColumnName("Biology_Slot1");

                entity.Property(e => e.BiologySlot2).HasColumnName("Biology_Slot2");

                entity.Property(e => e.BiologySlot3).HasColumnName("Biology_Slot3");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.ChemistrySlot1).HasColumnName("Chemistry_Slot1");

                entity.Property(e => e.ChemistrySlot2).HasColumnName("Chemistry_Slot2");

                entity.Property(e => e.ChemistrySlot3).HasColumnName("Chemistry_Slot3");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ComputerSlot1).HasColumnName("Computer_Slot1");

                entity.Property(e => e.ComputerSlot2).HasColumnName("Computer_Slot2");

                entity.Property(e => e.ComputerSlot3).HasColumnName("Computer_Slot3");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.EnglishSlot1).HasColumnName("English_Slot1");

                entity.Property(e => e.EnglishSlot2).HasColumnName("English_Slot2");

                entity.Property(e => e.EnglishSlot3).HasColumnName("English_Slot3");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.GradeSlot1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.IslamiatSlot1).HasColumnName("Islamiat_Slot1");

                entity.Property(e => e.IslamiatSlot2).HasColumnName("Islamiat_Slot2");

                entity.Property(e => e.IslamiatSlot3).HasColumnName("Islamiat_Slot3");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.MathematicsSlot1).HasColumnName("Mathematics_Slot1");

                entity.Property(e => e.MathematicsSlot2).HasColumnName("Mathematics_Slot2");

                entity.Property(e => e.MathematicsSlot3).HasColumnName("Mathematics_Slot3");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.PhysicsSlot1).HasColumnName("Physics_Slot1");

                entity.Property(e => e.PhysicsSlot2).HasColumnName("Physics_Slot2");

                entity.Property(e => e.PhysicsSlot3).HasColumnName("Physics_Slot3");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.PositionSlot1).HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2).HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3).HasColumnName("Position_Slot3");

                entity.Property(e => e.QuranSlot1).HasColumnName("Quran_Slot1");

                entity.Property(e => e.QuranSlot2).HasColumnName("Quran_Slot2");

                entity.Property(e => e.QuranSlot3).HasColumnName("Quran_Slot3");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScienceSlot1).HasColumnName("Science_Slot1");

                entity.Property(e => e.ScienceSlot2).HasColumnName("Science_Slot2");

                entity.Property(e => e.ScienceSlot3).HasColumnName("Science_Slot3");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.SocialStudiesSlot1).HasColumnName("SocialStudies_Slot1");

                entity.Property(e => e.SocialStudiesSlot2).HasColumnName("SocialStudies_Slot2");

                entity.Property(e => e.SocialStudiesSlot3).HasColumnName("SocialStudies_Slot3");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot1)
                    .HasColumnName("Total_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot2)
                    .HasColumnName("Total_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot3)
                    .HasColumnName("Total_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduSlot1).HasColumnName("Urdu_Slot1");

                entity.Property(e => e.UrduSlot2).HasColumnName("Urdu_Slot2");

                entity.Property(e => e.UrduSlot3).HasColumnName("Urdu_Slot3");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");
            });

            modelBuilder.Entity<TblRptDatesheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptDatesheet");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.Syllabus)
                    .IsUnicode(false)
                    .HasColumnName("syllabus");
            });

            modelBuilder.Entity<TblRptMarksList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptMarksLists");

                entity.Property(e => e.AgriHeconomicsObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AgriHEconomics_Obtained");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.ArabicObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Arabic_Obtained");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.BehaviorObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Behavior_Obtained");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BiologyObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Biology_Obtained");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.ChemistryObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Chemistry_Obtained");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ComputerObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Computer_Obtained");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.EnglishObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("English_Obtained");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.ExamName).IsUnicode(false);

                entity.Property(e => e.IslamiatObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Islamiat_Obtained");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.MathematicsObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Mathematics_Obtained");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.PhysicsObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Physics_Obtained");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.QuranObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Quran_Obtained");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.ScienceObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Science_Obtained");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.SocialStudiesObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SocialStudies_Obtained");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.UrduObtained)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Urdu_Obtained");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");
            });

            modelBuilder.Entity<TblRptStudentPaymentHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptStudentPaymentHistory");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TblRptStudentProgressRemark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptStudentProgressRemarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Slot1).HasColumnName("slot_1");

                entity.Property(e => e.Slot2).HasColumnName("slot_2");

                entity.Property(e => e.Slot3).HasColumnName("slot_3");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<TblRptSyllabusProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptSyllabusProgress");

                entity.Property(e => e.BwloadCovered).HasColumnName("BWLoadCovered");

                entity.Property(e => e.Bwstatus)
                    .IsUnicode(false)
                    .HasColumnName("BWStatus");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.GwloadCovered).HasColumnName("GWLoadCovered");

                entity.Property(e => e.Gwstatus)
                    .IsUnicode(false)
                    .HasColumnName("GWStatus");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.TotalDaysAvailable).HasColumnName("totalDaysAvailable");

                entity.Property(e => e.TotalDaysPassed).HasColumnName("totalDaysPassed");

                entity.Property(e => e.TotalWorkLoad).HasColumnName("totalWorkLoad");
            });

            modelBuilder.Entity<TblRptTestSeries>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptTestSeries");

                entity.Property(e => e.AgriHeconomicsFullBook)
                    .HasColumnName("AgriHEconomics_FullBook")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsHalfBook1)
                    .HasColumnName("AgriHEconomics_HalfBook1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsHalfBook2)
                    .HasColumnName("AgriHEconomics_HalfBook2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsSlot1).HasColumnName("AgriHEconomics_Slot1");

                entity.Property(e => e.AgriHeconomicsSlot2).HasColumnName("AgriHEconomics_Slot2");

                entity.Property(e => e.AgriHeconomicsSlot3).HasColumnName("AgriHEconomics_Slot3");

                entity.Property(e => e.AgriHeconomicsSlot4)
                    .HasColumnName("AgriHEconomics_Slot4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsSlot5)
                    .HasColumnName("AgriHEconomics_Slot5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.AgriHeconomicsTotalHalfFull)
                    .HasColumnName("AgriHEconomics_TotalHalfFull")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArabicFullBook).HasColumnName("Arabic_FullBook");

                entity.Property(e => e.ArabicHalfBook1).HasColumnName("Arabic_HalfBook1");

                entity.Property(e => e.ArabicHalfBook2).HasColumnName("Arabic_HalfBook2");

                entity.Property(e => e.ArabicSlot1).HasColumnName("Arabic_Slot1");

                entity.Property(e => e.ArabicSlot2).HasColumnName("Arabic_Slot2");

                entity.Property(e => e.ArabicSlot3).HasColumnName("Arabic_Slot3");

                entity.Property(e => e.ArabicSlot4).HasColumnName("Arabic_Slot4");

                entity.Property(e => e.ArabicSlot5).HasColumnName("Arabic_Slot5");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.ArabicTotalHalfFull).HasColumnName("Arabic_TotalHalfFull");

                entity.Property(e => e.BehaviorFullBook).HasColumnName("Behavior_FullBook");

                entity.Property(e => e.BehaviorHalfBook1).HasColumnName("Behavior_HalfBook1");

                entity.Property(e => e.BehaviorHalfBook2).HasColumnName("Behavior_HalfBook2");

                entity.Property(e => e.BehaviorSlot1).HasColumnName("Behavior_Slot1");

                entity.Property(e => e.BehaviorSlot2).HasColumnName("Behavior_Slot2");

                entity.Property(e => e.BehaviorSlot3).HasColumnName("Behavior_Slot3");

                entity.Property(e => e.BehaviorSlot4).HasColumnName("Behavior_Slot4");

                entity.Property(e => e.BehaviorSlot5).HasColumnName("Behavior_Slot5");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BehaviorTotalHalfFull).HasColumnName("Behavior_TotalHalfFull");

                entity.Property(e => e.BiologyFullBook).HasColumnName("Biology_FullBook");

                entity.Property(e => e.BiologyHalfBook1).HasColumnName("Biology_HalfBook1");

                entity.Property(e => e.BiologyHalfBook2).HasColumnName("Biology_HalfBook2");

                entity.Property(e => e.BiologySlot1).HasColumnName("Biology_Slot1");

                entity.Property(e => e.BiologySlot2).HasColumnName("Biology_Slot2");

                entity.Property(e => e.BiologySlot3).HasColumnName("Biology_Slot3");

                entity.Property(e => e.BiologySlot4).HasColumnName("Biology_Slot4");

                entity.Property(e => e.BiologySlot5).HasColumnName("Biology_Slot5");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.BiologyTotalHalfFull).HasColumnName("Biology_TotalHalfFull");

                entity.Property(e => e.ChemistryFullBook).HasColumnName("Chemistry_FullBook");

                entity.Property(e => e.ChemistryHalfBook1).HasColumnName("Chemistry_HalfBook1");

                entity.Property(e => e.ChemistryHalfBook2).HasColumnName("Chemistry_HalfBook2");

                entity.Property(e => e.ChemistrySlot1).HasColumnName("Chemistry_Slot1");

                entity.Property(e => e.ChemistrySlot2).HasColumnName("Chemistry_Slot2");

                entity.Property(e => e.ChemistrySlot3).HasColumnName("Chemistry_Slot3");

                entity.Property(e => e.ChemistrySlot4).HasColumnName("Chemistry_Slot4");

                entity.Property(e => e.ChemistrySlot5).HasColumnName("Chemistry_Slot5");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ChemistryTotalHalfFull).HasColumnName("Chemistry_TotalHalfFull");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ComputerFullBook).HasColumnName("Computer_FullBook");

                entity.Property(e => e.ComputerHalfBook1).HasColumnName("Computer_HalfBook1");

                entity.Property(e => e.ComputerHalfBook2).HasColumnName("Computer_HalfBook2");

                entity.Property(e => e.ComputerSlot1).HasColumnName("Computer_Slot1");

                entity.Property(e => e.ComputerSlot2).HasColumnName("Computer_Slot2");

                entity.Property(e => e.ComputerSlot3).HasColumnName("Computer_Slot3");

                entity.Property(e => e.ComputerSlot4).HasColumnName("Computer_Slot4");

                entity.Property(e => e.ComputerSlot5).HasColumnName("Computer_Slot5");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.ComputerTotalHalfFull).HasColumnName("Computer_TotalHalfFull");

                entity.Property(e => e.EnglishFullBook).HasColumnName("English_FullBook");

                entity.Property(e => e.EnglishHalfBook1).HasColumnName("English_HalfBook1");

                entity.Property(e => e.EnglishHalfBook2).HasColumnName("English_HalfBook2");

                entity.Property(e => e.EnglishSlot1).HasColumnName("English_Slot1");

                entity.Property(e => e.EnglishSlot2).HasColumnName("English_Slot2");

                entity.Property(e => e.EnglishSlot3).HasColumnName("English_Slot3");

                entity.Property(e => e.EnglishSlot4).HasColumnName("English_Slot4");

                entity.Property(e => e.EnglishSlot5).HasColumnName("English_Slot5");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.EnglishTotalHalfFull).HasColumnName("English_TotalHalfFull");

                entity.Property(e => e.GradeFullBook)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_FullBook");

                entity.Property(e => e.GradeHalfBook1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HalfBook1");

                entity.Property(e => e.GradeHalfBook2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HalfBook2");

                entity.Property(e => e.GradeSlot1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.GradeSlot4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot4");

                entity.Property(e => e.GradeSlot5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot5");

                entity.Property(e => e.IslamiatFullBook).HasColumnName("Islamiat_FullBook");

                entity.Property(e => e.IslamiatHalfBook1).HasColumnName("Islamiat_HalfBook1");

                entity.Property(e => e.IslamiatHalfBook2).HasColumnName("Islamiat_HalfBook2");

                entity.Property(e => e.IslamiatSlot1).HasColumnName("Islamiat_Slot1");

                entity.Property(e => e.IslamiatSlot2).HasColumnName("Islamiat_Slot2");

                entity.Property(e => e.IslamiatSlot3).HasColumnName("Islamiat_Slot3");

                entity.Property(e => e.IslamiatSlot4).HasColumnName("Islamiat_Slot4");

                entity.Property(e => e.IslamiatSlot5).HasColumnName("Islamiat_Slot5");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.IslamiatTotalHalfFull).HasColumnName("Islamiat_TotalHalfFull");

                entity.Property(e => e.MathematicsFullBook).HasColumnName("Mathematics_FullBook");

                entity.Property(e => e.MathematicsHalfBook1).HasColumnName("Mathematics_HalfBook1");

                entity.Property(e => e.MathematicsHalfBook2).HasColumnName("Mathematics_HalfBook2");

                entity.Property(e => e.MathematicsSlot1).HasColumnName("Mathematics_Slot1");

                entity.Property(e => e.MathematicsSlot2).HasColumnName("Mathematics_Slot2");

                entity.Property(e => e.MathematicsSlot3).HasColumnName("Mathematics_Slot3");

                entity.Property(e => e.MathematicsSlot4).HasColumnName("Mathematics_Slot4");

                entity.Property(e => e.MathematicsSlot5).HasColumnName("Mathematics_Slot5");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.MathematicsTotalHalfFull).HasColumnName("Mathematics_TotalHalfFull");

                entity.Property(e => e.PhysicsFullBook).HasColumnName("Physics_FullBook");

                entity.Property(e => e.PhysicsHalfBook1).HasColumnName("Physics_HalfBook1");

                entity.Property(e => e.PhysicsHalfBook2).HasColumnName("Physics_HalfBook2");

                entity.Property(e => e.PhysicsSlot1).HasColumnName("Physics_Slot1");

                entity.Property(e => e.PhysicsSlot2).HasColumnName("Physics_Slot2");

                entity.Property(e => e.PhysicsSlot3).HasColumnName("Physics_Slot3");

                entity.Property(e => e.PhysicsSlot4).HasColumnName("Physics_Slot4");

                entity.Property(e => e.PhysicsSlot5).HasColumnName("Physics_Slot5");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.PhysicsTotalHalfFull).HasColumnName("Physics_TotalHalfFull");

                entity.Property(e => e.PositionFullBook).HasColumnName("Position_FullBook");

                entity.Property(e => e.PositionHalfBook1).HasColumnName("Position_HalfBook1");

                entity.Property(e => e.PositionHalfBook2).HasColumnName("Position_HalfBook2");

                entity.Property(e => e.PositionSlot1).HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2).HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3).HasColumnName("Position_Slot3");

                entity.Property(e => e.PositionSlot4).HasColumnName("Position_Slot4");

                entity.Property(e => e.PositionSlot5).HasColumnName("Position_Slot5");

                entity.Property(e => e.QuranFullBook).HasColumnName("Quran_FullBook");

                entity.Property(e => e.QuranHalfBook1).HasColumnName("Quran_HalfBook1");

                entity.Property(e => e.QuranHalfBook2).HasColumnName("Quran_HalfBook2");

                entity.Property(e => e.QuranSlot1).HasColumnName("Quran_Slot1");

                entity.Property(e => e.QuranSlot2).HasColumnName("Quran_Slot2");

                entity.Property(e => e.QuranSlot3).HasColumnName("Quran_Slot3");

                entity.Property(e => e.QuranSlot4).HasColumnName("Quran_Slot4");

                entity.Property(e => e.QuranSlot5).HasColumnName("Quran_Slot5");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.QuranTotalHalfFull).HasColumnName("Quran_TotalHalfFull");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScienceFullBook).HasColumnName("Science_FullBook");

                entity.Property(e => e.ScienceHalfBook1).HasColumnName("Science_HalfBook1");

                entity.Property(e => e.ScienceHalfBook2).HasColumnName("Science_HalfBook2");

                entity.Property(e => e.ScienceSlot1).HasColumnName("Science_Slot1");

                entity.Property(e => e.ScienceSlot2).HasColumnName("Science_Slot2");

                entity.Property(e => e.ScienceSlot3).HasColumnName("Science_Slot3");

                entity.Property(e => e.ScienceSlot4).HasColumnName("Science_Slot4");

                entity.Property(e => e.ScienceSlot5).HasColumnName("Science_Slot5");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.ScienceTotalHalfFull).HasColumnName("Science_TotalHalfFull");

                entity.Property(e => e.SocialStudiesFullBook).HasColumnName("SocialStudies_FullBook");

                entity.Property(e => e.SocialStudiesHalfBook1).HasColumnName("SocialStudies_HalfBook1");

                entity.Property(e => e.SocialStudiesHalfBook2).HasColumnName("SocialStudies_HalfBook2");

                entity.Property(e => e.SocialStudiesSlot1).HasColumnName("SocialStudies_Slot1");

                entity.Property(e => e.SocialStudiesSlot2).HasColumnName("SocialStudies_Slot2");

                entity.Property(e => e.SocialStudiesSlot3).HasColumnName("SocialStudies_Slot3");

                entity.Property(e => e.SocialStudiesSlot4).HasColumnName("SocialStudies_Slot4");

                entity.Property(e => e.SocialStudiesSlot5).HasColumnName("SocialStudies_Slot5");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.SocialStudiesTotalHalfFull).HasColumnName("SocialStudies_TotalHalfFull");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalFullBook)
                    .HasColumnName("Total_FullBook")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHalfBook1)
                    .HasColumnName("Total_HalfBook1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHalfBook2)
                    .HasColumnName("Total_HalfBook2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalHalfFull)
                    .HasColumnName("Total_HalfFull")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot1)
                    .HasColumnName("Total_Slot1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot2)
                    .HasColumnName("Total_Slot2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot3)
                    .HasColumnName("Total_Slot3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot4)
                    .HasColumnName("Total_Slot4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSlot5)
                    .HasColumnName("Total_Slot5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrduFullBook).HasColumnName("Urdu_FullBook");

                entity.Property(e => e.UrduHalfBook1).HasColumnName("Urdu_HalfBook1");

                entity.Property(e => e.UrduHalfBook2).HasColumnName("Urdu_HalfBook2");

                entity.Property(e => e.UrduSlot1).HasColumnName("Urdu_Slot1");

                entity.Property(e => e.UrduSlot2).HasColumnName("Urdu_Slot2");

                entity.Property(e => e.UrduSlot3).HasColumnName("Urdu_Slot3");

                entity.Property(e => e.UrduSlot4).HasColumnName("Urdu_Slot4");

                entity.Property(e => e.UrduSlot5).HasColumnName("Urdu_Slot5");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");

                entity.Property(e => e.UrduTotalHalfFull).HasColumnName("Urdu_TotalHalfFull");
            });

            modelBuilder.Entity<TblRptTrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblRptTrialBalance");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblServices");

                entity.Property(e => e.FeeTypeName).HasColumnName("feeTypeName");

                entity.Property(e => e.FeeTypeShortName).HasColumnName("feeTypeShortName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Scope).HasColumnName("scope");

                entity.Property(e => e.ServiceName).HasColumnName("serviceName");
            });

            modelBuilder.Entity<TblStaffAdvType>(entity =>
            {
                entity.HasKey(e => e.AdvTypeId);

                entity.ToTable("tblStaffAdvTypes");

                entity.Property(e => e.AdvTypeId).HasColumnName("advTypeId");

                entity.Property(e => e.AdvTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("advTypeDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblStaffAdvance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStaffAdvances");

                entity.Property(e => e.AdvTypeId).HasColumnName("advTypeID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DateAdvTaken)
                    .HasColumnType("date")
                    .HasColumnName("dateAdvTaken");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StaffId).HasColumnName("staffID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblStaffOtherDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStaffOtherDeductions");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DedAmount).HasColumnName("dedAmount");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblStuAggResult>(entity =>
            {
                entity.HasKey(e => e.AggResultId);

                entity.ToTable("tblStuAggResults");

                entity.Property(e => e.AggResultId).HasColumnName("aggResultID");

                entity.Property(e => e.AggResultName)
                    .IsUnicode(false)
                    .HasColumnName("aggResultName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblStuAggResultApplicability>(entity =>
            {
                entity.HasKey(e => e.ExamId);

                entity.ToTable("tblStuAggResultApplicability");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.ExamDesc)
                    .IsUnicode(false)
                    .HasColumnName("examDesc");

                entity.Property(e => e.ExamTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("examTypeID")
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");
            });

            modelBuilder.Entity<TblStuAggResultWeight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuAggResultWeight");

                entity.Property(e => e.AggResultId).HasColumnName("aggResultID");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<TblStuAggResultsMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuAggResultsMarks");

                entity.Property(e => e.AggResultId).HasColumnName("aggResultID");

                entity.Property(e => e.ObtainedMarks).HasColumnName("obtainedMarks");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.TotalMarks).HasColumnName("totalMarks");
            });

            modelBuilder.Entity<TblStuAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuAttendance");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsAbsent).HasColumnName("isAbsent");

                entity.Property(e => e.IsLate).HasColumnName("isLate");

                entity.Property(e => e.LeaveAppRec)
                    .HasColumnName("leaveAppRec")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartialLeave).HasColumnName("partialLeave");

                entity.Property(e => e.ReasonOfLeave).HasColumnName("reasonOfLeave");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblStuBehavior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuBehavior");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuBehId).HasColumnName("stuBehID");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblStuClasswiseFeeDetail>(entity =>
            {
                entity.ToTable("tblStuClasswiseFeeDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdmissionFee).HasColumnName("admissionFee");

                entity.Property(e => e.AnnualCharges).HasColumnName("annualCharges");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SecurityDeposits).HasColumnName("securityDeposits");

                entity.Property(e => e.TuitionFee).HasColumnName("tuitionFee");
            });

            modelBuilder.Entity<TblStuDailyDiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuDailyDiary");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Subject).HasColumnName("subject");

                entity.Property(e => e.Task).HasColumnName("task");
            });

            modelBuilder.Entity<TblStuDiscType>(entity =>
            {
                entity.HasKey(e => e.StuDiscId);

                entity.ToTable("tblStuDiscTypes");

                entity.Property(e => e.StuDiscId).HasColumnName("stuDiscID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuDiscDesc)
                    .IsUnicode(false)
                    .HasColumnName("stuDiscDesc");
            });

            modelBuilder.Entity<TblStuEventStanding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuEventStandings");

                entity.Property(e => e.EventId).HasColumnName("eventId");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PrizeId).HasColumnName("prizeID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StudentId).HasColumnName("studentId");

                entity.Property(e => e.SubEventId).HasColumnName("subEventID");
            });

            modelBuilder.Entity<TblStuExam>(entity =>
            {
                entity.HasKey(e => e.ExamId)
                    .HasName("PK_tblStuExams_1");

                entity.ToTable("tblStuExams");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.ExamDescription)
                    .IsUnicode(false)
                    .HasColumnName("examDescription");

                entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRecordEntered).HasColumnName("isRecordEntered");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");
            });

            modelBuilder.Entity<TblStuExamAssociationWithSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuExamAssociationWithSubjects");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblStuExamResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuExamResults");

                entity.Property(e => e.ActualMarks).HasColumnName("actualMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.MarksObtained).HasColumnName("marksObtained");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StdMarks).HasColumnName("stdMarks");

                entity.Property(e => e.StdMarksObtained)
                    .HasColumnName("stdMarksObtained")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblStuExamResultsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuExamResults_Old");

                entity.Property(e => e.ActualMarks).HasColumnName("actualMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.MarksObtained).HasColumnName("marksObtained");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StdMarks).HasColumnName("stdMarks");

                entity.Property(e => e.StdMarksObtained).HasColumnName("stdMarksObtained");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblStuExamType>(entity =>
            {
                entity.HasKey(e => e.ExamTypeId);

                entity.ToTable("tblStuExamTypes");

                entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");

                entity.Property(e => e.ExamTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("examTypeDesc");

                entity.Property(e => e.ExamTypeRemarks)
                    .IsUnicode(false)
                    .HasColumnName("examTypeRemarks");
            });

            modelBuilder.Entity<TblStuFeeAdvance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuFeeAdvance");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeeCollector).HasColumnName("feeCollector");

                entity.Property(e => e.FeeMonthId).HasColumnName("feeMonthID");

                entity.Property(e => e.FeePaid).HasColumnName("feePaid");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.FundAmount).HasColumnName("fundAmount");

                entity.Property(e => e.I)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("i");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TblStuFeeDueAndReceived>(entity =>
            {
                entity.ToTable("tblStuFeeDueAndReceived");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeeCollector).HasColumnName("feeCollector");

                entity.Property(e => e.FeeDue)
                    .HasColumnName("feeDue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeMonthId).HasColumnName("feeMonthID");

                entity.Property(e => e.FeePaid)
                    .HasColumnName("feePaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeRemarks)
                    .IsUnicode(false)
                    .HasColumnName("feeRemarks")
                    .HasDefaultValueSql("('None')");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.FeeUnpaid)
                    .HasColumnName("feeUnpaid")
                    .HasComputedColumnSql("([feeDue]-[feePaid])", false);

                entity.Property(e => e.FundAmount)
                    .HasColumnName("fundAmount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstallmentStatus).HasColumnName("installmentStatus");

                entity.Property(e => e.ReceiptTime)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("receiptTime");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.WriteOff)
                    .HasColumnName("writeOff")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TblStuInquiry>(entity =>
            {
                entity.HasKey(e => e.StuInqId);

                entity.ToTable("tblStuInquiry");

                entity.Property(e => e.StuInqId).HasColumnName("stuInqID");

                entity.Property(e => e.AdvertisementTypeId).HasColumnName("advertisementTypeID");

                entity.Property(e => e.AppearedInAdmTest)
                    .HasColumnName("appearedInAdmTest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassInquired).HasColumnName("classInquired");

                entity.Property(e => e.ContactNumber)
                    .IsUnicode(false)
                    .HasColumnName("contactNumber");

                entity.Property(e => e.DateOfInquiry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfInquiry");

                entity.Property(e => e.FinalizeInquiry).HasColumnName("finalizeInquiry");

                entity.Property(e => e.RemarksStuInquiry)
                    .IsUnicode(false)
                    .HasColumnName("remarksStuInquiry");

                entity.Property(e => e.StAddress)
                    .IsUnicode(false)
                    .HasColumnName("stAddress");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.SubmittedAdmForm)
                    .HasColumnName("submittedAdmForm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakenAdmission)
                    .HasColumnName("takenAdmission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TakenProspectus)
                    .HasColumnName("takenProspectus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Town).HasColumnName("town");
            });

            modelBuilder.Entity<TblStuMain>(entity =>
            {
                entity.HasKey(e => e.StuId);

                entity.ToTable("tblStuMain");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.StuAdditionalRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuAdditionalRemarks");

                entity.Property(e => e.StuAdmClass).HasColumnName("stuAdmClass");

                entity.Property(e => e.StuAdmDate)
                    .HasColumnType("date")
                    .HasColumnName("stuAdmDate");

                entity.Property(e => e.StuAdmRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuAdmRemarks");

                entity.Property(e => e.StuAdmTestResults).HasColumnName("stuAdmTestResults");

                entity.Property(e => e.StuAdmissionNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuAdmissionNumber");

                entity.Property(e => e.StuBform).HasColumnName("stuBForm");

                entity.Property(e => e.StuBirthCertificate).HasColumnName("stuBirthCertificate");

                entity.Property(e => e.StuCastId).HasColumnName("stuCastID");

                entity.Property(e => e.StuCity)
                    .IsUnicode(false)
                    .HasColumnName("stuCity");

                entity.Property(e => e.StuCurrentClass).HasColumnName("stuCurrentClass");

                entity.Property(e => e.StuCurrentDiscount)
                    .HasColumnName("stuCurrentDiscount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StuCurrentSection)
                    .IsUnicode(false)
                    .HasColumnName("stuCurrentSection");

                entity.Property(e => e.StuCurrentWing).HasColumnName("stuCurrentWing");

                entity.Property(e => e.StuDiscountReason).HasColumnName("stuDiscountReason");

                entity.Property(e => e.StuDob)
                    .HasColumnType("date")
                    .HasColumnName("stuDOB");

                entity.Property(e => e.StuEmail)
                    .IsUnicode(false)
                    .HasColumnName("stuEmail");

                entity.Property(e => e.StuFatherBusinessAdd)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherBusinessAdd");

                entity.Property(e => e.StuFatherBusinessTown).HasColumnName("stuFatherBusinessTown");

                entity.Property(e => e.StuFatherCnic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherCNIC");

                entity.Property(e => e.StuFatherCniccopy).HasColumnName("stuFatherCNICCopy");

                entity.Property(e => e.StuFatherMobile)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherMobile");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuFatherOccupation).HasColumnName("stuFatherOccupation");

                entity.Property(e => e.StuFeeReminderRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuFeeReminderRemarks");

                entity.Property(e => e.StuFingerPrint).HasColumnName("stuFingerPrint");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuHomeStreet)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeStreet");

                entity.Property(e => e.StuHomeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeTelNo");

                entity.Property(e => e.StuHomeTown).HasColumnName("stuHomeTown");

                entity.Property(e => e.StuInqId).HasColumnName("stuInqID");

                entity.Property(e => e.StuLastPromotionDate)
                    .HasColumnType("date")
                    .HasColumnName("stuLastPromotionDate");

                entity.Property(e => e.StuMedicalProblems)
                    .IsUnicode(false)
                    .HasColumnName("stuMedicalProblems");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuOfficeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuOfficeTelNo");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StuReligionId).HasColumnName("stuReligionID");

                entity.Property(e => e.StuResultCard).HasColumnName("stuResultCard");

                entity.Property(e => e.StuSlc).HasColumnName("stuSLC");

                entity.Property(e => e.StuStatus).HasColumnName("stuStatus");

                entity.Property(e => e.StuWithDrawalCause)
                    .IsUnicode(false)
                    .HasColumnName("stuWithDrawalCause");

                entity.Property(e => e.StuWithDrawalDate)
                    .HasColumnType("date")
                    .HasColumnName("stuWithDrawalDate");

                entity.Property(e => e.StuWithDrawalRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuWithDrawalRemarks");
            });

            modelBuilder.Entity<TblStuReasonsOfWithDrawal>(entity =>
            {
                entity.HasKey(e => e.ReasonOfWithDrawalId);

                entity.ToTable("tblStuReasonsOfWithDrawal");

                entity.Property(e => e.ReasonOfWithDrawalId).HasColumnName("reasonOfWithDrawalID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.WithDrawalTypeDescription)
                    .IsUnicode(false)
                    .HasColumnName("withDrawalTypeDescription");
            });

            modelBuilder.Entity<TblStuStatus>(entity =>
            {
                entity.HasKey(e => e.StuStatusId);

                entity.ToTable("tblStuStatuses");

                entity.Property(e => e.StuStatusId).HasColumnName("stuStatusID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuStatusDesc)
                    .IsUnicode(false)
                    .HasColumnName("stuStatusDesc");
            });

            modelBuilder.Entity<TblStuSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("tblStuSubjects");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SubjectDesc)
                    .IsUnicode(false)
                    .HasColumnName("subjectDesc");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.SubjectRemarks)
                    .IsUnicode(false)
                    .HasColumnName("subjectRemarks");
            });

            modelBuilder.Entity<TblStuSubjectAssociationWithClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuSubjectAssociationWithClasses");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.PeriodsPerWeek)
                    .HasColumnName("periodsPerWeek")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblStuSyllabusBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuSyllabusBooks");

                entity.Property(e => e.Bookname).HasColumnName("bookname");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<TblStuUnpaidFeeStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStuUnpaidFeeStatus");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<TblStudentPortfolio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentPortfolio");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.StuId).HasColumnName("stuID");
            });

            modelBuilder.Entity<TblStudentWithService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentWithServices");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.Property(e => e.StudentId).HasColumnName("studentID");
            });

            modelBuilder.Entity<TblSubjectStandardMark>(entity =>
            {
                entity.ToTable("tblSubjectStandardMarks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<TblSyllabus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSyllabus");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.Syllabus).HasColumnName("syllabus");
            });

            modelBuilder.Entity<TblSyllabusBreakup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSyllabusBreakup");

                entity.Property(e => e.BoysWing).HasColumnName("boysWing");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassWork).HasColumnName("classWork");

                entity.Property(e => e.GirlsWing).HasColumnName("girlsWing");

                entity.Property(e => e.HomeWork).HasColumnName("homeWork");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SyllabusItem).HasColumnName("syllabusItem");

                entity.Property(e => e.SyllabusOrder).HasColumnName("syllabusOrder");

                entity.Property(e => e.TermId).HasColumnName("termID");

                entity.Property(e => e.WorkLoadDays)
                    .HasColumnName("workLoadDays")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblSyllabusProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSyllabusProgress");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Covered)
                    .HasColumnName("covered")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Section).HasColumnName("section");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SyllabusItem).HasColumnName("syllabusItem");

                entity.Property(e => e.SyllabusOrder).HasColumnName("syllabusOrder");

                entity.Property(e => e.TermId).HasColumnName("termID");
            });

            modelBuilder.Entity<TblSyllabusSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSyllabusSections");

                entity.Property(e => e.BookId).HasColumnName("bookID");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SyllabuSection).HasColumnName("syllabuSection");
            });

            modelBuilder.Entity<TblTeacherAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherAllowances");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblTeacherAssociationWithSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherAssociationWithSubjects");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblTeacherAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherAttendance");

                entity.Property(e => e.ApplicationReceived)
                    .HasColumnName("applicationReceived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsAbsent)
                    .HasColumnName("isAbsent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmergencyLeave).HasColumnName("isEmergencyLeave");

                entity.Property(e => e.IsHalfDay).HasColumnName("isHalfDay");

                entity.Property(e => e.IsLate)
                    .HasColumnName("isLate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReasonOfLeave)
                    .HasColumnName("reasonOfLeave")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.ShortLeave)
                    .HasColumnName("shortLeave")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblTeacherBehavior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherBehavior");

                entity.Property(e => e.BehaviorId).HasColumnName("behaviorID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblTeacherDeductionType>(entity =>
            {
                entity.HasKey(e => e.DeductionTypeId);

                entity.ToTable("tblTeacherDeductionTypes");

                entity.Property(e => e.DeductionTypeId).HasColumnName("deductionTypeID");

                entity.Property(e => e.DeductionDesc)
                    .IsUnicode(false)
                    .HasColumnName("deductionDesc");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblTeacherDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherDuties");

                entity.Property(e => e.AssignedBy).HasColumnName("assignedBy");

                entity.Property(e => e.DateOfAssignment)
                    .HasColumnType("date")
                    .HasColumnName("dateOfAssignment");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherFeedBack)
                    .IsUnicode(false)
                    .HasColumnName("teacherFeedBack");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblTeacherEmploymentRecord>(entity =>
            {
                entity.ToTable("tblTeacherEmploymentRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.DateOfTermination)
                    .HasColumnType("date")
                    .HasColumnName("dateOfTermination");

                entity.Property(e => e.ReasonOfTermination).HasColumnName("reasonOfTermination");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");
            });

            modelBuilder.Entity<TblTeacherLeavesSanctioned>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherLeavesSanctioned");

                entity.Property(e => e.Leaves).HasColumnName("leaves");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblTeacherLeavesSanctionedOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherLeavesSanctionedOld");

                entity.Property(e => e.Leaves).HasColumnName("leaves");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblTeacherMain>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("tblTeacherMain");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.Cnic)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CurrentGrossSalary).HasColumnName("currentGrossSalary");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.DateOfTermination)
                    .HasColumnType("date")
                    .HasColumnName("dateOfTermination");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EducationalQualifications)
                    .IsUnicode(false)
                    .HasColumnName("educationalQualifications");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmergencyContactName)
                    .IsUnicode(false)
                    .HasColumnName("emergencyContactName");

                entity.Property(e => e.EmergencyContactNumber)
                    .IsUnicode(false)
                    .HasColumnName("emergencyContactNumber");

                entity.Property(e => e.FacultyId)
                    .IsUnicode(false)
                    .HasColumnName("facultyID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("fatherName");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HomeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("homeTelNo");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.Institute)
                    .IsUnicode(false)
                    .HasColumnName("institute");

                entity.Property(e => e.IsPotentialTeacher).HasColumnName("isPotentialTeacher");

                entity.Property(e => e.IsTeacher).HasColumnName("isTeacher");

                entity.Property(e => e.LastIncrementDate)
                    .HasColumnType("date")
                    .HasColumnName("lastIncrementDate");

                entity.Property(e => e.MobileNo)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Objective)
                    .IsUnicode(false)
                    .HasColumnName("objective");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Possessive)
                    .IsUnicode(false)
                    .HasColumnName("possessive");

                entity.Property(e => e.PrimaryQualification)
                    .IsUnicode(false)
                    .HasColumnName("primaryQualification");

                entity.Property(e => e.PrimarySubject).HasColumnName("primarySubject");

                entity.Property(e => e.ReasonOfTermination).HasColumnName("reasonOfTermination");

                entity.Property(e => e.RemarksAtJoining)
                    .IsUnicode(false)
                    .HasColumnName("remarksAtJoining");

                entity.Property(e => e.RemarksAtTermination)
                    .IsUnicode(false)
                    .HasColumnName("remarksAtTermination");

                entity.Property(e => e.SecondarySubject).HasColumnName("secondarySubject");

                entity.Property(e => e.StaffCategoryId).HasColumnName("staffCategoryID");

                entity.Property(e => e.StartingSalary).HasColumnName("startingSalary");

                entity.Property(e => e.StreetAddress)
                    .IsUnicode(false)
                    .HasColumnName("streetAddress");

                entity.Property(e => e.Subjective)
                    .IsUnicode(false)
                    .HasColumnName("subjective");

                entity.Property(e => e.TFingerPrint).HasColumnName("tFingerPrint");

                entity.Property(e => e.Town)
                    .IsUnicode(false)
                    .HasColumnName("town");

                entity.Property(e => e.TransactionAccountId).HasColumnName("transactionAccountID");

                entity.Property(e => e.WasStaff).HasColumnName("wasStaff");
            });

            modelBuilder.Entity<TblTeacherSalDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherSalDeductions");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DeductionTypeId).HasColumnName("deductionTypeID");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.YearId).HasColumnName("yearID");
            });

            modelBuilder.Entity<TblTeacherSalarySheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherSalarySheet");

                entity.Property(e => e.Absents).HasColumnName("absents");

                entity.Property(e => e.AdvanceSalaryAdjustments).HasColumnName("advanceSalaryAdjustments");

                entity.Property(e => e.Allowances).HasColumnName("allowances");

                entity.Property(e => e.AlreadyAvailedLeaves).HasColumnName("alreadyAvailedLeaves");

                entity.Property(e => e.BasicSalary).HasColumnName("basicSalary");

                entity.Property(e => e.EmergencyLeaves).HasColumnName("emergencyLeaves");

                entity.Property(e => e.Lates).HasColumnName("lates");

                entity.Property(e => e.LeaveDeductions).HasColumnName("leaveDeductions");

                entity.Property(e => e.LeavesDeducted).HasColumnName("leavesDeducted");

                entity.Property(e => e.NetSalary).HasColumnName("netSalary");

                entity.Property(e => e.OtherDeductions).HasColumnName("otherDeductions");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SalaryMonth).HasColumnName("salaryMonth");

                entity.Property(e => e.SalaryYear).HasColumnName("salaryYear");

                entity.Property(e => e.ShortLeaves).HasColumnName("shortLeaves");

                entity.Property(e => e.TaxDeductions).HasColumnName("taxDeductions");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.Words)
                    .IsUnicode(false)
                    .HasColumnName("words");
            });

            modelBuilder.Entity<TblTeacherSyllabusWarning>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTeacherSyllabusWarnings");

                entity.Property(e => e.CashFine).HasColumnName("cashFine");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FurtherInstructions)
                    .IsUnicode(false)
                    .HasColumnName("furtherInstructions");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.WarningDescription).HasColumnName("warningDescription");
            });

            modelBuilder.Entity<TblTmpDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTmpDates");

                entity.Property(e => e.Dates)
                    .HasColumnType("date")
                    .HasColumnName("dates");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblUsers");

                entity.Property(e => e.ActualName)
                    .IsUnicode(false)
                    .HasColumnName("actualName");

                entity.Property(e => e.Checksum).HasColumnName("checksum");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Password)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Roles)
                    .IsUnicode(false)
                    .HasColumnName("roles");

                entity.Property(e => e.SecurityAnswer)
                    .IsUnicode(false)
                    .HasColumnName("securityAnswer");

                entity.Property(e => e.SecurityQuestion)
                    .IsUnicode(false)
                    .HasColumnName("securityQuestion");

                entity.Property(e => e.UserType)
                    .IsUnicode(false)
                    .HasColumnName("userType");

                entity.Property(e => e.Username)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<ViewAcademyResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAcademyResult");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.GradeSlot1)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.GradeSlot4)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot4");

                entity.Property(e => e.GradeSlot5)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot5");

                entity.Property(e => e.GradeSlot6)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot6");

                entity.Property(e => e.GradeSlot7)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot7");

                entity.Property(e => e.Paper10Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper10_Name");

                entity.Property(e => e.Paper10Slot1).HasColumnName("Paper10_Slot1");

                entity.Property(e => e.Paper10Slot2).HasColumnName("Paper10_Slot2");

                entity.Property(e => e.Paper10Slot3).HasColumnName("Paper10_Slot3");

                entity.Property(e => e.Paper10Slot4).HasColumnName("Paper10_Slot4");

                entity.Property(e => e.Paper10Slot5).HasColumnName("Paper10_Slot5");

                entity.Property(e => e.Paper10Slot6).HasColumnName("Paper10_Slot6");

                entity.Property(e => e.Paper10Slot7).HasColumnName("Paper10_Slot7");

                entity.Property(e => e.Paper10Total).HasColumnName("Paper10_Total");

                entity.Property(e => e.Paper11Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper11_Name");

                entity.Property(e => e.Paper11Slot1).HasColumnName("Paper11_Slot1");

                entity.Property(e => e.Paper11Slot2).HasColumnName("Paper11_Slot2");

                entity.Property(e => e.Paper11Slot3).HasColumnName("Paper11_Slot3");

                entity.Property(e => e.Paper11Slot4).HasColumnName("Paper11_Slot4");

                entity.Property(e => e.Paper11Slot5).HasColumnName("Paper11_Slot5");

                entity.Property(e => e.Paper11Slot6).HasColumnName("Paper11_Slot6");

                entity.Property(e => e.Paper11Slot7).HasColumnName("Paper11_Slot7");

                entity.Property(e => e.Paper11Total).HasColumnName("Paper11_Total");

                entity.Property(e => e.Paper12Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper12_Name");

                entity.Property(e => e.Paper12Slot1).HasColumnName("Paper12_Slot1");

                entity.Property(e => e.Paper12Slot2).HasColumnName("Paper12_Slot2");

                entity.Property(e => e.Paper12Slot3).HasColumnName("Paper12_Slot3");

                entity.Property(e => e.Paper12Slot4).HasColumnName("Paper12_Slot4");

                entity.Property(e => e.Paper12Slot5).HasColumnName("Paper12_Slot5");

                entity.Property(e => e.Paper12Slot6).HasColumnName("Paper12_Slot6");

                entity.Property(e => e.Paper12Slot7).HasColumnName("Paper12_Slot7");

                entity.Property(e => e.Paper12Total).HasColumnName("Paper12_Total");

                entity.Property(e => e.Paper13Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper13_Name");

                entity.Property(e => e.Paper13Slot1).HasColumnName("Paper13_Slot1");

                entity.Property(e => e.Paper13Slot2).HasColumnName("Paper13_Slot2");

                entity.Property(e => e.Paper13Slot3).HasColumnName("Paper13_Slot3");

                entity.Property(e => e.Paper13Slot4).HasColumnName("Paper13_Slot4");

                entity.Property(e => e.Paper13Slot5).HasColumnName("Paper13_Slot5");

                entity.Property(e => e.Paper13Slot6).HasColumnName("Paper13_Slot6");

                entity.Property(e => e.Paper13Slot7).HasColumnName("Paper13_Slot7");

                entity.Property(e => e.Paper13Total).HasColumnName("Paper13_Total");

                entity.Property(e => e.Paper14Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper14_Name");

                entity.Property(e => e.Paper14Slot1).HasColumnName("Paper14_Slot1");

                entity.Property(e => e.Paper14Slot2).HasColumnName("Paper14_Slot2");

                entity.Property(e => e.Paper14Slot3).HasColumnName("Paper14_Slot3");

                entity.Property(e => e.Paper14Slot4).HasColumnName("Paper14_Slot4");

                entity.Property(e => e.Paper14Slot5).HasColumnName("Paper14_Slot5");

                entity.Property(e => e.Paper14Slot6).HasColumnName("Paper14_Slot6");

                entity.Property(e => e.Paper14Slot7).HasColumnName("Paper14_Slot7");

                entity.Property(e => e.Paper14Total).HasColumnName("Paper14_Total");

                entity.Property(e => e.Paper1Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper1_Name");

                entity.Property(e => e.Paper1Slot1).HasColumnName("Paper1_Slot1");

                entity.Property(e => e.Paper1Slot2).HasColumnName("Paper1_Slot2");

                entity.Property(e => e.Paper1Slot3).HasColumnName("Paper1_Slot3");

                entity.Property(e => e.Paper1Slot4).HasColumnName("Paper1_Slot4");

                entity.Property(e => e.Paper1Slot5).HasColumnName("Paper1_Slot5");

                entity.Property(e => e.Paper1Slot6).HasColumnName("Paper1_Slot6");

                entity.Property(e => e.Paper1Slot7).HasColumnName("Paper1_Slot7");

                entity.Property(e => e.Paper1Total).HasColumnName("Paper1_Total");

                entity.Property(e => e.Paper2Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper2_Name");

                entity.Property(e => e.Paper2Slot1).HasColumnName("Paper2_Slot1");

                entity.Property(e => e.Paper2Slot2).HasColumnName("Paper2_Slot2");

                entity.Property(e => e.Paper2Slot3).HasColumnName("Paper2_Slot3");

                entity.Property(e => e.Paper2Slot4).HasColumnName("Paper2_Slot4");

                entity.Property(e => e.Paper2Slot5).HasColumnName("Paper2_Slot5");

                entity.Property(e => e.Paper2Slot6).HasColumnName("Paper2_Slot6");

                entity.Property(e => e.Paper2Slot7).HasColumnName("Paper2_Slot7");

                entity.Property(e => e.Paper2Total).HasColumnName("Paper2_Total");

                entity.Property(e => e.Paper3Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper3_Name");

                entity.Property(e => e.Paper3Slot1).HasColumnName("Paper3_Slot1");

                entity.Property(e => e.Paper3Slot2).HasColumnName("Paper3_Slot2");

                entity.Property(e => e.Paper3Slot3).HasColumnName("Paper3_Slot3");

                entity.Property(e => e.Paper3Slot4).HasColumnName("Paper3_Slot4");

                entity.Property(e => e.Paper3Slot5).HasColumnName("Paper3_Slot5");

                entity.Property(e => e.Paper3Slot6).HasColumnName("Paper3_Slot6");

                entity.Property(e => e.Paper3Slot7).HasColumnName("Paper3_Slot7");

                entity.Property(e => e.Paper3Total).HasColumnName("Paper3_Total");

                entity.Property(e => e.Paper4Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper4_Name");

                entity.Property(e => e.Paper4Slot1).HasColumnName("Paper4_Slot1");

                entity.Property(e => e.Paper4Slot2).HasColumnName("Paper4_Slot2");

                entity.Property(e => e.Paper4Slot3).HasColumnName("Paper4_Slot3");

                entity.Property(e => e.Paper4Slot4).HasColumnName("Paper4_Slot4");

                entity.Property(e => e.Paper4Slot5).HasColumnName("Paper4_Slot5");

                entity.Property(e => e.Paper4Slot6).HasColumnName("Paper4_Slot6");

                entity.Property(e => e.Paper4Slot7).HasColumnName("Paper4_Slot7");

                entity.Property(e => e.Paper4Total).HasColumnName("Paper4_Total");

                entity.Property(e => e.Paper5Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper5_Name");

                entity.Property(e => e.Paper5Slot1).HasColumnName("Paper5_Slot1");

                entity.Property(e => e.Paper5Slot2).HasColumnName("Paper5_Slot2");

                entity.Property(e => e.Paper5Slot3).HasColumnName("Paper5_Slot3");

                entity.Property(e => e.Paper5Slot4).HasColumnName("Paper5_Slot4");

                entity.Property(e => e.Paper5Slot5).HasColumnName("Paper5_Slot5");

                entity.Property(e => e.Paper5Slot6).HasColumnName("Paper5_Slot6");

                entity.Property(e => e.Paper5Slot7).HasColumnName("Paper5_Slot7");

                entity.Property(e => e.Paper5Total).HasColumnName("Paper5_Total");

                entity.Property(e => e.Paper6Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper6_Name");

                entity.Property(e => e.Paper6Slot1).HasColumnName("Paper6_Slot1");

                entity.Property(e => e.Paper6Slot2).HasColumnName("Paper6_Slot2");

                entity.Property(e => e.Paper6Slot3).HasColumnName("Paper6_Slot3");

                entity.Property(e => e.Paper6Slot4).HasColumnName("Paper6_Slot4");

                entity.Property(e => e.Paper6Slot5).HasColumnName("Paper6_Slot5");

                entity.Property(e => e.Paper6Slot6).HasColumnName("Paper6_Slot6");

                entity.Property(e => e.Paper6Slot7).HasColumnName("Paper6_Slot7");

                entity.Property(e => e.Paper6Total).HasColumnName("Paper6_Total");

                entity.Property(e => e.Paper7Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper7_Name");

                entity.Property(e => e.Paper7Slot1).HasColumnName("Paper7_Slot1");

                entity.Property(e => e.Paper7Slot2).HasColumnName("Paper7_Slot2");

                entity.Property(e => e.Paper7Slot3).HasColumnName("Paper7_Slot3");

                entity.Property(e => e.Paper7Slot4).HasColumnName("Paper7_Slot4");

                entity.Property(e => e.Paper7Slot5).HasColumnName("Paper7_Slot5");

                entity.Property(e => e.Paper7Slot6).HasColumnName("Paper7_Slot6");

                entity.Property(e => e.Paper7Slot7).HasColumnName("Paper7_Slot7");

                entity.Property(e => e.Paper7Total).HasColumnName("Paper7_Total");

                entity.Property(e => e.Paper8Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper8_Name");

                entity.Property(e => e.Paper8Slot1).HasColumnName("Paper8_Slot1");

                entity.Property(e => e.Paper8Slot2).HasColumnName("Paper8_Slot2");

                entity.Property(e => e.Paper8Slot3).HasColumnName("Paper8_Slot3");

                entity.Property(e => e.Paper8Slot4).HasColumnName("Paper8_Slot4");

                entity.Property(e => e.Paper8Slot5).HasColumnName("Paper8_Slot5");

                entity.Property(e => e.Paper8Slot6).HasColumnName("Paper8_Slot6");

                entity.Property(e => e.Paper8Slot7).HasColumnName("Paper8_Slot7");

                entity.Property(e => e.Paper8Total).HasColumnName("Paper8_Total");

                entity.Property(e => e.Paper9Name)
                    .IsUnicode(false)
                    .HasColumnName("Paper9_Name");

                entity.Property(e => e.Paper9Slot1).HasColumnName("Paper9_Slot1");

                entity.Property(e => e.Paper9Slot2).HasColumnName("Paper9_Slot2");

                entity.Property(e => e.Paper9Slot3).HasColumnName("Paper9_Slot3");

                entity.Property(e => e.Paper9Slot4).HasColumnName("Paper9_Slot4");

                entity.Property(e => e.Paper9Slot5).HasColumnName("Paper9_Slot5");

                entity.Property(e => e.Paper9Slot6).HasColumnName("Paper9_Slot6");

                entity.Property(e => e.Paper9Slot7).HasColumnName("Paper9_Slot7");

                entity.Property(e => e.Paper9Total).HasColumnName("Paper9_Total");

                entity.Property(e => e.PercSlot1).HasColumnName("Perc_Slot1");

                entity.Property(e => e.PercSlot2).HasColumnName("Perc_Slot2");

                entity.Property(e => e.PercSlot3).HasColumnName("Perc_Slot3");

                entity.Property(e => e.PercSlot4).HasColumnName("Perc_Slot4");

                entity.Property(e => e.PercSlot5).HasColumnName("Perc_Slot5");

                entity.Property(e => e.PercSlot6).HasColumnName("Perc_Slot6");

                entity.Property(e => e.PercSlot7).HasColumnName("Perc_Slot7");

                entity.Property(e => e.PositionSlot1)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot3");

                entity.Property(e => e.PositionSlot4)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot4");

                entity.Property(e => e.PositionSlot5)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot5");

                entity.Property(e => e.PositionSlot6)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot6");

                entity.Property(e => e.PositionSlot7)
                    .HasMaxLength(50)
                    .HasColumnName("Position_Slot7");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");

                entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");

                entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");

                entity.Property(e => e.TotalSlot6).HasColumnName("Total_Slot6");

                entity.Property(e => e.TotalSlot7).HasColumnName("Total_Slot7");
            });

            modelBuilder.Entity<ViewAcademyResultForSm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAcademyResultForSMS");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StuFatherMobile)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherMobile");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.TotalMarks).HasColumnName("Total_Marks");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");
            });

            modelBuilder.Entity<ViewAccountStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAccountStatement");

                entity.Property(e => e.AccountName)
                    .IsUnicode(false)
                    .HasColumnName("accountName");

                entity.Property(e => e.AccountTypeId).HasColumnName("accountTypeID");

                entity.Property(e => e.AccountTypeName)
                    .IsUnicode(false)
                    .HasColumnName("accountTypeName");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ReportingOrder).HasColumnName("reportingOrder");

                entity.Property(e => e.RunningBalance).HasColumnName("runningBalance");
            });

            modelBuilder.Entity<ViewAccountStatement1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAccountStatements");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Details).IsUnicode(false);
            });

            modelBuilder.Entity<ViewActiveStudentsContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewActiveStudentsContacts");

                entity.Property(e => e.AdmissionClass)
                    .IsUnicode(false)
                    .HasColumnName("Admission Class");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Home).IsUnicode(false);

                entity.Property(e => e.Landline).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.StuAdmDate)
                    .HasColumnType("date")
                    .HasColumnName("stuAdmDate");

                entity.Property(e => e.StuDob)
                    .HasColumnType("date")
                    .HasColumnName("stuDOB");

                entity.Property(e => e.StuFatherCnic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherCNIC");

                entity.Property(e => e.StuHomeStreet)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeStreet");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewActiveTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewActiveTeachers");

                entity.Property(e => e.CurrentSalary).HasColumnName("Current Salary");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.LastIncrement)
                    .HasColumnType("date")
                    .HasColumnName("Last Increment");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PrimaryQualification)
                    .IsUnicode(false)
                    .HasColumnName("primaryQualification");
            });

            modelBuilder.Entity<ViewActiveTeachersInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewActiveTeachersInfo");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Cnic)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CurrentGrossSalary).HasColumnName("currentGrossSalary");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.DateOfTermination)
                    .HasColumnType("date")
                    .HasColumnName("dateOfTermination");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Educational).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmergencyContactName)
                    .IsUnicode(false)
                    .HasColumnName("emergencyContactName");

                entity.Property(e => e.EmergencyContactNumber)
                    .IsUnicode(false)
                    .HasColumnName("emergencyContactNumber");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Institute)
                    .IsUnicode(false)
                    .HasColumnName("institute");

                entity.Property(e => e.IsTeacher).HasColumnName("isTeacher");

                entity.Property(e => e.LastIncrementDate)
                    .HasColumnType("date")
                    .HasColumnName("lastIncrementDate");

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objective)
                    .IsUnicode(false)
                    .HasColumnName("objective");

                entity.Property(e => e.Possessive)
                    .IsUnicode(false)
                    .HasColumnName("possessive");

                entity.Property(e => e.Ptcl)
                    .IsUnicode(false)
                    .HasColumnName("PTCL");

                entity.Property(e => e.Qualification).IsUnicode(false);

                entity.Property(e => e.ReasonOfTermination).HasColumnName("reasonOfTermination");

                entity.Property(e => e.RemarksAtJoining)
                    .IsUnicode(false)
                    .HasColumnName("remarksAtJoining");

                entity.Property(e => e.RemarksAtTermination)
                    .IsUnicode(false)
                    .HasColumnName("remarksAtTermination");

                entity.Property(e => e.Subjective)
                    .IsUnicode(false)
                    .HasColumnName("subjective");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.Town)
                    .IsUnicode(false)
                    .HasColumnName("town");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("Town Name");
            });

            modelBuilder.Entity<ViewActualCashReceiving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewActualCashReceivings");

                entity.Property(e => e.CashFee).HasColumnName("Cash Fee");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RegistrationNumber)
                    .IsUnicode(false)
                    .HasColumnName("Registration Number");

                entity.Property(e => e.TuitionFee).HasColumnName("Tuition Fee");
            });

            modelBuilder.Entity<ViewActualPayableFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewActualPayableFee");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.ClassFee).HasColumnName("Class Fee");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PayableFee).HasColumnName("Payable Fee");

                entity.Property(e => e.RegistrationNumber)
                    .IsUnicode(false)
                    .HasColumnName("Registration Number");
            });

            modelBuilder.Entity<ViewAdmissionChargesCollected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAdmissionChargesCollected");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDescription)
                    .IsUnicode(false)
                    .HasColumnName("Fee Description");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewAdmissionSlip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAdmissionSlips");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StuAdmDate)
                    .HasColumnType("date")
                    .HasColumnName("stuAdmDate");

                entity.Property(e => e.StuFatherMobile)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherMobile");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuHomeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeTelNo");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuOfficeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuOfficeTelNo");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");
            });

            modelBuilder.Entity<ViewAdvanceFeeCollected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAdvanceFeeCollected");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeePaid).HasColumnName("feePaid");

                entity.Property(e => e.FeeTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("feeTypeDesc");

                entity.Property(e => e.MonthName)
                    .IsUnicode(false)
                    .HasColumnName("monthName");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewAggregateResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAggregateResult");

                entity.Property(e => e.AggregateObtained).HasColumnName("Aggregate_Obtained");

                entity.Property(e => e.AggregateTotal).HasColumnName("Aggregate_Total");

                entity.Property(e => e.AgriHeconomicsAggregate).HasColumnName("AgriHEconomics_Aggregate");

                entity.Property(e => e.AgriHeconomicsAggregateTotal).HasColumnName("AgriHEconomics_Aggregate_Total");

                entity.Property(e => e.AgriHeconomicsSlot1).HasColumnName("AgriHEconomics_Slot1");

                entity.Property(e => e.AgriHeconomicsSlot2).HasColumnName("AgriHEconomics_Slot2");

                entity.Property(e => e.AgriHeconomicsSlot3).HasColumnName("AgriHEconomics_Slot3");

                entity.Property(e => e.AgriHeconomicsTerm).HasColumnName("AgriHEconomics_Term");

                entity.Property(e => e.AgriHeconomicsTermTotal).HasColumnName("AgriHEconomics_Term_Total");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.ArabicAggregate).HasColumnName("Arabic_Aggregate");

                entity.Property(e => e.ArabicAggregateTotal).HasColumnName("Arabic_Aggregate_Total");

                entity.Property(e => e.ArabicSlot1).HasColumnName("Arabic_Slot1");

                entity.Property(e => e.ArabicSlot2).HasColumnName("Arabic_Slot2");

                entity.Property(e => e.ArabicSlot3).HasColumnName("Arabic_Slot3");

                entity.Property(e => e.ArabicTerm).HasColumnName("Arabic_Term");

                entity.Property(e => e.ArabicTermTotal).HasColumnName("Arabic_Term_Total");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.BehaviorAggregate).HasColumnName("Behavior_Aggregate");

                entity.Property(e => e.BehaviorAggregateTotal).HasColumnName("Behavior_Aggregate_Total");

                entity.Property(e => e.BehaviorSlot1).HasColumnName("Behavior_Slot1");

                entity.Property(e => e.BehaviorSlot2).HasColumnName("Behavior_Slot2");

                entity.Property(e => e.BehaviorSlot3).HasColumnName("Behavior_Slot3");

                entity.Property(e => e.BehaviorTerm).HasColumnName("Behavior_Term");

                entity.Property(e => e.BehaviorTermTotal).HasColumnName("Behavior_Term_Total");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BiologyAggregate).HasColumnName("Biology_Aggregate");

                entity.Property(e => e.BiologyAggregateTotal).HasColumnName("Biology_Aggregate_Total");

                entity.Property(e => e.BiologySlot1).HasColumnName("Biology_Slot1");

                entity.Property(e => e.BiologySlot2).HasColumnName("Biology_Slot2");

                entity.Property(e => e.BiologySlot3).HasColumnName("Biology_Slot3");

                entity.Property(e => e.BiologyTerm).HasColumnName("Biology_Term");

                entity.Property(e => e.BiologyTermTotal).HasColumnName("Biology_Term_Total");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.ChemistryAggregate).HasColumnName("Chemistry_Aggregate");

                entity.Property(e => e.ChemistryAggregateTotal).HasColumnName("Chemistry_Aggregate_Total");

                entity.Property(e => e.ChemistrySlot1).HasColumnName("Chemistry_Slot1");

                entity.Property(e => e.ChemistrySlot2).HasColumnName("Chemistry_Slot2");

                entity.Property(e => e.ChemistrySlot3).HasColumnName("Chemistry_Slot3");

                entity.Property(e => e.ChemistryTerm).HasColumnName("Chemistry_Term");

                entity.Property(e => e.ChemistryTermTotal).HasColumnName("Chemistry_Term_Total");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ComputerAggregate).HasColumnName("Computer_Aggregate");

                entity.Property(e => e.ComputerAggregateTotal).HasColumnName("Computer_Aggregate_Total");

                entity.Property(e => e.ComputerSlot1).HasColumnName("Computer_Slot1");

                entity.Property(e => e.ComputerSlot2).HasColumnName("Computer_Slot2");

                entity.Property(e => e.ComputerSlot3).HasColumnName("Computer_Slot3");

                entity.Property(e => e.ComputerTerm).HasColumnName("Computer_Term");

                entity.Property(e => e.ComputerTermTotal).HasColumnName("Computer_Term_Total");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.EnglishAggregate).HasColumnName("English_Aggregate");

                entity.Property(e => e.EnglishAggregateTotal).HasColumnName("English_Aggregate_Total");

                entity.Property(e => e.EnglishSlot1).HasColumnName("English_Slot1");

                entity.Property(e => e.EnglishSlot2).HasColumnName("English_Slot2");

                entity.Property(e => e.EnglishSlot3).HasColumnName("English_Slot3");

                entity.Property(e => e.EnglishTerm).HasColumnName("English_Term");

                entity.Property(e => e.EnglishTermTotal).HasColumnName("English_Term_Total");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IslamiatAggregate).HasColumnName("Islamiat_Aggregate");

                entity.Property(e => e.IslamiatAggregateTotal).HasColumnName("Islamiat_Aggregate_Total");

                entity.Property(e => e.IslamiatSlot1).HasColumnName("Islamiat_Slot1");

                entity.Property(e => e.IslamiatSlot2).HasColumnName("Islamiat_Slot2");

                entity.Property(e => e.IslamiatSlot3).HasColumnName("Islamiat_Slot3");

                entity.Property(e => e.IslamiatTerm).HasColumnName("Islamiat_Term");

                entity.Property(e => e.IslamiatTermTotal).HasColumnName("Islamiat_Term_Total");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.MathematicsAggregate).HasColumnName("Mathematics_Aggregate");

                entity.Property(e => e.MathematicsAggregateTotal).HasColumnName("Mathematics_Aggregate_Total");

                entity.Property(e => e.MathematicsSlot1).HasColumnName("Mathematics_Slot1");

                entity.Property(e => e.MathematicsSlot2).HasColumnName("Mathematics_Slot2");

                entity.Property(e => e.MathematicsSlot3).HasColumnName("Mathematics_Slot3");

                entity.Property(e => e.MathematicsTerm).HasColumnName("Mathematics_Term");

                entity.Property(e => e.MathematicsTermTotal).HasColumnName("Mathematics_Term_Total");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.PhysicsAggregate).HasColumnName("Physics_Aggregate");

                entity.Property(e => e.PhysicsAggregateTotal).HasColumnName("Physics_Aggregate_Total");

                entity.Property(e => e.PhysicsSlot1).HasColumnName("Physics_Slot1");

                entity.Property(e => e.PhysicsSlot2).HasColumnName("Physics_Slot2");

                entity.Property(e => e.PhysicsSlot3).HasColumnName("Physics_Slot3");

                entity.Property(e => e.PhysicsTerm).HasColumnName("Physics_Term");

                entity.Property(e => e.PhysicsTermTotal).HasColumnName("Physics_Term_Total");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.PositionClass).HasColumnName("Position_Class");

                entity.Property(e => e.PositionOverall).HasColumnName("Position_Overall");

                entity.Property(e => e.QuranAggregate).HasColumnName("Quran_Aggregate");

                entity.Property(e => e.QuranAggregateTotal).HasColumnName("Quran_Aggregate_Total");

                entity.Property(e => e.QuranSlot1).HasColumnName("Quran_Slot1");

                entity.Property(e => e.QuranSlot2).HasColumnName("Quran_Slot2");

                entity.Property(e => e.QuranSlot3).HasColumnName("Quran_Slot3");

                entity.Property(e => e.QuranTerm).HasColumnName("Quran_Term");

                entity.Property(e => e.QuranTermTotal).HasColumnName("Quran_Term_Total");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScienceAggregate).HasColumnName("Science_Aggregate");

                entity.Property(e => e.ScienceAggregateTotal).HasColumnName("Science_Aggregate_Total");

                entity.Property(e => e.ScienceSlot1).HasColumnName("Science_Slot1");

                entity.Property(e => e.ScienceSlot2).HasColumnName("Science_Slot2");

                entity.Property(e => e.ScienceSlot3).HasColumnName("Science_Slot3");

                entity.Property(e => e.ScienceTerm).HasColumnName("Science_Term");

                entity.Property(e => e.ScienceTermTotal).HasColumnName("Science_Term_Total");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.SocialStudiesAggregate).HasColumnName("SocialStudies_Aggregate");

                entity.Property(e => e.SocialStudiesAggregateTotal).HasColumnName("SocialStudies_Aggregate_Total");

                entity.Property(e => e.SocialStudiesSlot1).HasColumnName("SocialStudies_Slot1");

                entity.Property(e => e.SocialStudiesSlot2).HasColumnName("SocialStudies_Slot2");

                entity.Property(e => e.SocialStudiesSlot3).HasColumnName("SocialStudies_Slot3");

                entity.Property(e => e.SocialStudiesTerm).HasColumnName("SocialStudies_Term");

                entity.Property(e => e.SocialStudiesTermTotal).HasColumnName("SocialStudies_Term_Total");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.UrduAggregate).HasColumnName("Urdu_Aggregate");

                entity.Property(e => e.UrduAggregateTotal).HasColumnName("Urdu_Aggregate_Total");

                entity.Property(e => e.UrduSlot1).HasColumnName("Urdu_Slot1");

                entity.Property(e => e.UrduSlot2).HasColumnName("Urdu_Slot2");

                entity.Property(e => e.UrduSlot3).HasColumnName("Urdu_Slot3");

                entity.Property(e => e.UrduTerm).HasColumnName("Urdu_Term");

                entity.Property(e => e.UrduTermTotal).HasColumnName("Urdu_Term_Total");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");
            });

            modelBuilder.Entity<ViewAnnualChargesCollected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAnnualChargesCollected");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDescription)
                    .IsUnicode(false)
                    .HasColumnName("Fee Description");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewAnswerSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAnswerSheets");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.DateIssued)
                    .HasColumnType("date")
                    .HasColumnName("dateIssued");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("date")
                    .HasColumnName("dateReceived");

                entity.Property(e => e.ExamDescription)
                    .IsUnicode(false)
                    .HasColumnName("examDescription");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.WingDesc)
                    .IsUnicode(false)
                    .HasColumnName("wingDesc");

                entity.Property(e => e.WingId).HasColumnName("wingID");
            });

            modelBuilder.Entity<ViewAppointmentLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewAppointmentLetters");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.FacultyId)
                    .IsUnicode(false)
                    .HasColumnName("facultyID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("fatherName");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IsTeacher).HasColumnName("isTeacher");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Objective)
                    .IsUnicode(false)
                    .HasColumnName("objective");

                entity.Property(e => e.Possessive)
                    .IsUnicode(false)
                    .HasColumnName("possessive");

                entity.Property(e => e.StartingSalary).HasColumnName("startingSalary");

                entity.Property(e => e.StreetAddress)
                    .IsUnicode(false)
                    .HasColumnName("streetAddress");

                entity.Property(e => e.Subjective)
                    .IsUnicode(false)
                    .HasColumnName("subjective");

                entity.Property(e => e.Town)
                    .IsUnicode(false)
                    .HasColumnName("town");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("townName");
            });

            modelBuilder.Entity<ViewBankStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewBankStatements");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details).IsUnicode(false);
            });

            modelBuilder.Entity<ViewBehavioralIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewBehavioralIssues");

                entity.Property(e => e.BehIssueDesc)
                    .IsUnicode(false)
                    .HasColumnName("behIssueDesc");

                entity.Property(e => e.BehIssueId).HasColumnName("behIssueId");

                entity.Property(e => e.EntityDesc)
                    .IsUnicode(false)
                    .HasColumnName("entityDesc");

                entity.Property(e => e.PertainsTo).HasColumnName("pertainsTo");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<ViewCashReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCashReport");

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.NameOfAccount)
                    .IsUnicode(false)
                    .HasColumnName("Name of Account");
            });

            modelBuilder.Entity<ViewClassTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewClassTeachers");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("Class Name");

                entity.Property(e => e.TeacherName)
                    .IsUnicode(false)
                    .HasColumnName("Teacher Name");
            });

            modelBuilder.Entity<ViewClasswiseFeeStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewClasswiseFeeStructure");

                entity.Property(e => e.AdmissionFee).HasColumnName("Admission Fee");

                entity.Property(e => e.AnnualCharges).HasColumnName("Annual Charges");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SecurityDeposit).HasColumnName("Security Deposit");

                entity.Property(e => e.TuitionFee).HasColumnName("Tuition Fee");
            });

            modelBuilder.Entity<ViewCombinedResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewCombinedResults");

                entity.Property(e => e.AgriHeconomicsSlot1).HasColumnName("AgriHEconomics_Slot1");

                entity.Property(e => e.AgriHeconomicsSlot2).HasColumnName("AgriHEconomics_Slot2");

                entity.Property(e => e.AgriHeconomicsSlot3).HasColumnName("AgriHEconomics_Slot3");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.ArabicSlot1).HasColumnName("Arabic_Slot1");

                entity.Property(e => e.ArabicSlot2).HasColumnName("Arabic_Slot2");

                entity.Property(e => e.ArabicSlot3).HasColumnName("Arabic_Slot3");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.BehaviorSlot1).HasColumnName("Behavior_Slot1");

                entity.Property(e => e.BehaviorSlot2).HasColumnName("Behavior_Slot2");

                entity.Property(e => e.BehaviorSlot3).HasColumnName("Behavior_Slot3");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BiologySlot1).HasColumnName("Biology_Slot1");

                entity.Property(e => e.BiologySlot2).HasColumnName("Biology_Slot2");

                entity.Property(e => e.BiologySlot3).HasColumnName("Biology_Slot3");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.ChemistrySlot1).HasColumnName("Chemistry_Slot1");

                entity.Property(e => e.ChemistrySlot2).HasColumnName("Chemistry_Slot2");

                entity.Property(e => e.ChemistrySlot3).HasColumnName("Chemistry_Slot3");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ComputerSlot1).HasColumnName("Computer_Slot1");

                entity.Property(e => e.ComputerSlot2).HasColumnName("Computer_Slot2");

                entity.Property(e => e.ComputerSlot3).HasColumnName("Computer_Slot3");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.EnglishSlot1).HasColumnName("English_Slot1");

                entity.Property(e => e.EnglishSlot2).HasColumnName("English_Slot2");

                entity.Property(e => e.EnglishSlot3).HasColumnName("English_Slot3");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.GradeSlot1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.IslamiatSlot1).HasColumnName("Islamiat_Slot1");

                entity.Property(e => e.IslamiatSlot2).HasColumnName("Islamiat_Slot2");

                entity.Property(e => e.IslamiatSlot3).HasColumnName("Islamiat_Slot3");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.MathematicsSlot1).HasColumnName("Mathematics_Slot1");

                entity.Property(e => e.MathematicsSlot2).HasColumnName("Mathematics_Slot2");

                entity.Property(e => e.MathematicsSlot3).HasColumnName("Mathematics_Slot3");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.PhysicsSlot1).HasColumnName("Physics_Slot1");

                entity.Property(e => e.PhysicsSlot2).HasColumnName("Physics_Slot2");

                entity.Property(e => e.PhysicsSlot3).HasColumnName("Physics_Slot3");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.PositionSlot1).HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2).HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3).HasColumnName("Position_Slot3");

                entity.Property(e => e.QuranSlot1).HasColumnName("Quran_Slot1");

                entity.Property(e => e.QuranSlot2).HasColumnName("Quran_Slot2");

                entity.Property(e => e.QuranSlot3).HasColumnName("Quran_Slot3");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScienceSlot1).HasColumnName("Science_Slot1");

                entity.Property(e => e.ScienceSlot2).HasColumnName("Science_Slot2");

                entity.Property(e => e.ScienceSlot3).HasColumnName("Science_Slot3");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.SocialStudiesSlot1).HasColumnName("SocialStudies_Slot1");

                entity.Property(e => e.SocialStudiesSlot2).HasColumnName("SocialStudies_Slot2");

                entity.Property(e => e.SocialStudiesSlot3).HasColumnName("SocialStudies_Slot3");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");

                entity.Property(e => e.UrduSlot1).HasColumnName("Urdu_Slot1");

                entity.Property(e => e.UrduSlot2).HasColumnName("Urdu_Slot2");

                entity.Property(e => e.UrduSlot3).HasColumnName("Urdu_Slot3");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");
            });

            modelBuilder.Entity<ViewDefaulter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewDefaulters");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.FeeDue).HasColumnName("feeDue");

                entity.Property(e => e.FeeMonthId).HasColumnName("feeMonthID");

                entity.Property(e => e.FeePaid).HasColumnName("feePaid");

                entity.Property(e => e.FeeTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("feeTypeDesc");

                entity.Property(e => e.FeeUnpaid).HasColumnName("feeUnpaid");

                entity.Property(e => e.MonthName)
                    .IsUnicode(false)
                    .HasColumnName("monthName");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.WingDesc)
                    .IsUnicode(false)
                    .HasColumnName("wingDesc");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewExamResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewExamResults");

                entity.Property(e => e.ActualMarks).HasColumnName("actualMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.MarksObtained).HasColumnName("marksObtained");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewExamSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewExamSubjects");

                entity.Property(e => e.ExamDescription)
                    .IsUnicode(false)
                    .HasColumnName("examDescription");

                entity.Property(e => e.ExamTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("examTypeDesc");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewFeeReceivable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFeeReceivable");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDue).HasColumnName("Fee Due");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("Fee Month");

                entity.Property(e => e.FeeRemarks)
                    .IsUnicode(false)
                    .HasColumnName("feeRemarks");

                entity.Property(e => e.FeeType)
                    .IsUnicode(false)
                    .HasColumnName("Fee Type");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.FeeUnpaid).HasColumnName("Fee Unpaid");

                entity.Property(e => e.FeeYear).HasColumnName("Fee Year");

                entity.Property(e => e.Home).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.StuFeeReminderRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuFeeReminderRemarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuOfficeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuOfficeTelNo");

                entity.Property(e => e.Wing).IsUnicode(false);

                entity.Property(e => e.WingId).HasColumnName("wingID");
            });

            modelBuilder.Entity<ViewFeeReceivableInactiveStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFeeReceivableInactiveStudents");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDue).HasColumnName("Fee Due");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("Fee Month");

                entity.Property(e => e.FeeType)
                    .IsUnicode(false)
                    .HasColumnName("Fee Type");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.FeeUnpaid).HasColumnName("Fee Unpaid");

                entity.Property(e => e.FeeYear).HasColumnName("Fee Year");

                entity.Property(e => e.Home).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.StuFeeReminderRemarks)
                    .IsUnicode(false)
                    .HasColumnName("stuFeeReminderRemarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuOfficeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuOfficeTelNo");

                entity.Property(e => e.Wing).IsUnicode(false);

                entity.Property(e => e.WingId).HasColumnName("wingID");
            });

            modelBuilder.Entity<ViewFeeVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFeeVouchers");

                entity.Property(e => e.AnnualChargesDue).HasColumnName("annualChargesDue");

                entity.Property(e => e.ArrearsOfFee).HasColumnName("arrearsOfFee");

                entity.Property(e => e.CurrentFeeDue).HasColumnName("currentFeeDue");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.FeeMonth)
                    .IsUnicode(false)
                    .HasColumnName("feeMonth");

                entity.Property(e => e.FeeNotice)
                    .IsUnicode(false)
                    .HasColumnName("feeNotice");

                entity.Property(e => e.FeeUnpaidMonths)
                    .IsUnicode(false)
                    .HasColumnName("feeUnpaidMonths");

                entity.Property(e => e.FeeVoucherId).HasColumnName("feeVoucherID");

                entity.Property(e => e.FeeYear)
                    .IsUnicode(false)
                    .HasColumnName("feeYear");

                entity.Property(e => e.OtherNotices)
                    .IsUnicode(false)
                    .HasColumnName("otherNotices");

                entity.Property(e => e.StuDob)
                    .HasColumnType("date")
                    .HasColumnName("stuDOB");

                entity.Property(e => e.StuEmail)
                    .IsUnicode(false)
                    .HasColumnName("stuEmail");

                entity.Property(e => e.StuFatherCnic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherCNIC");

                entity.Property(e => e.StuFatherMobile)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherMobile");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuHomeStreet)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeStreet");

                entity.Property(e => e.StuHomeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuHomeTelNo");

                entity.Property(e => e.StuOfficeTelNo)
                    .IsUnicode(false)
                    .HasColumnName("stuOfficeTelNo");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.StudentClass)
                    .IsUnicode(false)
                    .HasColumnName("studentClass");

                entity.Property(e => e.StudentId)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.Property(e => e.StudentName)
                    .IsUnicode(false)
                    .HasColumnName("studentName");

                entity.Property(e => e.TotalFeeDue).HasColumnName("totalFeeDue");
            });

            modelBuilder.Entity<ViewFeeVouchersNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewFeeVouchersNew");

                entity.Property(e => e.AcchargesDue).HasColumnName("ACChargesDue");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FatherCnic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FatherCNIC");

                entity.Property(e => e.FatherName).IsUnicode(false);

                entity.Property(e => e.FeeMonth).IsUnicode(false);

                entity.Property(e => e.FeeYear).IsUnicode(false);

                entity.Property(e => e.HomeTelephone).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Notice1).IsUnicode(false);

                entity.Property(e => e.Notice2).IsUnicode(false);

                entity.Property(e => e.OfficeTelephone).IsUnicode(false);

                entity.Property(e => e.RegNum).IsUnicode(false);

                entity.Property(e => e.StudentClass).IsUnicode(false);

                entity.Property(e => e.StudentId)
                    .IsUnicode(false)
                    .HasColumnName("StudentID");

                entity.Property(e => e.StudentName).IsUnicode(false);

                entity.Property(e => e.UnpaidMonths).IsUnicode(false);

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<ViewGeographicalDistOfStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewGeographicalDistOfStudents");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Town).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewInquiry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewInquiries");

                entity.Property(e => e.AdmissionFee).HasColumnName("admissionFee");

                entity.Property(e => e.AnnualCharges).HasColumnName("annualCharges");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ContactNumber)
                    .IsUnicode(false)
                    .HasColumnName("contactNumber");

                entity.Property(e => e.DateOfInquiry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfInquiry");

                entity.Property(e => e.SecurityDeposits).HasColumnName("securityDeposits");

                entity.Property(e => e.StAddress)
                    .IsUnicode(false)
                    .HasColumnName("stAddress");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuInqId).HasColumnName("stuInqID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("townName");

                entity.Property(e => e.TuitionFee).HasColumnName("tuitionFee");
            });

            modelBuilder.Entity<ViewMarksList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewMarksLists");

                entity.Property(e => e.AgriHe)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Agri_HE");

                entity.Property(e => e.Arabic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Behav).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Biology).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Chemistry).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.Comp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.English).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExamName).IsUnicode(false);

                entity.Property(e => e.Islamiat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Maths).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Physics).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quran).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Science).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SSt");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Urdu).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ViewOldStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewOldStaff");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.EducationalQualification)
                    .IsUnicode(false)
                    .HasColumnName("Educational Qualification");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.MobileNumber)
                    .IsUnicode(false)
                    .HasColumnName("Mobile Number");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PrimaryQualification)
                    .IsUnicode(false)
                    .HasColumnName("Primary Qualification");

                entity.Property(e => e.Ptcl)
                    .IsUnicode(false)
                    .HasColumnName("PTCL");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("townName");
            });

            modelBuilder.Entity<ViewPotentialTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewPotentialTeachers");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.MobileNumber)
                    .IsUnicode(false)
                    .HasColumnName("Mobile Number");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PrimarySubject)
                    .IsUnicode(false)
                    .HasColumnName("Primary Subject");

                entity.Property(e => e.PrimarySubject1).HasColumnName("primarySubject");

                entity.Property(e => e.Ptcl)
                    .IsUnicode(false)
                    .HasColumnName("PTCL");

                entity.Property(e => e.RemarksAtJoining)
                    .IsUnicode(false)
                    .HasColumnName("remarksAtJoining");

                entity.Property(e => e.SecondarySubject)
                    .IsUnicode(false)
                    .HasColumnName("Secondary Subject");

                entity.Property(e => e.SecondarySubject1).HasColumnName("secondarySubject");

                entity.Property(e => e.Town).IsUnicode(false);
            });

            modelBuilder.Entity<ViewQuestionCategoryAssociation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewQuestionCategoryAssociation");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.QuestionCategoryId).HasColumnName("questionCategoryID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");
            });

            modelBuilder.Entity<ViewQuestionsSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewQuestionsSummary");

                entity.Property(e => e.ChapterDescription).HasColumnName("chapterDescription");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewResultTestSeries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewResultTestSeries");

                entity.Property(e => e.AgriHeconomicsFullBook).HasColumnName("AgriHEconomics_FullBook");

                entity.Property(e => e.AgriHeconomicsHalfBook1).HasColumnName("AgriHEconomics_HalfBook1");

                entity.Property(e => e.AgriHeconomicsHalfBook2).HasColumnName("AgriHEconomics_HalfBook2");

                entity.Property(e => e.AgriHeconomicsSlot1).HasColumnName("AgriHEconomics_Slot1");

                entity.Property(e => e.AgriHeconomicsSlot2).HasColumnName("AgriHEconomics_Slot2");

                entity.Property(e => e.AgriHeconomicsSlot3).HasColumnName("AgriHEconomics_Slot3");

                entity.Property(e => e.AgriHeconomicsSlot4).HasColumnName("AgriHEconomics_Slot4");

                entity.Property(e => e.AgriHeconomicsSlot5).HasColumnName("AgriHEconomics_Slot5");

                entity.Property(e => e.AgriHeconomicsTotal).HasColumnName("AgriHEconomics_Total");

                entity.Property(e => e.AgriHeconomicsTotalHalfFull).HasColumnName("AgriHEconomics_TotalHalfFull");

                entity.Property(e => e.ArabicFullBook).HasColumnName("Arabic_FullBook");

                entity.Property(e => e.ArabicHalfBook1).HasColumnName("Arabic_HalfBook1");

                entity.Property(e => e.ArabicHalfBook2).HasColumnName("Arabic_HalfBook2");

                entity.Property(e => e.ArabicSlot1).HasColumnName("Arabic_Slot1");

                entity.Property(e => e.ArabicSlot2).HasColumnName("Arabic_Slot2");

                entity.Property(e => e.ArabicSlot3).HasColumnName("Arabic_Slot3");

                entity.Property(e => e.ArabicSlot4).HasColumnName("Arabic_Slot4");

                entity.Property(e => e.ArabicSlot5).HasColumnName("Arabic_Slot5");

                entity.Property(e => e.ArabicTotal).HasColumnName("Arabic_Total");

                entity.Property(e => e.ArabicTotalHalfFull).HasColumnName("Arabic_TotalHalfFull");

                entity.Property(e => e.BehaviorFullBook).HasColumnName("Behavior_FullBook");

                entity.Property(e => e.BehaviorHalfBook1).HasColumnName("Behavior_HalfBook1");

                entity.Property(e => e.BehaviorHalfBook2).HasColumnName("Behavior_HalfBook2");

                entity.Property(e => e.BehaviorSlot1).HasColumnName("Behavior_Slot1");

                entity.Property(e => e.BehaviorSlot2).HasColumnName("Behavior_Slot2");

                entity.Property(e => e.BehaviorSlot3).HasColumnName("Behavior_Slot3");

                entity.Property(e => e.BehaviorSlot4).HasColumnName("Behavior_Slot4");

                entity.Property(e => e.BehaviorSlot5).HasColumnName("Behavior_Slot5");

                entity.Property(e => e.BehaviorTotal).HasColumnName("Behavior_Total");

                entity.Property(e => e.BehaviorTotalHalfFull).HasColumnName("Behavior_TotalHalfFull");

                entity.Property(e => e.BiologyFullBook).HasColumnName("Biology_FullBook");

                entity.Property(e => e.BiologyHalfBook1).HasColumnName("Biology_HalfBook1");

                entity.Property(e => e.BiologyHalfBook2).HasColumnName("Biology_HalfBook2");

                entity.Property(e => e.BiologySlot1).HasColumnName("Biology_Slot1");

                entity.Property(e => e.BiologySlot2).HasColumnName("Biology_Slot2");

                entity.Property(e => e.BiologySlot3).HasColumnName("Biology_Slot3");

                entity.Property(e => e.BiologySlot4).HasColumnName("Biology_Slot4");

                entity.Property(e => e.BiologySlot5).HasColumnName("Biology_Slot5");

                entity.Property(e => e.BiologyTotal).HasColumnName("Biology_Total");

                entity.Property(e => e.BiologyTotalHalfFull).HasColumnName("Biology_TotalHalfFull");

                entity.Property(e => e.ChemistryFullBook).HasColumnName("Chemistry_FullBook");

                entity.Property(e => e.ChemistryHalfBook1).HasColumnName("Chemistry_HalfBook1");

                entity.Property(e => e.ChemistryHalfBook2).HasColumnName("Chemistry_HalfBook2");

                entity.Property(e => e.ChemistrySlot1).HasColumnName("Chemistry_Slot1");

                entity.Property(e => e.ChemistrySlot2).HasColumnName("Chemistry_Slot2");

                entity.Property(e => e.ChemistrySlot3).HasColumnName("Chemistry_Slot3");

                entity.Property(e => e.ChemistrySlot4).HasColumnName("Chemistry_Slot4");

                entity.Property(e => e.ChemistrySlot5).HasColumnName("Chemistry_Slot5");

                entity.Property(e => e.ChemistryTotal).HasColumnName("Chemistry_Total");

                entity.Property(e => e.ChemistryTotalHalfFull).HasColumnName("Chemistry_TotalHalfFull");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ComputerFullBook).HasColumnName("Computer_FullBook");

                entity.Property(e => e.ComputerHalfBook1).HasColumnName("Computer_HalfBook1");

                entity.Property(e => e.ComputerHalfBook2).HasColumnName("Computer_HalfBook2");

                entity.Property(e => e.ComputerSlot1).HasColumnName("Computer_Slot1");

                entity.Property(e => e.ComputerSlot2).HasColumnName("Computer_Slot2");

                entity.Property(e => e.ComputerSlot3).HasColumnName("Computer_Slot3");

                entity.Property(e => e.ComputerSlot4).HasColumnName("Computer_Slot4");

                entity.Property(e => e.ComputerSlot5).HasColumnName("Computer_Slot5");

                entity.Property(e => e.ComputerTotal).HasColumnName("Computer_Total");

                entity.Property(e => e.ComputerTotalHalfFull).HasColumnName("Computer_TotalHalfFull");

                entity.Property(e => e.EnglishFullBook).HasColumnName("English_FullBook");

                entity.Property(e => e.EnglishHalfBook1).HasColumnName("English_HalfBook1");

                entity.Property(e => e.EnglishHalfBook2).HasColumnName("English_HalfBook2");

                entity.Property(e => e.EnglishSlot1).HasColumnName("English_Slot1");

                entity.Property(e => e.EnglishSlot2).HasColumnName("English_Slot2");

                entity.Property(e => e.EnglishSlot3).HasColumnName("English_Slot3");

                entity.Property(e => e.EnglishSlot4).HasColumnName("English_Slot4");

                entity.Property(e => e.EnglishSlot5).HasColumnName("English_Slot5");

                entity.Property(e => e.EnglishTotal).HasColumnName("English_Total");

                entity.Property(e => e.EnglishTotalHalfFull).HasColumnName("English_TotalHalfFull");

                entity.Property(e => e.GradeFullBook)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_FullBook");

                entity.Property(e => e.GradeHalfBook1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HalfBook1");

                entity.Property(e => e.GradeHalfBook2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_HalfBook2");

                entity.Property(e => e.GradeSlot1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot1");

                entity.Property(e => e.GradeSlot2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot2");

                entity.Property(e => e.GradeSlot3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot3");

                entity.Property(e => e.GradeSlot4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot4");

                entity.Property(e => e.GradeSlot5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Slot5");

                entity.Property(e => e.IslamiatFullBook).HasColumnName("Islamiat_FullBook");

                entity.Property(e => e.IslamiatHalfBook1).HasColumnName("Islamiat_HalfBook1");

                entity.Property(e => e.IslamiatHalfBook2).HasColumnName("Islamiat_HalfBook2");

                entity.Property(e => e.IslamiatSlot1).HasColumnName("Islamiat_Slot1");

                entity.Property(e => e.IslamiatSlot2).HasColumnName("Islamiat_Slot2");

                entity.Property(e => e.IslamiatSlot3).HasColumnName("Islamiat_Slot3");

                entity.Property(e => e.IslamiatSlot4).HasColumnName("Islamiat_Slot4");

                entity.Property(e => e.IslamiatSlot5).HasColumnName("Islamiat_Slot5");

                entity.Property(e => e.IslamiatTotal).HasColumnName("Islamiat_Total");

                entity.Property(e => e.IslamiatTotalHalfFull).HasColumnName("Islamiat_TotalHalfFull");

                entity.Property(e => e.MathematicsFullBook).HasColumnName("Mathematics_FullBook");

                entity.Property(e => e.MathematicsHalfBook1).HasColumnName("Mathematics_HalfBook1");

                entity.Property(e => e.MathematicsHalfBook2).HasColumnName("Mathematics_HalfBook2");

                entity.Property(e => e.MathematicsSlot1).HasColumnName("Mathematics_Slot1");

                entity.Property(e => e.MathematicsSlot2).HasColumnName("Mathematics_Slot2");

                entity.Property(e => e.MathematicsSlot3).HasColumnName("Mathematics_Slot3");

                entity.Property(e => e.MathematicsSlot4).HasColumnName("Mathematics_Slot4");

                entity.Property(e => e.MathematicsSlot5).HasColumnName("Mathematics_Slot5");

                entity.Property(e => e.MathematicsTotal).HasColumnName("Mathematics_Total");

                entity.Property(e => e.MathematicsTotalHalfFull).HasColumnName("Mathematics_TotalHalfFull");

                entity.Property(e => e.PhysicsFullBook).HasColumnName("Physics_FullBook");

                entity.Property(e => e.PhysicsHalfBook1).HasColumnName("Physics_HalfBook1");

                entity.Property(e => e.PhysicsHalfBook2).HasColumnName("Physics_HalfBook2");

                entity.Property(e => e.PhysicsSlot1).HasColumnName("Physics_Slot1");

                entity.Property(e => e.PhysicsSlot2).HasColumnName("Physics_Slot2");

                entity.Property(e => e.PhysicsSlot3).HasColumnName("Physics_Slot3");

                entity.Property(e => e.PhysicsSlot4).HasColumnName("Physics_Slot4");

                entity.Property(e => e.PhysicsSlot5).HasColumnName("Physics_Slot5");

                entity.Property(e => e.PhysicsTotal).HasColumnName("Physics_Total");

                entity.Property(e => e.PhysicsTotalHalfFull).HasColumnName("Physics_TotalHalfFull");

                entity.Property(e => e.PositionFullBook).HasColumnName("Position_FullBook");

                entity.Property(e => e.PositionHalfBook1).HasColumnName("Position_HalfBook1");

                entity.Property(e => e.PositionHalfBook2).HasColumnName("Position_HalfBook2");

                entity.Property(e => e.PositionSlot1).HasColumnName("Position_Slot1");

                entity.Property(e => e.PositionSlot2).HasColumnName("Position_Slot2");

                entity.Property(e => e.PositionSlot3).HasColumnName("Position_Slot3");

                entity.Property(e => e.PositionSlot4).HasColumnName("Position_Slot4");

                entity.Property(e => e.PositionSlot5).HasColumnName("Position_Slot5");

                entity.Property(e => e.QuranFullBook).HasColumnName("Quran_FullBook");

                entity.Property(e => e.QuranHalfBook1).HasColumnName("Quran_HalfBook1");

                entity.Property(e => e.QuranHalfBook2).HasColumnName("Quran_HalfBook2");

                entity.Property(e => e.QuranSlot1).HasColumnName("Quran_Slot1");

                entity.Property(e => e.QuranSlot2).HasColumnName("Quran_Slot2");

                entity.Property(e => e.QuranSlot3).HasColumnName("Quran_Slot3");

                entity.Property(e => e.QuranSlot4).HasColumnName("Quran_Slot4");

                entity.Property(e => e.QuranSlot5).HasColumnName("Quran_Slot5");

                entity.Property(e => e.QuranTotal).HasColumnName("Quran_Total");

                entity.Property(e => e.QuranTotalHalfFull).HasColumnName("Quran_TotalHalfFull");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScienceFullBook).HasColumnName("Science_FullBook");

                entity.Property(e => e.ScienceHalfBook1).HasColumnName("Science_HalfBook1");

                entity.Property(e => e.ScienceHalfBook2).HasColumnName("Science_HalfBook2");

                entity.Property(e => e.ScienceSlot1).HasColumnName("Science_Slot1");

                entity.Property(e => e.ScienceSlot2).HasColumnName("Science_Slot2");

                entity.Property(e => e.ScienceSlot3).HasColumnName("Science_Slot3");

                entity.Property(e => e.ScienceSlot4).HasColumnName("Science_Slot4");

                entity.Property(e => e.ScienceSlot5).HasColumnName("Science_Slot5");

                entity.Property(e => e.ScienceTotal).HasColumnName("Science_Total");

                entity.Property(e => e.ScienceTotalHalfFull).HasColumnName("Science_TotalHalfFull");

                entity.Property(e => e.SocialStudiesFullBook).HasColumnName("SocialStudies_FullBook");

                entity.Property(e => e.SocialStudiesHalfBook1).HasColumnName("SocialStudies_HalfBook1");

                entity.Property(e => e.SocialStudiesHalfBook2).HasColumnName("SocialStudies_HalfBook2");

                entity.Property(e => e.SocialStudiesSlot1).HasColumnName("SocialStudies_Slot1");

                entity.Property(e => e.SocialStudiesSlot2).HasColumnName("SocialStudies_Slot2");

                entity.Property(e => e.SocialStudiesSlot3).HasColumnName("SocialStudies_Slot3");

                entity.Property(e => e.SocialStudiesSlot4).HasColumnName("SocialStudies_Slot4");

                entity.Property(e => e.SocialStudiesSlot5).HasColumnName("SocialStudies_Slot5");

                entity.Property(e => e.SocialStudiesTotal).HasColumnName("SocialStudies_Total");

                entity.Property(e => e.SocialStudiesTotalHalfFull).HasColumnName("SocialStudies_TotalHalfFull");

                entity.Property(e => e.StuCurrentWing).HasColumnName("stuCurrentWing");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.TotalFullBook).HasColumnName("Total_FullBook");

                entity.Property(e => e.TotalHalfBook1).HasColumnName("Total_HalfBook1");

                entity.Property(e => e.TotalHalfBook2).HasColumnName("Total_HalfBook2");

                entity.Property(e => e.TotalHalfFull).HasColumnName("Total_HalfFull");

                entity.Property(e => e.TotalSlot1).HasColumnName("Total_Slot1");

                entity.Property(e => e.TotalSlot2).HasColumnName("Total_Slot2");

                entity.Property(e => e.TotalSlot3).HasColumnName("Total_Slot3");

                entity.Property(e => e.TotalSlot4).HasColumnName("Total_Slot4");

                entity.Property(e => e.TotalSlot5).HasColumnName("Total_Slot5");

                entity.Property(e => e.UrduFullBook).HasColumnName("Urdu_FullBook");

                entity.Property(e => e.UrduHalfBook1).HasColumnName("Urdu_HalfBook1");

                entity.Property(e => e.UrduHalfBook2).HasColumnName("Urdu_HalfBook2");

                entity.Property(e => e.UrduSlot1).HasColumnName("Urdu_Slot1");

                entity.Property(e => e.UrduSlot2).HasColumnName("Urdu_Slot2");

                entity.Property(e => e.UrduSlot3).HasColumnName("Urdu_Slot3");

                entity.Property(e => e.UrduSlot4).HasColumnName("Urdu_Slot4");

                entity.Property(e => e.UrduSlot5).HasColumnName("Urdu_Slot5");

                entity.Property(e => e.UrduTotal).HasColumnName("Urdu_Total");

                entity.Property(e => e.UrduTotalHalfFull).HasColumnName("Urdu_TotalHalfFull");
            });

            modelBuilder.Entity<ViewSalarySheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSalarySheet");

                entity.Property(e => e.Absents).HasColumnName("absents");

                entity.Property(e => e.AdvanceSalary).HasColumnName("Advance Salary");

                entity.Property(e => e.Allowances).HasColumnName("allowances");

                entity.Property(e => e.AlreadyAvailedLeaves).HasColumnName("alreadyAvailedLeaves");

                entity.Property(e => e.BasicSalary).HasColumnName("Basic Salary");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.EmergencyLeaves).HasColumnName("emergencyLeaves");

                entity.Property(e => e.FacultyId)
                    .IsUnicode(false)
                    .HasColumnName("facultyID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Lates).HasColumnName("lates");

                entity.Property(e => e.LeaveDeductions).HasColumnName("Leave Deductions");

                entity.Property(e => e.LeavesDeducted).HasColumnName("leavesDeducted");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NetSalary).HasColumnName("netSalary");

                entity.Property(e => e.OtherDeductions).HasColumnName("Other Deductions");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SalaryYear).HasColumnName("Salary Year");

                entity.Property(e => e.ShortLeaves).HasColumnName("shortLeaves");

                entity.Property(e => e.ShortName)
                    .IsUnicode(false)
                    .HasColumnName("Short Name");

                entity.Property(e => e.TaxDeductions).HasColumnName("Tax Deductions");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.Words)
                    .IsUnicode(false)
                    .HasColumnName("words");
            });

            modelBuilder.Entity<ViewSalarySheetRdlc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSalarySheetRDLC");

                entity.Property(e => e.Absents).HasColumnName("absents");

                entity.Property(e => e.AdvanceSalaryAdjustments).HasColumnName("advanceSalaryAdjustments");

                entity.Property(e => e.Allowances).HasColumnName("allowances");

                entity.Property(e => e.AlreadyAvailedLeaves).HasColumnName("alreadyAvailedLeaves");

                entity.Property(e => e.BasicSalary).HasColumnName("basicSalary");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.EmergencyLeaves).HasColumnName("emergencyLeaves");

                entity.Property(e => e.FacultyId)
                    .IsUnicode(false)
                    .HasColumnName("facultyID");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("fatherName");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Lates).HasColumnName("lates");

                entity.Property(e => e.LeaveDeductions).HasColumnName("leaveDeductions");

                entity.Property(e => e.LeavesDeducted).HasColumnName("leavesDeducted");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NetSalary).HasColumnName("netSalary");

                entity.Property(e => e.OtherDeductions).HasColumnName("otherDeductions");

                entity.Property(e => e.Rem).IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SalaryMonth).HasColumnName("salaryMonth");

                entity.Property(e => e.SalaryYear).HasColumnName("salaryYear");

                entity.Property(e => e.ShortLeaves).HasColumnName("shortLeaves");

                entity.Property(e => e.TaxDeductions).HasColumnName("taxDeductions");

                entity.Property(e => e.TeacherId).HasColumnName("teacherID");

                entity.Property(e => e.Words)
                    .IsUnicode(false)
                    .HasColumnName("words");
            });

            modelBuilder.Entity<ViewSchoolLeavingCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSchoolLeavingCertificates");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StuAdmDate)
                    .HasColumnType("date")
                    .HasColumnName("stuAdmDate");

                entity.Property(e => e.StuDob)
                    .HasColumnType("date")
                    .HasColumnName("stuDOB");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.StuWithDrawalDate)
                    .HasColumnType("date")
                    .HasColumnName("stuWithDrawalDate");
            });

            modelBuilder.Entity<ViewStaffContactList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStaffContactList");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PrimarySubject)
                    .IsUnicode(false)
                    .HasColumnName("Primary Subject");

                entity.Property(e => e.Ptcl)
                    .IsUnicode(false)
                    .HasColumnName("PTCL");

                entity.Property(e => e.Town).IsUnicode(false);
            });

            modelBuilder.Entity<ViewStandardMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStandardMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ExamTypeId).HasColumnName("examTypeID");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudents");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StuFatherCnic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherCNIC");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");
            });

            modelBuilder.Entity<ViewStudentExamResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentExamResult");

                entity.Property(e => e.ActualMarks).HasColumnName("actualMarks");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ExamDescription)
                    .IsUnicode(false)
                    .HasColumnName("examDescription");

                entity.Property(e => e.ExamId).HasColumnName("examID");

                entity.Property(e => e.MarksObtained).HasColumnName("marksObtained");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Section)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.StdMarks).HasColumnName("stdMarks");

                entity.Property(e => e.StdMarksObtained).HasColumnName("stdMarksObtained");

                entity.Property(e => e.StuGender)
                    .IsUnicode(false)
                    .HasColumnName("stuGender");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewStudentPaymentHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentPaymentHistory");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeeTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("feeTypeDesc");

                entity.Property(e => e.MonthId).HasColumnName("monthID");

                entity.Property(e => e.MonthName)
                    .IsUnicode(false)
                    .HasColumnName("monthName");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewStudentPaymentRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentPaymentRecord");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FeePaid).HasColumnName("feePaid");

                entity.Property(e => e.FeeTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("feeTypeDesc");

                entity.Property(e => e.FundAmount).HasColumnName("fundAmount");

                entity.Property(e => e.MonthName)
                    .IsUnicode(false)
                    .HasColumnName("monthName");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ViewStudentStrengthClassWiseWingWise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentStrengthClassWiseWingWise");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.NumberOfStudents).HasColumnName("Number of Students");

                entity.Property(e => e.WingDesc)
                    .IsUnicode(false)
                    .HasColumnName("wingDesc");
            });

            modelBuilder.Entity<ViewStudentsAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentsAttendance");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.LeaveApplication).HasColumnName("Leave Application");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PartialLeave).HasColumnName("Partial Leave");

                entity.Property(e => e.ReasonOfLeave)
                    .IsUnicode(false)
                    .HasColumnName("Reason of Leave");

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewStudentsBehavior>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentsBehaviors");

                entity.Property(e => e.BehaviorDescription)
                    .IsUnicode(false)
                    .HasColumnName("Behavior Description");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.StuId).HasColumnName("stuID");

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewStudentsCampaignEffect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentsCampaignEffects");

                entity.Property(e => e.AdvTypeDesc)
                    .IsUnicode(false)
                    .HasColumnName("advTypeDesc");

                entity.Property(e => e.AdvertisementTypeId).HasColumnName("advertisementTypeID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StAddress)
                    .IsUnicode(false)
                    .HasColumnName("stAddress");

                entity.Property(e => e.StuFatherName)
                    .IsUnicode(false)
                    .HasColumnName("stuFatherName");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.TownName)
                    .IsUnicode(false)
                    .HasColumnName("townName");
            });

            modelBuilder.Entity<ViewStudentsFatherOccupation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewStudentsFatherOccupations");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FatherOccupation)
                    .IsUnicode(false)
                    .HasColumnName("Father Occupation");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewSubjectsAndClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSubjectsAndClasses");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<ViewSyllabus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSyllabus");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.Syllabus).HasColumnName("syllabus");
            });

            modelBuilder.Entity<ViewSyllabusCompletionDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSyllabusCompletionDates");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.DaysAvailable).HasColumnName("daysAvailable");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SessionDesc)
                    .IsUnicode(false)
                    .HasColumnName("sessionDesc");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TermName)
                    .IsUnicode(false)
                    .HasColumnName("termName");

                entity.Property(e => e.WorkLoadDays).HasColumnName("workLoadDays");
            });

            modelBuilder.Entity<ViewSyllabusProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewSyllabusProgress");

                entity.Property(e => e.BwloadCovered).HasColumnName("BWLoadCovered");

                entity.Property(e => e.Bwstatus)
                    .IsUnicode(false)
                    .HasColumnName("BWStatus");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.GwloadCovered).HasColumnName("GWLoadCovered");

                entity.Property(e => e.Gwstatus)
                    .IsUnicode(false)
                    .HasColumnName("GWStatus");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.TotalDaysAvailable).HasColumnName("totalDaysAvailable");

                entity.Property(e => e.TotalDaysPassed).HasColumnName("totalDaysPassed");

                entity.Property(e => e.TotalWorkLoad).HasColumnName("totalWorkLoad");
            });

            modelBuilder.Entity<ViewTeacherAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTeacherAttendance");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmergencyLeave).HasColumnName("Emergency Leave");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.LeaveApplication).HasColumnName("Leave Application");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ReasonOfLeave)
                    .IsUnicode(false)
                    .HasColumnName("Reason of Leave");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ShortLeave).HasColumnName("Short Leave");
            });

            modelBuilder.Entity<ViewTeacherBehaviorDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTeacherBehaviorDescription");

                entity.Property(e => e.BehaviorDescription)
                    .IsUnicode(false)
                    .HasColumnName("Behavior Description");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTeacherDailyDiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTeacherDailyDiary");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.ClassWork).HasColumnName("classWork");

                entity.Property(e => e.HomeWork).HasColumnName("homeWork");

                entity.Property(e => e.SessionDesc)
                    .IsUnicode(false)
                    .HasColumnName("sessionDesc");

                entity.Property(e => e.SubjectName)
                    .IsUnicode(false)
                    .HasColumnName("subjectName");

                entity.Property(e => e.SyllabusItem).HasColumnName("syllabusItem");

                entity.Property(e => e.SyllabusOrder).HasColumnName("syllabusOrder");

                entity.Property(e => e.TermId).HasColumnName("termID");

                entity.Property(e => e.TermName)
                    .IsUnicode(false)
                    .HasColumnName("termName");

                entity.Property(e => e.WorkLoadDays).HasColumnName("workLoadDays");
            });

            modelBuilder.Entity<ViewTotalActiveStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalActiveStudents");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.FatherSName)
                    .IsUnicode(false)
                    .HasColumnName("Father's Name'");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalAdmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalAdmissions");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("date")
                    .HasColumnName("Admission Date");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalExpenses");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.NameOfAccount)
                    .IsUnicode(false)
                    .HasColumnName("Name of Account");
            });

            modelBuilder.Entity<ViewTotalFeeCollectedOfAllType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalFeeCollectedOfAllTypes");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDescription)
                    .IsUnicode(false)
                    .HasColumnName("Fee Description");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalFeeReceivableStudentWise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalFeeReceivableStudentWise");

                entity.Property(e => e.ClassName)
                    .IsUnicode(false)
                    .HasColumnName("className");

                entity.Property(e => e.StuCurrentWing).HasColumnName("stuCurrentWing");

                entity.Property(e => e.StuName)
                    .IsUnicode(false)
                    .HasColumnName("stuName");

                entity.Property(e => e.StuRegNumber)
                    .IsUnicode(false)
                    .HasColumnName("stuRegNumber");

                entity.Property(e => e.TotalFeeDue).HasColumnName("Total Fee Due");
            });

            modelBuilder.Entity<ViewTotalIncome>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalIncomes");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.NameOfAccount)
                    .IsUnicode(false)
                    .HasColumnName("Name of Account");
            });

            modelBuilder.Entity<ViewTotalWithdrawal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTotalWithdrawals");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.DateOfWithdrawal)
                    .HasColumnType("date")
                    .HasColumnName("Date of Withdrawal");

                entity.Property(e => e.FatherSName)
                    .IsUnicode(false)
                    .HasColumnName("Father's name'");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTrialBalance");

                entity.Property(e => e.AccountName)
                    .IsUnicode(false)
                    .HasColumnName("accountName");

                entity.Property(e => e.AccountTypeId).HasColumnName("accountTypeID");

                entity.Property(e => e.AccountTypeName)
                    .IsUnicode(false)
                    .HasColumnName("accountTypeName");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Debit).HasColumnName("debit");
            });

            modelBuilder.Entity<ViewTuitionFeeCollected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewTuitionFeeCollected");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.FeeDescription)
                    .IsUnicode(false)
                    .HasColumnName("Fee Description");

                entity.Property(e => e.Month).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            modelBuilder.Entity<ViewWithdrawnStudentsContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWithdrawnStudentsContacts");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsUnicode(false)
                    .HasColumnName("Father Name");

                entity.Property(e => e.Home).IsUnicode(false);

                entity.Property(e => e.Landline).IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.StuWithDrawalDate)
                    .HasColumnType("date")
                    .HasColumnName("stuWithDrawalDate");

                entity.Property(e => e.Wing).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
