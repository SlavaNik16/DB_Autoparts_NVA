﻿using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Data.Common;
using System.IO;
using iTextSharp.text.html.simpleparser;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace DB_Autoparts_NVA.Forms
{
    public partial class ExportUserForm : Form
    {
        private List<String> list = new List<String>() { "Excel", "PDf"};
        public ListViewItem listItem;
        public DbContextOptions<ApplicationContext> options;
        private decimal priceAll;
        private int index = 0;
        private Users users = null;
        public ExportUserForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            dataGridProductExport.EnableHeadersVisualStyles = false;
        }
        public ExportUserForm(Users user) : this()
        {
            users = user;
            
            priceAll =new MainForm(users).AllMoney();
            if (user.status == "Admin") priceAll = new MainForm().MoneyUser(user);
            labelFIO.Text = $"{user.surname} {user.name}";
            labelPhone.Text = user.phone.ToString();
            var lists = MainForm.FormatDataGridUser(options, users);
            FullComboType();
        
            foreach (var l in lists)
            {
                listItem = new ListViewItem(new string[] {
                    l.Parts_id.ToString(),
                    l.NameProduct,
                    l.Count.ToString(),
                    l.PriceAll, 
                    l.DateBy.ToString()
                });
                listView1.Items.Add(listItem);
               
            } 
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }

     
        private void FullComboType()
        {
            foreach(var text in list)
            {
                comboBoxTypeExport.Items.Add(text);
            }
            comboBoxTypeExport.SelectedIndex = 0;
                
        }

        private void comboBoxTypeExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBoxTypeExport.SelectedIndex;
        }

        private void butExport_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    ExportExcel();
                    break; 
                case 1:
                    ExportPDf();
                    break;
            }
        }
        private void ExportExcel()
        {
            int i = 1;
            var xlApp = new Excel.Application();
            //Книга
            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 30;

            //Лист
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            //Присвоепние имени листа
            xlSheet.Name = "История покупок пользователя";

            xlSheet.Cells[i, 1] = "Фамилия";
            xlSheet.Cells[i, 2] = users.surname;
            i++;//2
            xlSheet.Cells[i, 1] = "Имя";
            xlSheet.Cells[i, 2] = users.name;
            i++;//3
            xlSheet.Cells[i, 1] = "Пол";
            xlSheet.Cells[i, 2] = users.gender;
            i++;//4
            xlSheet.Cells[i, 1] = "День рождения";
            xlSheet.Cells[i, 2] = users.birthday;
            i++;//5
            xlSheet.Cells[i, 1] = "Почта";
            xlSheet.Cells[i, 2] = users.email;
            i++;//6
            xlSheet.Cells[i, 1] = "Телефон";
            xlSheet.Cells[i, 2] = users.phone;

            xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[i, 1]].Interior.Color = Color.Orange;
            xlSheet.Range[xlSheet.Cells[1, 2], xlSheet.Cells[i, 2]].Interior.Color = Color.Coral;

            i++;//7
            xlSheet.Cells[i, 1] = "Всего: ";
            xlSheet.Cells[i, 1].HorizontalAlignment = HorizontalAlignment.Right;
            xlSheet.Cells[i, 2] = $"{priceAll:C2}";
            xlSheet.Cells[i, 1].Interior.Color = Color.FromArgb(255, 66, 170, 255);

            i += 2;//9
            xlSheet.Range[xlSheet.Cells[i, 2], xlSheet.Cells[i, 4]].Merge(true);
            xlSheet.Cells[i, 2] = "История покупок";
            xlSheet.Cells[i, 2].Interior.Color = Color.FromArgb(255, 229, 81, 55);

            i++;//10;
            xlSheet.Cells[i, 1] = "Id";
            xlSheet.Cells[i, 2] = "Продукт";
            xlSheet.Cells[i, 3] = "Кол-во";
            xlSheet.Cells[i, 4] = "Общая цена";
            xlSheet.Cells[i, 5] = "Дата покупки";
            xlSheet.Range[xlSheet.Cells[i, 1], xlSheet.Cells[i, 5]].Interior.Color = Color.Orange;
            i++;//11
            for (int k = 0; k < listView1.Items.Count; k++)
            {
                for (int j = 0; j < listItem.SubItems.Count; j++)
                {
                    xlSheet.Cells[k + i, j+1]= listView1.Items[k].SubItems[j].Text;
                    xlSheet.Cells[k + i, j+1].Interior.Color = Color.FromArgb(255, 255, 202, 134);
                }
            }
            xlSheet.Cells.HorizontalAlignment = 3;
            xlApp.Visible = true;
            //MessageBox.Show("Не забудьте самостоятельно выключить процесс в Диспетчере задач");
        }

        private void ExportPDf()
        {
            PdfPTable pdfTable = new PdfPTable(dataGridProductExport.ColumnCount - 2);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = 3;
            pdfTable.DefaultCell.BorderWidth = 1;

            var font = new Font(BaseFont
                .CreateFont("c:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED),
                10,
                iTextSharp.text.Font.NORMAL); 

            PdfPTable pdfTableUser = new PdfPTable(2);
            pdfTableUser.DefaultCell.Padding = 3;    
            pdfTableUser.WidthPercentage = 100;
            pdfTableUser.HorizontalAlignment = 3;
            pdfTableUser.DefaultCell.BorderWidth = 1;

            var cell = new PdfPCell(
                   new Phrase("Фамилия", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase(users.surname, font));

            cell = new PdfPCell(
                  new Phrase("Имя", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase(users.name, font));

            cell = new PdfPCell(
                 new Phrase("Пол", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase(users.gender, font));
            

            cell = new PdfPCell(
                 new Phrase("День рождения", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell); 
            pdfTableUser.AddCell(new Phrase(users.birthday.ToString(), font));
          

            cell = new PdfPCell(
                new Phrase("Email", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase(users.email, font));
           

            cell = new PdfPCell(
              new Phrase("Телефон", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase(users.phone, font));
           
            //Добавление в pdf Header
            for (int j = 0; j < listItem.SubItems.Count; j++)
            {
                cell = new PdfPCell(
                    new Phrase(new Phrase(listView1.Columns[j].Text.ToString(), font)));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            for (int k = 0; k < listView1.Items.Count; k++)
            {
                for (int j = 0; j < listItem.SubItems.Count; j++)
                {
                    pdfTable.AddCell(
                        new Phrase(listView1.Items[k].SubItems[j].Text, font));
                }
            }


            PdfPTable pdfTableResult = new PdfPTable(2);
            pdfTableUser.DefaultCell.Padding = 3;
            pdfTableUser.WidthPercentage = 100;
            pdfTableUser.HorizontalAlignment = 3;
            pdfTableUser.DefaultCell.BorderWidth = 1;

            cell = new PdfPCell(
            new Phrase("Всего", font));
            cell.BackgroundColor = new BaseColor(240, 240, 240);
            pdfTableUser.AddCell(cell);
            pdfTableUser.AddCell(new Phrase($"{priceAll:C2}", font));

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "История покупок пользователя";
            saveFileDialog.DefaultExt = ".pdf";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    using (var pdfDoc = new Document(PageSize.A4, 10f, 10f, 40f, 10f))
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTableUser);
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(pdfTableResult);
                    }
                }
            }
        }

        private void ExportUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }

}
