namespace GestionTareasPendientes
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text.Trim();

            if (tarea != "")
            {
                lstTareas.Items.Add(tarea);

                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una tarea.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
