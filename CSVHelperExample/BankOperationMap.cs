using System;
using CsvHelper.Configuration;

namespace CSVHelperExample
{
    sealed class BankOperationMap : ClassMap<BankOperationDocument>
    {
        public BankOperationMap()
        {
            Map(m => m.AccountingDate).Index(1);
            Map(m => m.ContractorName).Index(2);
            Map(m => m.Title).Index(3);
            Map(m => m.ContractorAccount).Index(4);
            Map(m => m.BankReference).Index(5);
            Map(m => m.OperationCodeName).Index(6);
            Map(m => m.TransactionReference).Index(7);
            Map(m => m.Amount).Index(8);
            Map(m => m.Currency).Index(9);
            Map(m => m.CurrencyDate).Index(1);
        }
    }
}
