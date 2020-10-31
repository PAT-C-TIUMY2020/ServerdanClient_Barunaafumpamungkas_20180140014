using System;

namespace Server_Barunaagumpamungkas_20180140014
{
    internal class ServiceHost
    {
        private Type type;

        public ServiceHost(Type type)
        {
            this.type = type;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}