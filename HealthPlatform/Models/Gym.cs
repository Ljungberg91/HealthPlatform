﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPlatform.Models
{
    public class Gym
    {
        public int Id { get; set; }
        public ICollection<Excercise> Exercises { get; set; }

    }
}
