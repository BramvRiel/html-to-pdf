using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfXref : IWritable
    {
        class PdfReference
        {
            public long Size { get; private set; }
            public PdfReference(long size)
            {
                this.Size = size;
            }

        }

        public void AddReference(long size)
        {
            var pdfReferences = this.PdfReferences.ToList();
            pdfReferences.Add(new PdfReference(size));
            this.PdfReferences = pdfReferences.ToArray();
        }

        PdfReference[] PdfReferences = new PdfReference[] { };

        public int ObjectCount;

        public long Start;

        public string Write()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("xref\n");
            sb.AppendFormat("0 {0}\n", this.ObjectCount);
            sb.AppendFormat("{0:0000000000} {1:00000} f \n", 0, 65535);
            foreach (var pdfReference in this.PdfReferences)
            {
                sb.AppendFormat("{0:0000000000} {1:00000} n \n", pdfReference.Size, 0);
            }
            return sb.ToString();
        }
    }
}
