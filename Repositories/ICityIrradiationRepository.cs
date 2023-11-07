using IrradApi.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace IrradApi.Repositories;

public interface ICityIrradiationRepository
{
    Task<IActionResult> Add(ICollection<CityIrradiation> stateIrradiation);
    Task<IActionResult> GetByName(string name);
}

