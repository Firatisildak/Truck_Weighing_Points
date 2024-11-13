using GeotekProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Domain.Entities
{
    public class Kamyon : BaseEntity
    {
        public required string Plaka { get; set; }
        public required string Hammadde { get; set; }
        public int Miktar { get; set; }
    }
}
