using ClassLibrary1.Model;
using Domain.DTOs;

namespace SEP4.Data.DaoInterfaces;

public interface IPlantPresetDao
{
    Task<PlantPreset> CreateAsync(PlantPreset plant);

    Task<GetPlantPresetDto> GetAsync(int id);
}