namespace Domain.DTOs;

public class GetPlantPresetDto
{
    public int presetId { get; set; }
    
    public float maxHumidity { get; set; }
    
    public float minHumidity { get; set; }
    
    public float maxTemp { get; set; }
    
    public float minTemp { get; set; }
    
    public float minUV { get; set; }
    
    public float maxUV { get; set; }
}