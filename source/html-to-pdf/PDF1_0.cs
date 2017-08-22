using html_to_pdf.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    class PDF1_0 : PDF
    {
        public PDF1_0()
            : base()
        {
            this.PdfHeader.Version = "1.0";
        }
    }
}
