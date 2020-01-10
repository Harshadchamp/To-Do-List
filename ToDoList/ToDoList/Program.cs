using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace ToDoList
{
    enum options
    {
        Add=1,Delete=3,Update=2,Show=4
    }
    public class Program
    {
        public static ServiceProvider serviceProviderObject = new ServiceProvider();
        static void Main(string[] args)
        { 
            Console.WriteLine("*****WELCOME*****");
            while (true)
            {
                Console.WriteLine("\n\n1.Add Item\n2.Update Item\n3.Delete Item\n4.Show Items\n5.Exit\n");
                Console.Write("Enter Your Choice:");
                int choice = 0,lowerBound=1,upperBound=5;
                while (true)
                {
                    try
                    {
                        choice = Int32.Parse(Console.ReadLine());
                        if (choice > upperBound || choice < lowerBound)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch { Console.Write("Enter a valid option:"); }
                }
                switch(choice)
                {
                    case (int)options.Add: AddItem addObject = new AddItem();
                        addObject.Item();
                        break;
                    case (int)options.Update:UpdateItem updateObject = new UpdateItem();
                        updateObject.Item();
                        break;
                    case (int)options.Delete:DeleteItem deleteObject = new DeleteItem();
                        deleteObject.Item();
                        break;
                    case (int)options.Show:ShowItems showObject = new ShowItems();
                        showObject.Items();
                        break;
                     default:
                        Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}


