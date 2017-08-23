using html_to_pdf.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    abstract class PDF
    {
        public PDF()
        {
            this.PdfHeader = new PdfHeader();

            this.PdfCatalog = new PdfCatalog();
            this.AddToPdfObjects(this.PdfCatalog);

            this.PdfCatalog.PdfPages = new PdfPages { };
            this.AddToPdfObjects(this.PdfCatalog.PdfPages);

            this.PdfXref = new PdfXref();
            this.PdfXref.ObjectCount = this.PdfObjects.Count();

            this.PdfTrailer = new PdfTrailer();

            this.PdfEof = new PdfEof();
        }

        public PdfHeader PdfHeader;

        public PdfObject[] PdfObjects = new PdfObject[] { };

        public PdfCatalog PdfCatalog;

        public PdfXref PdfXref;

        public void AddToPdfObjects(PdfObject pdfObject)
        {
            var pdfObjects = this.PdfObjects.ToList();
            pdfObject.Index = pdfObjects.Count + 1;
            pdfObjects.Add(pdfObject);
            this.PdfObjects = pdfObjects.ToArray();
        }

        public PdfTrailer PdfTrailer;

        public PdfEof PdfEof;

        internal void AddPage()
        {
            var pdfPages = this.PdfCatalog.PdfPages.Pages.ToList();
            var pdfPage = new PdfPage();
            pdfPage.ParentIndex = this.PdfCatalog.PdfPages.Index;
            this.AddToPdfObjects(pdfPage);
            pdfPages.Add(pdfPage);
            this.PdfCatalog.PdfPages.Pages = pdfPages.ToArray();
        }
    }
}
