



using System.Collections.Generic;
using CigarPalace.Models;
using CigarPalace.Repositories;

namespace CigarPalace.Services
{
    public class CigarsService  
    {
        private readonly CigarsRepository _cigarRepo;
        public CigarsService(CigarsRepository cigarRepo)
        {
            _cigarRepo = cigarRepo;
        }
        internal List<Cigar> GetCigars()
        {
            List<Cigar> cigars = _cigarRepo.GetCigars();
            return cigars;
        }
        
        internal Cigar CreateCigar(Cigar body)
        {
            Cigar cigar = _cigarRepo.CreateCigar(body);
            return cigar;
        }
    }
}