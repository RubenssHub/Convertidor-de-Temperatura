using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_de_Temperatura
{
    public partial class Form1 : Form
    {
        int bandera=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si escribio en centigrados
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(txtC.Text) * 1.8 + 32.0;
                    //Mostramos el resultado
                    txtF.Text = string.Format("{0:F2}", grados);
                }
                if (bandera == 2)
                {
                    grados = Convert.ToDouble(txtF.Text) - 32.0 * 1.8;
                    txtC.Text = string.Format("{0:F2}", grados);
                }

            }
            catch (FormatException)
            {
                txtC.Text = "0.0";
                txtF.Text = "32.00";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e); //Llama la función
            }
        }

        private void TxtF_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e); //Llama la función
            }
        }
    }
};