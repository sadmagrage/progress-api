using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Domain.Entities
{
    public class ProgressEntity
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Type { get; set; } = "";
    }
}