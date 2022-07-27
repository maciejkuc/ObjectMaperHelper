using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ObjectMappingHelper;
using ObjectMappingHelper.Interfaces;

namespace ObjectMappingHelperProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //TransformContext context = new TransformContext();
            //ObjectMappingHelper ObjectMappingHelper = new ObjectMappingHelper(context);
           
            ObjectMappingControler ObjectMappingHelperControler = new ObjectMappingControler();
            IEnumerable<Car> cars;

            ObjectMappingHelperControler.configuration.OpenWizard = false;

            ObjectMappingHelperControler.GetObject<Car>();
            ObjectMappingHelperControler.GetInputData(new InputData() { Filename = "cars.csv" });

            cars = ObjectMappingHelperControler.GetMappedData<Car>();

            if (ObjectMappingHelperControler.Reader.Configuration.HasHeaderRow)
            {
                Console.WriteLine(string.Join("\t",ObjectMappingHelperControler.Reader.GetColumnHeaders()));
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
