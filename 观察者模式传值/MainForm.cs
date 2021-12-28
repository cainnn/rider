using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 观察者模式传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ctrlForm = new ControlForm();
            ctrlForm.MdiParent = this;
            ctrlForm.Show();
            var cf1 = new ChildForm1(ctrlForm);
            cf1.MdiParent = this;
            cf1.Show();
            var cf2 = new ChildForm2(ctrlForm);
            cf2.MdiParent = this;
            cf2.Show();
            var cf3 = new ChildForm3(ctrlForm);
            cf3.MdiParent = this;
            cf3.Show();
        }
    }
}