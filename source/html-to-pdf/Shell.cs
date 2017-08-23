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
            return NewPDF1_1(new EmptyInterceptor());
        }

        public static byte[] NewPDF1_1(IEmptyInterseptor ShellInterceptor)
        {
            var process = new ShellProcess(ShellInterceptor);

            return process.GeneratePDF1_1().Export();
        }
    }
}
