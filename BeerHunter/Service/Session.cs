using System;

namespace BeerHunter.Service
{
    public sealed class Session
    {
        private static volatile Session instance;
        private static object sync = new Object();

        private Session() { }

        public static Session Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (sync)
                    {
                        if(instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }
        }
        public int id;
        public String tipo;
        public string Nome;
        public DateTime dtLogin;
    }
}
