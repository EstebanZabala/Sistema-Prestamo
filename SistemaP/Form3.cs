using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;



namespace SistemaP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        cliente objEntidad = new cliente();
        N_Clientes obtNego = new N_Clientes();
        void ListarClientes()
        {
            DataTable dt = obtNego.N_listado();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ListarClientes();
           
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaPDataSet.Listarcliente' Puede moverla o quitarla según sea necesario.
          //  this.listarclienteTableAdapter.Fill(this.sistemaPDataSet.Listarcliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {

try{         objEntidad.idc = int.Parse(textBox1.Text);
            objEntidad.nombre = textBox2.Text;
            objEntidad.apellido = textBox3.Text;
            objEntidad.idprestamo = int.Parse(textBox4.Text);
                

                
            obtNego.guardar(objEntidad.idc, objEntidad.nombre, objEntidad.apellido, objEntidad.idprestamo);
                
            MessageBox.Show("datos guardados :)");
                datos();

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            void datos() 
            {
                DataTable dt = obtNego.N_listado();
                dataGridView1.DataSource = dt;
            };
        }
        private void Registrar_load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
       {


            objEntidad.idc = int.Parse(textBox5.Text);
                obtNego.buscar(objEntidad.idc);
                datos();
                
             
  

            
        }
     


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       void datos()
        {
            DataTable dt = obtNego.buscar(objEntidad.idc);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidad.idc = int.Parse(textBox1.Text);

                obtNego.Eliminar(objEntidad.idc);
                datos();
                MessageBox.Show("datos borrados :(");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void datos()
            {
                DataTable dt = obtNego.N_listado();
                dataGridView1.DataSource = dt;
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                objEntidad.idc = int.Parse(textBox1.Text);
                objEntidad.nombre = textBox2.Text;
                objEntidad.apellido = textBox3.Text;
                objEntidad.idprestamo = int.Parse(textBox1.Text);
                
                obtNego.Update(objEntidad.idc, objEntidad.nombre, objEntidad.apellido, objEntidad.idprestamo);
                datos();
                MessageBox.Show("datos actualizados :)");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void datos()
            {
                DataTable dt = obtNego.N_listado();
                dataGridView1.DataSource = dt;
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

