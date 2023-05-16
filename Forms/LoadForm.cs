﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Autoparts_NVA.Forms
{
    public partial class LoadForm : Form
    {
        private Form loadForm;
        public LoadForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            loadForm = this;
            //progressBarLoad.Value = 0;
            //textLoad.Text = "Загрузка ...";

        }
        public async void EditTextProgress(string text, int value)
        {
                this.textLoad.Text = text;
                this.progressBarLoad.Value = value;
           
        }
    }
}
