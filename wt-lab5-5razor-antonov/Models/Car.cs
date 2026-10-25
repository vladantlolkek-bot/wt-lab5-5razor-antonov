using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_antonov.Models;

public class Car
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите марку")]
    [StringLength(50, ErrorMessage = "Максимум 50 символов")]
    public string Brand { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите модель")]
    public string Model { get; set; } = string.Empty;

    [Range(1900, 2100, ErrorMessage = "Год от 1900 до 2100")]
    public int Year { get; set; }

    [Range(0.01, 1000000, ErrorMessage = "Цена должна быть больше 0")]
    public decimal PricePerDay { get; set; }

    public bool IsAvailable { get; set; } = true;
}