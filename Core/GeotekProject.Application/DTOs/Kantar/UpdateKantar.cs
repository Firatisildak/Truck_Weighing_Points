using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Application.DTOs.Kantar
{
    public class UpdateKantar
    {
        public Guid Id { get; set; }
        public int KamyonKg { get; set; }
        public bool OnayDurum { get; set; }
        public string Plaka { get; set; }
        public Guid KamyonId { get; set; }
    }
}


