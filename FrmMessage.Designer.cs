namespace QzX
{
    partial class FrmMessage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCorrect = new Label();
            lblPts = new Label();
            lblResult = new Label();
            btnProcede = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblCorrect, 0, 2);
            tableLayoutPanel1.Controls.Add(lblPts, 0, 1);
            tableLayoutPanel1.Controls.Add(lblResult, 0, 0);
            tableLayoutPanel1.Controls.Add(btnProcede, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(377, 220);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCorrect
            // 
            lblCorrect.Anchor = AnchorStyles.None;
            lblCorrect.AutoSize = true;
            lblCorrect.Font = new Font("Segoe UI", 16F);
            lblCorrect.Location = new Point(146, 95);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(85, 30);
            lblCorrect.TabIndex = 2;
            lblCorrect.Text = "Correct";
            lblCorrect.UseMnemonic = false;
            // 
            // lblPts
            // 
            lblPts.Anchor = AnchorStyles.None;
            lblPts.AutoSize = true;
            lblPts.Font = new Font("Segoe UI", 16F);
            lblPts.Location = new Point(152, 51);
            lblPts.Name = "lblPts";
            lblPts.Size = new Size(72, 30);
            lblPts.TabIndex = 1;
            lblPts.Text = "points";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblResult.Location = new Point(140, 3);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(96, 37);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";
            // 
            // btnProcede
            // 
            btnProcede.Dock = DockStyle.Fill;
            btnProcede.Font = new Font("Segoe UI", 16F);
            btnProcede.Location = new Point(30, 162);
            btnProcede.Margin = new Padding(30, 30, 30, 10);
            btnProcede.Name = "btnProcede";
            btnProcede.Size = new Size(317, 48);
            btnProcede.TabIndex = 3;
            btnProcede.Text = "Procede";
            btnProcede.UseVisualStyleBackColor = true;
            btnProcede.Click += btnProcede_Click;
            // 
            // FrmMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 220);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmMessage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMessage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblResult;
        private Label lblCorrect;
        private Label lblPts;
        private Button btnProcede;

    }
}