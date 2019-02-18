using CodeDemo.BusinessRules.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDemo.BusinessRules.Models;
using CodeDemo.Data.Repositories.Interfaces;
using CodeDemo.Data.Entities;
using CodeDemo.Data;

namespace CodeDemo.BusinessRules.Services.Impl
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public void CreatePeopleAndUser(UserModel model)
        {
            using (var context = new DBContexCodeDemo())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.People.Add(model.People);
                        model.User.People = model.People;
                        context.Users.Add(model.User);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        public List<People> GetAllPeople()
        {
            return _peopleRepository.GetAll().ToList();
        }
    }
}
