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
    public partial class Form1 : Form
    {
        private const string adminLogin = "admin";
        private const string adminPassword = "admin123";
        public Form1()
        {
            InitializeComponent();
        }



        private void quitter_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valider_button_Click(object sender, EventArgs e)
        {
            string login = login_input.Text;
            string password = password_input.Text;

            if(login == adminLogin && password == adminPassword)
            {
                MessageBox.Show("Connection reussi!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                Console.WriteLine("Connected");
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error connecting");
            }

        }
    }
}
