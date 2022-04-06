using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [StringLength(500), Key]
    public string GoogleId {get; set;}
    [StringLength(30)]
    public string? Name { get; set; }
    [StringLength(50)]
    public string? Email {get; set;}
    public List<Recipe>? Recipes { get; set; }
    
}
