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

            this.PdfCatalog.Pages = new PdfPages { };
            this.AddToPdfObjects(this.PdfCatalog.Pages);

            this.PdfXref = new PdfXref();
            this.PdfXref.ObjectCount = this.PdfObjects.Count();
        }

        public PdfHeader PdfHeader;

        public PdfObject[] PdfObjects = new PdfObject[] { };

        public PdfCatalog PdfCatalog;

        public PdfXref PdfXref;

        public void AddToPdfObjects(PdfObject pdfObject)
        {
            var pdfObjects = this.PdfObjects.ToList();
            pdfObject.Index = pdfObjects.Count;
            pdfObjects.Add(pdfObject);
            this.PdfObjects = pdfObjects.ToArray();
        }
    }
}
