namespace deneme789456
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(396, 250);
            button1.Name = "button1";
            button1.Size = new Size(272, 67);
            button1.TabIndex = 0;
            button1.Text = "BAŞLAT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 23);
            label1.Name = "label1";
            label1.Size = new Size(624, 45);
            label1.TabIndex = 1;
            label1.Text = "Hangi Yazılım Dilini Öğrenmelisin?\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 107);
            label2.Name = "label2";
            label2.Size = new Size(1057, 66);
            label2.TabIndex = 2;
            label2.Text = "Bu teste vereceğin cevaplara göre öğrenmen gereken yazılım dili tavsiyesini sana söyleyeceğiz.\r\nHazır olduğunda \"BAŞLAT\" a tıkla.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(876, 357);
            label3.Name = "label3";
            label3.Size = new Size(202, 78);
            label3.TabIndex = 3;
            label3.Text = "Mehmet Akif TÜRK\r\n220206005\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1129, 476);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}