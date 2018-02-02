using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPlatform.Models.Base
{
    public class ActivityBase : Identity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Duration { get; set; }
    }
}
