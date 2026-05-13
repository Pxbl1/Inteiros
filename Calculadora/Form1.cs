using System;
using System.Windows.Forms;

namespace NumerosInteiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Laço For — começa em 0, vai até 100 (inclusive)
        private void btnFor_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i;
            for (i = 0; i <= 100; i++)
            {
                lstNumeros.Items.Add(i);
            }
        }

        // Laço While — começa em 1, vai até 100
        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i = 1;
            while (i <= 100)
            {
                lstNumeros.Items.Add(i);
                i++;
            }
        }

        // Laço Do-While — começa em 1, executa ao menos uma vez
        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            int i = 1;
            do
            {
                lstNumeros.Items.Add(i);
                i++;
            }
            while (i <= 100);
        }

        // Limpar o ListBox
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
        }
    }
}
