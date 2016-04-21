using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableArray
{
    public class Class1 : IDisposable
    {
        private Task[] tasks;
        private IDisposable[] disposables = null;

        public Class1()
        {
            this.tasks = new Task[0];
        }

        public void Dispose()
        {
        }
    }
}
