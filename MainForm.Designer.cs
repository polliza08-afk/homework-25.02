namespace Домашня_робота
{
    partial class MainForm
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
            btnCreateAbonent = new Button();
            SuspendLayout();
            // 
            // btnCreateAbonent
            // 
            btnCreateAbonent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreateAbonent.Location = new Point(99, 75);
            btnCreateAbonent.Name = "btnCreateAbonent";
            btnCreateAbonent.Size = new Size(132, 72);
            btnCreateAbonent.TabIndex = 0;
            btnCreateAbonent.Text = "Створити абонент";
            btnCreateAbonent.UseVisualStyleBackColor = true;
            btnCreateAbonent.Click += btnCreateAbonent_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 254);
            Controls.Add(btnCreateAbonent);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateAbonent;
    }
}
