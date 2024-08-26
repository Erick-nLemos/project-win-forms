using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl01_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnviarMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + txtName.Text + "\nEmail: " + txtEmail.Text + "\nTelefone: " + txtTel.Text
                + "\nData Nascimento: " + mskDateNasc.ToString() + "\nSexo: "
                + "\nNascionalidade: " + comboNascio.SelectedItem
                + "\nEndereço: " + txtEnder.Text
                + "\nNº: " + txtNum.Text
                + "\nBairro: " + txtBairro.Text
                + "\nCidade: " + txtCidade.Text
                + "\nUF: " + comboUF.SelectedItem);
        }

        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResp.Text = "Dados Recebidos:. ";
            txtName.Text = "";
            txtEmail.Text = "";
            mskDateNasc.Text = "";
            txtTel.Text = "";
            txtEnder.Text = "";
            txtNum.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtComp.Text = "";
            comboNascio.Text = "-1";
            comboUF.Text = "-1";
            txtName.Focus();
        }

        private void btnEnviarLabel_Click(object sender, EventArgs e)
        {
            lblResp.Text =
                "Nome: " + txtName.Text + "\nEmail: " + txtEmail.Text + "\nTelefone: " + txtTel.Text
                + "\nData Nascimento: " + mskDateNasc.ToString() + "\nSexo: "
                + "\nNascionalidade: " + comboNascio.SelectedItem
                + "\nEndereço: " + txtEnder.Text
                + "\nNº: " + txtNum.Text
                + "\nBairro: " + txtBairro.Text
                + "\nCidade: " + txtCidade.Text
                + "\nUF: " + comboUF.SelectedItem;
        }
    }
}
