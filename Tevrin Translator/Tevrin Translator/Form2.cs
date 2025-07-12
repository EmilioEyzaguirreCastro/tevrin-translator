using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tevrin_Translator
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.aboutUs.Enabled = true;
            mainForm.submitEnglish.Enabled = true;
            // mainForm.submitSpanish.Enabled = true;
            mainForm.textBox1.ReadOnly = false;
        }
    }
}
