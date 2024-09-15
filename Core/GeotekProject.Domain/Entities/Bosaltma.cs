using GeotekProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotekProject.Domain.Entities
{
    public class Bosaltma : BaseEntity
    {
        public bool BosaltmaDurumu { get; set; }
        public Guid KamyonId { get; set; }
        public Kamyon Kamyon { get; set; }
    }
}
