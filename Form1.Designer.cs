namespace Calculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPercent = new Button();
            btnDelete = new Button();
            btnDoubleZero = new Button();
            btnDot = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            btnSub = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnMul = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnDiv = new Button();
            btn9 = new Button();
            btn8 = new Button();
            txtDisplay = new TextBox();
            btn7 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnPercent, 4, 4);
            tableLayoutPanel1.Controls.Add(btnDelete, 4, 3);
            tableLayoutPanel1.Controls.Add(btnDoubleZero, 4, 2);
            tableLayoutPanel1.Controls.Add(btnDot, 4, 1);
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 4);
            tableLayoutPanel1.Controls.Add(btn0, 0, 4);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btnEqual, 2, 4);
            tableLayoutPanel1.Controls.Add(btnClear, 1, 4);
            tableLayoutPanel1.Controls.Add(btnSub, 3, 3);
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btnMul, 3, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btnDiv, 3, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(353, 474);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPercent.Location = new Point(283, 379);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(67, 92);
            btnPercent.TabIndex = 24;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 128);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(283, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 88);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDel_Click;
            // 
            // btnDoubleZero
            // 
            btnDoubleZero.Dock = DockStyle.Fill;
            btnDoubleZero.FlatStyle = FlatStyle.Flat;
            btnDoubleZero.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoubleZero.Location = new Point(283, 191);
            btnDoubleZero.Name = "btnDoubleZero";
            btnDoubleZero.Size = new Size(67, 88);
            btnDoubleZero.TabIndex = 22;
            btnDoubleZero.Text = "00";
            btnDoubleZero.UseVisualStyleBackColor = true;
            btnDoubleZero.Click += Number_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(283, 97);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 88);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(213, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 92);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operator_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(3, 379);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 92);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(3, 285);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 88);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(3, 191);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 88);
            btn4.TabIndex = 17;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ButtonHighlight;
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(143, 379);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(64, 92);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(73, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 92);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSub
            // 
            btnSub.Dock = DockStyle.Fill;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(213, 285);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(64, 88);
            btnSub.TabIndex = 13;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Operator_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(143, 285);
            btn3.Name = "btn3";
            btn3.RightToLeft = RightToLeft.No;
            btn3.Size = new Size(64, 88);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(73, 285);
            btn2.Name = "btn2";
            btn2.RightToLeft = RightToLeft.No;
            btn2.Size = new Size(64, 88);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.MouseCaptureChanged += Number_Click;
            // 
            // btnMul
            // 
            btnMul.Dock = DockStyle.Fill;
            btnMul.FlatStyle = FlatStyle.Flat;
            btnMul.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(213, 191);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(64, 88);
            btnMul.TabIndex = 9;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += Operator_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(143, 191);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 88);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(73, 191);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 88);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btnDiv
            // 
            btnDiv.Dock = DockStyle.Fill;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(213, 97);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(64, 88);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Operator_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(143, 97);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 88);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(73, 97);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 88);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // txtDisplay
            // 
            tableLayoutPanel1.SetColumnSpan(txtDisplay, 5);
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Microsoft Sans Serif", 22F);
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(347, 88);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(3, 97);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 88);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(353, 474);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDiv;
        private Button btn5;
        private Button btn6;
        private Button btnMul;
        private Button btn2;
        private Button btn3;
        private Button btnSub;
        private Button btnClear;
        private Button btnEqual;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btnAdd;
        private Button btnDot;
        private Button btnDoubleZero;
        private Button btnDelete;
        private Button btnPercent;
    }
}
