using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class ServiceProvider
    {
        List<TodoItem> toDoItemList = new List<TodoItem>();
        public void AddItem(string item)
        {
            TodoItem itemObject = new TodoItem();
            itemObject.item = item;
            toDoItemList.Add(itemObject);
        }
        public void DeleteItem(int option)
        {
            toDoItemList.RemoveAt(option-1);
        }
        public void UpdateItem(int option,string item)
        {
            toDoItemList[option - 1].item = item;
        }
        public string getItem(int option)
        {
            return toDoItemList[option].item;
        }
        public int listCount()
        {
            return toDoItemList.Count;
        }
    }
}
