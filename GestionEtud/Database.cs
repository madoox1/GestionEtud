using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionEtud
{
    internal class Database
    {
        private MySqlConnection conn;

        public Database()
        {
            string connectionString = "Server=localhost;Database=GestionEtudiants;User=root;Password=123456;";
            conn = new MySqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public void AjouterEtudiant(string nom, string prenom, string codeEtudiant, string filiere)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO Etudiants (nom, prenom, code_etudiant, filiere) VALUES (@nom, @prenom, @codeEtudiant, @filiere)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@codeEtudiant", codeEtudiant);
                    cmd.Parameters.AddWithValue("@filiere", filiere);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added succesfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout de l'étudiant : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void SupprimerEtudiant(string codeEtudiant)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Etudiants WHERE code_etudiant = @codeEtudiant";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codeEtudiant", codeEtudiant);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted succesfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'étudiant : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ModifierEtudiant(string nom, string prenom, string codeEtudiant, string filiere)
        {
            try
            {
                OpenConnection();
                string query = "UPDATE Etudiants SET nom = @nom, prenom = @prenom, filiere = @filiere WHERE code_etudiant = @codeEtudiant";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@codeEtudiant", codeEtudiant);
                    cmd.Parameters.AddWithValue("@filiere", filiere);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la modification de l'étudiant : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable GetEtudiants()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                string query = "SELECT * FROM Etudiants";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des étudiants : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
    }
}