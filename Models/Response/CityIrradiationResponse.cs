using Microsoft.AspNetCore.Mvc;

namespace IrradApi.Models.Response;

public class CityIrradiationResponse : IActionResult
{
    public int StatusCode { get; set; } = 200;
    public CityIrradiationDataResponse? CityIrradiationData { get; set; }

    public void SetStatusCode(int statusCode) => StatusCode = statusCode;

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var result = new ObjectResult(this) { StatusCode = StatusCode };

        await result.ExecuteResultAsync(context);
    }
}

