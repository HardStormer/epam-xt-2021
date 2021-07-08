using GMD.THREE_LAYER.StandartBLL;
using GMD.THREE_LAYER.BLL.Interfaces;
using GMD.THREE_LAYER.JsonDAL;
using GMD.THREE_LAYER.DAL.Interfaces;

namespace GMD.THREE_LAYER.Dependecies
{
    public class DependencyResolver
    {
        #region SINGLETONE

        private static DependencyResolver _instance = null;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DependencyResolver();

                return _instance;
            }
        }

        #endregion


        public IUsersDAO usersDAO => new UsersJsonDAO();
        public IAwardsDAO awardsDAO => new AwardsJsonDAO();

        public IUsersLogic usersLogic => new UsersLogic(usersDAO);
        public IAwardsLogic awardsLogic => new AwardsLogic(awardsDAO);
    }
}
