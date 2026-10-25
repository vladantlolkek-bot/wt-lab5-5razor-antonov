using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_antonov.Data;
using wt_lab5_5razor_antonov.Models;

namespace wt_lab5_5razor_antonov.Pages.Cars;

public class IndexModel : PageModel
{
    public List<Car> Cars { get; set; } = new();

    public void OnGet()
    {
        Cars = CarStore.Cars;
    }

    // Обработчик для удаления прямо из каталога
    public IActionResult OnPostDelete(int id)
    {
        var car = CarStore.Cars.FirstOrDefault(c => c.Id == id);
        if (car != null) CarStore.Cars.Remove(car);
        return RedirectToPage("./Index");
    }
}