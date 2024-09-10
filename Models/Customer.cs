using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc4.Models;
public class Customer{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id{ get; set; }
    public string? Name{ get; set; }
    public int Orders{ get; set; }
}