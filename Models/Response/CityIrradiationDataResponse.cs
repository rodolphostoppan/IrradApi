namespace IrradApi.Models.Response;

public class CityIrradiationDataResponse
{
    public int Id { get; set; }
    public float Lon { get; set; }
    public float Lat { get; set; }
    public string? Name { get; set; }
    public string? State { get; set; }
    public int Annual { get; set; }
    public int Jan { get; set; }
    public int Feb { get; set; }
    public int Mar { get; set; }
    public int Apr { get; set; }
    public int May { get; set; }
    public int Jun { get; set; }
    public int Jul { get; set; }
    public int Aug { get; set; }
    public int Sep { get; set; }
    public int Oct { get; set; }
    public int Nov { get; set; }
    public int Dec { get; set; }
}