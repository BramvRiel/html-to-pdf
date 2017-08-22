using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_to_pdf.Configuration
{
    interface IPageSize
    {
        int Width { get; set; }

        int Height { get; set; }

        void Rotate();
    }

    class PageSize : IPageSize
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public void Rotate()
        {
            int temp = this.Width;
            this.Width = this.Height;
            this.Height = temp;
        }
    }

    static class PageSizes
    {
        static IPageSize Letter = new PageSize
        {
            Width = 612,
            Height = 792
        };

        static IPageSize LetterSmall = new PageSize
        {
            Width = 612,
            Height = 792
        };

        static IPageSize Tabloid = new PageSize
        {
            Width = 792,
            Height = 1224
        };

        static IPageSize Ledger = new PageSize
        {
            Width = 1224,
            Height = 792
        };

        static IPageSize Legal = new PageSize
        {
            Width = 612,
            Height = 1008
        };

        static IPageSize Executive = new PageSize
        {
            Width = 540,
            Height = 720
        };

        static IPageSize A0 = new PageSize
        {
            Width = 2384,
            Height = 3371
        };

        static IPageSize A1 = new PageSize
        {
            Width = 1685,
            Height = 2384
        };

        static IPageSize A2 = new PageSize
        {
            Width = 1190,
            Height = 1684
        };

        static IPageSize A3 = new PageSize
        {
            Width = 842,
            Height = 1190
        };

        static IPageSize A4 = new PageSize
        {
            Width = 595,
            Height = 842
        };

        static IPageSize A4Small = new PageSize
        {
            Width = 595,
            Height = 842
        };

        static IPageSize A5 = new PageSize
        {
            Width = 420,
            Height = 595
        };

        static IPageSize B4 = new PageSize
        {
            Width = 729,
            Height = 1032
        };

        static IPageSize B5 = new PageSize
        {
            Width = 516,
            Height = 729
        };

        static IPageSize Folio = new PageSize
        {
            Width = 612,
            Height = 936
        };

        static IPageSize Quarto = new PageSize
        {
            Width = 610,
            Height = 780
        };

        static IPageSize s10x14 = new PageSize
        {
            Width = 720,
            Height = 1008
        };
    }
}