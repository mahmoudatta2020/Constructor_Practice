using System;

namespace Constructor
{
    class car
    {
        public string model;
        public string color;
        public int year;
        public car(string modelName,string colorName,int year2)
        {
            model = modelName;
            color = colorName;
            year = year2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            car BMW = new car("fnjnd","blue",2019);
            
            Console.WriteLine("Model is"+" "+BMW.model);
            Console.WriteLine("Color is" + " " + BMW.color);
            Console.WriteLine("Year is " + " " + BMW.year);
        }
    }
}
