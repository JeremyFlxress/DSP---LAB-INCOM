using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ordenar : Form
        
    {
        public Ordenar()
        {
            InitializeComponent();
        }
        int[] matriz = new int[5];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ordenar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (i <= 5)
            {
                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstDesorden.Items.Add(matriz[i]);
                i += 1;
                txtNum.Clear();
                txtNum.Select();
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int j, k, count;
            double valor;
            int Tam = 5;

            for (j = 0; j < Tam; j++)
            {
                if (matriz[k] > matriz[k + 1])
                {
                    valor = matriz[k];
                    matriz[k] = matriz[k + 1];
                    matriz[k + 1] = Convert.ToInt16(valor);
                }
            }
            lstOrden.Items.Clear();
            for (count = 0; count < Tam; count++)
            {
                lstOrden.Items.Add(matriz[count]);
            }


                }
        }
    }

