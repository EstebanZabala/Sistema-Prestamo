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
    public partial class Form2 : Form
    {
        Capa_Entidad.Prestamos ob = new Capa_Entidad.Prestamos();

        public Form2()
        {
            InitializeComponent();
        }
        cliente objEntidad = new cliente();
        N_Clientes obtNego = new N_Clientes();
        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'sistemaPDataSet1.Listarprestamos' Puede moverla o quitarla según sea necesario.
            this.listarprestamosTableAdapter.Fill(this.sistemaPDataSet1.Listarprestamos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               // objEntidad.idprestamo = int.Parse(textBox1.Text);
                objEntidad.nombre = textBox2.Text;
                objEntidad.apellido = textBox3.Text;
                ob.monto = int.Parse(textBox4.Text);
                ob.cuota = int.Parse(textBox5.Text);
                ob.tiempo = int.Parse(textBox6.Text);
                ob.fecha = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                ob.interes = int.Parse(textBox7.Text);
                ob.monto_total = int.Parse(textBox8.Text);

                obtNego.GuardarPrestamos(objEntidad.nombre, objEntidad.apellido, ob.monto,ob.cuota,ob.tiempo,ob.fecha,ob.interes, ob.monto_total);
                datos();
                MessageBox.Show("datos guardados :)");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void datos()
            {
                DataTable dt = obtNego.D2_Listado();
                dataGridView1.DataSource = dt;
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         
        public void Calcular()
        {
            decimal monto = Convert.ToDecimal(textBox4.Text);
            decimal tasa = Convert.ToDecimal(textBox7.Text);
            tasa = tasa / 100;
            decimal total = monto + (monto * tasa);
            int tiempo = Convert.ToInt32(textBox6.Text);

            textBox5.Text = Convert.ToString(Math.Truncate(total / tiempo));
            textBox8.Text = Convert.ToString(Math.Truncate(total));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ob.idprestamo = int.Parse(textBox1.Text);
                ob.nombre = textBox2.Text;
                ob.apellido = textBox3.Text;
                ob.monto = int.Parse(textBox4.Text);
                ob.cuota = int.Parse(textBox5.Text);
                ob.tiempo = int.Parse(textBox6.Text);
                ob.fecha = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                ob.interes = int.Parse(textBox7.Text);
                ob.monto_total = int.Parse(textBox8.Text);


                obtNego.UpdatePrestamo(ob.idprestamo, ob.nombre, ob.apellido, ob.monto,ob.cuota,ob.tiempo,ob.fecha,ob.interes,ob.monto_total);
                datos();
                MessageBox.Show("datos actualizados :)");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void datos()
            {
                DataTable dt = obtNego.D2_Listado();
                dataGridView1.DataSource = dt;
            };
        }
        void datos()
        {
            DataTable dt = obtNego.BuscarPrestamo(ob.idprestamo);
            dataGridView1.DataSource = dt;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ob.idprestamo = int.Parse(textBox1.Text);
            obtNego.BuscarPrestamo(ob.idprestamo);
            datos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ob.idprestamo = int.Parse(textBox1.Text);

                obtNego.EliminarPrestamo(ob.idprestamo);
                datos();
                MessageBox.Show("datos borrados :(");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void datos()
            {
                DataTable dt = obtNego.D2_Listado();
                dataGridView1.DataSource = dt;
            };
        }
    }
}
