using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace CSVHelperExample
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

            var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                DetectDelimiter = true,

            };

            using (var reader = new StreamReader("Lista_transakcji.csv"))
            using (var csvreader = new CsvReader(reader, config))
            {
                csvreader.Context.RegisterClassMap<BankOperationMap>();

                //csvreader.Read();
                //BankOperationDocument doc = csvreader.GetRecord<BankOperationDocument>();

                documents = csvreader.GetRecords<BankOperationDocument>().ToList();
            }

            foreach (var doc in documents)
            {
                Console.WriteLine($"{doc.AccountingDate}; {doc.ContractorName}; {doc.Amount}; {doc.Currency}");
            }
            Console.ReadLine();
        }

        static void AutoParseStatement()

        {
            IEnumerable<SimpleBankOperationDocument> documents;

            var config = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                DetectDelimiter = true,

            };

            using (var reader = new StreamReader("Lista_transakcji_headers.csv"))
            using (var csvreader = new CsvReader(reader, config))
            {
                csvreader.Context.AutoMap<SimpleBankOperationDocument>();
                //reader.Read();
                //SimpleBankOperationDocument doc =  reader.GetRecord<SimpleBankOperationDocument>();

                documents = csvreader.GetRecords<SimpleBankOperationDocument>().ToList();
            }

            foreach (var doc in documents)
            {
                Console.WriteLine($"{doc.AccountingDate}; {doc.ContractorName}; {doc.Amount}; {doc.Currency}");
            }
            Console.ReadLine();
        }
    }
}
