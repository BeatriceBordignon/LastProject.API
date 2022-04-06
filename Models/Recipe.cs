using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipe
{
    [Key]
    public string idMeal { get; set; }
    [StringLength(30)]
    public string strMeal { get; set; }
    [StringLength(100)]
    public string strMealThumb { get; set; }
    [StringLength(500)]
    
    
    // navigation
    [ForeignKey("User")]
    public string GoogleId {get; set; }
    public User User { get; set; }

    // public string UserGoogleId {get; set; }


}