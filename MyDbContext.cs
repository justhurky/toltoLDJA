using System;

namespace tolto
{
    internal class MyDbContext : IDisposable
    {
        public object Users { get; internal set; }

        internal object SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}