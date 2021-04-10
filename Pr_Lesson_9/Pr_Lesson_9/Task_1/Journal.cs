using System;


namespace Task_1
{
    public class Journal : IPrintable
    {
        public string Name { get; set; }
        public Journal(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
