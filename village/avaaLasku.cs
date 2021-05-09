using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace village
{
    public partial class avaaLasku : Form
    {
        public avaaLasku(int varausid)
        {
            InitializeComponent();
            dgvVaraus.DataSource = TaskDB.HaeVaraus(varausid);
            dgvMokki.DataSource = TaskDB.HaeMokki(varausid);
            dgvAsiakas.DataSource = TaskDB.HaeAs(varausid);

        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Lasku.pdf";
            bool fileError = false;

            Document pdfD = new Document(PageSize.A4);
            pdfD.SetMargins(3, 3, 3, 3);
            Paragraph prg = new Paragraph("Lasku, Newbie Village");
            prg.Add(Chunk.NEWLINE);
            prg.Add(Chunk.NEWLINE);
            prg.Add("Asiakas");
            prg.Add(Chunk.NEWLINE);
            prg.Add(Chunk.NEWLINE);

            Paragraph prg2 = new Paragraph();
            prg2.Add(Chunk.NEWLINE);
            prg2.Add(Chunk.NEWLINE);
            prg2.Add("Mökki");
            prg2.Add(Chunk.NEWLINE);
            prg2.Add(Chunk.NEWLINE);

            Paragraph prg3 = new Paragraph();
            prg3.Add(Chunk.NEWLINE);
            prg3.Add(Chunk.NEWLINE);
            prg3.Add("Varauksen tiedot");
            prg3.Add(Chunk.NEWLINE);
            prg3.Add(Chunk.NEWLINE);
            if (dgvAsiakas.Rows.Count >0)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Laskun kirjoittaminen ei onnistunut!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        
                        try
                        {
                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1250,BaseFont.EMBEDDED);
                            PdfPTable pdf = new PdfPTable(dgvAsiakas.Columns.Count);
                            pdf.DefaultCell.Padding = 3;
                            pdf.WidthPercentage = 100;
                            pdf.HorizontalAlignment = Element.ALIGN_LEFT;
                           


                            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,10,iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvAsiakas.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text));
                                pdf.AddCell(cell);
                            }
                            string pdfcell;
                            foreach (DataGridViewRow row in dgvAsiakas.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell = null;
                                    }
                                    else
                                    {
                                        pdfcell = cell.Value.ToString();
                                        pdf.AddCell(new Phrase(pdfcell, text));
                                    }
                                }
                            }

                            PdfPTable pdf2 = new PdfPTable(dgvMokki.Columns.Count);
                            pdf2.DefaultCell.Padding = 3;
                            pdf2.WidthPercentage = 100;
                            pdf2.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

                            iTextSharp.text.Font text2 = new iTextSharp.text.Font(bf2, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvMokki.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text2));
                                pdf2.AddCell(cell);
                            }
                            string pdfcell2;
                            foreach (DataGridViewRow row in dgvMokki.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell2 = null;
                                    }
                                    else
                                    {
                                        pdfcell2 = cell.Value.ToString();
                                        pdf2.AddCell(new Phrase(pdfcell2, text2));
                                    }
                                }
                            }



                            BaseFont bf3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                            PdfPTable pdf3 = new PdfPTable(dgvVaraus.Columns.Count);
                            pdf3.DefaultCell.Padding = 3;
                            pdf3.WidthPercentage = 100;
                            pdf3.HorizontalAlignment = Element.ALIGN_LEFT;


                            iTextSharp.text.Font text3 = new iTextSharp.text.Font(bf3, 10, iTextSharp.text.Font.NORMAL);
                            foreach (DataGridViewColumn column in dgvVaraus.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, text3));
                                pdf3.AddCell(cell);
                            }
                            string pdfcell3;
                            foreach (DataGridViewRow row in dgvVaraus.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfcell3 = null;
                                    }
                                    else
                                    {
                                        pdfcell3 = cell.Value.ToString();
                                        pdf3.AddCell(new Phrase(pdfcell3, text3));
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {

                                PdfWriter.GetInstance(pdfD, stream);
                                pdfD.Open();
                                pdfD.Add(prg);
                                pdfD.Add(pdf);
                                pdfD.Add(prg2);
                                pdfD.Add(pdf2);
                                pdfD.Add(prg3);
                                pdfD.Add(pdf3);
                                pdfD.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Laskun tekeminen onnistui!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error! Laskun kirjoittaminen ei onnistunut" + ex.Message);
                        }
                    }
                }
            }

          
        }
    }
}
