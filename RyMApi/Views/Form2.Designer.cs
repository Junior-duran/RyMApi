namespace RyMApi
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlRoot = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            grpCharacterDetails = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblOrigin = new Label();
            txtOrigin = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            picCharacter = new PictureBox();
            pnlSearch = new Panel();
            Buscar_txt = new TextBox();
            btnLoad = new Button();
            pnlRight = new Panel();
            grpCharacters = new GroupBox();
            dgvCharacters = new DataGridView();
            pnlRoot.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            grpCharacterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCharacter).BeginInit();
            pnlSearch.SuspendLayout();
            pnlRight.SuspendLayout();
            grpCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).BeginInit();
            SuspendLayout();
            // 
            // pnlRoot
            // 
            pnlRoot.BackColor = Color.FromArgb(22, 34, 56);
            pnlRoot.BackgroundImage = (Image)resources.GetObject("pnlRoot.BackgroundImage");
            pnlRoot.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRoot.Controls.Add(panel1);
            pnlRoot.Controls.Add(pnlLeft);
            pnlRoot.Controls.Add(pnlRight);
            pnlRoot.Dock = DockStyle.Fill;
            pnlRoot.Location = new Point(0, 0);
            pnlRoot.Name = "pnlRoot";
            pnlRoot.Padding = new Padding(16);
            pnlRoot.Size = new Size(1100, 702);
            pnlRoot.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 76);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeft.BackColor = Color.Transparent;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(grpCharacterDetails);
            pnlLeft.Controls.Add(pnlSearch);
            pnlLeft.Location = new Point(24, 94);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(12);
            pnlLeft.Size = new Size(400, 588);
            pnlLeft.TabIndex = 1;
            // 
            // grpCharacterDetails
            // 
            grpCharacterDetails.BackColor = Color.Transparent;
            grpCharacterDetails.Controls.Add(lblName);
            grpCharacterDetails.Controls.Add(txtName);
            grpCharacterDetails.Controls.Add(lblSpecies);
            grpCharacterDetails.Controls.Add(txtSpecies);
            grpCharacterDetails.Controls.Add(lblOrigin);
            grpCharacterDetails.Controls.Add(txtOrigin);
            grpCharacterDetails.Controls.Add(lblStatus);
            grpCharacterDetails.Controls.Add(txtStatus);
            grpCharacterDetails.Controls.Add(picCharacter);
            grpCharacterDetails.Font = new Font("Segoe UI", 10F);
            grpCharacterDetails.ForeColor = Color.FromArgb(153, 255, 238);
            grpCharacterDetails.Location = new Point(12, 8);
            grpCharacterDetails.Name = "grpCharacterDetails";
            grpCharacterDetails.Size = new Size(372, 480);
            grpCharacterDetails.TabIndex = 0;
            grpCharacterDetails.TabStop = false;
            grpCharacterDetails.Text = "Character Details";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.WhiteSmoke;
            lblName.Location = new Point(18, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(100, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 25);
            txtName.TabIndex = 1;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.ForeColor = Color.WhiteSmoke;
            lblSpecies.Location = new Point(18, 28);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(56, 19);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.BorderStyle = BorderStyle.FixedSingle;
            txtSpecies.Location = new Point(100, 28);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(240, 25);
            txtSpecies.TabIndex = 3;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.ForeColor = Color.WhiteSmoke;
            lblOrigin.Location = new Point(18, 28);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(50, 19);
            lblOrigin.TabIndex = 4;
            lblOrigin.Text = "Origin:";
            // 
            // txtOrigin
            // 
            txtOrigin.BorderStyle = BorderStyle.FixedSingle;
            txtOrigin.Location = new Point(100, 28);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(240, 25);
            txtOrigin.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.WhiteSmoke;
            lblStatus.Location = new Point(18, 28);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 19);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Location = new Point(100, 28);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(240, 25);
            txtStatus.TabIndex = 7;
            // 
            // picCharacter
            // 
            picCharacter.BorderStyle = BorderStyle.FixedSingle;
            picCharacter.Location = new Point(44, 81);
            picCharacter.Name = "picCharacter";
            picCharacter.Size = new Size(281, 367);
            picCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            picCharacter.TabIndex = 8;
            picCharacter.TabStop = false;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(Buscar_txt);
            pnlSearch.Controls.Add(btnLoad);
            pnlSearch.Location = new Point(12, 500);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(372, 70);
            pnlSearch.TabIndex = 1;
            // 
            // Buscar_txt
            // 
            Buscar_txt.Font = new Font("Segoe UI", 11F);
            Buscar_txt.Location = new Point(0, 20);
            Buscar_txt.Name = "Buscar_txt";
            Buscar_txt.PlaceholderText = "Search characters...";
            Buscar_txt.Size = new Size(260, 27);
            Buscar_txt.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(102, 255, 204);
            btnLoad.FlatAppearance.BorderColor = Color.FromArgb(102, 255, 204);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.FromArgb(10, 16, 28);
            btnLoad.Location = new Point(270, 18);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 32);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRight.BackColor = Color.Transparent;
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(grpCharacters);
            pnlRight.Location = new Point(440, 94);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(12);
            pnlRight.Size = new Size(636, 588);
            pnlRight.TabIndex = 2;
            // 
            // grpCharacters
            // 
            grpCharacters.BackColor = Color.FromArgb(10, 16, 28);
            grpCharacters.Controls.Add(dgvCharacters);
            grpCharacters.Font = new Font("Segoe UI", 10F);
            grpCharacters.ForeColor = Color.FromArgb(153, 255, 238);
            grpCharacters.Location = new Point(12, 12);
            grpCharacters.Name = "grpCharacters";
            grpCharacters.Size = new Size(610, 559);
            grpCharacters.TabIndex = 0;
            grpCharacters.TabStop = false;
            grpCharacters.Text = "Rick and Morty Characters";
            // 
            // dgvCharacters
            // 
            dgvCharacters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCharacters.BackgroundColor = Color.FromArgb(14, 22, 40);
            dgvCharacters.BorderStyle = BorderStyle.None;
            dgvCharacters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(153, 255, 238);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCharacters.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCharacters.GridColor = Color.FromArgb(52, 112, 104);
            dgvCharacters.Location = new Point(3, 21);
            dgvCharacters.Name = "dgvCharacters";
            dgvCharacters.RowHeadersVisible = false;
            dgvCharacters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCharacters.Size = new Size(604, 532);
            dgvCharacters.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(10, 16, 28);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1100, 702);
            Controls.Add(pnlRoot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rick and Morty - API Characters";
            pnlRoot.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            grpCharacterDetails.ResumeLayout(false);
            grpCharacterDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCharacter).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlRight.ResumeLayout(false);
            grpCharacters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCharacters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox grpCharacterDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PictureBox picCharacter;

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox Buscar_txt;
        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpCharacters;
        private System.Windows.Forms.DataGridView dgvCharacters;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
