namespace lab_3
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
            txtBase = new TextBox();
            txtExp = new TextBox();
            btnCalculate = new Button();
            txtResult = new TextBox();
            label4 = new Label();
            lblNaiveOps = new Label();
            lblNaiveTime = new Label();
            lblFastOps = new Label();
            lblFastTime = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 33);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 0;
            label1.Text = "Калькулятор степеней";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 94);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Введите основание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 96);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Введите показатель:";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(69, 117);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(115, 23);
            txtBase.TabIndex = 3;
            // 
            // txtExp
            // 
            txtExp.Location = new Point(522, 117);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(125, 23);
            txtExp.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(262, 96);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(164, 44);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "РАССЧИТАТЬ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(69, 180);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(610, 23);
            txtResult.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 162);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Результат:";
            // 
            // lblNaiveOps
            // 
            lblNaiveOps.AutoSize = true;
            lblNaiveOps.Location = new Point(70, 254);
            lblNaiveOps.Name = "lblNaiveOps";
            lblNaiveOps.Size = new Size(163, 15);
            lblNaiveOps.TabIndex = 8;
            lblNaiveOps.Text = "Операций наивного метода:";
            // 
            // lblNaiveTime
            // 
            lblNaiveTime.AutoSize = true;
            lblNaiveTime.Location = new Point(70, 311);
            lblNaiveTime.Name = "lblNaiveTime";
            lblNaiveTime.Size = new Size(156, 15);
            lblNaiveTime.TabIndex = 9;
            lblNaiveTime.Text = "Времени наивного метода:";
            // 
            // lblFastOps
            // 
            lblFastOps.AutoSize = true;
            lblFastOps.Location = new Point(410, 254);
            lblFastOps.Name = "lblFastOps";
            lblFastOps.Size = new Size(164, 15);
            lblFastOps.TabIndex = 10;
            lblFastOps.Text = "Операций быстрого метода:";
            // 
            // lblFastTime
            // 
            lblFastTime.AutoSize = true;
            lblFastTime.Location = new Point(417, 311);
            lblFastTime.Name = "lblFastTime";
            lblFastTime.Size = new Size(157, 15);
            lblFastTime.TabIndex = 11;
            lblFastTime.Text = "Времени быстрого метода:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 490);
            Controls.Add(lblFastTime);
            Controls.Add(lblFastOps);
            Controls.Add(lblNaiveTime);
            Controls.Add(lblNaiveOps);
            Controls.Add(label4);
            Controls.Add(txtResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtExp);
            Controls.Add(txtBase);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBase;
        private TextBox txtExp;
        private Button btnCalculate;
        private TextBox txtResult;
        private Label label4;
        private Label lblNaiveOps;
        private Label lblNaiveTime;
        private Label lblFastOps;
        private Label lblFastTime;
    }
}
