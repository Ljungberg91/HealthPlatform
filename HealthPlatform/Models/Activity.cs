using HealthPlatform.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPlatform.Models
{
    public class Activity : ActivityBase
    {
        public ICollection<ActivityType> Types { get; set; }
    }
}
