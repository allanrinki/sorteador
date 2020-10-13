using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jbSortear_Click(object sender, EventArgs e)
        {

            
            List<int> numerosSorteados = new List<int>();
            
            Random randNum = new Random();

            
            int maximo = int.Parse(tbNumeroFinal.Text);
            int minimo = int.Parse(tbNumeroInicial.Text);

            int sorteio;
                                   
            if (numerosSorteados.Count <= maximo)
            {
                
                sorteio = randNum.Next(minimo,maximo);

                // verifica se não existe o numero sorteado na lista
                if (!numerosSorteados.Contains(sorteio))
                {
                    // adiciona o numero a lista
                    numerosSorteados.Add(sorteio);
                }
                lbSorteio.DataSource = numerosSorteados;
            }
        }

        private void tbNumeroInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumeroFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
