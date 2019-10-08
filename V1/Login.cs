using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELEPRO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXT_USER.Text = "Nombre de Usuario";
            TXT_PASS.Text = "Contraseña";
        }

        private void TXT_USER_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TXT_USER.Text = "";
        }

        private void TXT_USER_MouseClick(object sender, MouseEventArgs e)
        {
            TXT_USER.Text = "";
        }

        private void TXT_USER_DragLeave(object sender, EventArgs e)
        {
            TXT_USER.Text = "Nombre de Usuario";
        }

        private void TXT_USER_MouseLeave(object sender, EventArgs e)
        {
            // TXT_USER.Text = "Nombre de Usuario";
        }

        private void TXT_USER_MouseMove(object sender, MouseEventArgs e)
        {
            // TXT_USER.Text = "Nombre de Usuario";
        }

        private void TXT_USER_Leave(object sender, EventArgs e)
        {
            if (TXT_USER.Text == "")
            {
                TXT_USER.Text = "Nombre de Usuario";
            }
            else
            {

            }

        }

        // INICIA CONTROL DE TEXT BOX 
        //------------------------------------------------------------------------------------------------------
        private void TXT_PASS_MouseClick(object sender, MouseEventArgs e)
        {
            TXT_PASS.Text = "";
        }

        private void TXT_PASS_DragLeave(object sender, EventArgs e)
        {
            TXT_PASS.Text = "Contraseña";
        }

        private void TXT_PASS_Leave(object sender, EventArgs e)
        {
            if (TXT_PASS.Text == "")
            {
                TXT_PASS.Text = "Contraseña";
            }
            else
            {

            }
        }

        private void TXT_PASS_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si tiene algun problema y/o pregunta comuniquese con el departamente de soporte quien brindara la ayuda necesaria", "Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_USER.Text == "admin")
            {
                if (TXT_PASS.Text == "admin")
                {
                    this.Hide();
                    Pantalla1 frm = new Pantalla1();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta ", "Error en inicio de sesion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_PASS.Text = "Contraseña";
                TXT_USER.Text = "Nombre de usuario";
            }
        }

        private void TXT_USER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
