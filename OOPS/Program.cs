using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"C:\Users\OMKAR BADE\source\repos\OOPS\OOPS\Inventory.json");
            Console.ReadKey();
        }
    }
}
