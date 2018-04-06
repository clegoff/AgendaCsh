namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Password_label;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Connexion_Button = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            Password_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agenda.Properties.Resources.wall_clock_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion_Button
            // 
            this.Connexion_Button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Connexion_Button.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Connexion_Button.Location = new System.Drawing.Point(312, 205);
            this.Connexion_Button.Name = "Connexion_Button";
            this.Connexion_Button.Size = new System.Drawing.Size(139, 42);
            this.Connexion_Button.TabIndex = 1;
            this.Connexion_Button.Text = "Connexion";
            this.Connexion_Button.UseVisualStyleBackColor = false;
            this.Connexion_Button.Click += new System.EventHandler(this.Connexion_Button_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(312, 57);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(139, 25);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(312, 132);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 25);
            this.Password.TabIndex = 3;
            // 
            // Login_label
            // 
            this.Login_label.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.Login_label.Location = new System.Drawing.Point(312, 31);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(139, 23);
            this.Login_label.TabIndex = 4;
            this.Login_label.Text = "Login";
            this.Login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_label
            // 
            Password_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Password_label.Location = new System.Drawing.Point(312, 106);
            Password_label.Name = "Password_label";
            Password_label.Size = new System.Drawing.Size(139, 23);
            Password_label.TabIndex = 5;
            Password_label.Text = "Password";
            Password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Connexion_Button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Connexion_Button;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Login_label;
    }
}

