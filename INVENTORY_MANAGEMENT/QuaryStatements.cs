using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace INVENTORY_MANAGEMENT
{
    class QuaryStatements
    {
        public const string STOCK_QUERY = "select+" +
            " inventory.inv_id,inventory.inv_name,inventory.inv_description,inventory.inv_unit_price,stock.stock_qunantity" +
            " from inventory " +
            "left join stock " +
            "on " +
            "inventory.inv_id = stock.stock_id;";

        public const string ADD_INVENTORY = "INSERT INTO" +
            " inventory(inv_id,inv_name,inv_description,inv_unit_price)" +
            " VALUES(@inv_id,@inv_name,@inv_description,@inv_unit_price);";



    }
}
