using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constants
{
    public class Expands
    {
        public List<string> AccountExpand = new List<string>
                {
                    "payment_methods",
                    "payments",
                    "default_payment_method",
                    "billing_documents",
                    "bill_to",
                    "sold_to",
                    "subscriptions",
                    "subscriptions.subscription_plans.plan",
                    "subscriptions.subscription_plans.subscription_items",
                    "usage_records",
                    "invoices",
                    "credit_memos",
                    "debit_memos"
                };

        public List<string> CreditMemoExpand = new List<string>
        {
            "account",
            "items",
            "bill_to",
            "applied_to"
        };

        public List<string> CreditMemoItemExpand = new List<string>
        {
            "subscription",
            "credit_memo",
            "subscription_item",
            "taxation_items",
            "billing_document",
        };

        public List<string> CustomObjectExpand = new List<string>
        {
            "account"
        };

        public List<string> DebitMemoExpand = new List<string>
        {
            "account",
            "items",
            "bill_to"
        };

        public List<string> DebitMemoItemExpand = new List<string>
        {
            "subscription",
            "debit_memo",
            "subscription_item",
            "taxation_items",
            "billing_document",
        };

        public List<string> InvoiceItemsExpand = new List<string>
        {
            "subscription",
            "subscription_item",
            "taxation_items",
            "invoice",
            "line_item"
        };

        public List<string> InvoicesExpand = new List<string>
        {
            "account",
            "items",
            "bill_to"
        };

        public List<string> OrderExpand = new List<string>
        {
            "account",
            "line_items",
            "line_items.invoice_items",
            "subscriptions",
            "subscriptions.subscription_plans",
            "subscriptions.subscription_plans.subscription_items",
            "order_actions",
        };

        public List<string> PaymentExpand = new List<string>
        {
            "account",
            "payment_method",
            "payment_applied_to",
        };

        public List<string> PaymentMethodExpand = new List<string>
        {
            "account"
        };

        public List<string> PlanExpand = new List<string>
        {
            "product",
            "prices"
        };

        public List<string> PriceExpand = new List<string>
        {
            "plan"
        };

        public List<string> ProductExpand = new List<string>
        {
            "plans",
            "plans.prices"
        };

        public List<string> RefundExpand = new List<string>
        {
            "account",
            "payment_method",
            "applied_to",
            "applied_to.payment",
            "applied_to.items",
        };

        public List<string> SubscriptionItemsExpand = new List<string>
        {
            "price",
            "subscription_plan"
        };

        public List<string> SubscriptionPlanExpand = new List<string>
        {
            "subscription",
            "plan",
            "subscription_items"
        };

        public List<string> SubscriptionsExpand = new List<string>
                {
                    "subscription_plans",
                    "account",
                    "account.payment_methods",
                    "account.invoices",
                    "account.payments",
                    "account.credit_memos",
                    "account.debit_memos",
                    "invoice_owner_account",
                    "bill_to",
                    "sold_to",
                    "invoice_items",
                 //   "prepaid_balance",
                    "invoice_items"
                };

        public List<string> UsageRecordExpand = new List<string>
        {
            "account",
            "subscriptions",
            "subscriptions.subscription_plans.plan",
            "subscription_items",
        };
    };
}