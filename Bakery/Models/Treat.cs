using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat must have a name!")]
    public string TreatName { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
  }
}