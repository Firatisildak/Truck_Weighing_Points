using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Application.DTOs.Kantar
{
    public class CreateKantar
    {
        public int KamyonKg { get; set; }
        public bool OnayDurum { get; set; }
        public Guid KamyonId { get; set; }
    }
}
