using System;
using System.Collections.Generic;
using ProjectRegistration.Models;
using System.Linq;
using ProjectRegistration.Persistance;

namespace ProjectRegistration.Service
{
    public class TimeRegistrationService : ITimeRegistrationService
    {

        private readonly ApiContext _db;

        public TimeRegistrationService(ApiContext db)
        {
            _db = db;
        }

        public void Create(TimeRegistration dto)
        {

            _db.TimeRegistrations.Add(dto);
        }

        public void Delete(int id)
        {
            var entity = _db.TimeRegistrations.Where(s => s.Id == id).FirstOrDefault();
            _db.TimeRegistrations.Remove(entity);
        }

        public IEnumerable<TimeRegistration> List()
        {
            return _db.TimeRegistrations.ToList();
        }

        public TimeRegistration Single(int id)
        {
            return _db.TimeRegistrations.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Update(int id, TimeRegistration dto)
        {
            _db.TimeRegistrations.Update(dto);
        }
    }
}
