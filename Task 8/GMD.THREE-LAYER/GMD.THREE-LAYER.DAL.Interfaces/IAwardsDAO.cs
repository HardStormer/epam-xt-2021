using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;
   

namespace GMD.THREE_LAYER.DAL.Interfaces
{
    public interface IAwardsDAO
    {
        void Create(Award award);
        IEnumerable<Award> GetAll();
        void Update(Award award);
        void Delete(Guid id);
        Award GetById(Guid id);
    }
}
