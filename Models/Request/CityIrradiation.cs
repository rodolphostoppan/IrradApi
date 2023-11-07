using System.ComponentModel.DataAnnotations;

namespace IrradApi.Models.Request;
public class CityIrradiation
{
    [Required]
    public string? NameIdentification { get; set; }

    [Required]
    public CityIrradiationData? CityIrradiationData { get; set; }
}
