using html_to_pdf;
using NUnit.Framework;
using System;

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
                Assert.AreEqual("1.1", version);
            };

            ShellInterceptor.OnWriteHeaderEvent = (pdfHeader) =>
            {
                string pdf_text = pdfHeader.Write();
                System.Diagnostics.Debug.Write(pdf_text);
                Assert.AreEqual("%PDF-1.1\n", pdf_text);
            };

            ShellInterceptor.OnWriteObjectEvent = (pdfObject) =>
            {
                string pdf_text = pdfObject.Write();
                System.Diagnostics.Debug.Write(pdf_text);
            };

            ShellInterceptor.OnWriteXrefEvent = (pdfXref) =>
            {
                string pdf_text = pdfXref.Write();
                System.Diagnostics.Debug.Write(pdf_text);
            };

            var pdf = Shell.NewPDF1_1(ShellInterceptor);
        }

        class DebugInterceptor : EmptyShellInterceptor
        {
            public Action<string> OnInitEvent;

            public Action<html_to_pdf.Elements.IWritable> OnWriteHeaderEvent;

            public Action<html_to_pdf.Elements.IWritable> OnWriteObjectEvent;

            public Action<html_to_pdf.Elements.IWritable> OnWriteXrefEvent;

            public override void OnInit(string version)
            {
                if (OnInitEvent != null)
                    this.OnInitEvent(version);

                base.OnInit(version);
            }

            public override void OnWriteHeader(html_to_pdf.Elements.IWritable pdfHeader)
            {
                if (OnWriteHeaderEvent != null)
                    this.OnWriteHeaderEvent(pdfHeader);

                base.OnWriteHeader(pdfHeader);
            }

            public override void OnWriteObject(html_to_pdf.Elements.IWritable pdfObject)
            {
                if (OnWriteObjectEvent != null)
                    this.OnWriteObjectEvent(pdfObject);

                base.OnWriteObject(pdfObject);
            }

            public override void OnWriteXref(html_to_pdf.Elements.IWritable pdfXref)
            {
                if (OnWriteXrefEvent != null)
                    this.OnWriteXrefEvent(pdfXref);

                base.OnWriteXref(pdfXref);
            }
        }
    }
}
