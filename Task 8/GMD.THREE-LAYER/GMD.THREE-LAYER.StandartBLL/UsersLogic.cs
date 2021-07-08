using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.BLL.Interfaces;
using GMD.THREE_LAYER.DAL.Interfaces;
using GMD.THREE_LAYER.Entities;

namespace GMD.THREE_LAYER.StandartBLL
{
    public class UsersLogic : IUsersLogic
    {
        private readonly IUsersDAO _userDao;

        public UsersLogic(IUsersDAO userDao)
        {
            _userDao = userDao;
        }
        public void Create(User user)
        {
            _userDao.Create(user);
        }

        public void Delete(Guid id)
        {
            _userDao.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public void Update(User user)
        {
            _userDao.Update(user);
        }
        public User GetById(Guid id)
        {
            return _userDao.GetById(id);
        }
    }
}
