using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IVending
    {
        decimal Purchase(string ID);
        void ShowAll();
        decimal InsertMoney(int coin);
        Dictionary<string, decimal> EndTransaction();
    }
}
