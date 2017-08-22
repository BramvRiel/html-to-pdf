using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfCatalog : PdfObject
    {
        public PdfPages Pages;

        public override string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} 0 obj\n", this.Index + 1);
            sb.Append("<<\n");
            sb.Append(" /Type /Catalog\n");
            sb.AppendFormat(" /Pages {0} 0\n", Pages.Index + 1);
            sb.Append(">>\n");
            sb.Append("endobj\n");
            return sb.ToString();
        }
    }
}
