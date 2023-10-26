using ClassLibrary1.Model;
using Domain.DTOs;

namespace SEP4.Data.DaoInterfaces;

public interface IPlantDao
{
    Task<Plant> CreateAsync(Plant plant);

    Task<GetPlantDto> GetAsync(int id);


}