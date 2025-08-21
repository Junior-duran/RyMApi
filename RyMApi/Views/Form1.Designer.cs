namespace RyMApi
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
            button1 = new Button();
            dgvCharacters = new DataGridView();
            label1 = new Label();
            Personajes = new PictureBox();
            label2 = new Label();
            Buscar_txt = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Personajes).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(661, 386);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 0;
            button1.Text = "Obtener Personajes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvCharacters
            // 
            dgvCharacters.AllowUserToAddRows = false;
            dgvCharacters.AllowUserToDeleteRows = false;
            dgvCharacters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCharacters.Location = new Point(319, 67);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.ReadOnly = true;
            dgvCharacters.Size = new Size(469, 302);
            dgvCharacters.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 20);
            label1.Name = "label1";
            label1.Size = new Size(361, 34);
            label1.TabIndex = 2;
            label1.Text = "Personajes de Rick y Morty";
            // 
            // Personajes
            // 
            Personajes.Location = new Point(45, 67);
            Personajes.Name = "Personajes";
            Personajes.Size = new Size(234, 302);
            Personajes.SizeMode = PictureBoxSizeMode.StretchImage;
            Personajes.TabIndex = 3;
            Personajes.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 20);
            label2.Name = "label2";
            label2.Size = new Size(144, 34);
            label2.TabIndex = 4;
            label2.Text = "Personaje";
            // 
            // Buscar_txt
            // 
            Buscar_txt.Location = new Point(130, 375);
            Buscar_txt.Multiline = true;
            Buscar_txt.Name = "Buscar_txt";
            Buscar_txt.Size = new Size(149, 41);
            Buscar_txt.TabIndex = 5;
            Buscar_txt.TextChanged += Buscar_txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 386);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(label3);
            Controls.Add(Buscar_txt);
            Controls.Add(label2);
            Controls.Add(Personajes);
            Controls.Add(label1);
            Controls.Add(dgvCharacters);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)Personajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvCharacters;
        private Label label1;
        private PictureBox Personajes;
        private Label label2;
        private TextBox Buscar_txt;
        private Label label3;
    }
}
