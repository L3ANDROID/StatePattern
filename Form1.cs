using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        Estado _estado;

        private int i = 2;
        public Form1()
        {
            _estado = new Activa();
            Console.WriteLine(_estado.Describir());
            InitializeComponent();
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            Contexto ct = new Contexto();
            switch (i)
            {
                case 0:
                    txtIntentos.Text = "0";
                    ct.Presionar();
                    break;
                case 1:
                    txtIntentos.Text = "1";
                    break;
                case 2:
                    txtIntentos.Text = "2";
                    break;
            }

            i--;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
