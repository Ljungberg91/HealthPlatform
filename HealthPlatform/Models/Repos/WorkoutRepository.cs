using HealthPlatform.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPlatform.Models.Repos
{
    public class WorkoutRepository
    {
        private WorkoutContext _context;

        public WorkoutRepository(WorkoutContext context)
        {
            _context = context;
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return _context.Activities.ToList();
        }

        public Activity GetActivity(int id)
        {
            var activity = _context.Activities.FirstOrDefault(a => a.Id == id);

            return activity;
        }
    }
}
