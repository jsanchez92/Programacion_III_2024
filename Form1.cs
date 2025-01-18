using IntroClase_POO.Clases;
using IntroClase_POO.Controladores;
using System.ComponentModel;

namespace IntroClase_POO
{
    public partial class FrmMain : Form
    {

        bool editar = false;
        bool editar2 = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //// Llamado a la función que carga los datos en la tabla
            //ShowStudents();
            //ShowTeachers();
            //var estudiante = new Students("Ing.","Primero");
            //dynamic est = new Students();

            ////  Polimorfismo:

            //People studiant = new Students() { Nombres = "Alvino", Apellidos="Corea", Carnet="UAN-12342-12T" };


            //MessageBox.Show(studiant.ToString
            //

            CStudents estudiante = new CStudents();
            string add = estudiante.Add();
            try
            {
                if (Convert.ToInt32(add) == 1)
                {
                    MessageBox.Show("Estudiante Agregado con éxito.");
                }
                else
                {
                    MessageBox.Show(add);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error De Logica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Implementar logica para los metodos Edit,Show y Delete de la clase CStudents
            // escriba un metodo en la clase del formulario en donde se generen excepciones
            // al llamar los metodos de la clase CStudents. 
            // LLame los metodos desde el Load del Formulario 'FrmMain_Load'

        }
        private BindingList<Students> students = new BindingList<Students>();
        private BindingList<Teachers> teachers = new BindingList<Teachers>();
        void ShowStudents()
        {
            // creamos la Lista para simular como fuente de datos

            // List<Students> students = new List<Students>();

            // Tambien pueden Usar BindingList<Students> students = new BindingList<Students>();

            //Se añade un nuevo estudiante a la lista
            students.Add(new Students()
            {
                Nombres = "Alvino Roberto",
                Apellidos = "Corea Montiel",
                Sexo = "M",
                Nacimiento = Convert.ToDateTime("29/05/1998"),
                Carnet = "2019-3434"
            });
            // sel le pasa la lista de estudiantes al DataGridView com Fuente de datos en la Propiedad Datasource
            DtStudents.DataSource = students;

            //Refrescamos el control para Mostrar los datos
            DtStudents.Refresh();
        }
        void ShowTeachers()
        {
            //Se añade un nuevo Maestro a la lista
            teachers.Add(new Teachers()
            {
                Nombres = "Belkis ",
                Apellidos = "Gimenez",
                Sexo = "F",
                Nacimiento = Convert.ToDateTime("29/05/1985")
            });
            // sel le pasa la lista de estudiantes al DataGridView com Fuente de datos en la Propiedad Datasource
            DtTeachers.DataSource = teachers;

            //Refrescamos el control para Mostrar los datos
            DtTeachers.Refresh();
        }

        private void DtStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddRow_Click(object sender, EventArgs e)
        {

            students.Add(new Students() { Id = DtStudents.Rows.Count - 1, Nombres = "", Apellidos = "", Sexo = "" });
            DtStudents.Refresh();
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            students.Remove(students[DtStudents.CurrentRow.Index]);
            DtStudents.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar)
            {

                students[DtStudents.CurrentRow.Index].Nombres = TxtNombres.Text.Trim();
                students[DtStudents.CurrentRow.Index].Apellidos = TxtApellidos.Text.Trim();
                students[DtStudents.CurrentRow.Index].Sexo = TxtSexo.Text.Trim();
                students[DtStudents.CurrentRow.Index].Nacimiento = TxtNacimiento.Value;
                students[DtStudents.CurrentRow.Index].Carnet = TxtCarnet.Text.Trim();
                students[DtStudents.CurrentRow.Index].Dni = TxtDni.Text.Trim();

                editar = false;

            }
            else
            {
                int id = 0;
                id = students[students.Count - 1].Id + 1;

                Students newStudents = new Students()
                {
                    Id = id,
                    Nombres = TxtNombres.Text.Trim(),
                    Apellidos = TxtApellidos.Text.Trim(),
                    Sexo = TxtSexo.Text.Trim(),
                    Nacimiento = TxtNacimiento.Value,
                    Carnet = TxtCarnet.Text.Trim(),
                    Dni = TxtDni.Text.Trim(),
                };
                students.Add(newStudents);
            }

            DtStudents.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = DtStudents.CurrentRow.Index;
                students.Remove(students[indice]);
                DtStudents.Refresh();
            }
            catch (Exception E)
            {
                MessageBox.Show("Nom hay estudiantes para eliminar.", "Alert.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void DtStudents_DoubleClick(object sender, EventArgs e)
        {
            TxtId.Text = students[DtStudents.CurrentRow.Index].Id.ToString();
            TxtNombres.Text = students[DtStudents.CurrentRow.Index].Nombres;
            TxtApellidos.Text = students[DtStudents.CurrentRow.Index].Apellidos;
            TxtSexo.Text = students[DtStudents.CurrentRow.Index].Sexo;
            TxtNacimiento.Value = students[DtStudents.CurrentRow.Index].Nacimiento;
            TxtCarnet.Text = students[DtStudents.CurrentRow.Index].Carnet;
            TxtDni.Text = students[DtStudents.CurrentRow.Index].Dni;
            editar = true;

        }

        private void BtnAddMaestro_Click(object sender, EventArgs e)
        {
            if (editar)
            {

                teachers[DtTeachers.CurrentRow.Index].Nombres = TNombre.Text.Trim();
                teachers[DtTeachers.CurrentRow.Index].Apellidos = TApellido.Text.Trim();
                teachers[DtTeachers.CurrentRow.Index].Sexo = TSexo.Text.Trim();
                teachers[DtTeachers.CurrentRow.Index].Nacimiento = TNacimiento.Value;
                teachers[DtTeachers.CurrentRow.Index].Dni = TDni.Text.Trim();


                editar = false;

            }
            else
            {
                int id = 0;
                id = teachers[teachers.Count - 1].Id + 1;

                Teachers newTeacher = new Teachers()
                {
                    Id = id,
                    Nombres = TNombre.Text.Trim(),
                    Apellidos = TApellido.Text.Trim(),
                    Sexo = TSexo.Text.Trim(),
                    Nacimiento = TNacimiento.Value,
                    Dni = TDni.Text.Trim(),
                };
                teachers.Add(newTeacher);
            }

            DtTeachers.Refresh();
        }
    }
}
