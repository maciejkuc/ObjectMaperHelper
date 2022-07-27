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
            //ParseStatement();
            AutoParseStatement();
        }

        static void ParseStatement()

        {
            IEnumerable<BankOperationDocument> documents;

            using (var reader = new StreamReader("Lista_transakcji.csv"))
            using (var csvreader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {               
                csvreader.Context.RegisterClassMap<BankOperationMap>();
                csvreader.Context.Configuration.Delimiter = ";";
                csvreader.Context.Configuration.DetectDelimiter = true;
                csvreader.Context.Configuration.HasHeaderRecord = true;
                //csvreader.Context.Configuration.TrimOptions = CsvHelper.Configuration.TrimOptions.InsideQuotes;
                csvreader.Read();
                BankOperationDocument doc =  csvreader.GetRecord<BankOperationDocument>();

                documents = csvreader.GetRecords<BankOperationDocument>().ToList();
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

            using (var reader = new StreamReader("Lista_transakcji_headers.csv"))
            using (var csvreader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                csvreader.Context.Configuration.Delimiter = ";";
                //csvreader.Context.Configuration.Quote = '"';
                //csvreader.Configuration.TrimFields = true;
                //csvreader.Parser.Configuration.TrimHeaders = true;
                csvreader.Context.AutoMap<SimpleBankOperationDocument>();
                //reader.Read();
                //SimpleBankOperationDocument doc =  reader.GetRecord<SimpleBankOperationDocument>();

                documents = csvreader.GetRecords<SimpleBankOperationDocument>().ToList();
            }

            foreach (var doc in documents)
            {
                Console.WriteLine($"{doc.AccountingDate}, {doc.ContractorName}, {doc.Amount}, {doc.Currency}");
            }
            Console.ReadLine();
        }
    }
}
