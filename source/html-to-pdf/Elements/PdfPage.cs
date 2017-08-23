using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfPage : PdfObject
    {
        public int ParentIndex;

        public override string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} 0 obj\n", this.Index);
            sb.Append("<<\n");
            sb.Append("\t/Type /Page\n");
            sb.AppendFormat("\t/Parent {0} 0 R\n", this.ParentIndex);
            sb.Append("\t/Resources <<>>\n");
            sb.Append("\t/MediaBox [0 0 595 842]\n");
            sb.Append(">>\n");
            sb.Append("endobj\n");
            return sb.ToString();
        }
    }
}
