using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Домашня_робота
{
    public partial class AbonentCreateForm : Form
    {
        public AbonentCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string PIB = txtPIB.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Email = txtEmail.Text.Trim();


            if (string.IsNullOrWhiteSpace(txtPIB.Text))
            {
                lblPIBError.Text = "Введіть ПІБ";
                lblPIBError.Visible = true;
                txtPIB.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                lblPIBError.Visible = false;
                lblPIBError.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblPhoneError.Text = "Введіть телефон";
                lblPhoneError.Visible = true;
                txtPhone.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                lblPhoneError.Visible = false;
                lblPhoneError.Text = "";
            }

            if (!txtEmail.Text.Contains("@"))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.MistyRose;
                return;
            }
            else
            {
                lblEmailError.Visible = false;
                lblEmailError.Text = "";
            }

            //MessageBox.Show("Абонент доданий");

            string path = "contacts.txt";

            MessageBox.Show($"{PIB} {Email} - {Phone}");
            DialogResult = DialogResult.OK;
        }

        private void txtPIB_TextChanged(object sender, EventArgs e)
        {
            lblPIBError.Text = "";
            txtPIB.BackColor = Color.White;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            lblPhoneError.Text = "";
            txtPhone.BackColor = Color.White;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailError.Text = "";
            txtEmail.BackColor = Color.White;
        }

        private void AbonentCreateForm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
