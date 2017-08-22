using html_to_pdf;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf1._1.tests
{
    [TestFixture]
    public class pdf1_1
    {
        [Test]
        public void GeneratePDF1_1_HelloWorldTest()
        {
            var ShellInterceptor = new ShellInterceptor();
            var pdf = Shell.GeneratePDF1_1(ShellInterceptor);
        }
    }
}
