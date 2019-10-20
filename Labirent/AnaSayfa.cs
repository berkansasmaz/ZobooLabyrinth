using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

      

        private void btnTekBasinaOyna_Click(object sender, EventArgs e)
        {
            Labirent labirent = new Labirent(1);
            labirent.Show();
            this.Hide();
        }

        private void btnBilgisayarOyna_Click(object sender, EventArgs e)
        {
            Labirent labirent = new Labirent(2);
            labirent.Show();
            this.Hide();
        }
    }
}
