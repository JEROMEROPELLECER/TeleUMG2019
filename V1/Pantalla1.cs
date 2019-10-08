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
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {

        }

        private void BTEST_Click(object sender, EventArgs e)
        {
            GB1.Visible = false;
            GB2.Visible = true;
        }

        private void BRR_Click(object sender, EventArgs e)
        {
            GB1.Visible = true;
            GB2.Visible = false;
            
        }

        private void BCP_Click(object sender, EventArgs e)
        {
            GB1.Visible = false;
            GB2.Visible = true;
        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void BRR_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void BRR_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BRR_MouseHover(object sender, EventArgs e)
        {
            ltl.Visible = true;
        }

        private void BRR_MouseLeave(object sender, EventArgs e)
        {
            ltl.Visible = false;
        }

        private void BCP_MouseHover(object sender, EventArgs e)
        {
            L1R.Visible = true;
        }

        private void BCP_MouseLeave(object sender, EventArgs e)
        {
            L1R.Visible = false;
        }

        private void textBox8_DragLeave(object sender, EventArgs e)
        {
            T1.Text = "Numero, Direccion";
        }

        private void T1_Click(object sender, EventArgs e)
        {

        }

        private void T1_MouseClick(object sender, MouseEventArgs e)
        {
            T1.Text = "";
        }

        private void T1_Leave(object sender, EventArgs e)
        {
            if (T1.Text == "")
            {
                T1.Text = "Numero, Direccion";
            }
            else
            {

            }
        }

        private void textBox9_DragLeave(object sender, EventArgs e)
        {
            t2.Text = "Juan Perez Aldana Reyes";
        }

        private void t2_MouseClick(object sender, MouseEventArgs e)
        {
            t2.Text = "";
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            if (t2.Text == "")
            {
                t2.Text = "Juan Perez Aldana Reyes";
            }
            else
            {

            }
        }

        private void textBox10_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox12_DragLeave(object sender, EventArgs e)
        {
            t4.Text = "0000 0000 0000";
        }

        private void t4_MouseClick(object sender, MouseEventArgs e)
        {
            t4.Text = "";
        }

        private void t4_Leave(object sender, EventArgs e)
        {
            if (t4.Text == "")
            {
                t4.Text = "0000 0000 0000";
            }
            else
            {

            }

          
        }

        private void t5_DragLeave(object sender, EventArgs e)
        {
            t5.Text = "0000.00";
        }

        private void t5_MouseClick(object sender, MouseEventArgs e)
        {
            t5.Text = " ";
        }

        private void t5_Leave(object sender, EventArgs e)
        {
            if (t5.Text == "")
            {
                t5.Text = "0000.00";
            }
            else
            {

            }
        }

        private void TT1_DragLeave(object sender, EventArgs e)
        {
            TT1.Text = "Numero, Direccion";
        }

        private void TT1_MouseClick(object sender, MouseEventArgs e)
        {
            TT1.Text = "";
        }

        private void TT1_Leave(object sender, EventArgs e)
        {
            if (TT1.Text == "")
            {
                TT1.Text = "Numero, Direccion";
            }
            else
            {

            }
        }

        private void textBox2_DragLeave(object sender, EventArgs e)
        {
            TT2.Text = "Juan Perez Aldana Reyes";
        }

        private void textBox3_DragLeave(object sender, EventArgs e)
        {
            TT3.Text = "2352 0928";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            TT3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            TT3.Text = "";
            if (TT3.Text == "")
            {
                TT3.Text = "2352 0928";
            }
            else
            {

            }
        }

        private void TT2_MouseClick(object sender, MouseEventArgs e)
        {
            TT2.Text = "";
        }

        private void TT2_Leave(object sender, EventArgs e)
        {
            if (TT2.Text == "")
            {
                TT2.Text = "Juan Perez Aldana Reyes";
            }
            else
            {

            }
        }

        private void TT4_DragLeave(object sender, EventArgs e)
        {
            TT4.Text = "0000 0000";
        }

        private void TT4_MouseClick(object sender, MouseEventArgs e)
        {
            TT4.Text = "";
        }

        private void GB2_Leave(object sender, EventArgs e)
        {
            if (TT4.Text == "")
            {
                TT4.Text = "0000 0000";
            }
            else
            {

            }
        }

        private void textBox5_DragLeave(object sender, EventArgs e)
        {
            TT5.Text = "0000 00000 0000";
        }

        private void TT5_MouseClick(object sender, MouseEventArgs e)
        {
            TT5.Text = "";
        }

        private void TT5_Leave(object sender, EventArgs e)
        {
            if (TT5.Text == "")
            {
                TT5.Text = "0000 00000 0000";
            }
            else
            {

            }
        }

        private void TT6_DragLeave(object sender, EventArgs e)
        {
            TT6.Text = "juan.perez@correo.correo";
        }

        private void TT7_MouseHover(object sender, EventArgs e)
        {

        }

        private void TT7_DragLeave(object sender, EventArgs e)
        {
            TT7.Text = "0000 0000";
        }

        private void TT7_MouseClick(object sender, MouseEventArgs e)
        {
            TT7.Text = "";
        }

        private void TT7_Leave(object sender, EventArgs e)
        {
            if (TT7.Text == "")
            {
                TT7.Text = "0000 0000";
            }
            else
            {

            }
        }

        private void TT6_MouseClick(object sender, MouseEventArgs e)
        {
            TT6.Text = "";
        }

        private void TT6_Leave(object sender, EventArgs e)
        {
            if (TT6.Text == "")
            {
                TT6.Text = "juan.perez@correo.correo";
            }
            else
            {

            }
        }
    }
}
