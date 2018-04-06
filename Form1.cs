using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*'; // Masque le mot de passe
            Password.MaxLength = 10; // Longueur maximum du password a 10 caractères
        }

        // Vérification de l'utilisateur
        private void Connexion_Button_Click(object sender, EventArgs e)
        {
            string[] log = { "oceane" , "axel" };
            
            if (Login.Text.Equals("oceane") && Password.Text.Equals("oceane"))
            {
                Main m = new Main();
                m.Show();

                this.Hide(); // Cache la page d'identification
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
