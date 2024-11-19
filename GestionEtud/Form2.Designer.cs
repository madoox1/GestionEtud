namespace GestionEtud
{
    partial class Form2
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
            this.code_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filiere_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precedent_button = new System.Windows.Forms.Button();
            this.suivant_button = new System.Windows.Forms.Button();
            this.dernier_button = new System.Windows.Forms.Button();
            this.premier_button = new System.Windows.Forms.Button();
            this.quitter_button = new System.Windows.Forms.Button();
            this.nouveau_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.chercher_button = new System.Windows.Forms.Button();
            this.afficher_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_input
            // 
            this.code_input.Location = new System.Drawing.Point(219, 110);
            this.code_input.Multiline = true;
            this.code_input.Name = "code_input";
            this.code_input.Size = new System.Drawing.Size(157, 32);
            this.code_input.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code";
            // 
            // nom_input
            // 
            this.nom_input.Location = new System.Drawing.Point(219, 160);
            this.nom_input.Multiline = true;
            this.nom_input.Name = "nom_input";
            this.nom_input.Size = new System.Drawing.Size(157, 32);
            this.nom_input.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // prenom_input
            // 
            this.prenom_input.Location = new System.Drawing.Point(219, 205);
            this.prenom_input.Multiline = true;
            this.prenom_input.Name = "prenom_input";
            this.prenom_input.Size = new System.Drawing.Size(157, 32);
            this.prenom_input.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenom";
            // 
            // filiere_input
            // 
            this.filiere_input.Location = new System.Drawing.Point(219, 245);
            this.filiere_input.Multiline = true;
            this.filiere_input.Name = "filiere_input";
            this.filiere_input.Size = new System.Drawing.Size(157, 32);
            this.filiere_input.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filiere";
            // 
            // precedent_button
            // 
            this.precedent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedent_button.Location = new System.Drawing.Point(172, 367);
            this.precedent_button.Name = "precedent_button";
            this.precedent_button.Size = new System.Drawing.Size(125, 44);
            this.precedent_button.TabIndex = 14;
            this.precedent_button.Text = "Precedent";
            this.precedent_button.UseVisualStyleBackColor = true;
            this.precedent_button.Click += new System.EventHandler(this.precedent_button_Click);
            // 
            // suivant_button
            // 
            this.suivant_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_button.Location = new System.Drawing.Point(303, 367);
            this.suivant_button.Name = "suivant_button";
            this.suivant_button.Size = new System.Drawing.Size(122, 44);
            this.suivant_button.TabIndex = 15;
            this.suivant_button.Text = "Suivant";
            this.suivant_button.UseVisualStyleBackColor = true;
            this.suivant_button.Click += new System.EventHandler(this.suivant_button_Click);
            // 
            // dernier_button
            // 
            this.dernier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dernier_button.Location = new System.Drawing.Point(431, 367);
            this.dernier_button.Name = "dernier_button";
            this.dernier_button.Size = new System.Drawing.Size(121, 44);
            this.dernier_button.TabIndex = 16;
            this.dernier_button.Text = "Dernier";
            this.dernier_button.UseVisualStyleBackColor = true;
            this.dernier_button.Click += new System.EventHandler(this.dernier_button_Click);
            // 
            // premier_button
            // 
            this.premier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premier_button.Location = new System.Drawing.Point(52, 367);
            this.premier_button.Name = "premier_button";
            this.premier_button.Size = new System.Drawing.Size(114, 44);
            this.premier_button.TabIndex = 17;
            this.premier_button.Text = "Premiere";
            this.premier_button.UseVisualStyleBackColor = true;
            this.premier_button.Click += new System.EventHandler(this.premier_button_Click);
            // 
            // quitter_button
            // 
            this.quitter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter_button.Location = new System.Drawing.Point(446, 50);
            this.quitter_button.Name = "quitter_button";
            this.quitter_button.Size = new System.Drawing.Size(121, 44);
            this.quitter_button.TabIndex = 18;
            this.quitter_button.Text = "Quitter";
            this.quitter_button.UseVisualStyleBackColor = true;
            this.quitter_button.Click += new System.EventHandler(this.quitter_button_Click);
            // 
            // nouveau_button
            // 
            this.nouveau_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau_button.Location = new System.Drawing.Point(446, 100);
            this.nouveau_button.Name = "nouveau_button";
            this.nouveau_button.Size = new System.Drawing.Size(121, 44);
            this.nouveau_button.TabIndex = 19;
            this.nouveau_button.Text = "Nouveau";
            this.nouveau_button.UseVisualStyleBackColor = true;
            this.nouveau_button.Click += new System.EventHandler(this.nouveau_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_button.Location = new System.Drawing.Point(446, 150);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(121, 44);
            this.modifier_button.TabIndex = 20;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.modifier_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_button.Location = new System.Drawing.Point(446, 200);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(121, 44);
            this.supprimer_button.TabIndex = 21;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.supprimer_button_Click);
            // 
            // chercher_button
            // 
            this.chercher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercher_button.Location = new System.Drawing.Point(446, 250);
            this.chercher_button.Name = "chercher_button";
            this.chercher_button.Size = new System.Drawing.Size(121, 44);
            this.chercher_button.TabIndex = 22;
            this.chercher_button.Text = "Chercher";
            this.chercher_button.UseVisualStyleBackColor = true;
            this.chercher_button.Click += new System.EventHandler(this.chercher_button_Click);
            // 
            // afficher_button
            // 
            this.afficher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher_button.Location = new System.Drawing.Point(446, 300);
            this.afficher_button.Name = "afficher_button";
            this.afficher_button.Size = new System.Drawing.Size(121, 44);
            this.afficher_button.TabIndex = 23;
            this.afficher_button.Text = "Afficher";
            this.afficher_button.UseVisualStyleBackColor = true;
            this.afficher_button.Click += new System.EventHandler(this.afficher_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.afficher_button);
            this.Controls.Add(this.chercher_button);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.nouveau_button);
            this.Controls.Add(this.quitter_button);
            this.Controls.Add(this.premier_button);
            this.Controls.Add(this.dernier_button);
            this.Controls.Add(this.suivant_button);
            this.Controls.Add(this.precedent_button);
            this.Controls.Add(this.filiere_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenom_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.code_input);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenom_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filiere_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button precedent_button;
        private System.Windows.Forms.Button suivant_button;
        private System.Windows.Forms.Button dernier_button;
        private System.Windows.Forms.Button premier_button;
        private System.Windows.Forms.Button quitter_button;
        private System.Windows.Forms.Button nouveau_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button chercher_button;
        private System.Windows.Forms.Button afficher_button;
    }
}