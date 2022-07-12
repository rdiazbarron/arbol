using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol
{
    public partial class Form1 : Form
    {
        private ArbolBinario MiArbol;
        //private TNodoArbol raiz;
        public Form1()
        {
            InitializeComponent();
            MiArbol = new ArbolBinario();
        }

        


        private void button1_Click(object sender, EventArgs e)//insertar raiz
        {
            //TNodoArbol raiz;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Escriba el valor de la raiz");
                return;
            }
            else
            {
                //raiz = new TNodoArbol(textBox1.Text);
                MiArbol.AnadirRaiz(textBox1.Text);
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)//insert izq

        {
            TNodoArbol aux;

            // TNodoArbol temp1;
            //rbolBinario temp2;
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Escriba el valor del padre y del hijo");
                return;
            }
            if (MiArbol.buscar(textBox2.Text) == null)

            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }

            else
            {
                aux = MiArbol.buscar(textBox2.Text);
                MiArbol.InsertarIzq(new TNodoArbol(textBox3.Text), aux);
            }
        }

        private void button3_Click(object sender, EventArgs e)//insertar derecho
        {
            TNodoArbol aux;

            // TNodoArbol temp1;
            //rbolBinario temp2;
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Escriba el valor del padre y del hijo");
                return;
            }
            if (MiArbol.buscar(textBox2.Text) == null)

            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }

            else
            {
                aux = MiArbol.buscar(textBox2.Text);
                MiArbol.InsertarDer(new TNodoArbol(textBox3.Text), aux);
            }
        }

        private void button4_Click(object sender, EventArgs e)//eliminar izqierdo
        {
            TNodoArbol aux;

            // TNodoArbol temp1;
            //rbolBinario temp2;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Escriba el valor del padre");
                return;
            }
            if (MiArbol.buscar(textBox2.Text) == null)

            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }

            else
            {
                aux = MiArbol.buscar(textBox2.Text);
                MiArbol.EliminarIzquierdo(aux);
            }
        }

        private void button5_Click(object sender, EventArgs e)//eliminar derecho
        {
            TNodoArbol aux;

            // TNodoArbol temp1;
            //rbolBinario temp2;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Escriba el valor del padre");
                return;
            }
            if (MiArbol.buscar(textBox2.Text) == null)

            {
                MessageBox.Show("Inserte un nodo padre que exista");
                return;
            }

            else
            {
                aux = MiArbol.buscar(textBox2.Text);
                MiArbol.EliminarDerecho(aux);
            }

        }

        private void button6_Click(object sender, EventArgs e)//preorden
        {
            
            textBox4.Text = MiArbol.PreOrden1(MiArbol.raiz);
        }

        private void button7_Click(object sender, EventArgs e)//entreorden
        {
            textBox4.Text= MiArbol.EntreOrden(MiArbol.raiz);
        }

        private void Form1_Load(object sender, EventArgs e)//posorden
        {
            textBox4.Text= MiArbol.PosOrden(MiArbol.raiz);
        }

        private void button9_Click(object sender, EventArgs e)//limpiar
        {
            textBox4.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
