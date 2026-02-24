namespace lab3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalculate = new Button();
            lblNaiveOps = new Label();
            lblNaiveTime = new Label();
            lblFastOps = new Label();
            lblFastTime = new Label();
            txtResult = new TextBox();
            txtBase = new TextBox();
            txtExp = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, -5);
            label1.Name = "label1";
            label1.Size = new Size(325, 37);
            label1.TabIndex = 0;
            label1.Text = "Возводитель в степени";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(485, 24);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Основание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(599, 24);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "Показатель:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.SlateGray;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(485, 93);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(211, 27);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Возвести в степень";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblNaiveOps
            // 
            lblNaiveOps.AutoSize = true;
            lblNaiveOps.BackColor = Color.Transparent;
            lblNaiveOps.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNaiveOps.ForeColor = Color.White;
            lblNaiveOps.Location = new Point(298, 263);
            lblNaiveOps.Name = "lblNaiveOps";
            lblNaiveOps.Size = new Size(206, 21);
            lblNaiveOps.TabIndex = 4;
            lblNaiveOps.Text = "Тут количество операций";
            lblNaiveOps.Click += lblNaiveOps_Click;
            // 
            // lblNaiveTime
            // 
            lblNaiveTime.AutoSize = true;
            lblNaiveTime.BackColor = Color.Transparent;
            lblNaiveTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNaiveTime.ForeColor = Color.White;
            lblNaiveTime.Location = new Point(298, 242);
            lblNaiveTime.Name = "lblNaiveTime";
            lblNaiveTime.Size = new Size(131, 21);
            lblNaiveTime.TabIndex = 5;
            lblNaiveTime.Text = "Тут будет время";
            lblNaiveTime.Click += lblNaiveTime_Click;
            // 
            // lblFastOps
            // 
            lblFastOps.AutoSize = true;
            lblFastOps.BackColor = Color.Transparent;
            lblFastOps.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFastOps.ForeColor = Color.White;
            lblFastOps.Location = new Point(510, 263);
            lblFastOps.Name = "lblFastOps";
            lblFastOps.Size = new Size(206, 21);
            lblFastOps.TabIndex = 6;
            lblFastOps.Text = "Тут количество операций";
            // 
            // lblFastTime
            // 
            lblFastTime.AutoSize = true;
            lblFastTime.BackColor = Color.Transparent;
            lblFastTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFastTime.ForeColor = Color.White;
            lblFastTime.Location = new Point(510, 242);
            lblFastTime.Name = "lblFastTime";
            lblFastTime.Size = new Size(131, 21);
            lblFastTime.TabIndex = 7;
            lblFastTime.Text = "Тут будет время\r\n";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtResult.ForeColor = Color.Black;
            txtResult.Location = new Point(264, 167);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(432, 29);
            txtResult.TabIndex = 8;
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtBase.ForeColor = Color.Black;
            txtBase.Location = new Point(485, 48);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(98, 23);
            txtBase.TabIndex = 9;
            // 
            // txtExp
            // 
            txtExp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtExp.ForeColor = Color.Black;
            txtExp.Location = new Point(599, 48);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(100, 23);
            txtExp.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(175, 170);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 11;
            label4.Text = "Результат:";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(290, 93);
            button1.Name = "button1";
            button1.Size = new Size(174, 27);
            button1.TabIndex = 12;
            button1.Text = "Помощь";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(298, 212);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 13;
            label5.Text = "Наивный метод:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(510, 212);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 15;
            label7.Text = "Быстрый метод:";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_black_background_with_numbers_image_934120;
            ClientSize = new Size(711, 293);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtExp);
            Controls.Add(txtBase);
            Controls.Add(txtResult);
            Controls.Add(lblFastTime);
            Controls.Add(lblFastOps);
            Controls.Add(lblNaiveTime);
            Controls.Add(lblNaiveOps);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ulitka Soft - Возводитель в степени";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalculate;
        private Label lblNaiveOps;
        private Label lblNaiveTime;
        private Label lblFastOps;
        private Label lblFastTime;
        private TextBox txtResult;
        private TextBox txtBase;
        private TextBox txtExp;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label7;
    }
}
