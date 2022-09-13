


using System.Collections.Generic;
using CigarPalace.Models;

namespace CigarPalace.db
{
  public static class Db
  {
    public static List<Cigar> Cigars { get; set; } = new List<Cigar>(){
     new Cigar("Cavalier", "Inner Circle", "Nicaraguan", "Nicaraguan", "Full", 1),
   
    };
  }
}