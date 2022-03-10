using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Entities
{
    public class Mekaiker
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Stilling { get; set; }

        public string Fuldenavn => $"{Fornavn} {Efternavn}";

    }
}
