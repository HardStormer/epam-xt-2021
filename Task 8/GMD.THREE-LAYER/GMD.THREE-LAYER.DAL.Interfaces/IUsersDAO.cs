using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;

namespace GMD.THREE_LAYER.DAL.Interfaces
{
    //crud
    public interface IUsersDAO
    {
        void Create(User user);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        void Update(User user);
        void Delete(Guid id);

    }
}
