using System;
using System.IO;

namespace CSharp25_11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Test(@"C:\Users\dmaty\RiderProjects\CSharp25_11\test.txt");
        }

        private static void Test(string file)
        {
            Client client1, client2;
            using (var reader = new StreamReader(file))
            {
                string data = reader.ReadLine().Trim();
                int id;
                client1 = new Client(new ConcretePrototype1(data, 0));
                client2 = new Client(new ConcretePrototype2(data, 0));

                for (int i = 0; i < Convert.ToInt32(reader.ReadLine()); i++)
                {
                    id = Convert.ToInt32(reader.ReadLine());
                    client1.Operation(id);
                    client2.Operation(id);
                }
            }
            Console.WriteLine(client1.GetObjects());
            Console.WriteLine(client2.GetObjects());
        }
    }
}