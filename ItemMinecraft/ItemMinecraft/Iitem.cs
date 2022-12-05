using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemMinecraft
{
    public interface Iitem
    {
        public string Name { get; set; }
        public List<(Iitem, double)> items { get; set; }

        public void display(double count, int tabs);
        public void addItem(Iitem item, double countItem);
        public void removeItem(Iitem item);
        public List<(string, double)> GetElemsCount(double count, List<(string, double)> arrayItems);

    }
}
