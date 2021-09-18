using System;
using System.Collections.Generic;
namespace Quiz1
{
    class Program

    {
        static void Main(string[] args)
        {
            int totalrose;
            string name, description, hight, circle;
            int ID, amount;
            Console.Write("input total roses : ");
            totalrose = int.Parse(Console.ReadLine());
            for(int i = 0; i <= totalrose; i++)
            {
                Console.Write("INPUT");
                Console.Write("ID : ");
                ID = int.Parse(Console.ReadLine());
                Console.Write("name : ");
                name = Console.ReadLine();
                Console.Write("description : ");
                description = Console.ReadLine();
                Console.Write("amount : ");
                amount = int.Parse(Console.ReadLine());
                Console.Write("hight : ");
                hight = Console.ReadLine();
                Console.Write("circle : ");
                circle = Console.ReadLine();

                rose rose_1 = new rose(ID,name,description,amount,hight,circle);  
            }
            rose
        }
        class rose
        {
            public int ID, Amount;
            public string name, description, hight, circle;
            public rose(int value_ID, string value_name, string value_description, int value_amount, string value_hight, string value_circle)
            {
                ID = value_ID;
                name = value_name;
                description = value_description;
                Amount = value_amount;
                hight = value_hight;
                circle = value_circle;
            }
            public void output()
            {
                Console.WriteLine("Rose ID = {0}", this.ID);
                Console.WriteLine("Rose name = {0}", this.name);
                Console.WriteLine("Rose description = {0}", this.description);
                Console.WriteLine("Rose amount = {0}", this.Amount);
                Console.WriteLine("Rose hight = {0}", this.hight);
                Console.WriteLine("Rose circle = {0}", this.circle);
            }
        }
        class outone
        {
            private List<rose> showon;
            public outone()
                {
                showon = new List<rose>();
                }
            public void list (rose Rose)
            {
                showon.Add(Rose);
            }
        }
    }
}
