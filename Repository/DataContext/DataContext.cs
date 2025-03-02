using Microsoft.EntityFrameworkCore;
using ZIP2GO.Repository.Models;

namespace Repository.DataContext
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=.;Database=ZIP2GO;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionAddPlan> SubscriptionAddPlans { get; set; }
        public DbSet<SubscriptionCancel> SubscriptionCancels { get; set; }
        public DbSet<SubscriptionPause> SubscriptionPauses { get; set; }
        public DbSet<SubscriptionRemovePlan> SubscriptionRemovePlans { get; set; }
        public DbSet<SubscriptionRenew> SubscriptionRenews { get; set; }
        public DbSet<ArTransactions> ArTransactions { get; set; }
        public DbSet<CreditMemo> CreditMemos { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PaymentTransactions> PaymentTransactions { get; set; }
        public DbSet<RefundTransactions> RefundTransactions { get; set; }
        public DbSet<TransactionsState> TransactionsState { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<CreditMemoItem> CreditMemoItems { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<SubscriptionTerm> SubscriptionTerms { get; set; }
        public DbSet<TaxCertificate> TaxCertificates { get; set; }
        public DbSet<SubscriptionItem> SubscriptionItems { get; set; }
        public DbSet<BillingDocument> BillingDocuments { get; set; }
        public DbSet<BillingDocumentSettings> BillingDocumentSettings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomObject> CustomObjects { get; set; }
        public DbSet<DebitMemo> DebitMemos { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<TaxIdentifier> TaxIdentifiers { get; set; }
        public DbSet<BillingDocumentItem> BillingDocumentItems { get; set; }
        public DbSet<PaymentScheduleItem> PaymentScheduleItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderLineItems { get; set; }
        public DbSet<PaymentsAppliedTo> PaymentsAppliedTo { get; set; }
        public DbSet<CreditMemoAppliedTo> CreditMemoAppliedTo { get; set; }
        public DbSet<DebitMemoItem> DebitMemoItems { get; set; }
        public DbSet<TaxationItem> TaxationItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");
            modelBuilder.Entity<SubscriptionAddPlan>().ToTable("SubscriptionAddPlan");
            modelBuilder.Entity<SubscriptionCancel>().ToTable("SubscriptionCancel");
            modelBuilder.Entity<SubscriptionPause>().ToTable("SubscriptionPause");
            modelBuilder.Entity<SubscriptionRemovePlan>().ToTable("SubscriptionRemovePlan");
            modelBuilder.Entity<SubscriptionRenew>().ToTable("SubscriptionRenew");
            modelBuilder.Entity<ArTransactions>().ToTable("ArTransactions");
            modelBuilder.Entity<CreditMemo>().ToTable("CreditMemo");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<PaymentTransactions>().ToTable("PaymentTransactions");
            modelBuilder.Entity<RefundTransactions>().ToTable("RefundTransactions");
            modelBuilder.Entity<TransactionsState>().ToTable("TransactionsState");
            modelBuilder.Entity<Usage>().ToTable("Usage");
            modelBuilder.Entity<CreditMemoItem>().ToTable("CreditMemoItem");
            modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem");
            modelBuilder.Entity<Refund>().ToTable("Refund");
            modelBuilder.Entity<SubscriptionPlan>().ToTable("SubscriptionPlan");
            modelBuilder.Entity<SubscriptionTerm>().ToTable("SubscriptionTerm");
            modelBuilder.Entity<TaxCertificate>().ToTable("TaxCertificate");
            modelBuilder.Entity<SubscriptionItem>().ToTable("SubscriptionItem");
            modelBuilder.Entity<BillingDocument>().ToTable("BillingDocument");
            modelBuilder.Entity<BillingDocumentSettings>().ToTable("BillingDocumentSettings");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<CustomObject>().ToTable("CustomObject");
            modelBuilder.Entity<DebitMemo>().ToTable("DebitMemo");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<TaxIdentifier>().ToTable("TaxIdentifier");
            modelBuilder.Entity<BillingDocumentItem>().ToTable("BillingDocumentItem");
            modelBuilder.Entity<PaymentScheduleItem>().ToTable("PaymentScheduleItem");
            modelBuilder.Entity<OrderItem>().ToTable("OrderLineItem");
            modelBuilder.Entity<PaymentsAppliedTo>().ToTable("PaymentsAppliedTo");
            modelBuilder.Entity<CreditMemoAppliedTo>().ToTable("CreditMemoAppliedTo");
            modelBuilder.Entity<DebitMemoItem>().ToTable("DebitMemoItem");
            modelBuilder.Entity<TaxationItem>().ToTable("TaxationItem");
        }
    }
}