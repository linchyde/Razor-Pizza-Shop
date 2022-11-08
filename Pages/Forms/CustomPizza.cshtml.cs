using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 2;
            if (Pizza.Anchovies) PizzaPrice += 3;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.BbqSauce) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 2;
            if (Pizza.Pepperoni) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});
        }
    }
}
