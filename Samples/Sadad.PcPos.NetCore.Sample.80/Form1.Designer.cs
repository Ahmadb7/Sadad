namespace Sadad.PcPos.NetCore.Sample._80
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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            BtnSend = new Button();
            textBox2 = new TextBox();
            BtnGovSale = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "172.24.32.97";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(279, 33);
            numericUpDown1.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // BtnSend
            // 
            BtnSend.Location = new Point(485, 33);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(75, 23);
            BtnSend.TabIndex = 2;
            BtnSend.Text = "Simple Sale";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 62);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(776, 376);
            textBox2.TabIndex = 3;
            // 
            // BtnGovSale
            // 
            BtnGovSale.Location = new Point(566, 33);
            BtnGovSale.Name = "BtnGovSale";
            BtnGovSale.Size = new Size(75, 23);
            BtnGovSale.TabIndex = 4;
            BtnGovSale.Text = "Gov Sale";
            BtnGovSale.UseVisualStyleBackColor = true;
            BtnGovSale.Click += BtnGovSale_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGovSale);
            Controls.Add(textBox2);
            Controls.Add(BtnSend);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button BtnSend;
        private TextBox textBox2;
        private Button BtnGovSale;
    }
}
