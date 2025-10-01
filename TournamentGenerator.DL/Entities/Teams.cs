namespace TI_Net2025_DemoCleanAsp.DL.Entities;

public class Teams
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public List<Teams> Members { get; set; }
    
    
}