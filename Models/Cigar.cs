using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CigarPalace.Models
{
    public class Cigar
    {
       public Cigar(string company, string name, string binder, string filler, string body, int id)
       {
        Company = company;
        Name = name;
        Binder = binder;
        Filler = filler;
        Body = body;
        Id = id;
       }

       public Cigar()
       {

       }

    public string Company { get; set; }
    public string Name { get; set; }
    public string Binder { get; set; }
    public string Filler { get; set; }
    public string Body { get; set; }
    public int Id { get; set; }
  }
}