using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    internal class Greeting
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);
            try
            {
                Console.WriteLine(Properties.Settings.Default.Name);
                Console.WriteLine((Properties.Settings.Default.Age).ToString());
                Console.WriteLine(Properties.Settings.Default.Job);
            }
            catch
            {
                Console.WriteLine("Setting file doesn't exist!");
            }
            Console.Write("Name: ");
            Properties.Settings.Default.Name = Console.ReadLine();

            Console.Write("Age: ");
            Properties.Settings.Default.Age = Console.ReadLine();
                        
            Console.Write("Job: ");
            Properties.Settings.Default.Job = Console.ReadLine();
            Properties.Settings.Default.Save();
        }
    }
}
