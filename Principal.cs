using Encrypt.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encrypt
{
    public partial class Principal : Form
    {
        public int xClick = 0, yClick = 0;
        string tarjeta = "";
        string tarjetaSHA256 = "";

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            //Desencripta la cadena
            string dato = AesExtensions.DecryptString(txtCadenaEncriptada.Text, txtKey.Text, txtIV.Text);

            txtTarjetaDesencriptada.Text = dato;
        }

        private void btnLimpiarContenido_Click(object sender, EventArgs e)
        {
            txtContenido.Text = "";
            txtContenido.Focus();
            txtResultado.Clear();

            txtCadenaEncriptada.Text = "";
            txtTarjetaDesencriptada.Text = "";
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            tarjeta = txtContenido.Text;

            if (tarjeta.Length != 16)
            {
                MessageBox.Show("¡La tarjeta de crédito debe ser de 16 dígitos!");
                txtContenido.Focus();

                return;
            }

            txtContenido.Text = Enmascarar(tarjeta);
            txtContenido.Select(txtContenido.Text.Length, 0);

            tarjetaSHA256 = GetSHA256(tarjeta);

            string dato = AesExtensions.EncryptString(tarjeta, txtKey.Text, txtIV.Text);

            txtResultado.Text = dato;
        }

        private string NumeroTecleado(string texto)
        {
            string tarjeta = "";

            char[] digitos = texto.ToCharArray();

            for (int i = 0; i < digitos.Length; i++)
            {
                if (i == digitos.Length - 1)
                {
                    tarjeta += digitos[i];
                }
            }

            return tarjeta;
        }

        private string Enmascarar(string texto)
        {
            string mask = "";

            char[] digitos = texto.ToCharArray();

            for (int i = 0; i < digitos.Length; i++)
            {
                if (i < 12)
                {
                    mask += "X";
                }
                else
                {
                    if (i < 16)
                    {
                        mask += digitos[i];
                    }
                }
            }

            return mask;
        }

        private void txtContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick);
                this.Top = this.Top + (e.Y - yClick);
            }
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
