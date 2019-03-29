using CodeDemo.BusinessRules.Models;
using CodeDemo.BusinessRules.Services.Interfaces;
using CodeDemo.Data;
using CodeDemo.Data.Entities;
using CodeDemo.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeDemo.BusinessRules.Services.Impl
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IUserRepository _userRepository;


        public PeopleService(IPeopleRepository peopleRepository,IUserRepository userRepository)
        {
            _peopleRepository = peopleRepository;
            _userRepository = userRepository;
        }
        public void CreatePeopleAndUser(UserModel model)
        {
            using (var context = new DBContexCodeDemo())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (model.People.Id > 0 && model.User.Id > 0)
                        {
                            _peopleRepository.Update(model.People,model.People.Id);
                            model.User.PeopleId = model.People.Id;
                            _userRepository.Update(model.User,model.User.Id);
                        }
                        else
                        {
                            context.People.Add(model.People);
                            model.User.People = model.People;
                            context.Users.Add(model.User);
                            context.SaveChanges();
                            dbContextTransaction.Commit();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                _userRepository.Delete(_userRepository.Get(id));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<People> GetAllPeople()
        {
            return _peopleRepository.GetAll().ToList();
        }

        public UserModel EditUser(int id)
        {
            var user = _userRepository.Get(id);
            var model= new UserModel
            {
                People = user.People,
                User = user
            };
            return model;
        }
    }
}
