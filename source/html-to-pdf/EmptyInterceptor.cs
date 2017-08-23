using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public class EmptyInterceptor : IEmptyInterseptor
    {
        public EmptyInterceptor() { }

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


        public virtual void OnWriteTrailer(Elements.IWritable pdfTrailer)
        {

        }


        public virtual void OnWriteEof(Elements.IWritable pdfEof)
        {
            
        }
    }
}
