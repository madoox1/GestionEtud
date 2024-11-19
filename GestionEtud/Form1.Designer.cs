namespace GestionEtud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valider_button = new System.Windows.Forms.Button();
            this.quitter_button = new System.Windows.Forms.Button();
            this.login_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // valider_button
            // 
            this.valider_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_button.Location = new System.Drawing.Point(256, 364);
            this.valider_button.Name = "valider_button";
            this.valider_button.Size = new System.Drawing.Size(95, 44);
            this.valider_button.TabIndex = 2;
            this.valider_button.Text = "Valider";
            this.valider_button.UseVisualStyleBackColor = true;
            this.valider_button.Click += new System.EventHandler(this.valider_button_Click);
            // 
            // quitter_button
            // 
            this.quitter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter_button.Location = new System.Drawing.Point(373, 364);
            this.quitter_button.Name = "quitter_button";
            this.quitter_button.Size = new System.Drawing.Size(95, 44);
            this.quitter_button.TabIndex = 3;
            this.quitter_button.Text = "Quitter";
            this.quitter_button.UseVisualStyleBackColor = true;
            this.quitter_button.Click += new System.EventHandler(this.quitter_button_Click);
            // 
            // login_input
            // 
            this.login_input.Location = new System.Drawing.Point(267, 167);
            this.login_input.Name = "login_input";
            this.login_input.Size = new System.Drawing.Size(157, 20);
            this.login_input.TabIndex = 4;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(267, 221);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(157, 20);
            this.password_input.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.login_input);
            this.Controls.Add(this.quitter_button);
            this.Controls.Add(this.valider_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestion des Etudiants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button valider_button;
        private System.Windows.Forms.Button quitter_button;
        private System.Windows.Forms.TextBox login_input;
        private System.Windows.Forms.TextBox password_input;
    }
}

