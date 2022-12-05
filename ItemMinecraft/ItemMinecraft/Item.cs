using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemMinecraft
{
    public class Item : Iitem
    {
        public string Name { get; set; }
        public List<(Iitem, double)> items { get; set; } = new List<(Iitem, double)>();

        public void addItem(Iitem item, double countItem)
        {
            items.Add((item, countItem == 0? 1 : countItem));
        }

        public void display(double count, int tabs)
        {
            string tabseString = "";
            for (int i = 0; i < tabs; i++)
            {
                tabseString += "\t";
            }

            Console.WriteLine($"{tabseString}{Name} - {count} "+ (items.Count > 0 ? ":" : ""));
            
            foreach((Iitem,double) item in items)
            {
                item.Item1.display(item.Item2*count,tabs+1);
            }
        }

        public void removeItem(Iitem item)
        {
            (Iitem,double) itemFind = items.Find(e => e.Item1.Name == item.Name);
            items.Remove(itemFind);
        }

        public List<(string,double)> GetElemsCount(double count, List<(string,double)> arrayItems)
        {
            for (int i = 0; i < arrayItems.Count; i++)
            {
                if (arrayItems[i].Item1 == this.Name)
                {
                    arrayItems[i] = (arrayItems[i].Item1, arrayItems[i].Item2+count);
                }
            }

            foreach ((Iitem, double) item in items)
            {
                item.Item1.GetElemsCount(item.Item2 * count, arrayItems);
            }

            return arrayItems;
        }
    }
}
