namespace BaiTap5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Đổi tên các control cho rõ nghĩa hơn
        private System.Windows.Forms.Label labelNumberA;
        private System.Windows.Forms.Label labelNumberB;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textNumberA;
        private System.Windows.Forms.TextBox textNumberB;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.RadioButton radioGCD;
        private System.Windows.Forms.RadioButton radioLCM;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelNumberA = new Label();
            labelNumberB = new Label();
            labelResult = new Label();
            textNumberA = new TextBox();
            textNumberB = new TextBox();
            textResult = new TextBox();
            groupOptions = new GroupBox();
            radioLCM = new RadioButton();
            radioGCD = new RadioButton();
            buttonCalculate = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            groupOptions.SuspendLayout();
            SuspendLayout();
            // 
            // labelNumberA
            // 
            labelNumberA.AutoSize = true;
            labelNumberA.Location = new Point(25, 30);
            labelNumberA.Name = "labelNumberA";
            labelNumberA.Size = new Size(43, 20);
            labelNumberA.TabIndex = 0;
            labelNumberA.Text = "Số A:";
            // 
            // labelNumberB
            // 
            labelNumberB.AutoSize = true;
            labelNumberB.Location = new Point(25, 70);
            labelNumberB.Name = "labelNumberB";
            labelNumberB.Size = new Size(42, 20);
            labelNumberB.TabIndex = 1;
            labelNumberB.Text = "Số B:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(25, 120);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "Kết quả:";
            // 
            // textNumberA
            // 
            textNumberA.Location = new Point(90, 27);
            textNumberA.Name = "textNumberA";
            textNumberA.Size = new Size(140, 27);
            textNumberA.TabIndex = 0;
         
            // 
            // textNumberB
            // 
            textNumberB.Location = new Point(90, 67);
            textNumberB.Name = "textNumberB";
            textNumberB.Size = new Size(140, 27);
            textNumberB.TabIndex = 1;
            // 
            // textResult
            // 
            textResult.Enabled = false;
            textResult.Location = new Point(90, 117);
            textResult.Name = "textResult";
            textResult.Size = new Size(140, 27);
            textResult.TabIndex = 4;
            // 
            // groupOptions
            // 
            groupOptions.Controls.Add(radioLCM);
            groupOptions.Controls.Add(radioGCD);
            groupOptions.Location = new Point(250, 20);
            groupOptions.Name = "groupOptions";
            groupOptions.Size = new Size(130, 90);
            groupOptions.TabIndex = 2;
            groupOptions.TabStop = false;
            groupOptions.Text = "Lựa chọn";
            // 
            // radioLCM
            // 
            radioLCM.AutoSize = true;
            radioLCM.Location = new Point(15, 55);
            radioLCM.Name = "radioLCM";
            radioLCM.Size = new Size(78, 24);
            radioLCM.TabIndex = 0;
            radioLCM.Text = "BSCNN";
            // 
            // radioGCD
            // 
            radioGCD.AutoSize = true;
            radioGCD.Checked = true;
            radioGCD.Location = new Point(15, 25);
            radioGCD.Name = "radioGCD";
            radioGCD.Size = new Size(75, 24);
            radioGCD.TabIndex = 1;
            radioGCD.TabStop = true;
            radioGCD.Text = "USCLN";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(29, 160);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 35);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Tìm";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(149, 160);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 35);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Bỏ qua";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(269, 160);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 35);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(404, 213);
            Controls.Add(labelNumberA);
            Controls.Add(labelNumberB);
            Controls.Add(textNumberA);
            Controls.Add(textNumberB);
            Controls.Add(groupOptions);
            Controls.Add(labelResult);
            Controls.Add(textResult);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonClear);
            Controls.Add(buttonExit);
            Name = "Form1";
            Text = "Tìm USCLN và BSCNN";
            groupOptions.ResumeLayout(false);
            groupOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
