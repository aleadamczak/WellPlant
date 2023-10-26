using ClassLibrary1.Model;

namespace Domain.DTOs;

public class GetPlantDto
{
    public int plantId { get; set; }
    
    public string Name { get; set; }
    
    public string location { get; set; }
    
    public PlantPreset preset { get; set; }
}