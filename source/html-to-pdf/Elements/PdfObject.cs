using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    abstract class PdfObject : IWritable
    {
        public int Index { get; set; }

        public abstract string Write();
    }
}
