using System;
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

        public virtual void OnWriteHeader(Elements.IWritable pdfHeader)
        {

        }

        public virtual void OnWriteObject(Elements.IWritable pdfObject)
        {

        }

        public virtual void OnWriteXref(Elements.IWritable pdfXref)
        {

        }
    }
}
