﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public class EmptyShellInterceptor : IEmptyInterseptor
    {
        public EmptyShellInterceptor() { }

        public virtual void OnInit(string version) { }
    }
}
