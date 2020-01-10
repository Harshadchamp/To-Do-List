using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class AddItem
    {
        public void Item()
        {
            Console.WriteLine("Enter the Item:");
            string item = Console.ReadLine();
            Program.serviceProviderObject.AddItem(item);
        }
    }
}
