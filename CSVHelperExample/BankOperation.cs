using System;

namespace CSVHelperExample
{
    public class BankOperationDocument
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public BankOperationDocument()
        {
            CurrencyDate = DateTime.MinValue;
            AccountingDate = DateTime.MinValue;

            Amount = 0;
            Currency = string.Empty;
            OperationCodeGVC = 0;
            OperationCodeSWIFT = string.Empty;
            ClientInfo = string.Empty;
            ClientReference = string.Empty;
            BankReference = string.Empty;
            AdditionalInfo = string.Empty;

            OperationCodeName = string.Empty;
            ClientAccount = string.Empty;
            TransactionReference = string.Empty;
            Title = string.Empty;

            ContractorName = string.Empty;
            ContractorAddress = string.Empty;
            ContractorAccount = string.Empty;
        }

        public DateTime CurrencyDate { get; set; }
        public DateTime AccountingDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public long OperationCodeGVC { get; set; }
        public string OperationCodeSWIFT { get; set; }
        public string ClientInfo { get; set; }
        public string ClientReference { get; set; }
        public string BankReference { get; set; }
        public string AdditionalInfo { get; set; }

        public string OperationCodeName { get; set; }
        public string ClientAccount { get; set; }
        public string TransactionReference { get; set; }
        public string Title { get; set; }

        public string ContractorName { get; set; }
        public string ContractorAddress { get; set; }
        public string ContractorAccount { get; set; }
    }

    public class SimpleBankOperationDocument
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public SimpleBankOperationDocument()
        {

        }


        public DateTime AccountingDate { get; set; }
        public DateTime CurrencyDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public string BankReference { get; set; }

        public string OperationCodeName { get; set; }
        public string TransactionReference { get; set; }
        public string Title { get; set; }

        public string ContractorName { get; set; }
        public string ContractorAccount { get; set; }
    }
}
