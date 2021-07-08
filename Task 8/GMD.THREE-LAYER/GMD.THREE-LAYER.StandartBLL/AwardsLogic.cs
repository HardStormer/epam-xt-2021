using System;
using System.Collections.Generic;
using GMD.THREE_LAYER.BLL.Interfaces;
using GMD.THREE_LAYER.DAL.Interfaces;
using GMD.THREE_LAYER.Entities;

namespace GMD.THREE_LAYER.StandartBLL
{
    public class AwardsLogic : IAwardsLogic
    {
        private readonly IAwardsDAO _awardDao;

        public AwardsLogic(IAwardsDAO awardDao)
        {
            _awardDao = awardDao;
        }

        public void Create(Award award)
        {
            _awardDao.Create(award);
        }

        public void Delete(Guid id)
        {
            _awardDao.Delete(id);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDao.GetAll();
        }

        public void Update(Award award)
        {
            _awardDao.Update(award);
        }
        public Award GetById(Guid id)
        {
            return _awardDao.GetById(id);
        }
    }
}
