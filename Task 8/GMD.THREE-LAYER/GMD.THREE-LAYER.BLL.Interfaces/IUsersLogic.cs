using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;

namespace GMD.THREE_LAYER.BLL.Interfaces
{
    public interface IUsersLogic
    {
        void Create(User user);
        IEnumerable<User> GetAll();
        void Update(User user);
        void Delete(Guid id);
        User GetById(Guid id);
    }
}
