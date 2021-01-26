using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Razor.Parser;

namespace CustomControls
{
    public class AccVariables
    {
        public class Actions
        {
            public readonly static string SALES = "001";
            public readonly static string PURCHASE = "002";
            public readonly static string SALARY = "003";
            public readonly static string ASSET_PURCHASE = "004";
            public readonly static string EXPENSE = "005";
            public readonly static string DUE_PAYMENT = "006";
            public readonly static string DUE_PAYMENT_CUSTOMER = "007";
            public readonly static string ADVANCE_PAYMENT = "008";
            public readonly static string ADVANCE_PAYMENT_CUSTOMER = "009";
            public readonly static string OPENING_BALANCE = "010";
            public readonly static string ClOSING_BALANCE = "011";
            public readonly static string WAREHOUSE_DUE_PAYMENT = "012";
            public readonly static string WAREHOUSE_PURCHASE = "013";
            public readonly static string EXPENSE_DUE_PAYMENT = "014";



        }

        public class AccIdentifier
        {
            public readonly static string CASH = "001";
            public readonly static string VAT_PURCHASE = "002";
            public readonly static string VAT_SALES = "003";
            public readonly static string PARTY = "004";
            public readonly static string EMPLOYEE = "005";
            public readonly static string CUSTOMER = "006";
            public readonly static string BANK = "007";
        }

        public static Dictionary<string, string> DefaultAccounts = new Dictionary<string, string>()
        {
            {"001","CASH" },
            {"002","VAT_PURCHASE" },
            {"003","VAT_SALES" },
        };

        public class AccTypes
        {
            public readonly static int NORMAL = 0;
            public readonly static int DEBTOR = 1;
            public readonly static int CREDITOR = 2;

        }

        public class TransactionType
        {
            public readonly static int NORMAL = 0;
            public readonly static int DEBIT = 1;
            public readonly static int CREDIT = 2;

        }

        public class PartyPaymentMode
        {
            public readonly static int PURCHASE = 0;
            public readonly static int PURCHASE_DUE_PAYMENT = 1;
            public readonly static int ADVANCE = 2;
            public readonly static int WAREHOUSE_PURCHASE = 3;
            public readonly static int EXPENSE = 4;
            public readonly static int ASSET_PURCHASE = 5;
            public readonly static int EXPENSE_DUE_PAYMENT = 6;
            public readonly static int WAREHOUSE_PURCHASE_DUE_PAYMENT = 7;

            public Dictionary<int, string> Modes = new Dictionary<int, string>()
            {
                {0, "PURCHASE"},
                {1, "PURCHASE_DUE_PAYMENT"},
                {2, "ADVANCE"},
                {3, "WAREHOUSE_PURCHASE"},
                {4, "EXPENSE"},
                {5, "ASSET_PURCHASE"},
                {6, "EXPENSE_DUE_PAYMENT"},
                {7, "WAREHOUSE_PURCHASE_DUE_PAYMENT"},

            };
           

        }
    }
}
