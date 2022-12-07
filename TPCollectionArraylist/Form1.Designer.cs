namespace TPCollectionArraylist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxInsererDebut = new System.Windows.Forms.TextBox();
            this.buttonInsererDebut = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSupprimerDernier = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Q1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Q2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAjoutDirect_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Q3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonTabArray_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Q4 moyenne";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonMoyenne_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Q5 moyenne";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonMoyenneForeach_Click);
            // 
            // textBoxInsererDebut
            // 
            this.textBoxInsererDebut.Location = new System.Drawing.Point(255, 45);
            this.textBoxInsererDebut.Name = "textBoxInsererDebut";
            this.textBoxInsererDebut.Size = new System.Drawing.Size(125, 27);
            this.textBoxInsererDebut.TabIndex = 5;
            // 
            // buttonInsererDebut
            // 
            this.buttonInsererDebut.Location = new System.Drawing.Point(386, 44);
            this.buttonInsererDebut.Name = "buttonInsererDebut";
            this.buttonInsererDebut.Size = new System.Drawing.Size(140, 29);
            this.buttonInsererDebut.TabIndex = 6;
            this.buttonInsererDebut.Text = "Inserer au début";
            this.buttonInsererDebut.UseVisualStyleBackColor = true;
            this.buttonInsererDebut.Click += new System.EventHandler(this.buttonInsererDebut_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(255, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 29);
            this.button6.TabIndex = 8;
            this.button6.Text = "Inserer 3 chiffres à l\'indice 4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonInsererIndice4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saisir un chiffre :";
            // 
            // buttonSupprimerDernier
            // 
            this.buttonSupprimerDernier.Location = new System.Drawing.Point(255, 171);
            this.buttonSupprimerDernier.Name = "buttonSupprimerDernier";
            this.buttonSupprimerDernier.Size = new System.Drawing.Size(205, 29);
            this.buttonSupprimerDernier.TabIndex = 10;
            this.buttonSupprimerDernier.Text = "Supprimer l\'element 3";
            this.buttonSupprimerDernier.UseVisualStyleBackColor = true;
            this.buttonSupprimerDernier.Click += new System.EventHandler(this.buttonSupprimerDernier_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(255, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 29);
            this.button7.TabIndex = 11;
            this.button7.Text = "Supprimer les 3 derniers";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonSupprimer3Derniers_Click);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(47, 324);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(13, 20);
            this.resultat.TabIndex = 12;
            this.resultat.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSupprimerDernier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonInsererDebut);
            this.Controls.Add(this.textBoxInsererDebut);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBoxInsererDebut;
        private Button buttonInsererDebut;
        private Button button6;
        private Label label1;
        private Button buttonSupprimerDernier;
        private Button button7;
        private Label resultat;
    }
}