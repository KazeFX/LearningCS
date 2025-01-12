using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class Animal : IDisposable
    {
        public Animal()
        {
            // allocate unmanaged resources            
        }

        ~Animal()
        {
            Dispose(false);
        }

        bool disposed = false; // have resources been released?

        public void Dispose()
        {
            Dispose(true);
            // tell garbage collector not to call finalizer
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            // deallocate unmanaged resources

            if (disposing)
            {
                // release other managed resources that implement IDisposable
            }
            disposed = true;
        }
    }
}