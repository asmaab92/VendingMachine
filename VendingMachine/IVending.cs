using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IVending
    {
        Product Purchase();
        List<string> ShowAll();
        string Details(int Id);
        void InsertMoney();
        Dictionary<int, int> EndTransaction();
    }
}
