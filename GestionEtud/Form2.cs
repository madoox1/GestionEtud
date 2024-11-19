using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionEtud
{
    public partial class Form2 : Form
    {
        private Database db;
        private DataTable dataTable;
        private int currentRowIndex = 0;

        public Form2()
        {
            InitializeComponent();
            db = new Database();
            LoadData(); 
        }

        private void LoadData()
        {
            dataTable = db.GetEtudiants();
            if (dataTable.Rows.Count > 0)
            {
                currentRowIndex = 0;
                DisplayCurrentRow();
            }
            else
            {
                MessageBox.Show("No data available.");
                ClearInputFields();
            }
        }

        private void quitter_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveau_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom_input.Text) || string.IsNullOrWhiteSpace(prenom_input.Text) ||
                string.IsNullOrWhiteSpace(code_input.Text) || string.IsNullOrWhiteSpace(filiere_input.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            db.AjouterEtudiant(nom_input.Text, prenom_input.Text, code_input.Text, filiere_input.Text);
            LoadData();  
        }

        private void modifier_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code_input.Text))
            {
                MessageBox.Show("Please enter the code of the student to modify.");
                return;
            }

            try
            {
                db.ModifierEtudiant(nom_input.Text, prenom_input.Text, code_input.Text, filiere_input.Text);
                LoadData(); 
                MessageBox.Show("Student information updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student information: {ex.Message}");
            }
        }

        private void supprimer_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code_input.Text))
            {
                MessageBox.Show("Please provide a student code to delete.");
                return;
            }

            db.SupprimerEtudiant(code_input.Text);
            LoadData();  
        }

        private void chercher_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(code_input.Text))
            {
                MessageBox.Show("Please enter a code to search.");
                return;
            }

            DataRow[] foundRows = dataTable.Select($"code_etudiant = '{code_input.Text}'");

            if (foundRows.Length > 0)
            {
                DataRow row = foundRows[0];
                nom_input.Text = row["nom"].ToString();
                prenom_input.Text = row["prenom"].ToString();
                filiere_input.Text = row["filiere"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found.");
                ClearInputFields();
            }
        }

        private void dernier_button_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                currentRowIndex = dataTable.Rows.Count - 1;
                DisplayCurrentRow();
            }
        }

        private void suivant_button_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < dataTable.Rows.Count - 1)
            {
                currentRowIndex++;
                DisplayCurrentRow();
            }
            else
            {
                MessageBox.Show("You have reached the end.");
            }
        }

        private void precedent_button_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                DisplayCurrentRow();
            }
            else
            {
                MessageBox.Show("You have reached the beginning.");
            }
        }

        private void premier_button_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                currentRowIndex = 0;
                DisplayCurrentRow();
            }
        }

        private void DisplayCurrentRow()
        {
            if (dataTable.Rows.Count > 0)
            {
                code_input.Text = dataTable.Rows[currentRowIndex]["code_etudiant"].ToString();
                nom_input.Text = dataTable.Rows[currentRowIndex]["nom"].ToString();
                prenom_input.Text = dataTable.Rows[currentRowIndex]["prenom"].ToString();
                filiere_input.Text = dataTable.Rows[currentRowIndex]["filiere"].ToString();
            }
        }

        private void ClearInputFields()
        {
            code_input.Text = string.Empty;
            nom_input.Text = string.Empty;
            prenom_input.Text = string.Empty;
            filiere_input.Text = string.Empty;
        }

        private void afficher_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
