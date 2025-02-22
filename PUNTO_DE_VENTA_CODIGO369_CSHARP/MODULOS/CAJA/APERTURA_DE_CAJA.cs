using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS.CAJA
{
    public partial class APERTURA_DE_CAJA : Form
    {
        public APERTURA_DE_CAJA()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int idcaja=Convert.ToInt32(txtidcaja.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_dinero_caja_inicial", con); /// aqui llamo a mi procedimiento acelerado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_caja",idcaja);
                cmd.Parameters.AddWithValue("@saldo", txtmonto.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                frm.ShowDialog();
                this.Hide();

            }
            catch (Exception ex)
            {
                    
            }
        }

        private void MOSTRAR_CAJA_POR_SERIAL()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", lblSerialPc.Text); ///aqui tengo mi serial acompañado del parametro
                da.Fill(dt);
                datalistado_caja.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n"+ ex.StackTrace);
            }
          
        }
        private void APERTURA_DE_CAJA_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
            foreach (ManagementObject getserial in MOS.Get())
            {
                lblSerialPc.Text = getserial.Properties["SerialNumber"].Value.ToString();///mostramos y obtenemos el serial
                MOSTRAR_CAJA_POR_SERIAL();
                try
                {
                    txtidcaja.Text = datalistado_caja.SelectedCells[0].Value.ToString();/// para obtener el idcaja desde el numero 1 de datalsitadocaja que nos ayudara para ingresar el monto de caja
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
            }


        }

        private static void OnlyNumber(KeyPressEventArgs e, bool isdecimal)
        {
            String aceptados;
            if (!isdecimal)
            {
                aceptados = "0123456789." + Convert.ToChar(8);
            }
            else
                aceptados = "0123456789," + Convert.ToChar(8);

            if (aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblSerialPc_Click(object sender, EventArgs e)
        {

        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //OnlyNumber(e, false);
            //{
            //    // Si se pulsa la tecla Intro, pasar al siguiente
            //    //if( e.KeyChar == Convert.ToChar('\r') ){
            //    if (e.KeyChar == '\r')
            //   {
            //   e.Handled = true;
            //    }
            //    else if (e.KeyChar == ',')
            //    {
            //        // si se pulsa en el punto se convertirá en coma
            //        e.Handled = true;
            //        SendKeys.Send(".");
            //    }
            //}
            //CONEXION.Numeros_separadores.Separador_de_Numeros(txtmonto, e);
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsSeparator('.'))
            //{
            //    e.Handled = false;

            //}
            //else if (e.KeyChar == ',')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}


            CONEXION.Numeros_separadores.Separador_de_Numeros(txtmonto, e);

        }

        private void Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_dinero_caja_inicial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_caja", txtidcaja.Text);
                cmd.Parameters.AddWithValue("@saldo", 0);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK frm = new VENTAS_MENU_PRINCIPAL.VENTAS_MENU_PRINCIPALOK();
                frm.ShowDialog();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
