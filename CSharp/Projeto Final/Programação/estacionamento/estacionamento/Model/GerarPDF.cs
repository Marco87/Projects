using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using Estacionamento.Control;
using Estacionamento.Controller;
//using Root.Reports;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Estacionamento.Model
{
    class GerarPDF
    {

        public void gerarPDFEstacionar(string nomeDocumento, string dados)
        {
            try
            {
                
                // cria uma instância de iTextSharp.text.Document
                Document documento = new Document();

                // cria um Writer para o documento
                PdfWriter.GetInstance(documento, new
                  FileStream("..\\..\\..\\Comprovantes\\" + nomeDocumento + ".pdf", FileMode.Create));

                // abre o documento
                documento.Open();

                // adiciona conteúdo
                documento.Add(new Paragraph(dados));

                // fecha o documento
                documento.Close();

                MessageBox.Show("Comprovante criado com sucesso.");
            }
            catch
            {
            }
        }

    }
}
