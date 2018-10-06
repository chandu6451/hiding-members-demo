using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Show();

            Manager mgr = new Manager();
            mgr.Show();

            Employee empMgr = new Manager();
            empMgr.Show();

            

            Console.ReadKey();
        }
    }
}
