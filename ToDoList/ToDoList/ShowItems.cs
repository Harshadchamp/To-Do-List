using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ShowItems
    {
        public void Items()
        {
            int listCount = Program.serviceProviderObject.listCount();
            if (listCount == 0)
            {
                Console.WriteLine("No Items So please add items..");
            }
            for (int i = 0; i < listCount; i++)
            {
                string displayItem = Program.serviceProviderObject.getItem(i);
                Console.WriteLine((i + 1) + "." + displayItem);
            }
        }
    }
}
