using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerProje
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void personelDB_Click(object sender, EventArgs e)
        {
            FormPersoneller formpersoneller = new FormPersoneller();


            formpersoneller.Show();
        }

        private void ameliyatDB_Click(object sender, EventArgs e)
        {
            FormPersoneller formpersoneller = new FormPersoneller();


            formpersoneller.Show();
        }

        private void hastaDB_Click(object sender, EventArgs e)
        {
            FormHastalar formhastalar = new FormHastalar();


            formhastalar.Show();
        }
    }
}
