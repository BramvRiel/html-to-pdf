using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    class ShellProcess
    {
        private ShellInterceptor ShellInterceptor;

        public ShellProcess() { }

        public ShellProcess(ShellInterceptor ShellInterceptor)
        {
            // TODO: Complete member initialization
            this.ShellInterceptor = ShellInterceptor;
        }

        internal PDF GeneratePDF1_1()
        {
            return new PDF1_1();
        }
    }
}
