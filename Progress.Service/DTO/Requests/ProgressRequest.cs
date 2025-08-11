using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Application.DTO.Requests
{
    public class ProgressRequest
    {
        public DateTime Time { get; set; }
        public string Type { get; set; } = "";
    }
}
