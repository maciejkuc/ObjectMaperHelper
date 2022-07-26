using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ObjectMaper;
using ObjectMaper.Interfaces;

namespace ObjectMaperProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //TransformContext context = new TransformContext();
            //ObjectMaper objectMaper = new ObjectMaper(context);
           
            ObjectMaperControler objectMaperControler = new ObjectMaperControler();
            IEnumerable<Car> cars;

            objectMaperControler.configuration.OpenWizard = false;

            objectMaperControler.GetObject<Car>();
            objectMaperControler.GetInputData(new InputData() { Filename = "cars.csv" });

            cars = objectMaperControler.GetMappedData<Car>();

            if (objectMaperControler.Reader.Configuration.HasHeaderRow)
            {
                Console.WriteLine(string.Join("\t",objectMaperControler.Reader.GetColumnHeaders()));
            }
            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model}\t{car.Color}\t{car.Power}\t{car.Engine}");
            }
            Console.ReadLine();
        }
    }

    internal class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public Engine Engine { get; set; }
    }

    class InputData : IInputData
    {
        public string Filename { get; set; }
        public DataTable Datatable { get; set; }
        public Stream Stream { get ; set; }
    }
    enum Engine
    {
        gasoline,
        diesel,
        gas,
        none
    }
}
