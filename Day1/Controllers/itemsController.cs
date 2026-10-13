using Microsoft.AspNetCore.Mvc;
using Day1.Models;

namespace Day1.Controllers
{
    public class itemsController: Controller
    {
        public IActionResult Index()
        {
            items[] items = new items[5];
            for(int i = 0; i<5; i++)
            {
                var item  = new items()
                {
                    id = i + 1,
                    name = "Items" + (i + 1),
                    description = "This is an Items Description",
                    price = 10.0f + i,
                    stockQuantity = i + 3,



                };
                items[i] = item; 
            }
            return View(items);
        }
    }

    

}
