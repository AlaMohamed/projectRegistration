using System;
using ProjectRegistration.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjectRegistration.Service
{
    public interface ITimeRegistrationService
    {
        void Create(TimeRegistration dto);
        void Update(int id, TimeRegistration dto);
        TimeRegistration Single(int id);
        IEnumerable<TimeRegistration> List();
        void Delete(int id);
    }
}
