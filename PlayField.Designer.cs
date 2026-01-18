using System.Windows.Forms;

namespace QzX
{
    partial class PlayField
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayField));
            tableLayoutPanel3 = new TableLayoutPanel();
            Layer_4 = new TableLayoutPanel();
            tblMainTable = new DataGridView();
            colPlayer = new DataGridViewTextBoxColumn();
            colPoints = new DataGridViewTextBoxColumn();
            colActive = new DataGridViewTextBoxColumn();
            tblThemes = new TableLayoutPanel();
            btn7Hard = new Button();
            btn7Med = new Button();
            btn7Easy = new Button();
            lblTheme7 = new Label();
            btn6Hard = new Button();
            btn6Med = new Button();
            btn6Easy = new Button();
            lblTheme6 = new Label();
            btn5Hard = new Button();
            btn5Med = new Button();
            btn5Easy = new Button();
            lblTheme5 = new Label();
            btn4Hard = new Button();
            btn4Med = new Button();
            btn4Easy = new Button();
            lblTheme4 = new Label();
            btn3Hard = new Button();
            btn3Med = new Button();
            btn3Easy = new Button();
            lblTheme3 = new Label();
            btn2Hard = new Button();
            btn2Med = new Button();
            btn2Easy = new Button();
            lblTheme2 = new Label();
            btn1Hard = new Button();
            btn1Med = new Button();
            btn1Easy = new Button();
            lblTheme1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveStat = new Button();
            picture = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblQuestion = new Label();
            panel1 = new Panel();
            tblTxtAns = new TableLayoutPanel();
            btnTxtAns = new Button();
            txtBoxTextAns = new TextBox();
            btnSkip = new Button();
            tblVarAns = new TableLayoutPanel();
            btnAns4 = new Button();
            btnAns2 = new Button();
            btnAns3 = new Button();
            btnAns1 = new Button();
            Layer_1 = new TableLayoutPanel();
            Layer_2 = new TableLayoutPanel();
            Layer_3 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            Layer_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblMainTable).BeginInit();
            tblThemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tblTxtAns.SuspendLayout();
            tblVarAns.SuspendLayout();
            Layer_1.SuspendLayout();
            Layer_2.SuspendLayout();
            Layer_3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(Layer_4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(299, 587);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Layer_4
            // 
            Layer_4.ColumnCount = 1;
            Layer_4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Layer_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Layer_4.Controls.Add(btnSaveStat, 0, 1);
            Layer_4.Controls.Add(tblMainTable, 0, 0);
            Layer_4.Dock = DockStyle.Fill;
            Layer_4.Location = new Point(3, 3);
            Layer_4.Name = "Layer_4";
            Layer_4.RowCount = 2;
            Layer_4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            Layer_4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Layer_4.Size = new Size(293, 581);
            Layer_4.TabIndex = 0;
            // 
            // tblMainTable
            // 
            tblMainTable.AllowUserToAddRows = false;
            tblMainTable.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tblMainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tblMainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMainTable.Columns.AddRange(new DataGridViewColumn[] { colPlayer, colPoints, colActive });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tblMainTable.DefaultCellStyle = dataGridViewCellStyle4;
            tblMainTable.Dock = DockStyle.Fill;
            tblMainTable.Location = new Point(3, 3);
            tblMainTable.Name = "tblMainTable";
            tblMainTable.ReadOnly = true;
            tblMainTable.RowHeadersVisible = false;
            tblMainTable.Size = new Size(287, 400);
            tblMainTable.TabIndex = 1;
            // 
            // colPlayer
            // 
            colPlayer.HeaderText = "Player";
            colPlayer.Name = "colPlayer";
            colPlayer.ReadOnly = true;
            // 
            // colPoints
            // 
            colPoints.HeaderText = "Points";
            colPoints.Name = "colPoints";
            colPoints.ReadOnly = true;
            // 
            // colActive
            // 
            colActive.HeaderText = "Active";
            colActive.Name = "colActive";
            colActive.ReadOnly = true;
            // 
            // tblThemes
            // 
            tblThemes.BackColor = Color.AliceBlue;
            tblThemes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tblThemes.ColumnCount = 4;
            tblThemes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tblThemes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblThemes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblThemes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblThemes.Controls.Add(btn7Hard, 3, 7);
            tblThemes.Controls.Add(btn7Med, 2, 7);
            tblThemes.Controls.Add(btn7Easy, 1, 7);
            tblThemes.Controls.Add(lblTheme7, 0, 7);
            tblThemes.Controls.Add(btn6Hard, 3, 6);
            tblThemes.Controls.Add(btn6Med, 2, 6);
            tblThemes.Controls.Add(btn6Easy, 1, 6);
            tblThemes.Controls.Add(lblTheme6, 0, 6);
            tblThemes.Controls.Add(btn5Hard, 3, 5);
            tblThemes.Controls.Add(btn5Med, 2, 5);
            tblThemes.Controls.Add(btn5Easy, 1, 5);
            tblThemes.Controls.Add(lblTheme5, 0, 5);
            tblThemes.Controls.Add(btn4Hard, 3, 4);
            tblThemes.Controls.Add(btn4Med, 2, 4);
            tblThemes.Controls.Add(btn4Easy, 1, 4);
            tblThemes.Controls.Add(lblTheme4, 0, 4);
            tblThemes.Controls.Add(btn3Hard, 3, 3);
            tblThemes.Controls.Add(btn3Med, 2, 3);
            tblThemes.Controls.Add(btn3Easy, 1, 3);
            tblThemes.Controls.Add(lblTheme3, 0, 3);
            tblThemes.Controls.Add(btn2Hard, 3, 2);
            tblThemes.Controls.Add(btn2Med, 2, 2);
            tblThemes.Controls.Add(btn2Easy, 1, 2);
            tblThemes.Controls.Add(lblTheme2, 0, 2);
            tblThemes.Controls.Add(btn1Hard, 3, 1);
            tblThemes.Controls.Add(btn1Med, 2, 1);
            tblThemes.Controls.Add(btn1Easy, 1, 1);
            tblThemes.Controls.Add(lblTheme1, 0, 1);
            tblThemes.Controls.Add(label4, 3, 0);
            tblThemes.Controls.Add(label3, 2, 0);
            tblThemes.Controls.Add(label2, 1, 0);
            tblThemes.Controls.Add(label1, 0, 0);
            tblThemes.Dock = DockStyle.Fill;
            tblThemes.Location = new Point(3, 3);
            tblThemes.Name = "tblThemes";
            tblThemes.RowCount = 9;
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.RowStyles.Add(new RowStyle());
            tblThemes.Size = new Size(1017, 250);
            tblThemes.TabIndex = 5;
            // 
            // btn7Hard
            // 
            btn7Hard.Dock = DockStyle.Fill;
            btn7Hard.Font = new Font("Segoe UI", 14F);
            btn7Hard.Location = new Point(836, 299);
            btn7Hard.Name = "btn7Hard";
            btn7Hard.Size = new Size(176, 36);
            btn7Hard.TabIndex = 50;
            btn7Hard.Text = "**";
            btn7Hard.UseVisualStyleBackColor = true;
            // 
            // btn7Med
            // 
            btn7Med.Dock = DockStyle.Fill;
            btn7Med.Font = new Font("Segoe UI", 14F);
            btn7Med.Location = new Point(653, 299);
            btn7Med.Name = "btn7Med";
            btn7Med.Size = new Size(175, 36);
            btn7Med.TabIndex = 49;
            btn7Med.Text = "**";
            btn7Med.UseVisualStyleBackColor = true;
            // 
            // btn7Easy
            // 
            btn7Easy.Dock = DockStyle.Fill;
            btn7Easy.Font = new Font("Segoe UI", 14F);
            btn7Easy.Location = new Point(470, 299);
            btn7Easy.Name = "btn7Easy";
            btn7Easy.Size = new Size(175, 36);
            btn7Easy.TabIndex = 48;
            btn7Easy.Text = "**";
            btn7Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme7
            // 
            lblTheme7.AutoSize = true;
            lblTheme7.Dock = DockStyle.Fill;
            lblTheme7.Font = new Font("Segoe UI", 16F);
            lblTheme7.Location = new Point(7, 301);
            lblTheme7.Margin = new Padding(5);
            lblTheme7.Name = "lblTheme7";
            lblTheme7.Padding = new Padding(1);
            lblTheme7.Size = new Size(453, 32);
            lblTheme7.TabIndex = 47;
            lblTheme7.Text = "Theme_7";
            lblTheme7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn6Hard
            // 
            btn6Hard.Dock = DockStyle.Fill;
            btn6Hard.Font = new Font("Segoe UI", 14F);
            btn6Hard.Location = new Point(836, 257);
            btn6Hard.Name = "btn6Hard";
            btn6Hard.Size = new Size(176, 34);
            btn6Hard.TabIndex = 46;
            btn6Hard.Text = "**";
            btn6Hard.UseVisualStyleBackColor = true;
            // 
            // btn6Med
            // 
            btn6Med.Dock = DockStyle.Fill;
            btn6Med.Font = new Font("Segoe UI", 14F);
            btn6Med.Location = new Point(653, 257);
            btn6Med.Name = "btn6Med";
            btn6Med.Size = new Size(175, 34);
            btn6Med.TabIndex = 45;
            btn6Med.Text = "**";
            btn6Med.UseVisualStyleBackColor = true;
            // 
            // btn6Easy
            // 
            btn6Easy.Dock = DockStyle.Fill;
            btn6Easy.Font = new Font("Segoe UI", 14F);
            btn6Easy.Location = new Point(470, 257);
            btn6Easy.Name = "btn6Easy";
            btn6Easy.Size = new Size(175, 34);
            btn6Easy.TabIndex = 44;
            btn6Easy.Text = "**";
            btn6Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme6
            // 
            lblTheme6.AutoSize = true;
            lblTheme6.Dock = DockStyle.Fill;
            lblTheme6.Font = new Font("Segoe UI", 16F);
            lblTheme6.Location = new Point(7, 259);
            lblTheme6.Margin = new Padding(5);
            lblTheme6.Name = "lblTheme6";
            lblTheme6.Size = new Size(453, 30);
            lblTheme6.TabIndex = 43;
            lblTheme6.Text = "Theme_6";
            lblTheme6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn5Hard
            // 
            btn5Hard.Dock = DockStyle.Fill;
            btn5Hard.Font = new Font("Segoe UI", 14F);
            btn5Hard.Location = new Point(836, 215);
            btn5Hard.Name = "btn5Hard";
            btn5Hard.Size = new Size(176, 34);
            btn5Hard.TabIndex = 42;
            btn5Hard.Text = "**";
            btn5Hard.UseVisualStyleBackColor = true;
            // 
            // btn5Med
            // 
            btn5Med.Dock = DockStyle.Fill;
            btn5Med.Font = new Font("Segoe UI", 14F);
            btn5Med.Location = new Point(653, 215);
            btn5Med.Name = "btn5Med";
            btn5Med.Size = new Size(175, 34);
            btn5Med.TabIndex = 41;
            btn5Med.Text = "**";
            btn5Med.UseVisualStyleBackColor = true;
            // 
            // btn5Easy
            // 
            btn5Easy.Dock = DockStyle.Fill;
            btn5Easy.Font = new Font("Segoe UI", 14F);
            btn5Easy.Location = new Point(470, 215);
            btn5Easy.Name = "btn5Easy";
            btn5Easy.Size = new Size(175, 34);
            btn5Easy.TabIndex = 40;
            btn5Easy.Text = "**";
            btn5Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme5
            // 
            lblTheme5.AutoSize = true;
            lblTheme5.Dock = DockStyle.Fill;
            lblTheme5.Font = new Font("Segoe UI", 16F);
            lblTheme5.Location = new Point(7, 217);
            lblTheme5.Margin = new Padding(5);
            lblTheme5.Name = "lblTheme5";
            lblTheme5.Size = new Size(453, 30);
            lblTheme5.TabIndex = 39;
            lblTheme5.Text = "Theme_5";
            lblTheme5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn4Hard
            // 
            btn4Hard.Dock = DockStyle.Fill;
            btn4Hard.Font = new Font("Segoe UI", 14F);
            btn4Hard.Location = new Point(836, 173);
            btn4Hard.Name = "btn4Hard";
            btn4Hard.Size = new Size(176, 34);
            btn4Hard.TabIndex = 38;
            btn4Hard.Text = "**";
            btn4Hard.UseVisualStyleBackColor = true;
            // 
            // btn4Med
            // 
            btn4Med.Dock = DockStyle.Fill;
            btn4Med.Font = new Font("Segoe UI", 14F);
            btn4Med.Location = new Point(653, 173);
            btn4Med.Name = "btn4Med";
            btn4Med.Size = new Size(175, 34);
            btn4Med.TabIndex = 37;
            btn4Med.Text = "**";
            btn4Med.UseVisualStyleBackColor = true;
            // 
            // btn4Easy
            // 
            btn4Easy.Dock = DockStyle.Fill;
            btn4Easy.Font = new Font("Segoe UI", 14F);
            btn4Easy.Location = new Point(470, 173);
            btn4Easy.Name = "btn4Easy";
            btn4Easy.Size = new Size(175, 34);
            btn4Easy.TabIndex = 36;
            btn4Easy.Text = "**";
            btn4Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme4
            // 
            lblTheme4.AutoSize = true;
            lblTheme4.Dock = DockStyle.Fill;
            lblTheme4.Font = new Font("Segoe UI", 16F);
            lblTheme4.Location = new Point(7, 175);
            lblTheme4.Margin = new Padding(5);
            lblTheme4.Name = "lblTheme4";
            lblTheme4.Size = new Size(453, 30);
            lblTheme4.TabIndex = 35;
            lblTheme4.Text = "Theme_4";
            lblTheme4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn3Hard
            // 
            btn3Hard.Dock = DockStyle.Fill;
            btn3Hard.Font = new Font("Segoe UI", 14F);
            btn3Hard.Location = new Point(836, 131);
            btn3Hard.Name = "btn3Hard";
            btn3Hard.Size = new Size(176, 34);
            btn3Hard.TabIndex = 34;
            btn3Hard.Text = "**";
            btn3Hard.UseVisualStyleBackColor = true;
            // 
            // btn3Med
            // 
            btn3Med.Dock = DockStyle.Fill;
            btn3Med.Font = new Font("Segoe UI", 14F);
            btn3Med.Location = new Point(653, 131);
            btn3Med.Name = "btn3Med";
            btn3Med.Size = new Size(175, 34);
            btn3Med.TabIndex = 33;
            btn3Med.Text = "**";
            btn3Med.UseVisualStyleBackColor = true;
            // 
            // btn3Easy
            // 
            btn3Easy.Dock = DockStyle.Fill;
            btn3Easy.Font = new Font("Segoe UI", 14F);
            btn3Easy.Location = new Point(470, 131);
            btn3Easy.Name = "btn3Easy";
            btn3Easy.Size = new Size(175, 34);
            btn3Easy.TabIndex = 32;
            btn3Easy.Text = "**";
            btn3Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme3
            // 
            lblTheme3.AutoSize = true;
            lblTheme3.Dock = DockStyle.Fill;
            lblTheme3.Font = new Font("Segoe UI", 16F);
            lblTheme3.Location = new Point(7, 133);
            lblTheme3.Margin = new Padding(5);
            lblTheme3.Name = "lblTheme3";
            lblTheme3.Size = new Size(453, 30);
            lblTheme3.TabIndex = 31;
            lblTheme3.Text = "Theme_3";
            lblTheme3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn2Hard
            // 
            btn2Hard.Dock = DockStyle.Fill;
            btn2Hard.Font = new Font("Segoe UI", 14F);
            btn2Hard.Location = new Point(836, 89);
            btn2Hard.Name = "btn2Hard";
            btn2Hard.Size = new Size(176, 34);
            btn2Hard.TabIndex = 30;
            btn2Hard.Text = "**";
            btn2Hard.UseVisualStyleBackColor = true;
            // 
            // btn2Med
            // 
            btn2Med.Dock = DockStyle.Fill;
            btn2Med.Font = new Font("Segoe UI", 14F);
            btn2Med.Location = new Point(653, 89);
            btn2Med.Name = "btn2Med";
            btn2Med.Size = new Size(175, 34);
            btn2Med.TabIndex = 29;
            btn2Med.Text = "**";
            btn2Med.UseVisualStyleBackColor = true;
            // 
            // btn2Easy
            // 
            btn2Easy.Dock = DockStyle.Fill;
            btn2Easy.Font = new Font("Segoe UI", 14F);
            btn2Easy.Location = new Point(470, 89);
            btn2Easy.Name = "btn2Easy";
            btn2Easy.Size = new Size(175, 34);
            btn2Easy.TabIndex = 28;
            btn2Easy.Text = "**";
            btn2Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme2
            // 
            lblTheme2.AutoSize = true;
            lblTheme2.Dock = DockStyle.Fill;
            lblTheme2.Font = new Font("Segoe UI", 16F);
            lblTheme2.Location = new Point(7, 91);
            lblTheme2.Margin = new Padding(5);
            lblTheme2.Name = "lblTheme2";
            lblTheme2.Size = new Size(453, 30);
            lblTheme2.TabIndex = 27;
            lblTheme2.Text = "Theme_2";
            lblTheme2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn1Hard
            // 
            btn1Hard.Dock = DockStyle.Fill;
            btn1Hard.Font = new Font("Segoe UI", 14F);
            btn1Hard.Location = new Point(836, 47);
            btn1Hard.Name = "btn1Hard";
            btn1Hard.Size = new Size(176, 34);
            btn1Hard.TabIndex = 26;
            btn1Hard.Text = "**";
            btn1Hard.UseVisualStyleBackColor = true;
            // 
            // btn1Med
            // 
            btn1Med.Dock = DockStyle.Fill;
            btn1Med.Font = new Font("Segoe UI", 14F);
            btn1Med.Location = new Point(653, 47);
            btn1Med.Name = "btn1Med";
            btn1Med.Size = new Size(175, 34);
            btn1Med.TabIndex = 19;
            btn1Med.Text = "**";
            btn1Med.UseVisualStyleBackColor = true;
            // 
            // btn1Easy
            // 
            btn1Easy.Dock = DockStyle.Fill;
            btn1Easy.Font = new Font("Segoe UI", 14F);
            btn1Easy.Location = new Point(470, 47);
            btn1Easy.Name = "btn1Easy";
            btn1Easy.Size = new Size(175, 34);
            btn1Easy.TabIndex = 13;
            btn1Easy.Text = "**";
            btn1Easy.UseVisualStyleBackColor = true;
            // 
            // lblTheme1
            // 
            lblTheme1.AutoSize = true;
            lblTheme1.Dock = DockStyle.Fill;
            lblTheme1.Font = new Font("Segoe UI", 16F);
            lblTheme1.Location = new Point(7, 49);
            lblTheme1.Margin = new Padding(5);
            lblTheme1.Name = "lblTheme1";
            lblTheme1.Size = new Size(453, 30);
            lblTheme1.TabIndex = 12;
            lblTheme1.Text = "Theme_1";
            lblTheme1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(838, 7);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 11;
            label4.Text = "Hard";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(655, 7);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 10;
            label3.Text = "Med";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(472, 7);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 9;
            label2.Text = "Easy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(7, 7);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 1;
            label1.Text = "Themes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveStat
            // 
            btnSaveStat.BackColor = SystemColors.GradientActiveCaption;
            btnSaveStat.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveStat.Dock = DockStyle.Fill;
            btnSaveStat.FlatAppearance.BorderColor = Color.Black;
            btnSaveStat.Font = new Font("Segoe UI", 20F);
            btnSaveStat.Location = new Point(50, 456);
            btnSaveStat.Margin = new Padding(50);
            btnSaveStat.Name = "btnSaveStat";
            btnSaveStat.Size = new Size(193, 75);
            btnSaveStat.TabIndex = 51;
            btnSaveStat.Text = "Save";
            btnSaveStat.UseVisualStyleBackColor = false;
            btnSaveStat.Visible = false;
            btnSaveStat.Click += btnSaveStat_Click;
            // 
            // picture
            // 
            picture.BackColor = Color.AliceBlue;
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Dock = DockStyle.Fill;
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(1032, 3);
            picture.Name = "picture";
            picture.Size = new Size(549, 855);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 2;
            picture.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.CornflowerBlue;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(lblQuestion, 0, 0);
            tableLayoutPanel4.Controls.Add(panel1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(308, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(706, 587);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // lblQuestion
            // 
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblQuestion.Location = new Point(10, 10);
            lblQuestion.Margin = new Padding(10);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(686, 214);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tblTxtAns);
            panel1.Controls.Add(tblVarAns);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 347);
            panel1.TabIndex = 1;
            // 
            // tblTxtAns
            // 
            tblTxtAns.ColumnCount = 1;
            tblTxtAns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTxtAns.Controls.Add(btnTxtAns, 0, 1);
            tblTxtAns.Controls.Add(txtBoxTextAns, 0, 0);
            tblTxtAns.Controls.Add(btnSkip, 0, 2);
            tblTxtAns.Dock = DockStyle.Fill;
            tblTxtAns.Location = new Point(0, 0);
            tblTxtAns.Name = "tblTxtAns";
            tblTxtAns.RowCount = 3;
            tblTxtAns.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblTxtAns.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblTxtAns.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblTxtAns.Size = new Size(700, 347);
            tblTxtAns.TabIndex = 2;
            tblTxtAns.Visible = false;
            // 
            // btnTxtAns
            // 
            btnTxtAns.Anchor = AnchorStyles.None;
            btnTxtAns.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnTxtAns.Location = new Point(150, 212);
            btnTxtAns.Margin = new Padding(0, 50, 0, 0);
            btnTxtAns.Name = "btnTxtAns";
            btnTxtAns.Size = new Size(400, 40);
            btnTxtAns.TabIndex = 1;
            btnTxtAns.Text = "SUBMIT";
            btnTxtAns.UseVisualStyleBackColor = true;
            btnTxtAns.Click += btnTxtAns_Click;
            // 
            // txtBoxTextAns
            // 
            txtBoxTextAns.Anchor = AnchorStyles.None;
            txtBoxTextAns.Font = new Font("Segoe UI", 16F);
            txtBoxTextAns.Location = new Point(150, 66);
            txtBoxTextAns.Margin = new Padding(0, 30, 0, 0);
            txtBoxTextAns.Name = "txtBoxTextAns";
            txtBoxTextAns.Size = new Size(400, 36);
            txtBoxTextAns.TabIndex = 0;
            // 
            // btnSkip
            // 
            btnSkip.Anchor = AnchorStyles.None;
            btnSkip.Font = new Font("Segoe UI", 10F);
            btnSkip.Location = new Point(312, 298);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(75, 27);
            btnSkip.TabIndex = 2;
            btnSkip.Text = "Skip";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // tblVarAns
            // 
            tblVarAns.ColumnCount = 1;
            tblVarAns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblVarAns.Controls.Add(btnAns4, 0, 3);
            tblVarAns.Controls.Add(btnAns2, 0, 1);
            tblVarAns.Controls.Add(btnAns3, 0, 2);
            tblVarAns.Controls.Add(btnAns1, 0, 0);
            tblVarAns.Dock = DockStyle.Fill;
            tblVarAns.Location = new Point(0, 0);
            tblVarAns.Name = "tblVarAns";
            tblVarAns.RowCount = 4;
            tblVarAns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblVarAns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblVarAns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblVarAns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblVarAns.Size = new Size(700, 347);
            tblVarAns.TabIndex = 4;
            tblVarAns.Visible = false;
            // 
            // btnAns4
            // 
            btnAns4.Dock = DockStyle.Fill;
            btnAns4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAns4.Location = new Point(3, 261);
            btnAns4.Name = "btnAns4";
            btnAns4.Padding = new Padding(10, 0, 0, 0);
            btnAns4.Size = new Size(694, 83);
            btnAns4.TabIndex = 3;
            btnAns4.Text = "4. Var";
            btnAns4.TextAlign = ContentAlignment.MiddleLeft;
            btnAns4.UseVisualStyleBackColor = true;
            // 
            // btnAns2
            // 
            btnAns2.Dock = DockStyle.Fill;
            btnAns2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAns2.Location = new Point(3, 89);
            btnAns2.Name = "btnAns2";
            btnAns2.Padding = new Padding(10, 0, 0, 0);
            btnAns2.Size = new Size(694, 80);
            btnAns2.TabIndex = 1;
            btnAns2.Text = "2. Var";
            btnAns2.TextAlign = ContentAlignment.MiddleLeft;
            btnAns2.UseVisualStyleBackColor = true;
            // 
            // btnAns3
            // 
            btnAns3.Dock = DockStyle.Fill;
            btnAns3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAns3.Location = new Point(3, 175);
            btnAns3.Name = "btnAns3";
            btnAns3.Padding = new Padding(10, 0, 0, 0);
            btnAns3.Size = new Size(694, 80);
            btnAns3.TabIndex = 2;
            btnAns3.Text = "3. Var";
            btnAns3.TextAlign = ContentAlignment.MiddleLeft;
            btnAns3.UseVisualStyleBackColor = true;
            // 
            // btnAns1
            // 
            btnAns1.Dock = DockStyle.Fill;
            btnAns1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnAns1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAns1.Location = new Point(3, 3);
            btnAns1.Name = "btnAns1";
            btnAns1.Padding = new Padding(10, 0, 0, 0);
            btnAns1.Size = new Size(694, 80);
            btnAns1.TabIndex = 0;
            btnAns1.Text = "1. Var";
            btnAns1.TextAlign = ContentAlignment.MiddleLeft;
            btnAns1.UseVisualStyleBackColor = true;
            // 
            // Layer_1
            // 
            Layer_1.ColumnCount = 2;
            Layer_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            Layer_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            Layer_1.Controls.Add(picture, 1, 0);
            Layer_1.Controls.Add(Layer_2, 0, 0);
            Layer_1.Dock = DockStyle.Fill;
            Layer_1.Location = new Point(0, 0);
            Layer_1.Name = "Layer_1";
            Layer_1.RowCount = 1;
            Layer_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Layer_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Layer_1.Size = new Size(1584, 861);
            Layer_1.TabIndex = 1;
            // 
            // Layer_2
            // 
            Layer_2.ColumnCount = 1;
            Layer_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Layer_2.Controls.Add(tblThemes, 0, 0);
            Layer_2.Controls.Add(Layer_3, 0, 1);
            Layer_2.Dock = DockStyle.Fill;
            Layer_2.Location = new Point(3, 3);
            Layer_2.Name = "Layer_2";
            Layer_2.RowCount = 2;
            Layer_2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            Layer_2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            Layer_2.Size = new Size(1023, 855);
            Layer_2.TabIndex = 0;
            // 
            // Layer_3
            // 
            Layer_3.ColumnCount = 2;
            Layer_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            Layer_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            Layer_3.Controls.Add(tableLayoutPanel4, 1, 0);
            Layer_3.Controls.Add(tableLayoutPanel3, 0, 0);
            Layer_3.Dock = DockStyle.Fill;
            Layer_3.Location = new Point(3, 259);
            Layer_3.Name = "Layer_3";
            Layer_3.RowCount = 1;
            Layer_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Layer_3.Size = new Size(1017, 593);
            Layer_3.TabIndex = 0;
            // 
            // PlayField
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1584, 861);
            Controls.Add(Layer_1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlayField";
            Text = "QzX";
            tableLayoutPanel3.ResumeLayout(false);
            Layer_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblMainTable).EndInit();
            tblThemes.ResumeLayout(false);
            tblThemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tblTxtAns.ResumeLayout(false);
            tblTxtAns.PerformLayout();
            tblVarAns.ResumeLayout(false);
            Layer_1.ResumeLayout(false);
            Layer_2.ResumeLayout(false);
            Layer_3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblQuestion;
        private Panel panel1;
        private TableLayoutPanel tblTxtAns;
        private Button btnTxtAns;
        private TextBox txtBoxTextAns;
        private Button btnSkip;
        private TableLayoutPanel tblVarAns;
        private Button btnAns4;
        private Button btnAns2;
        private Button btnAns3;
        private Button btnAns1;
        private PictureBox picture;
        private TableLayoutPanel tblThemes;
        private Button btn7Hard;
        private Button btn7Med;
        private Button btn7Easy;
        private Label lblTheme7;
        private Button btn6Hard;
        private Button btn6Med;
        private Button btn6Easy;
        private Label lblTheme6;
        private Button btn5Hard;
        private Button btn5Med;
        private Button btn5Easy;
        private Label lblTheme5;
        private Button btn4Hard;
        private Button btn4Med;
        private Button btn4Easy;
        private Label lblTheme4;
        private Button btn3Hard;
        private Button btn3Med;
        private Button btn3Easy;
        private Label lblTheme3;
        private Button btn2Hard;
        private Button btn2Med;
        private Button btn2Easy;
        private Label lblTheme2;
        private Button btn1Hard;
        private Button btn1Med;
        private Button btn1Easy;
        private Label lblTheme1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveStat;
        private TableLayoutPanel Layer_1;
        private TableLayoutPanel Layer_2;
        private TableLayoutPanel Layer_3;
        private TableLayoutPanel Layer_4;
        private DataGridView tblMainTable;
        private DataGridViewTextBoxColumn colPlayer;
        private DataGridViewTextBoxColumn colPoints;
        private DataGridViewTextBoxColumn colActive;
    }
}