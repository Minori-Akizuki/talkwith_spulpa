using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace talkwith_spulpa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            saveConfig();
            this.Close();
        }

        private void saveConfig()
        {
            ConfigurationManager.AppSettings["sepString"] = textBox_sepString.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_sepString.Text = ConfigurationManager.AppSettings["sepString"];
        }
    }
}
