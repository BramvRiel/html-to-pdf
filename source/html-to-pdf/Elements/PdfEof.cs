using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfEof : IWritable
    {
        public long StartXref;

        public string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("startxref\n");
            sb.AppendFormat("{0}\n",this.StartXref);
            sb.Append("%%EOF\n");
            return sb.ToString();
        }
    }
}
