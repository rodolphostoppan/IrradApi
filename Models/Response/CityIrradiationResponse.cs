namespace IrradApi.Models.Response;

public class CityIrradiationResponse
{
    public int StatusCode { get; set; } = 200;
    public List<CityIrradiationDataResponse>? CityIrradiationData { get; set; }

    public void SetStatusCode(int statusCode) => StatusCode = statusCode;
}

