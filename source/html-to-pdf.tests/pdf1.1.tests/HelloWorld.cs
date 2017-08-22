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
        public void NewPDF1_1_HelloWorldTest()
        {
            var ShellInterceptor = new DebugInterceptor();
            ShellInterceptor.OnInitEvent = (version) =>
            {
                System.Diagnostics.Debug.WriteLine("New process started for creating PDF with version: " + version);
            };

            var pdf = Shell.NewPDF1_1(ShellInterceptor);
        }

        class DebugInterceptor : EmptyShellInterceptor
        {
            public Action<string> OnInitEvent;

            public override void OnInit(string version)
        {
                if (OnInitEvent != null)
                    this.OnInitEvent(version);

                base.OnInit(version);
            }
        }
    }
}
