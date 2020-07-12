using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestApi01.Models;


namespace TestApi01.Controllers
{
    [Produces("application/json")]
    [Route("api/itemamount")]
    public class ItemAmountController
    {
        ItemAmount[] allItems = new ItemAmount[]
        {
            new ItemAmount {ItemID=1,ItemNumber=45645,ItemsAmount=10},
            new ItemAmount {ItemID=2,ItemNumber=4353,ItemsAmount=10},
            new ItemAmount {ItemID=3,ItemNumber=3453,ItemsAmount=10},
            new ItemAmount {ItemID=4,ItemNumber=43543,ItemsAmount=10}
        };

        [HttpGet]
        public IEnumerable<ItemAmount> ListAllItemsAmount(){
            return allItems;
        }

        [HttpGet("itemnr/{itemNumber}")]
        public IEnumerable<ItemAmount> ListItemById(int itemNumber){

            IEnumerable<ItemAmount> returnValue =
                from g in allItems
                where g.ItemNumber.Equals(itemNumber)
                select g;

            return returnValue;

        }
    }
}