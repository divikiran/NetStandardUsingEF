using System;
namespace NetStandard2.DbConnection
{
    public sealed class DbConnect
    {
        private static object _syncRoot = new object();
        private static DbConnect _instance;
        public static DbConnect Instance
        {
            get{

                if(_instance != null)
                    return _instance;

                lock(_syncRoot)
                {
                    if (_instance == null)
                        _instance = new DbConnect();
                }
                return _instance;
            }
        }

        public DatabaseContext DbContext => new DatabaseContext();

        private DbConnect()
        {
        }
    }
}
