using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    interface IShellProcess
    {
        string PdfVersion { get; }
    }

    class ShellProcess : IShellProcess
    {
        private IEmptyInterseptor ShellInterceptor;

        public string PdfVersion { get; set; }

        public ShellProcess() { }

        public ShellProcess(IEmptyInterseptor ShellInterceptor)
        {
            this.ShellInterceptor = ShellInterceptor;
        }

        internal PDF GeneratePDF1_1()
        {
            this.PdfVersion = "1.1";

            ShellInterceptor.OnInit(this.PdfVersion);

            return new PDF1_1();
        }
    }
}
