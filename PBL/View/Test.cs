﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.View;

namespace PBL.View
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            // Ensure 'UCQuanLyNhapXuatKho_Main' is defined in the 'PBL.View.UC' namespace  
            ucThongKeDoanhSo_Main uc = new ucThongKeDoanhSo_Main();
            this.Controls.Add(uc);
        }
    }
}
