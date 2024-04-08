namespace LAB4
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            btnGet = new Button();
            txtOut = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(260, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(13, 47);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(260, 44);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(12, 97);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(62, 120);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(80, 97);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(193, 120);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(287, 231);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Animals";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private Button btnGet;
        private RichTextBox txtOut;
    }
}
