using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class InventoryManagement
    {

        public void ReadData(string filepath)
        {
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = jsonConvert.DeserializeObject<List<Inventory>>(json);
                    Console.WriteLine("Name\t" + "Price\t" + "Weight\t" + "Total amount");
                    foreach (var data in items)
                    {
                        Console.WriteLine(data.Name + "\t" + data.Price + "\t" + data.Weight + "\t" + data.Price * data.Weight);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
