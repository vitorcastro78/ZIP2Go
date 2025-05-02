using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "BillingDocumentStateTransitions");

            migrationBuilder.DropTable(
                name: "CreditMemoAppliedTo");

            migrationBuilder.DropTable(
                name: "ItemTier");

            migrationBuilder.DropTable(
                name: "PaymentOption");

            migrationBuilder.DropTable(
                name: "PaymentScheduleItemPayments");

            migrationBuilder.DropTable(
                name: "PrepaidBalanceTransaction");

            migrationBuilder.DropTable(
                name: "ProductTier");

            migrationBuilder.DropTable(
                name: "RefundAppliedToItem");

            migrationBuilder.DropTable(
                name: "SubscriptionCancels");

            migrationBuilder.DropTable(
                name: "SubscriptionPauses");

            migrationBuilder.DropTable(
                name: "SubscriptionRemovePlans");

            migrationBuilder.DropTable(
                name: "SubscriptionRenews");

            migrationBuilder.DropTable(
                name: "TaxationItems");

            migrationBuilder.DropTable(
                name: "Tier");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "PaymentScheduleItems");

            migrationBuilder.DropTable(
                name: "PrepaidBalance");

            migrationBuilder.DropTable(
                name: "ValidityPeriod");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "RefundsAppliedTo");

            migrationBuilder.DropTable(
                name: "ResumeSubscription");

            migrationBuilder.DropTable(
                name: "SubscriptionTerms");

            migrationBuilder.DropTable(
                name: "BillingDocumentItems");

            migrationBuilder.DropTable(
                name: "CreditMemoItems");

            migrationBuilder.DropTable(
                name: "DebitMemoItems");

            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "PaymentSchedule");

            migrationBuilder.DropTable(
                name: "PrepaidBalances");

            migrationBuilder.DropTable(
                name: "ProductPlan");

            migrationBuilder.DropTable(
                name: "Refunds");

            migrationBuilder.DropTable(
                name: "PaymentsAppliedTo");

            migrationBuilder.DropTable(
                name: "DebitMemos");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "OrderLineItems");

            migrationBuilder.DropTable(
                name: "SubscriptionItems");

            migrationBuilder.DropTable(
                name: "RefundStateTransitions");

            migrationBuilder.DropTable(
                name: "RefundTransactions");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "OrderLineItemRevenue");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "SubscriptionAddPlans");

            migrationBuilder.DropTable(
                name: "SubscriptionPlans");

            migrationBuilder.DropTable(
                name: "GatewayOptions");

            migrationBuilder.DropTable(
                name: "GatewayStateTransitions");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PaymentStateTransitions");

            migrationBuilder.DropTable(
                name: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "Amounts");

            migrationBuilder.DropTable(
                name: "Drawdown");

            migrationBuilder.DropTable(
                name: "Overage");

            migrationBuilder.DropTable(
                name: "Prepayment");

            migrationBuilder.DropTable(
                name: "Recurring");

            migrationBuilder.DropTable(
                name: "Revenue");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AchDebit");

            migrationBuilder.DropTable(
                name: "ApplePay");

            migrationBuilder.DropTable(
                name: "AuBecsDebit");

            migrationBuilder.DropTable(
                name: "AutogiroDebit");

            migrationBuilder.DropTable(
                name: "BacsDebit");

            migrationBuilder.DropTable(
                name: "BetalingsDebit");

            migrationBuilder.DropTable(
                name: "BillingDetails");

            migrationBuilder.DropTable(
                name: "CcRef");

            migrationBuilder.DropTable(
                name: "GetCardList");

            migrationBuilder.DropTable(
                name: "GooglePay");

            migrationBuilder.DropTable(
                name: "NzBecsDebit");

            migrationBuilder.DropTable(
                name: "PadDebit");

            migrationBuilder.DropTable(
                name: "PaypalAdaptive");

            migrationBuilder.DropTable(
                name: "PaypalExpressNative");

            migrationBuilder.DropTable(
                name: "PaypalExpress");

            migrationBuilder.DropTable(
                name: "SepaDebit");

            migrationBuilder.DropTable(
                name: "TransactionsState");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Term");

            migrationBuilder.DropTable(
                name: "AddressFieldDefinitions");

            migrationBuilder.DropTable(
                name: "CcRefCard");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Mandate");

            migrationBuilder.DropTable(
                name: "CardMandate");

            migrationBuilder.DropTable(
                name: "CustomerAcceptanceMandate");

            migrationBuilder.DropTable(
                name: "BillingDocumentSettings");

            migrationBuilder.DropTable(
                name: "CreditMemos");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ArTransactions");

            migrationBuilder.DropTable(
                name: "StateTransitions");

            migrationBuilder.DropTable(
                name: "BillingDocuments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "TaxCertificates");

            migrationBuilder.DropTable(
                name: "TaxIdentifiers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CustomFields");

            migrationBuilder.DropTable(
                name: "CustomObjects");
        }

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    County = table.Column<string>(type: "TEXT", nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressFieldDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressFieldDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreditMemoNumbers = table.Column<string>(type: "TEXT", nullable: false),
                    InvoiceNumbers = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CcRefCard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CcRefCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAcceptanceMandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAcceptanceMandate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drawdown",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConversionRate = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatewayOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatewayStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkedForSubmissionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SettledTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubmittedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatewayStateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mandate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLineItemRevenue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdjustmentRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    ContractRecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    ExcludeItemBillingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    ExcludeItemBookingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineItemRevenue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Overage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplyAtEndOfSmoothingPeriod = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreditUnusedUnits = table.Column<bool>(type: "INTEGER", nullable: true),
                    IncludedUnits = table.Column<decimal>(type: "TEXT", nullable: true),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalAdaptive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PreapprovalKey = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalAdaptive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalExpress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Baid = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalExpress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaypalExpressNative",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Baid = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaypalExpressNative", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prepayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreditOption = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    ValidityPeriod = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepayment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurring",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AlignmentBehavior = table.Column<string>(type: "TEXT", nullable: false),
                    DurationInterval = table.Column<string>(type: "TEXT", nullable: false),
                    DurationIntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Formula = table.Column<string>(type: "TEXT", nullable: false),
                    Interval = table.Column<string>(type: "TEXT", nullable: false),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    On = table.Column<string>(type: "TEXT", nullable: false),
                    RatingGroup = table.Column<string>(type: "TEXT", nullable: false),
                    RecurringOn = table.Column<string>(type: "TEXT", nullable: false),
                    Timing = table.Column<string>(type: "TEXT", nullable: false),
                    Usage = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurring", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefundStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundStateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Revenue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExcludeItemBillingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    ExcludeItemBookingFromRevenueAccounting = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<string>(type: "TEXT", nullable: false),
                    PostedTime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTransitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionCancels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CancelAt = table.Column<string>(type: "TEXT", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionCancels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionRemovePlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionPlanId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionRemovePlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxCertificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyCode = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EntityUseCode = table.Column<string>(type: "TEXT", nullable: false),
                    IssuingJurisdiction = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    TaxIdentifier = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCertificates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxIdentifiers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxIdentifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Term",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Interval = table.Column<string>(type: "TEXT", nullable: false),
                    IntervalCount = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsState",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Failed = table.Column<string>(type: "TEXT", nullable: false),
                    Succeeded = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDetails_AddressFieldDefinitions_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressFieldDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardMandate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerAcceptanceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    NetworkTransactionId = table.Column<string>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Verified = table.Column<bool>(type: "INTEGER", nullable: true),
                    Verify = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardMandate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardMandate_CustomerAcceptanceMandate_CustomerAcceptanceId",
                        column: x => x.CustomerAcceptanceId,
                        principalTable: "CustomerAcceptanceMandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSubscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ExtendTerm = table.Column<bool>(type: "INTEGER", nullable: true),
                    ResumeAt = table.Column<string>(type: "TEXT", nullable: false),
                    ResumeDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResumeSubscription_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionAddPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanId = table.Column<string>(type: "TEXT", nullable: false),
                    UniqueToken = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionAddPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionAddPlans_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<string>(type: "TEXT", nullable: false),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PostedById = table.Column<string>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocuments_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocuments_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AddressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Fax = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MobilePhone = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    OtherPhone = table.Column<string>(type: "TEXT", nullable: false),
                    OtherPhoneType = table.Column<string>(type: "TEXT", nullable: false),
                    TaxRegion = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    WorkEmail = table.Column<string>(type: "TEXT", nullable: false),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AchDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BankAbaCode = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountName = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankAccountType = table.Column<string>(type: "TEXT", nullable: false),
                    BankName = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AchDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuBecsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuBecsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuBecsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutogiroDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    IdentityNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutogiroDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutogiroDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BacsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BacsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BetalingsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    IdentityNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetalingsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetalingsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CcRef",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SecondToken = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CcRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CcRef_CcRefCard_CardId",
                        column: x => x.CardId,
                        principalTable: "CcRefCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CcRef_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GetCardList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetCardList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetCardList_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NzBecsDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NzBecsDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NzBecsDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PadDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankCode = table.Column<string>(type: "TEXT", nullable: false),
                    BranchCode = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PadDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PadDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SepaDebit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BusinessIdentificationCode = table.Column<string>(type: "TEXT", nullable: false),
                    IBAN = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepaDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SepaDebit_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AutoRenew = table.Column<bool>(type: "INTEGER", nullable: true),
                    CurrentTermId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RenewalTermId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTerms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionTerms_Term_CurrentTermId",
                        column: x => x.CurrentTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionTerms_Term_RenewalTermId",
                        column: x => x.RenewalTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_ArTransactions_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentTransactions_TransactionsState_StateId",
                        column: x => x.StateId,
                        principalTable: "TransactionsState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefundTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceNumbers = table.Column<string>(type: "TEXT", nullable: false),
                    RefundNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundTransactions_ArTransactions_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RefundTransactions_TransactionsState_StateId",
                        column: x => x.StateId,
                        principalTable: "TransactionsState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    CardNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryMonth = table.Column<decimal>(type: "TEXT", nullable: true),
                    ExpiryYear = table.Column<decimal>(type: "TEXT", nullable: true),
                    Last4 = table.Column<string>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SecurityCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_CardMandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "CardMandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPauses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PauseAt = table.Column<string>(type: "TEXT", nullable: false),
                    PauseDate = table.Column<string>(type: "TEXT", nullable: false),
                    PauseInterval = table.Column<string>(type: "TEXT", nullable: false),
                    PauseIntervalCount = table.Column<decimal>(type: "TEXT", nullable: true),
                    ResumeBehaviorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPauses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionPauses_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPauses_ResumeSubscription_ResumeBehaviorId",
                        column: x => x.ResumeBehaviorId,
                        principalTable: "ResumeSubscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentStateTransitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CanceledTime = table.Column<string>(type: "TEXT", nullable: false),
                    PostedTime = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentStateTransitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentStateTransitions_BillingDocuments_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentId = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemoAppliedTo_BillingDocuments_BillingDocumentId1",
                        column: x => x.BillingDocumentId1,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSchedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    Custom = table.Column<bool>(type: "INTEGER", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    NextPaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NumberOfPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    PaymentGatewayId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentMethodId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentScheduleNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Period = table.Column<string>(type: "TEXT", nullable: false),
                    Prepayment = table.Column<bool>(type: "INTEGER", nullable: true),
                    RecentPaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RunHour = table.Column<int>(type: "INTEGER", nullable: true),
                    Standalone = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalPaymentsErrored = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalPaymentsProcessed = table.Column<int>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_BillingDocuments_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentSchedule_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    ActiveCurrencies = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plan_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    ActiveCurrencies = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPlan_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPlan_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPlan_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionRenews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TermsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionRenews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionRenews_SubscriptionTerms_TermsId",
                        column: x => x.TermsId,
                        principalTable: "SubscriptionTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplePay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MandateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplePay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplePay_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplePay_Mandate_MandateId",
                        column: x => x.MandateId,
                        principalTable: "Mandate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GooglePay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GooglePay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GooglePay_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DetailId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentScheduleId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOption_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentOption_PaymentSchedule_PaymentScheduleId",
                        column: x => x.PaymentScheduleId,
                        principalTable: "PaymentSchedule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: false),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: false),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldPerUnitRate = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldTotalAmount = table.Column<string>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DrawdownId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MaxQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    MinQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanId = table.Column<string>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PrepaymentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RevenueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RevenueRecognitionRule = table.Column<string>(type: "TEXT", nullable: false),
                    StackedDiscount = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: false),
                    Taxable = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PlanId1 = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Price_Amounts_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Amounts_DiscountAmountsId",
                        column: x => x.DiscountAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Amounts_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Drawdown_DrawdownId",
                        column: x => x.DrawdownId,
                        principalTable: "Drawdown",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Plan_PlanId1",
                        column: x => x.PlanId1,
                        principalTable: "Plan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Price_Prepayment_PrepaymentId",
                        column: x => x.PrepaymentId,
                        principalTable: "Prepayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Price_Revenue_RevenueId",
                        column: x => x.RevenueId,
                        principalTable: "Revenue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: false),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: false),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldPerUnitRate = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldTotalAmount = table.Column<string>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DrawdownId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MaxQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    MinQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductPlanId = table.Column<string>(type: "TEXT", nullable: false),
                    PlanNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PrepaymentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RevenueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RevenueRecognitionRule = table.Column<string>(type: "TEXT", nullable: false),
                    StackedDiscount = table.Column<bool>(type: "INTEGER", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: false),
                    Taxable = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProductPlanId1 = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_DiscountAmountsId",
                        column: x => x.DiscountAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Amounts_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Amounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Drawdown_DrawdownId",
                        column: x => x.DrawdownId,
                        principalTable: "Drawdown",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Prepayment_PrepaymentId",
                        column: x => x.PrepaymentId,
                        principalTable: "Prepayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_ProductPlan_ProductPlanId1",
                        column: x => x.ProductPlanId1,
                        principalTable: "ProductPlan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductPrice_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Revenue_RevenueId",
                        column: x => x.RevenueId,
                        principalTable: "Revenue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tier_Money_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tier_Money_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tier_Price_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Price",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductTier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitAmountsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    ProductPriceId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTier_Money_AmountsId",
                        column: x => x.AmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTier_Money_UnitAmountsId",
                        column: x => x.UnitAmountsId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTier_ProductPrice_ProductPriceId",
                        column: x => x.ProductPriceId,
                        principalTable: "ProductPrice",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AutoPay = table.Column<bool>(type: "INTEGER", nullable: true),
                    Batch = table.Column<string>(type: "TEXT", nullable: false),
                    BillCycleDay = table.Column<int>(type: "INTEGER", nullable: true),
                    BillingDocumentsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<string>(type: "TEXT", nullable: false),
                    CommunicationProfileId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CrmId = table.Column<string>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DefaultPaymentMethodId = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Enabled = table.Column<bool>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ParentAccountId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentGateway = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingCreditMemoBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingDebitMemoBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingInvoiceBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RemainingPaymentBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SalesRep = table.Column<string>(type: "TEXT", nullable: false),
                    SequenceSetId = table.Column<string>(type: "TEXT", nullable: false),
                    SoldToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SoldToId = table.Column<string>(type: "TEXT", nullable: false),
                    TaxCertificateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TaxIdentifierId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_BillingDocuments_BillingDocumentsId",
                        column: x => x.BillingDocumentsId,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Contacts_BillToId1",
                        column: x => x.BillToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Contacts_SoldToId1",
                        column: x => x.SoldToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_TaxCertificates_TaxCertificateId",
                        column: x => x.TaxCertificateId,
                        principalTable: "TaxCertificates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_TaxIdentifiers_TaxIdentifierId",
                        column: x => x.TaxIdentifierId,
                        principalTable: "TaxIdentifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<string>(type: "TEXT", nullable: false),
                    PostedById = table.Column<string>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemos_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemos_ArTransactions_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreditMemos_Contacts_BillToId1",
                        column: x => x.BillToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemos_CreditMemos_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreditMemos_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemos_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemos_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AchDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplePayId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AuBecsDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AutoGenerated = table.Column<bool>(type: "INTEGER", nullable: true),
                    AutogiroDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BacsDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BankIdentificationNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BetalingsDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDetailsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CardId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CcRefId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomType = table.Column<string>(type: "TEXT", nullable: false),
                    DeviceSessionId = table.Column<string>(type: "TEXT", nullable: false),
                    ExistingMandate = table.Column<bool>(type: "INTEGER", nullable: true),
                    GooglePayId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IpAddress = table.Column<string>(type: "TEXT", nullable: false),
                    LastFailedSaleTransactionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastTransactionStatus = table.Column<string>(type: "TEXT", nullable: false),
                    LastTransactionTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MaximumPaymentAttempts = table.Column<decimal>(type: "TEXT", nullable: true),
                    NumberOfConsecutiveFailures = table.Column<int>(type: "INTEGER", nullable: true),
                    NzBecsDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PadDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentRetryInterval = table.Column<int>(type: "INTEGER", nullable: true),
                    PaypalAdaptiveId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaypalExpressId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaypalExpressNativeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SepaDebitId = table.Column<Guid>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    TotalNumberOfErrorPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalNumberOfProcessedPayments = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UseDefaultRetryRule = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_AchDebit_AchDebitId",
                        column: x => x.AchDebitId,
                        principalTable: "AchDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_ApplePay_ApplePayId",
                        column: x => x.ApplePayId,
                        principalTable: "ApplePay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_AuBecsDebit_AuBecsDebitId",
                        column: x => x.AuBecsDebitId,
                        principalTable: "AuBecsDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_AutogiroDebit_AutogiroDebitId",
                        column: x => x.AutogiroDebitId,
                        principalTable: "AutogiroDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_BacsDebit_BacsDebitId",
                        column: x => x.BacsDebitId,
                        principalTable: "BacsDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_BetalingsDebit_BetalingsDebitId",
                        column: x => x.BetalingsDebitId,
                        principalTable: "BetalingsDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_BillingDetails_BillingDetailsId",
                        column: x => x.BillingDetailsId,
                        principalTable: "BillingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_CcRef_CcRefId",
                        column: x => x.CcRefId,
                        principalTable: "CcRef",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_GetCardList_CardId",
                        column: x => x.CardId,
                        principalTable: "GetCardList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_GooglePay_GooglePayId",
                        column: x => x.GooglePayId,
                        principalTable: "GooglePay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_NzBecsDebit_NzBecsDebitId",
                        column: x => x.NzBecsDebitId,
                        principalTable: "NzBecsDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PadDebit_PadDebitId",
                        column: x => x.PadDebitId,
                        principalTable: "PadDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaypalAdaptive_PaypalAdaptiveId",
                        column: x => x.PaypalAdaptiveId,
                        principalTable: "PaypalAdaptive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaypalExpressNative_PaypalExpressNativeId",
                        column: x => x.PaypalExpressNativeId,
                        principalTable: "PaypalExpressNative",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaypalExpress_PaypalExpressId",
                        column: x => x.PaypalExpressId,
                        principalTable: "PaypalExpress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_SepaDebit_SepaDebitId",
                        column: x => x.SepaDebitId,
                        principalTable: "SepaDebit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionNumber = table.Column<string>(type: "TEXT", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usages_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usages_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usages_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdditionalEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CreditMemoTemplateId = table.Column<string>(type: "TEXT", nullable: false),
                    DebitMemoTemplateId = table.Column<string>(type: "TEXT", nullable: false),
                    EmailDocuments = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceTemplateId = table.Column<string>(type: "TEXT", nullable: false),
                    PrintDocuments = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentSettings_CreditMemos_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderLineItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AdjustmentLiabilityAccount = table.Column<string>(type: "TEXT", nullable: false),
                    BillingRule = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    ContractAssetAccount = table.Column<string>(type: "TEXT", nullable: false),
                    ContractLiabilityAccount = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountUnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ListPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    ListUnitPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OrderId = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalOrderDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OriginalOrderId = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalOrderLineItemId = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalOrderLineItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    OriginalSoldToId = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductCode = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityAvailableForReturn = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityFulfilled = table.Column<decimal>(type: "TEXT", nullable: true),
                    QuantityPendingFulfillment = table.Column<decimal>(type: "TEXT", nullable: true),
                    RelatedSubscriptionNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RequiresFulfillment = table.Column<bool>(type: "INTEGER", nullable: true),
                    RevenueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SoldToId = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    TargetDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UnbilledReceivablesAccount = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OrderId1 = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLineItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLineItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLineItems_OrderLineItemRevenue_RevenueId",
                        column: x => x.RevenueId,
                        principalTable: "OrderLineItemRevenue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLineItems_Order_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountApplied = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    AuthorizationId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    External = table.Column<bool>(type: "INTEGER", nullable: true),
                    GatewayId = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayOptionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    GatewayOrderId = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayReconciliationReason = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayReconciliationStatus = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayResponse = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayResponseCode = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayState = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayStateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentMethodId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentMethodId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PayoutId = table.Column<string>(type: "TEXT", nullable: false),
                    ReferenceId = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SecondReferenceId = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptor = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptorPhone = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_GatewayOptions_GatewayOptionsId",
                        column: x => x.GatewayOptionsId,
                        principalTable: "GatewayOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_GatewayStateTransitions_GatewayStateTransitionsId",
                        column: x => x.GatewayStateTransitionsId,
                        principalTable: "GatewayStateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId1",
                        column: x => x.PaymentMethodId1,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentStateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "PaymentStateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTransactions_PaymentTransactionsId",
                        column: x => x.PaymentTransactionsId,
                        principalTable: "PaymentTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BankAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    External = table.Column<bool>(type: "INTEGER", nullable: true),
                    GatewayId = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayOptionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    GatewayReconciliationReason = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayReconciliationStatus = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayResponse = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayResponseCode = table.Column<string>(type: "TEXT", nullable: false),
                    GatewayState = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentMethodId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentMethodId = table.Column<string>(type: "TEXT", nullable: false),
                    PayoutId = table.Column<string>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    ReferenceId = table.Column<string>(type: "TEXT", nullable: false),
                    RefundDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundMethodType = table.Column<string>(type: "TEXT", nullable: false),
                    RefundNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SecondReferenceId = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptor = table.Column<string>(type: "TEXT", nullable: false),
                    StatementDescriptorPhone = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnappliedPaymentAccount = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefundTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refunds_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_CreditMemos_CreditMemoId",
                        column: x => x.CreditMemoId,
                        principalTable: "CreditMemos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_GatewayOptions_GatewayOptionsId",
                        column: x => x.GatewayOptionsId,
                        principalTable: "GatewayOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_PaymentMethods_PaymentMethodId1",
                        column: x => x.PaymentMethodId1,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_RefundStateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "RefundStateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_RefundTransactions_RefundTransactionsId",
                        column: x => x.RefundTransactionsId,
                        principalTable: "RefundTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DebitMemos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DebitMemoNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExcludeFromAutoApplyRules = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvoiceId = table.Column<string>(type: "TEXT", nullable: false),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    PostedById = table.Column<string>(type: "TEXT", nullable: false),
                    ReasonCode = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitMemos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebitMemos_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemos_BillingDocumentSettings_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemos_Contacts_BillToId1",
                        column: x => x.BillToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemos_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemos_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemos_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Paid = table.Column<bool>(type: "INTEGER", nullable: true),
                    PastDue = table.Column<bool>(type: "INTEGER", nullable: true),
                    Pay = table.Column<bool>(type: "INTEGER", nullable: true),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    PostedById = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SoldToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SoldToId = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    StateTransitionsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    Total = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransferToAccounting = table.Column<bool>(type: "INTEGER", nullable: true),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArTransactionsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_ArTransactions_ArTransactionsId",
                        column: x => x.ArTransactionsId,
                        principalTable: "ArTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Invoices_BillingDocumentSettings_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Contacts_BillToId1",
                        column: x => x.BillToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Contacts_SoldToId1",
                        column: x => x.SoldToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_StateTransitions_StateTransitionsId",
                        column: x => x.StateTransitionsId,
                        principalTable: "StateTransitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    AutoRenew = table.Column<bool>(type: "INTEGER", nullable: true),
                    BillingDocumentSettingsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillToId = table.Column<string>(type: "TEXT", nullable: false),
                    CancelReason = table.Column<string>(type: "TEXT", nullable: false),
                    ContractedMrr = table.Column<string>(type: "TEXT", nullable: false),
                    ContractEffective = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentTermId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerAcceptance = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InitialTermId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceOwnerAccountId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceOwnerAccountId = table.Column<string>(type: "TEXT", nullable: false),
                    InvoiceSeparately = table.Column<bool>(type: "INTEGER", nullable: true),
                    LastBookingDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LatestVersion = table.Column<bool>(type: "INTEGER", nullable: true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentTerms = table.Column<string>(type: "TEXT", nullable: false),
                    RenewalTermId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ServiceActivation = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SoldToId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SoldToId = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionNumber = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Version = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Accounts_InvoiceOwnerAccountId1",
                        column: x => x.InvoiceOwnerAccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_BillingDocumentSettings_BillingDocumentSettingsId",
                        column: x => x.BillingDocumentSettingsId,
                        principalTable: "BillingDocumentSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Contacts_BillToId1",
                        column: x => x.BillToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Contacts_SoldToId1",
                        column: x => x.SoldToId1,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscriptions_Term_CurrentTermId",
                        column: x => x.CurrentTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Term_InitialTermId",
                        column: x => x.InitialTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Term_RenewalTermId",
                        column: x => x.RenewalTermId,
                        principalTable: "Term",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentsAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentId = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentsAppliedTo_BillingDocuments_BillingDocumentId1",
                        column: x => x.BillingDocumentId1,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentsAppliedTo_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentScheduleItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountId = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CancellationReason = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorMessage = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentGatewayId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentMethodId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentOptionId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentScheduleId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentScheduleId = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentScheduleItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentScheduleNumber = table.Column<string>(type: "TEXT", nullable: false),
                    RunHour = table.Column<int>(type: "INTEGER", nullable: true),
                    ScheduledDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Standalone = table.Column<bool>(type: "INTEGER", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentScheduleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItems_BillingDocuments_BillingDocumentId",
                        column: x => x.BillingDocumentId,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItems_PaymentSchedule_PaymentScheduleId1",
                        column: x => x.PaymentScheduleId1,
                        principalTable: "PaymentSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItems_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefundsAppliedTo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    BillingDocumentId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentId = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    PaymentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RefundId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundsAppliedTo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_BillingDocuments_BillingDocumentId1",
                        column: x => x.BillingDocumentId1,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefundsAppliedTo_Refunds_RefundId",
                        column: x => x.RefundId,
                        principalTable: "Refunds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PrepaidUOM = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TotalBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepaidBalance_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepaidBalances_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PlanId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlans_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlans_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlans_Plan_PlanId1",
                        column: x => x.PlanId1,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlans_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionPlans_Subscriptions_SubscriptionId1",
                        column: x => x.SubscriptionId1,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentScheduleItemPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentScheduleItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentScheduleItemPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentScheduleItemPayments_PaymentScheduleItems_PaymentScheduleItemId",
                        column: x => x.PaymentScheduleItemId,
                        principalTable: "PaymentScheduleItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefundAppliedToItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    CreditMemoItemId = table.Column<string>(type: "TEXT", nullable: false),
                    TaxationItemId = table.Column<string>(type: "TEXT", nullable: false),
                    RefundsAppliedToId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundAppliedToItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefundAppliedToItem_RefundsAppliedTo_RefundsAppliedToId",
                        column: x => x.RefundsAppliedToId,
                        principalTable: "RefundsAppliedTo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValidityPeriod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    OverageRatedAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    OverageRatedQuantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    PrepaidUOM = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TotalBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    PrepaidBalancesId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidityPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidityPeriod_PrepaidBalances_PrepaidBalancesId",
                        column: x => x.PrepaidBalancesId,
                        principalTable: "PrepaidBalances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    ApplyDiscountTo = table.Column<string>(type: "TEXT", nullable: false),
                    ChargedThroughDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ChargeModel = table.Column<string>(type: "TEXT", nullable: false),
                    ChargeType = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    DiscountLevel = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OverageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceBaseInterval = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    ProcessedThroughDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProductId = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecurringId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StartEvent = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionPlanId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionPlanId = table.Column<string>(type: "TEXT", nullable: false),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TiersMode = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SubscriptionAddPlanId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_Overage_OverageId",
                        column: x => x.OverageId,
                        principalTable: "Overage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_Price_PriceId1",
                        column: x => x.PriceId1,
                        principalTable: "Price",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_Recurring_RecurringId",
                        column: x => x.RecurringId,
                        principalTable: "Recurring",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_SubscriptionAddPlans_SubscriptionAddPlanId",
                        column: x => x.SubscriptionAddPlanId,
                        principalTable: "SubscriptionAddPlans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionItems_SubscriptionPlans_SubscriptionPlanId1",
                        column: x => x.SubscriptionPlanId1,
                        principalTable: "SubscriptionPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepaidBalanceTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    TransactionDate = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    PrepaidBalanceId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ValidityPeriodId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepaidBalanceTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepaidBalanceTransaction_PrepaidBalance_PrepaidBalanceId",
                        column: x => x.PrepaidBalanceId,
                        principalTable: "PrepaidBalance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrepaidBalanceTransaction_ValidityPeriod_ValidityPeriodId",
                        column: x => x.ValidityPeriodId,
                        principalTable: "ValidityPeriod",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillingDocumentItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<string>(type: "TEXT", nullable: false),
                    BillingDocumentId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    BillingDocumentId = table.Column<string>(type: "TEXT", nullable: false),
                    BookingReference = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PriceDescription = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PaymentsAppliedToId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingDocumentItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_BillingDocuments_BillingDocumentId1",
                        column: x => x.BillingDocumentId1,
                        principalTable: "BillingDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_PaymentsAppliedTo_PaymentsAppliedToId",
                        column: x => x.PaymentsAppliedToId,
                        principalTable: "PaymentsAppliedTo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_SubscriptionItems_SubscriptionItemId1",
                        column: x => x.SubscriptionItemId1,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingDocumentItems_Subscriptions_SubscriptionId1",
                        column: x => x.SubscriptionId1,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreditMemoId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreditMemoId = table.Column<string>(type: "TEXT", nullable: false),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditMemoItems_CreditMemos_CreditMemoId1",
                        column: x => x.CreditMemoId1,
                        principalTable: "CreditMemos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItems_SubscriptionItems_SubscriptionItemId1",
                        column: x => x.SubscriptionItemId1,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreditMemoItems_Subscriptions_SubscriptionId1",
                        column: x => x.SubscriptionId1,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DebitMemoItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DebitMemoId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    DebitMemoId = table.Column<string>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitMemoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DebitMemoItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItems_DebitMemos_DebitMemoId1",
                        column: x => x.DebitMemoId1,
                        principalTable: "DebitMemos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItems_SubscriptionItems_SubscriptionItemId1",
                        column: x => x.SubscriptionItemId1,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DebitMemoItems_Subscriptions_SubscriptionId1",
                        column: x => x.SubscriptionId1,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountingCode = table.Column<string>(type: "TEXT", nullable: false),
                    AccountsReceivableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AppliedToItemId = table.Column<string>(type: "TEXT", nullable: false),
                    BookingReference = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DeferredRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountItem = table.Column<bool>(type: "INTEGER", nullable: true),
                    DocumentItemDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InvoiceId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    InvoiceId = table.Column<string>(type: "TEXT", nullable: false),
                    LineItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PriceId = table.Column<string>(type: "TEXT", nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<decimal>(type: "TEXT", nullable: true),
                    RecognizedRevenueAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    RevenueRecognitionRuleName = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceEnd = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceStart = table.Column<string>(type: "TEXT", nullable: false),
                    Sku = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionId = table.Column<string>(type: "TEXT", nullable: false),
                    SubscriptionItemId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubscriptionItemId = table.Column<string>(type: "TEXT", nullable: false),
                    Tax = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitOfMeasure = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId1",
                        column: x => x.InvoiceId1,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_OrderLineItems_LineItemId",
                        column: x => x.LineItemId,
                        principalTable: "OrderLineItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_SubscriptionItems_SubscriptionItemId1",
                        column: x => x.SubscriptionItemId1,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Subscriptions_SubscriptionId1",
                        column: x => x.SubscriptionId1,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UnitAmount = table.Column<decimal>(type: "TEXT", nullable: true),
                    UpTo = table.Column<decimal>(type: "TEXT", nullable: true),
                    SubscriptionItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTier_SubscriptionItems_SubscriptionItemId",
                        column: x => x.SubscriptionItemId,
                        principalTable: "SubscriptionItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaxationItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountApplied = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountCredited = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountExempt = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "TEXT", nullable: true),
                    AmountRefunded = table.Column<decimal>(type: "TEXT", nullable: true),
                    CreatedById = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CustomFieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomObjectsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Jurisdiction = table.Column<string>(type: "TEXT", nullable: false),
                    LocationCode = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OnAccountAccount = table.Column<string>(type: "TEXT", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "TEXT", nullable: true),
                    SalesTaxPayableAccount = table.Column<string>(type: "TEXT", nullable: false),
                    SourceTaxItemId = table.Column<string>(type: "TEXT", nullable: false),
                    TaxCode = table.Column<string>(type: "TEXT", nullable: false),
                    TaxCodeName = table.Column<string>(type: "TEXT", nullable: false),
                    TaxDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TaxInclusive = table.Column<bool>(type: "INTEGER", nullable: true),
                    TaxRate = table.Column<decimal>(type: "TEXT", nullable: true),
                    TaxRateName = table.Column<string>(type: "TEXT", nullable: false),
                    TaxRateType = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedById = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BillingDocumentItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreditMemoItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DebitMemoItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    InvoiceItemId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxationItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxationItems_BillingDocumentItems_BillingDocumentItemId",
                        column: x => x.BillingDocumentItemId,
                        principalTable: "BillingDocumentItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItems_CreditMemoItems_CreditMemoItemId",
                        column: x => x.CreditMemoItemId,
                        principalTable: "CreditMemoItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItems_CustomFields_CustomFieldsId",
                        column: x => x.CustomFieldsId,
                        principalTable: "CustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxationItems_CustomObjects_CustomObjectsId",
                        column: x => x.CustomObjectsId,
                        principalTable: "CustomObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxationItems_DebitMemoItems_DebitMemoItemId",
                        column: x => x.DebitMemoItemId,
                        principalTable: "DebitMemoItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxationItems_InvoiceItems_InvoiceItemId",
                        column: x => x.InvoiceItemId,
                        principalTable: "InvoiceItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BillingDocumentSettingsId",
                table: "Accounts",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BillingDocumentsId",
                table: "Accounts",
                column: "BillingDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BillToId1",
                table: "Accounts",
                column: "BillToId1");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CustomFieldsId",
                table: "Accounts",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CustomObjectsId",
                table: "Accounts",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SoldToId1",
                table: "Accounts",
                column: "SoldToId1");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TaxCertificateId",
                table: "Accounts",
                column: "TaxCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TaxIdentifierId",
                table: "Accounts",
                column: "TaxIdentifierId");

            migrationBuilder.CreateIndex(
                name: "IX_AchDebit_MandateId",
                table: "AchDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplePay_CardId",
                table: "ApplePay",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplePay_MandateId",
                table: "ApplePay",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_AuBecsDebit_MandateId",
                table: "AuBecsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_AutogiroDebit_MandateId",
                table: "AutogiroDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BacsDebit_MandateId",
                table: "BacsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BetalingsDebit_MandateId",
                table: "BetalingsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDetails_AddressId",
                table: "BillingDetails",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_BillingDocumentId1",
                table: "BillingDocumentItems",
                column: "BillingDocumentId1");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_CustomFieldsId",
                table: "BillingDocumentItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_CustomObjectsId",
                table: "BillingDocumentItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_PaymentsAppliedToId",
                table: "BillingDocumentItems",
                column: "PaymentsAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_SubscriptionId1",
                table: "BillingDocumentItems",
                column: "SubscriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentItems_SubscriptionItemId1",
                table: "BillingDocumentItems",
                column: "SubscriptionItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocuments_CustomFieldsId",
                table: "BillingDocuments",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocuments_CustomObjectsId",
                table: "BillingDocuments",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentSettings_CreditMemoId",
                table: "BillingDocumentSettings",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingDocumentStateTransitions_BillingDocumentId",
                table: "BillingDocumentStateTransitions",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_MandateId",
                table: "Card",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_CardMandate_CustomerAcceptanceId",
                table: "CardMandate",
                column: "CustomerAcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CcRef_CardId",
                table: "CcRef",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CcRef_MandateId",
                table: "CcRef",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomFieldsId",
                table: "Contacts",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomObjectsId",
                table: "Contacts",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoAppliedTo_BillingDocumentId1",
                table: "CreditMemoAppliedTo",
                column: "BillingDocumentId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItems_CreditMemoId1",
                table: "CreditMemoItems",
                column: "CreditMemoId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItems_CustomFieldsId",
                table: "CreditMemoItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItems_CustomObjectsId",
                table: "CreditMemoItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItems_SubscriptionId1",
                table: "CreditMemoItems",
                column: "SubscriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemoItems_SubscriptionItemId1",
                table: "CreditMemoItems",
                column: "SubscriptionItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_AccountId1",
                table: "CreditMemos",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_ArTransactionsId",
                table: "CreditMemos",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_BillToId1",
                table: "CreditMemos",
                column: "BillToId1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_CreditMemoId",
                table: "CreditMemos",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_CustomFieldsId",
                table: "CreditMemos",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_CustomObjectsId",
                table: "CreditMemos",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditMemos_StateTransitionsId",
                table: "CreditMemos",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItems_CustomFieldsId",
                table: "DebitMemoItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItems_CustomObjectsId",
                table: "DebitMemoItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItems_DebitMemoId1",
                table: "DebitMemoItems",
                column: "DebitMemoId1");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItems_SubscriptionId1",
                table: "DebitMemoItems",
                column: "SubscriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemoItems_SubscriptionItemId1",
                table: "DebitMemoItems",
                column: "SubscriptionItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_AccountId1",
                table: "DebitMemos",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_BillingDocumentSettingsId",
                table: "DebitMemos",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_BillToId1",
                table: "DebitMemos",
                column: "BillToId1");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_CustomFieldsId",
                table: "DebitMemos",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_CustomObjectsId",
                table: "DebitMemos",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_DebitMemos_StateTransitionsId",
                table: "DebitMemos",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_GetCardList_MandateId",
                table: "GetCardList",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_GooglePay_CardId",
                table: "GooglePay",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_CustomFieldsId",
                table: "InvoiceItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_CustomObjectsId",
                table: "InvoiceItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId1",
                table: "InvoiceItems",
                column: "InvoiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_LineItemId",
                table: "InvoiceItems",
                column: "LineItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_SubscriptionId1",
                table: "InvoiceItems",
                column: "SubscriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_SubscriptionItemId1",
                table: "InvoiceItems",
                column: "SubscriptionItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AccountId1",
                table: "Invoices",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ArTransactionsId",
                table: "Invoices",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BillingDocumentSettingsId",
                table: "Invoices",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BillToId1",
                table: "Invoices",
                column: "BillToId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomFieldsId",
                table: "Invoices",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomObjectsId",
                table: "Invoices",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SoldToId1",
                table: "Invoices",
                column: "SoldToId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StateTransitionsId",
                table: "Invoices",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTier_SubscriptionItemId",
                table: "ItemTier",
                column: "SubscriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NzBecsDebit_MandateId",
                table: "NzBecsDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AccountId1",
                table: "Order",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomFieldsId",
                table: "Order",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomObjectsId",
                table: "Order",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_CustomFieldsId",
                table: "OrderLineItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_CustomObjectsId",
                table: "OrderLineItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_OrderId1",
                table: "OrderLineItems",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_RevenueId",
                table: "OrderLineItems",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_PadDebit_MandateId",
                table: "PadDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_AccountId1",
                table: "PaymentMethods",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_AchDebitId",
                table: "PaymentMethods",
                column: "AchDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_ApplePayId",
                table: "PaymentMethods",
                column: "ApplePayId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_AuBecsDebitId",
                table: "PaymentMethods",
                column: "AuBecsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_AutogiroDebitId",
                table: "PaymentMethods",
                column: "AutogiroDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BacsDebitId",
                table: "PaymentMethods",
                column: "BacsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BetalingsDebitId",
                table: "PaymentMethods",
                column: "BetalingsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BillingDetailsId",
                table: "PaymentMethods",
                column: "BillingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CardId",
                table: "PaymentMethods",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CcRefId",
                table: "PaymentMethods",
                column: "CcRefId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CustomFieldsId",
                table: "PaymentMethods",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CustomObjectsId",
                table: "PaymentMethods",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_GooglePayId",
                table: "PaymentMethods",
                column: "GooglePayId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_NzBecsDebitId",
                table: "PaymentMethods",
                column: "NzBecsDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PadDebitId",
                table: "PaymentMethods",
                column: "PadDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PaypalAdaptiveId",
                table: "PaymentMethods",
                column: "PaypalAdaptiveId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PaypalExpressId",
                table: "PaymentMethods",
                column: "PaypalExpressId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PaypalExpressNativeId",
                table: "PaymentMethods",
                column: "PaypalExpressNativeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_SepaDebitId",
                table: "PaymentMethods",
                column: "SepaDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOption_DetailId",
                table: "PaymentOption",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOption_PaymentScheduleId",
                table: "PaymentOption",
                column: "PaymentScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AccountId1",
                table: "Payments",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomFieldsId",
                table: "Payments",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomObjectsId",
                table: "Payments",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GatewayOptionsId",
                table: "Payments",
                column: "GatewayOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GatewayStateTransitionsId",
                table: "Payments",
                column: "GatewayStateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId1",
                table: "Payments",
                column: "PaymentMethodId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTransactionsId",
                table: "Payments",
                column: "PaymentTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_StateTransitionsId",
                table: "Payments",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsAppliedTo_BillingDocumentId1",
                table: "PaymentsAppliedTo",
                column: "BillingDocumentId1");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsAppliedTo_PaymentId",
                table: "PaymentsAppliedTo",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_BillingDocumentId",
                table: "PaymentSchedule",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_CustomFieldsId",
                table: "PaymentSchedule",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSchedule_CustomObjectsId",
                table: "PaymentSchedule",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItemPayments_PaymentScheduleItemId",
                table: "PaymentScheduleItemPayments",
                column: "PaymentScheduleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItems_BillingDocumentId",
                table: "PaymentScheduleItems",
                column: "BillingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItems_CustomFieldsId",
                table: "PaymentScheduleItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItems_CustomObjectsId",
                table: "PaymentScheduleItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItems_PaymentId",
                table: "PaymentScheduleItems",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentScheduleItems_PaymentScheduleId1",
                table: "PaymentScheduleItems",
                column: "PaymentScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_ArTransactionsId",
                table: "PaymentTransactions",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_StateId",
                table: "PaymentTransactions",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_CustomFieldsId",
                table: "Plan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_CustomObjectsId",
                table: "Plan",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ProductId1",
                table: "Plan",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalance_SubscriptionId",
                table: "PrepaidBalance",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalances_SubscriptionId",
                table: "PrepaidBalances",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalanceTransaction_PrepaidBalanceId",
                table: "PrepaidBalanceTransaction",
                column: "PrepaidBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PrepaidBalanceTransaction_ValidityPeriodId",
                table: "PrepaidBalanceTransaction",
                column: "ValidityPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_AmountsId",
                table: "Price",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CustomFieldsId",
                table: "Price",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_CustomObjectsId",
                table: "Price",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_DiscountAmountsId",
                table: "Price",
                column: "DiscountAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_DrawdownId",
                table: "Price",
                column: "DrawdownId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_OverageId",
                table: "Price",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_PlanId1",
                table: "Price",
                column: "PlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_Price_PrepaymentId",
                table: "Price",
                column: "PrepaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_RecurringId",
                table: "Price",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_RevenueId",
                table: "Price",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Price_UnitAmountsId",
                table: "Price",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_CustomFieldsId",
                table: "ProductPlan",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_CustomObjectsId",
                table: "ProductPlan",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPlan_ProductId1",
                table: "ProductPlan",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_AmountsId",
                table: "ProductPrice",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_CustomFieldsId",
                table: "ProductPrice",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_CustomObjectsId",
                table: "ProductPrice",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_DiscountAmountsId",
                table: "ProductPrice",
                column: "DiscountAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_DrawdownId",
                table: "ProductPrice",
                column: "DrawdownId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_OverageId",
                table: "ProductPrice",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_PrepaymentId",
                table: "ProductPrice",
                column: "PrepaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductPlanId1",
                table: "ProductPrice",
                column: "ProductPlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_RecurringId",
                table: "ProductPrice",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_RevenueId",
                table: "ProductPrice",
                column: "RevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_UnitAmountsId",
                table: "ProductPrice",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomFieldsId",
                table: "Products",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomObjectsId",
                table: "Products",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_AmountsId",
                table: "ProductTier",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_ProductPriceId",
                table: "ProductTier",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTier_UnitAmountsId",
                table: "ProductTier",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundAppliedToItem_RefundsAppliedToId",
                table: "RefundAppliedToItem",
                column: "RefundsAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_AccountId1",
                table: "Refunds",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_CreditMemoId",
                table: "Refunds",
                column: "CreditMemoId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_CustomFieldsId",
                table: "Refunds",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_CustomObjectsId",
                table: "Refunds",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_GatewayOptionsId",
                table: "Refunds",
                column: "GatewayOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_PaymentMethodId1",
                table: "Refunds",
                column: "PaymentMethodId1");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundTransactionsId",
                table: "Refunds",
                column: "RefundTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_StateTransitionsId",
                table: "Refunds",
                column: "StateTransitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_BillingDocumentId1",
                table: "RefundsAppliedTo",
                column: "BillingDocumentId1");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_PaymentId",
                table: "RefundsAppliedTo",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundsAppliedTo_RefundId",
                table: "RefundsAppliedTo",
                column: "RefundId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundTransactions_ArTransactionsId",
                table: "RefundTransactions",
                column: "ArTransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundTransactions_StateId",
                table: "RefundTransactions",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSubscription_CustomFieldsId",
                table: "ResumeSubscription",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SepaDebit_MandateId",
                table: "SepaDebit",
                column: "MandateId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionAddPlans_CustomFieldsId",
                table: "SubscriptionAddPlans",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_CustomFieldsId",
                table: "SubscriptionItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_CustomObjectsId",
                table: "SubscriptionItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_OverageId",
                table: "SubscriptionItems",
                column: "OverageId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_PriceId1",
                table: "SubscriptionItems",
                column: "PriceId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_RecurringId",
                table: "SubscriptionItems",
                column: "RecurringId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_SubscriptionAddPlanId",
                table: "SubscriptionItems",
                column: "SubscriptionAddPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionItems_SubscriptionPlanId1",
                table: "SubscriptionItems",
                column: "SubscriptionPlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPauses_CustomFieldsId",
                table: "SubscriptionPauses",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPauses_ResumeBehaviorId",
                table: "SubscriptionPauses",
                column: "ResumeBehaviorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlans_CustomFieldsId",
                table: "SubscriptionPlans",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlans_CustomObjectsId",
                table: "SubscriptionPlans",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlans_PlanId1",
                table: "SubscriptionPlans",
                column: "PlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlans_ProductId1",
                table: "SubscriptionPlans",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPlans_SubscriptionId1",
                table: "SubscriptionPlans",
                column: "SubscriptionId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionRenews_TermsId",
                table: "SubscriptionRenews",
                column: "TermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_AccountId1",
                table: "Subscriptions",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_BillingDocumentSettingsId",
                table: "Subscriptions",
                column: "BillingDocumentSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_BillToId1",
                table: "Subscriptions",
                column: "BillToId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CurrentTermId",
                table: "Subscriptions",
                column: "CurrentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CustomFieldsId",
                table: "Subscriptions",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CustomObjectsId",
                table: "Subscriptions",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_InitialTermId",
                table: "Subscriptions",
                column: "InitialTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_InvoiceOwnerAccountId1",
                table: "Subscriptions",
                column: "InvoiceOwnerAccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_OrderId",
                table: "Subscriptions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_RenewalTermId",
                table: "Subscriptions",
                column: "RenewalTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SoldToId1",
                table: "Subscriptions",
                column: "SoldToId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTerms_CurrentTermId",
                table: "SubscriptionTerms",
                column: "CurrentTermId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTerms_RenewalTermId",
                table: "SubscriptionTerms",
                column: "RenewalTermId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_BillingDocumentItemId",
                table: "TaxationItems",
                column: "BillingDocumentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_CreditMemoItemId",
                table: "TaxationItems",
                column: "CreditMemoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_CustomFieldsId",
                table: "TaxationItems",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_CustomObjectsId",
                table: "TaxationItems",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_DebitMemoItemId",
                table: "TaxationItems",
                column: "DebitMemoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxationItems_InvoiceItemId",
                table: "TaxationItems",
                column: "InvoiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_AmountsId",
                table: "Tier",
                column: "AmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_PriceId",
                table: "Tier",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tier_UnitAmountsId",
                table: "Tier",
                column: "UnitAmountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Usages_AccountId1",
                table: "Usages",
                column: "AccountId1");

            migrationBuilder.CreateIndex(
                name: "IX_Usages_CustomFieldsId",
                table: "Usages",
                column: "CustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Usages_CustomObjectsId",
                table: "Usages",
                column: "CustomObjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidityPeriod_PrepaidBalancesId",
                table: "ValidityPeriod",
                column: "PrepaidBalancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_BillingDocumentSettings_BillingDocumentSettingsId",
                table: "Accounts",
                column: "BillingDocumentSettingsId",
                principalTable: "BillingDocumentSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
