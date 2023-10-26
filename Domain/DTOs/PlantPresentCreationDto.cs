namespace Domain.DTOs;

public class PlantPresentCreationDto
{
    public float maxHumidity { get; set; }
    
    public float minHumidity { get; set; }
    
    public float maxTemp { get; set; }
    
    public float minTemp { get; set; }
    
    public float minUV { get; set; }
    
    public float maxUV { get; set; }
}