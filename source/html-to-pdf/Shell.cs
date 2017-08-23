using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public class Shell
    {
        public static IShellProcess NewPDF()
        {
            return NewPDF(new EmptyInterceptor());
        }

        public static IShellProcess NewPDF(IEmptyInterseptor ShellInterceptor)
        {
            var process = new ShellProcess(ShellInterceptor);
            
            return process;
        }
    }
}
