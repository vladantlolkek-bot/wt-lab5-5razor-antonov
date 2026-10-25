using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_antonov.Data;
using wt_lab5_5razor_antonov.Models;

namespace wt_lab5_5razor_antonov.Pages.Cars;

public class DetailsModel : PageModel
{
    public Car? Car { get; set; }

    public IActionResult OnGet(int id)
    {
        Car = CarStore.Cars.FirstOrDefault(c => c.Id == id);
        if (Car == null) return NotFound(); // Обработка ошибки!
        return Page();
    }
}