
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model;

public class PlantPreset
{
    [Key]
    public int PresetId { get; set; }
    
    public float maxHumidity { get; set; }
    
    public float minHumidity { get; set; }
    
    public float maxTemp { get; set; }
    
    public float minTemp { get; set; }
    
    public float minUV { get; set; }
    
    public float maxUV { get; set; }
    
    
}