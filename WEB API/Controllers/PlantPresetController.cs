using ClassLibrary1.Model;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using SEP4.Data.DaoInterfaces;

namespace WEB_API.Controllers;

public class PlantPresetController : ControllerBase
{
    private IPlantPresetDao plantPresetDao;

    public PlantPresetController(IPlantPresetDao plantPresetDao)
    
    {
        this.plantPresetDao = plantPresetDao;
    }

    [HttpPost]
    [Route("createPlantPreset")]
    public async Task<ActionResult<PlantPreset>> CreateAsync(PlantPreset plantPreset)
    {
        try
        {
            PlantPreset newPlant = await plantPresetDao.CreateAsync(plantPreset);
            return Created($"/file/{plantPreset.PresetId}", newPlant);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }

    }
    
    [HttpGet]
    [Route("getPlant")]
    public async Task<ActionResult<GetPlantPresetDto>> GetAsync([FromQuery] int presetId)
    {
        try
        {
            GetPlantPresetDto getPlantPreset = await plantPresetDao.GetAsync(presetId);
            Console.WriteLine("The send plant: " + getPlantPreset.presetId);

            return getPlantPreset;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}