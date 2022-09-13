using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CigarPalace.db;
using CigarPalace.Models;

namespace CigarPalace.Repositories
{
    public class CigarsRepository
    {
        internal List<Cigar> GetCigars()
        {
            return Db.Cigars;
        }
        internal Cigar CreateCigar(Cigar body)
        {
            body.Id = Db.Cigars.Count + 1;

            Db.Cigars.Add(body);
            return body;
        }
        
    }
}
