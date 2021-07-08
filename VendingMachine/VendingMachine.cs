﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        Dictionary<string, Product> Products = new Dictionary<string, Product>()
        {{"P1",new Drink("CocaCola",5)},
         {"P2",new Drink("Pepsi",5)},
         {"P3",new Drink("Mirinda",5)},
         {"P4",new Drink("Sprite",5)},

         {"P5",new Food("Chocolate",5.4M)},
         {"P6",new Food("Chips",3.77M)},

         {"P7",new Toy("Car",5.4M)},
         {"P8",new Toy("Doll",5.4M)},
        };

        public Dictionary<string, decimal> EndTransaction()
        {
            throw new NotImplementedException();
        }

        public decimal InsertMoney(int coin)
        {
            throw new NotImplementedException();
        }

        public decimal Purchase(string ID)
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
