using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Elements
{
    class PdfHeader : IWritable
    {
        public string Version { get; set; }

        public string Write()
        {
            return "%PDF-" + this.Version + '\n';
        }
    }
}
