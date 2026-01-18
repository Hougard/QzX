using System.Windows.Forms;

namespace QzX
{
    partial class StartForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnStartNew = new Button();
            btnChooseExistingGame = new Button();
            pnlCreateGame = new Panel();
            btnCreate = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPlayer7 = new TextBox();
            txtPlayer6 = new TextBox();
            txtPlayer5 = new TextBox();
            txtPlayer4 = new TextBox();
            txtPlayer3 = new TextBox();
            txtPlayer2 = new TextBox();
            txtPlayer1 = new TextBox();
            txtGameName = new TextBox();
            dropGamesList = new ComboBox();
            startTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnStart = new Button();
            pnlCreateGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)startTable).BeginInit();
            SuspendLayout();
            // 
            // btnStartNew
            // 
            btnStartNew.Location = new Point(41, 30);
            btnStartNew.Name = "btnStartNew";
            btnStartNew.Size = new Size(182, 42);
            btnStartNew.TabIndex = 0;
            btnStartNew.Text = "Start New";
            btnStartNew.UseVisualStyleBackColor = true;
            btnStartNew.Click += btnStartNew_Click;
            // 
            // btnChooseExistingGame
            // 
            btnChooseExistingGame.Enabled = false;
            btnChooseExistingGame.Location = new Point(355, 30);
            btnChooseExistingGame.Name = "btnChooseExistingGame";
            btnChooseExistingGame.Size = new Size(132, 42);
            btnChooseExistingGame.TabIndex = 1;
            btnChooseExistingGame.Text = "Choose Existing Game";
            btnChooseExistingGame.UseVisualStyleBackColor = true;
            // 
            // pnlCreateGame
            // 
            pnlCreateGame.Controls.Add(btnCreate);
            pnlCreateGame.Controls.Add(label8);
            pnlCreateGame.Controls.Add(label7);
            pnlCreateGame.Controls.Add(label6);
            pnlCreateGame.Controls.Add(label5);
            pnlCreateGame.Controls.Add(label4);
            pnlCreateGame.Controls.Add(label3);
            pnlCreateGame.Controls.Add(label2);
            pnlCreateGame.Controls.Add(label1);
            pnlCreateGame.Controls.Add(txtPlayer7);
            pnlCreateGame.Controls.Add(txtPlayer6);
            pnlCreateGame.Controls.Add(txtPlayer5);
            pnlCreateGame.Controls.Add(txtPlayer4);
            pnlCreateGame.Controls.Add(txtPlayer3);
            pnlCreateGame.Controls.Add(txtPlayer2);
            pnlCreateGame.Controls.Add(txtPlayer1);
            pnlCreateGame.Controls.Add(txtGameName);
            pnlCreateGame.Enabled = false;
            pnlCreateGame.Location = new Point(12, 123);
            pnlCreateGame.Name = "pnlCreateGame";
            pnlCreateGame.Size = new Size(285, 471);
            pnlCreateGame.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(111, 392);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 28);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Create";
            btnCreate.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 341);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 15;
            label8.Text = "Player_7:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 295);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 14;
            label7.Text = "Player_6:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 248);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 13;
            label6.Text = "Player_5:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 203);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Player_4:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 158);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 11;
            label4.Text = "Player_3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 115);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 10;
            label3.Text = "Player_2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Player_1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Game Name:";
            // 
            // txtPlayer7
            // 
            txtPlayer7.Location = new Point(111, 338);
            txtPlayer7.Name = "txtPlayer7";
            txtPlayer7.Size = new Size(100, 23);
            txtPlayer7.TabIndex = 7;
            // 
            // txtPlayer6
            // 
            txtPlayer6.Location = new Point(111, 292);
            txtPlayer6.Name = "txtPlayer6";
            txtPlayer6.Size = new Size(100, 23);
            txtPlayer6.TabIndex = 6;
            // 
            // txtPlayer5
            // 
            txtPlayer5.Location = new Point(111, 245);
            txtPlayer5.Name = "txtPlayer5";
            txtPlayer5.Size = new Size(100, 23);
            txtPlayer5.TabIndex = 5;
            // 
            // txtPlayer4
            // 
            txtPlayer4.Location = new Point(111, 200);
            txtPlayer4.Name = "txtPlayer4";
            txtPlayer4.Size = new Size(100, 23);
            txtPlayer4.TabIndex = 4;
            // 
            // txtPlayer3
            // 
            txtPlayer3.Location = new Point(111, 155);
            txtPlayer3.Name = "txtPlayer3";
            txtPlayer3.Size = new Size(100, 23);
            txtPlayer3.TabIndex = 3;
            // 
            // txtPlayer2
            // 
            txtPlayer2.Location = new Point(111, 112);
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.Size = new Size(100, 23);
            txtPlayer2.TabIndex = 2;
            // 
            // txtPlayer1
            // 
            txtPlayer1.Location = new Point(111, 68);
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.Size = new Size(100, 23);
            txtPlayer1.TabIndex = 1;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(111, 24);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(100, 23);
            txtGameName.TabIndex = 0;
            // 
            // dropGamesList
            // 
            dropGamesList.Enabled = false;
            dropGamesList.FormattingEnabled = true;
            dropGamesList.Location = new Point(551, 41);
            dropGamesList.Name = "dropGamesList";
            dropGamesList.Size = new Size(185, 23);
            dropGamesList.TabIndex = 4;
            // 
            // startTable
            // 
            startTable.AllowUserToAddRows = false;
            startTable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            startTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            startTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            startTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            startTable.DefaultCellStyle = dataGridViewCellStyle2;
            startTable.Location = new Point(355, 125);
            startTable.Name = "startTable";
            startTable.ReadOnly = true;
            startTable.RowHeadersVisible = false;
            startTable.Size = new Size(381, 337);
            startTable.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Games";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Points";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnStart
            // 
            btnStart.Enabled = false;
            btnStart.Location = new Point(402, 508);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(273, 62);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 664);
            Controls.Add(btnStart);
            Controls.Add(startTable);
            Controls.Add(dropGamesList);
            Controls.Add(pnlCreateGame);
            Controls.Add(btnChooseExistingGame);
            Controls.Add(btnStartNew);
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            pnlCreateGame.ResumeLayout(false);
            pnlCreateGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)startTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartNew;
        private Button btnChooseExistingGame;
        private Panel pnlCreateGame;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPlayer7;
        private TextBox txtPlayer6;
        private TextBox txtPlayer5;
        private TextBox txtPlayer4;
        private TextBox txtPlayer3;
        private TextBox txtPlayer2;
        private TextBox txtPlayer1;
        private TextBox txtGameName;
        private Button btnCreate;
        private ComboBox dropGamesList;
        private DataGridView startTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnStart;
    }
}
