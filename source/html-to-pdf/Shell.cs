using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public class Shell
    {
        public static byte[] NewPDF1_1()
        {
            var process = new ShellProcess(new EmptyShellInterceptor());
            process.GeneratePDF1_1();

            return new byte[] { };
        }

        public static byte[] NewPDF1_1(IEmptyInterseptor ShellInterceptor)
        {
            var process = new ShellProcess(ShellInterceptor);
            process.GeneratePDF1_1();

            return new byte[] { };
        }
    }
}
