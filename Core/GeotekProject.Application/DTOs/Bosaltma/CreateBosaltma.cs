using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Application.DTOs.Bosaltma
{
    public class CreateBosaltma
    {
        public bool BosaltmaDurumu { get; set; }
        public string Plaka { get; set; }
        public Guid KamyonId { get; set; }
    }

}
