namespace Домашня_робота
{
    partial class AbonentCreateForm
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
            label1 = new Label();
            label2 = new Label();
            txtPIB = new RichTextBox();
            label3 = new Label();
            txtPhone = new RichTextBox();
            label4 = new Label();
            txtEmail = new RichTextBox();
            btnSave = new Button();
            lblPIBError = new Label();
            lblPhoneError = new Label();
            lblEmailError = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(128, 28);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "Створити абонента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "ПІБ";
            // 
            // txtPIB
            // 
            txtPIB.Location = new Point(128, 84);
            txtPIB.Name = "txtPIB";
            txtPIB.Size = new Size(320, 25);
            txtPIB.TabIndex = 2;
            txtPIB.Text = "";
            txtPIB.TextChanged += txtPIB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 1;
            label3.Text = "Телефон";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(128, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(320, 25);
            txtPhone.TabIndex = 2;
            txtPhone.Text = "";
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 25);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(70, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 58);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPIBError
            // 
            lblPIBError.AutoSize = true;
            lblPIBError.Enabled = false;
            lblPIBError.Location = new Point(128, 112);
            lblPIBError.Name = "lblPIBError";
            lblPIBError.Size = new Size(71, 15);
            lblPIBError.TabIndex = 4;
            lblPIBError.Tag = "";
            lblPIBError.Text = "Вкажіть ПІБ";
            lblPIBError.Visible = false;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.Enabled = false;
            lblPhoneError.Location = new Point(128, 157);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(144, 15);
            lblPhoneError.TabIndex = 4;
            lblPhoneError.Text = "Вкажіть номер телефону";
            lblPhoneError.Visible = false;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Enabled = false;
            lblEmailError.Location = new Point(128, 203);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(81, 15);
            lblEmailError.TabIndex = 4;
            lblEmailError.Text = "Вкажіть Email";
            lblEmailError.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(272, 238);
            button1.Name = "button1";
            button1.Size = new Size(111, 58);
            button1.TabIndex = 3;
            button1.Text = "Скасувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCancel_Click;
            // 
            // AbonentCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 326);
            Controls.Add(lblEmailError);
            Controls.Add(lblPhoneError);
            Controls.Add(lblPIBError);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtPIB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AbonentCreateForm";
            Text = "AbonentCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox txtPIB;
        private Label label3;
        private RichTextBox txtPhone;
        private Label label4;
        private RichTextBox txtEmail;
        private Button btnSave;
        private Label lblPIBError;
        private Label lblPhoneError;
        private Label lblEmailError;
        private Button button1;
    }
}