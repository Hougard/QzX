namespace QzX
{
    partial class Formyn
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
            tableLayoutPanel2 = new TableLayoutPanel();
            correct = new Button();
            wrong = new Button();
            lblanswer = new Label();
            lblvalue = new Label();
            lblexp = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(lblanswer, 0, 0);
            tableLayoutPanel1.Controls.Add(lblvalue, 0, 1);
            tableLayoutPanel1.Controls.Add(lblexp, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(658, 394);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(correct, 0, 0);
            tableLayoutPanel2.Controls.Add(wrong, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 316);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(652, 75);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // correct
            // 
            correct.BackColor = Color.LimeGreen;
            correct.Dock = DockStyle.Fill;
            correct.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correct.Location = new Point(40, 10);
            correct.Margin = new Padding(40, 10, 40, 10);
            correct.Name = "correct";
            correct.Size = new Size(246, 55);
            correct.TabIndex = 0;
            correct.Text = "CORRECT";
            correct.UseVisualStyleBackColor = false;
            correct.Click += correct_Click;
            // 
            // wrong
            // 
            wrong.BackColor = Color.LightCoral;
            wrong.Dock = DockStyle.Fill;
            wrong.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wrong.Location = new Point(366, 10);
            wrong.Margin = new Padding(40, 10, 40, 10);
            wrong.Name = "wrong";
            wrong.Size = new Size(246, 55);
            wrong.TabIndex = 1;
            wrong.Text = "WRONG";
            wrong.UseVisualStyleBackColor = false;
            wrong.Click += wrong_Click;
            // 
            // lblanswer
            // 
            lblanswer.AutoSize = true;
            lblanswer.Dock = DockStyle.Fill;
            lblanswer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblanswer.Location = new Point(3, 0);
            lblanswer.Name = "lblanswer";
            lblanswer.Size = new Size(652, 78);
            lblanswer.TabIndex = 1;
            lblanswer.Text = "label1";
            lblanswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblvalue
            // 
            lblvalue.AutoSize = true;
            lblvalue.Dock = DockStyle.Fill;
            lblvalue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblvalue.Location = new Point(3, 78);
            lblvalue.Name = "lblvalue";
            lblvalue.Size = new Size(652, 78);
            lblvalue.TabIndex = 2;
            lblvalue.Text = "label2";
            lblvalue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblexp
            // 
            lblexp.AutoSize = true;
            lblexp.Dock = DockStyle.Fill;
            lblexp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblexp.Location = new Point(3, 156);
            lblexp.Name = "lblexp";
            lblexp.Padding = new Padding(40, 40, 40, 20);
            lblexp.Size = new Size(652, 157);
            lblexp.TabIndex = 3;
            lblexp.Text = "exp";
            // 
            // Formyn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 394);
            Controls.Add(tableLayoutPanel1);
            Name = "Formyn";
            Text = "Result";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button correct;
        private Button wrong;
        private Label lblanswer;
        private Label lblvalue;
        private Label lblexp;
    }
}