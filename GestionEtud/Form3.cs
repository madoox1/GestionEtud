using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtud
{
    public partial class Form3 : Form
    {
        private Database db;
        public Form3()
        {
            InitializeComponent();
            db = new Database();
            dataGridView1.DataSource = db.GetEtudiants();
        }

        private void quitter_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
