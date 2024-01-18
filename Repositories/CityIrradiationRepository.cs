using IrradApi.Configs;
using IrradApi.Models.Request;
using IrradApi.Models.Response;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IrradApi.Repositories;

public class CityIrradiationRepository : ICityIrradiationRepository
{
    private readonly ContextConfig _contextConfig;

    public CityIrradiationRepository(ContextConfig contextConfig)
    {
        _contextConfig = contextConfig;
    }

    public async Task<IActionResult> Add(ICollection<CityIrradiation> stateIrradiation)
    {
        await _contextConfig.AddRangeAsync(stateIrradiation);
        await _contextConfig.SaveChangesAsync();

        var result = stateIrradiation.Adapt<CityIrradiationResponse>();
        result.SetStatusCode(201);

        return (IActionResult)result;
    }

    public async Task<IActionResult> GetByName(string name)
    {
        var cityIrradiation = await _contextConfig.CityIrradiation.Include(prop => prop.CityIrradiationData).FirstOrDefaultAsync(prop => prop.NameIdentification == name);

        if (cityIrradiation is null) return cityIrradiation.Adapt<NotFoundResult>();

        var responseData = cityIrradiation.CityIrradiationData;

        return new ObjectResult(responseData);
    }
}

