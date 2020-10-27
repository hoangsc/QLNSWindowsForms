using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Authorization
{
    class SingletonToken
    {
        public string token;
        private static SingletonToken _instance;
        protected SingletonToken(string _token)
        {
            token = _token;
        }
        public static SingletonToken Instance(string token = "")
        {
            if (_instance == null)
            {
                _instance = new SingletonToken(token);
            }

            return _instance;
        }
    }
}
