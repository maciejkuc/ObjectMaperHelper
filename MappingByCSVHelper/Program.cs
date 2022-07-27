using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace MappingByColumnName
{
    class Program
    {
        static void Main()
        {
            ParseStatement();
            AutoParseStatement();
        }

        static void ParseStatement()

        {
            IEnumerable<BankOperationDocument> documents;

            using (var streamReader = File.OpenText("Lista_transakcji.csv"))
            {
                var reader = new CsvReader(streamReader);
                reader.Configuration.RegisterClassMap<BankOperationMap>();
                reader.Configuration.Delimiter = ";";
                reader.Configuration.IgnoreQuotes = true;
                reader.Configuration.TrimFields = true;
                //reader.Read();
                //BankOperationDocument doc =  reader.GetRecord<BankOperationDocument>();

                documents = reader.GetRecords<BankOperationDocument>().ToList();
            }

            foreach (var doc in documents)
            {
                Console.WriteLine($"{doc.AccountingDate}, {doc.ContractorName}, {doc.Amount}, {doc.Currency}");
            }
            Console.ReadLine();
        }

        static void AutoParseStatement()

        {
            IEnumerable<SimpleBankOperationDocument> documents;

            using (var streamReader = File.OpenText("Lista_transakcji_headers.csv"))
            {
                var reader = new CsvReader(streamReader);
                //reader.Configuration.RegisterClassMap<BankOperationMap>();
                reader.Configuration.Delimiter = ";";
                reader.Configuration.IgnoreQuotes = true;
                reader.Configuration.TrimFields = true;
                reader.Parser.Configuration.TrimHeaders = true;
                reader.Configuration.AutoMap<SimpleBankOperationDocument>();
                //reader.Read();
                //SimpleBankOperationDocument doc =  reader.GetRecord<SimpleBankOperationDocument>();

                documents = reader.GetRecords<SimpleBankOperationDocument>().ToList();
            }

            foreach (var doc in documents)
            {
                Console.WriteLine($"{doc.AccountingDate}, {doc.ContractorName}, {doc.Amount}, {doc.Currency}");
            }
            Console.ReadLine();
        }
    }
}
