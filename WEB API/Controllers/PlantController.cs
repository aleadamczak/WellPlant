using ClassLibrary1.Model;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using SEP4.Data.DaoInterfaces;

namespace WEB_API.Controllers;


[ApiController]
[Route("[controller]")]
public class PlantController:ControllerBase
{
    private IPlantDao plantDao;

    public PlantController(IPlantDao plantDao)
    {
        this.plantDao = plantDao;
    }

    [HttpPost]
    [Route("createPlant")]
    public async Task<ActionResult<Plant>> CreateAsync(Plant plant)
    {
        try
        {
            Plant newPlant = await plantDao.CreateAsync(plant);
            return Created($"/file/{plant.Plantid}", newPlant);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("getPlant")]
    public async Task<ActionResult<GetPlantDto>> GetAsync([FromQuery] int plantId)
    {
        try
        {
            GetPlantDto getPlant = await plantDao.GetAsync(plantId);
            Console.WriteLine("The send plant: " + getPlant.Name);

            return getPlant;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
   
    }
    