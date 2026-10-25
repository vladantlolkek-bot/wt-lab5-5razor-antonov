using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_antonov.Data;
using wt_lab5_5razor_antonov.Models;

namespace wt_lab5_5razor_antonov.Pages.Cars;

public class CreateModel : PageModel
{
    [BindProperty]
    public Car Car { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        Car.Id = CarStore.Cars.Any() ? CarStore.Cars.Max(x => x.Id) + 1 : 1;
        CarStore.Cars.Add(Car);
        return RedirectToPage("./Index");
    }
}