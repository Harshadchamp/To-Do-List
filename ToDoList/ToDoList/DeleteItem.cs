﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class DeleteItem
    {
        public void Item()
        {
            ShowItems showObject = new ShowItems();
            showObject.Items();
            Console.WriteLine("Select an item:");
            int option = 0;
            while (true)
            {
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                    if (option > 0 || option < Program.serviceProviderObject.listCount())
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch { Console.WriteLine("Enter Valid Option:"); }
            }
            Program.serviceProviderObject.DeleteItem(option);
        }
    }
}
