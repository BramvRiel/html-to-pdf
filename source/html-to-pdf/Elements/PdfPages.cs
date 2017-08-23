using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfPages : PdfObject
    {
        public PdfPage[] Pages = new PdfPage[] { };

        public override string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} 0 obj\n", this.Index);
            sb.Append("<<\n");
            sb.Append("\t/Type /Pages\n");
            sb.AppendFormat("\t/Kids [{0} 0 R]\n",Pages.First().Index);
            sb.AppendFormat("\t/Count {0}\n", Pages.Count());
            sb.Append(">>\n");
            sb.Append("endobj\n");
            return sb.ToString();
        }
    }
}
