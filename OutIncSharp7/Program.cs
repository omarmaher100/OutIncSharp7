using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutIncSharp7
{
    class Program
    {
        public static void MyName(out string firstName, out string lastName)
        {
            firstName = "Omar";
            lastName = "Maher";
        }
        public static void OldWay()
        {
            string firstName;
            string lastName;
            MyName(out firstName, out lastName);

            Console.WriteLine($"My Name is :{ firstName} {lastName}  => Old way");
        }

        public static void CSharp7Way()
        {
            MyName(out string firstName, out string lastName);

            Console.WriteLine($"My Name is :{ firstName} {lastName}  => c#7 way");
        }
        static void Main(string[] args)
        {
            OldWay();
            CSharp7Way();
        }
    }
}
