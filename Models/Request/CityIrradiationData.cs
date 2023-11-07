using System.ComponentModel.DataAnnotations;

namespace IrradApi.Models.Request;

public class CityIrradiationData
{
    [Required]
    public int Id { get; set; }

    [Required]
    public float Lon { get; set; }

    [Required]
    public float Lat { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? State { get; set; }

    [Required]
    public int Annual { get; set; }

    [Required]
    public int Jan { get; set; }

    [Required]
    public int Feb { get; set; }

    [Required]
    public int Mar { get; set; }

    [Required]
    public int Apr { get; set; }

    [Required]
    public int May { get; set; }

    [Required]
    public int Jun { get; set; }

    [Required]
    public int Jul { get; set; }

    [Required]
    public int Aug { get; set; }

    [Required]
    public int Sep { get; set; }

    [Required]
    public int Oct { get; set; }

    [Required]
    public int Nov { get; set; }

    [Required]
    public int Dec { get; set; }
}