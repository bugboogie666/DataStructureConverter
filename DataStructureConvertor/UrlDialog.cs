using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureConvertor
{
    public partial class UrlDialog : Form
    {
        public string TextUrl { get; private set; }

        public UrlDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbInputUrlDialog_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOKUrlDialog_Click(object sender, EventArgs e)
        {
            TextUrl = this.tbInputUrlDialog.Text;
            this.Close();
        }
    }
}
