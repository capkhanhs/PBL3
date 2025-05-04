using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL.DAL;
using PBL.Model;

namespace PBL.View
{
    public partial class testdbform : Form
    {
        public testdbform()
        {
            PBL3_azure_databaseEntities db = new PBL3_azure_databaseEntities();
            InitializeComponent();
            var list = db.Danh_Muc.ToList();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Ten_danh_muc);
                listBox2.Items.Add(item.Mo_ta);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PBL3_azure_databaseEntities db = new PBL3_azure_databaseEntities();
            var list = db.Danh_Muc.ToList();
            listBox1.Items.Clear(); 
            listBox2.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Ten_danh_muc);
                listBox2.Items.Add(item.Mo_ta);
            }
        }
    }
}
