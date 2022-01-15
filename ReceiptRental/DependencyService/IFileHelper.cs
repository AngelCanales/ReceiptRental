using ReceiptRental.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptRental.DependencyService
{
    public interface IFileHelper
    {
     
        Task<string> StrartConverting(string html, string namefile);

        string DocumentFilePath { get; }

        void ConvertHTMLtoPDF(PDFToHtml _PDFToHtml);
    }
}
