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

        public string Write()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("trailer\n");
            sb.Append("<<\n");
            sb.AppendFormat("   /Size {0}", this.Size);
            sb.AppendFormat("   /Root 1 0 R");
            sb.Append(">>\n");
            return sb.ToString();
        }
    }
}
