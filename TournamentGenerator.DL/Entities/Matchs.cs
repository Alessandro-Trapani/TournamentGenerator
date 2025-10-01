using System.Text.RegularExpressions;

namespace TI_Net2025_DemoCleanAsp.DL.Entities;

public class Matchs
{
    
    public int Id { get; set; }
    
    public List<Matchs> EquipesList { get; set; }
    
    public string winner { get; set; }
    
}