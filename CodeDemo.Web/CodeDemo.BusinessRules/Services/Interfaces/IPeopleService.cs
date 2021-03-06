﻿using CodeDemo.Data.Entities;
using CodeDemo.BusinessRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.BusinessRules.Services.Interfaces
{
    public interface IPeopleService
    {
        void CreatePeopleAndUser(UserModel model);
        bool DeleteUser(int id);
        List<People> GetAllPeople();
        UserModel EditUser(int id);
    }
}
