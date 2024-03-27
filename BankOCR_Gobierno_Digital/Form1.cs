namespace BankOCR_Gobierno_Digital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ruta_Click(object sender, EventArgs e)
        {
            string ruta_Archivo = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta_Archivo = openFileDialog.FileName;
            }

            tb_ruta.Text = ruta_Archivo;
        }

        private void btn_interprete_Click(object sender, EventArgs e)
        {
            string tb_ruta_archivo = tb_ruta.Text;
            
            if(tb_ruta_archivo != string.Empty)
            {
                Archivo archivo = new Archivo();
                archivo.ruta_archivo = tb_ruta_archivo;

                archivo.recorre_arr_archivo(lb_resultados);
            }
            else
            {
                string mensaje = "Seleccione un Archivo";
                string titulo = "Ruta Vacía";
                MessageBox.Show(mensaje, titulo);
            }
        }
    }
}
