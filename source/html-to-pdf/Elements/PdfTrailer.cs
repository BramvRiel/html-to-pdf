using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfTrailer : IWritable
    {
        public int Size { get; set; }

        public int CatalogIndex { get; set; }

        public string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("trailer\n");
            sb.Append("<<\n");
            sb.AppendFormat("\t/Size {0}\n", this.Size);
            sb.AppendFormat("\t/Root {0} 0 R\n", this.CatalogIndex);
            sb.Append(">>\n");
            return sb.ToString();
        }
    }
}
