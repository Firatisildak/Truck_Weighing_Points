using GeotekProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Domain.Entities
{
    public class Kantar : BaseEntity
    {
        public int KamyonKg { get; set; }
        public bool OnayDurum { get; set; }
        public string Plaka { get; set; }
        public  Kamyon Kamyon { get; set; }
        public Guid KamyonId { get; set; }
    }
}
