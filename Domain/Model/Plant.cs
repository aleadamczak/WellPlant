using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model;

public class Plant
{
    
    [Key]
    public int Plantid { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(50)]
    public string location { get; set; }
    
    public PlantPreset preset { get; set; }

    public Plant(string name, string location)
    {
        Name = name;
        this.location = location;
    }
}