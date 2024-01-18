using IrradApi.Models.Request;
using IrradApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IrradApi.Controllers;

[ApiController]
[Route("/irradiation")]
public class CityIrradiationController : ControllerBase
{
    private readonly CityIrradiationService _cityIrradiationService;

    public CityIrradiationController(CityIrradiationService cityIrradiationService)
    {
        _cityIrradiationService = cityIrradiationService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ICollection<CityIrradiation> stateIrradiation) => await _cityIrradiationService.CreateCityIrradiation(stateIrradiation);

    [HttpGet("{cityName}")]
    public async Task<IActionResult> Get([FromRoute] string cityName) => await _cityIrradiationService.FindCityIrradiation(cityName);
}