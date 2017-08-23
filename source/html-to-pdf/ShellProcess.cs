using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public interface IShellProcess
    {
        IShellProcess Version();

        IShellProcess AddPage();

        byte[] Export();
    }

    class ShellProcess : IShellProcess
    {
        private IEmptyInterseptor ShellInterceptor;

        public PDF Pdf { get; set; }

        public ShellProcess() { }

        public ShellProcess(IEmptyInterseptor ShellInterceptor)
        {
            this.ShellInterceptor = ShellInterceptor;
        }

        public IShellProcess Version()
        {
            this.Pdf = new PDF1_1();
            ShellInterceptor.OnInit(this.Pdf.PdfHeader.Version);
            return this;
        }

        public IShellProcess AddPage()
        {
            if (this.Pdf == null)
                throw new Exception("Unknown PDF format. Use IShellProcess.Version() to set the format.");

            this.Pdf.AddPage();

            return this;
        }

        public byte[] Export()
        {
            if (this.Pdf.PdfCatalog.PdfPages.Pages.Count() == 0)
                throw new Exception("Cannot export PDF with 0 pages. Use IShellProcess.AddPage() to add a page.");

            byte[] export = null;

            string written;

            using (MemoryStream stream = new MemoryStream())
            using (StreamWriter writer = new StreamWriter(stream))
            {
                ShellInterceptor.OnWriteHeader(this.Pdf.PdfHeader);
                writer.Write(this.Pdf.PdfHeader.Write());
                writer.Flush();
                this.Pdf.PdfXref.AddReference(stream.Position);

                for (int i = 0; i < this.Pdf.PdfObjects.Count(); i++)
                {
                    var pdfObject = this.Pdf.PdfObjects[i];
                    ShellInterceptor.OnWriteObject(pdfObject);
                    writer.Write(pdfObject.Write());
                    writer.Flush();
                    this.Pdf.PdfXref.AddReference(stream.Position);
                }

                ShellInterceptor.OnWriteXref(this.Pdf.PdfXref);
                writer.Write(this.Pdf.PdfXref.Write());
                writer.Flush();
                this.Pdf.PdfXref.Start = stream.Position;

                this.Pdf.PdfTrailer.CatalogIndex = this.Pdf.PdfCatalog.Index;
                this.Pdf.PdfTrailer.Size = this.Pdf.PdfObjects.Count();
                ShellInterceptor.OnWriteTrailer(this.Pdf.PdfTrailer);
                writer.Write(this.Pdf.PdfTrailer.Write());
                writer.Flush();

                this.Pdf.PdfEof.StartXref = this.Pdf.PdfXref.Start;
                ShellInterceptor.OnWriteEof(this.Pdf.PdfEof);
                writer.Write(this.Pdf.PdfEof.Write());
                writer.Flush();

                stream.Position = 0;
                export = stream.ToArray();
            }

            return export;
        }
    }
}
