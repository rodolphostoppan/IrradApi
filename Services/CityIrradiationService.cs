using IrradApi.Models.Request;
using IrradApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IrradApi.Services;
public class CityIrradiationService
{
    private readonly ICityIrradiationRepository _cityIrradiationRepository;

    public CityIrradiationService(ICityIrradiationRepository cityIrradiationRepository)
    {
        _cityIrradiationRepository = cityIrradiationRepository;
    }

    public Task<IActionResult> CreateCityIrradiation(ICollection<CityIrradiation> stateIrradiation)
    {
        return _cityIrradiationRepository.Add(stateIrradiation);
    }

    public Task<IActionResult> FindCityIrradiation(string cityName)
    {
        return _cityIrradiationRepository.GetByName(cityName);
    }
}