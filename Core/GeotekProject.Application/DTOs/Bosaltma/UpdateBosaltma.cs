using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Application.DTOs.Bosaltma
{
    public class UpdateBosaltma
    {
        public Guid Id { get; set; }
        public bool BosaltmaDurumu { get; set; }
        public Guid KamyonId { get; set; }
    }

}


