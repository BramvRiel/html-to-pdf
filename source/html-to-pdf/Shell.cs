using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public class Shell
    {
        public static PDF GeneratePDF1_1()
        {
            var process = new ShellProcess();
            return process.GeneratePDF1_1();
        }

        public static object GeneratePDF1_1(ShellInterceptor ShellInterceptor)
        {
            var process = new ShellProcess(ShellInterceptor);
            return process.GeneratePDF1_1();
        }
    }
}
