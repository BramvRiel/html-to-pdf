﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    class PDF1_1 : PDF1_0
    {
        public PDF1_1()
            : base()
        {
            this.PdfHeader.Version = "1.1";
        }
    }
}
