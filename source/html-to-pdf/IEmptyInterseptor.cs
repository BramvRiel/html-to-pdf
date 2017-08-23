using html_to_pdf.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf
{
    public interface IEmptyInterseptor
    {
        void OnInit(string version);

        void OnWriteHeader(IWritable pdfHeader);

        void OnWriteObject(IWritable pdfObject);

        void OnWriteXref(IWritable pdfXref);

        void OnWriteTrailer(IWritable pdfTrailer);

        void OnWriteEof(IWritable pdfEof);
    }
}
