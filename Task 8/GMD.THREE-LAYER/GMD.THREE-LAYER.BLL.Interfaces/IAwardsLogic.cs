using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.Entities;


namespace GMD.THREE_LAYER.BLL.Interfaces
{
    public interface IAwardsLogic
    {
        void Create(Award award);
        IEnumerable<Award> GetAll();
        void Update(Award award);
        void Delete(Guid id);
        Award GetById(Guid id);
    }
}
