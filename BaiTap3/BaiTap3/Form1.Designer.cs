namespace BaiTap3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các control (TextBox và Button)
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button exitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainTextBox = new TextBox();
            showButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(50, 40);
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(320, 27);
            mainTextBox.TabIndex = 0;
           
            // 
            // showButton
            // 
            showButton.Location = new Point(50, 90);
            showButton.Name = "showButton";
            showButton.Size = new Size(120, 45);
            showButton.TabIndex = 1;
            showButton.Text = "Hiển thị";
            showButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(250, 90);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(120, 45);
            exitButton.TabIndex = 2;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 180);
            Controls.Add(mainTextBox);
            Controls.Add(showButton);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "Bài tập 3: Xử lý Sự kiện Form";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
