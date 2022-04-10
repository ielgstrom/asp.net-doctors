using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Clases;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        List<Medico> listaMedicos = new List<Medico>();
        List<Paciente> PacientesAMostrar = new List<Paciente>();
        protected void Page_Load(object sender, EventArgs e)
        {
        

        }
        void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["ListaMedicos"] = listaMedicos;
            listaMedicos = Application["ListaMedicos"] as List<Medico>;
            Medico NewMedico = new Medico(Convert.ToInt32(TextBox2.Text), TextBox3.Text, TextBox1.Text);
            listaMedicos.Add(NewMedico);
        ;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            ListBox3.Items.Add(NewMedico.ToString());
            Application["ListaMedicos"] = listaMedicos;
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            listaMedicos = (List<Medico>)Application["listaMedicos"];
            listaMedicos[ListBox3.SelectedIndex].asignarleElPaciente(new Paciente(Convert.ToInt32(TextBox5.Text), DateTime.Now, TextBox4.Text));
            ListBox2.Items.Clear();
            foreach (Paciente pacienteAsignado in listaMedicos[ListBox3.SelectedIndex].pacientesAsignados())
            {

                ListBox2.Items.Add(pacienteAsignado.ToString());
            }
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMedicos = (List<Medico>)Application["listaMedicos"];
            ListBox2.Items.Clear();
            foreach (Paciente pacienteAsignado in listaMedicos[ListBox3.SelectedIndex].pacientesAsignados())
            {

                ListBox2.Items.Add(pacienteAsignado.ToString());
            }
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            Button4.Enabled = true;
        }
        
        private void isDoctorSelected(bool selected) 
        {
           
            TextBox4.Enabled = selected;
            TextBox5.Enabled = selected;
            Button4.Enabled = selected;
        }
    }
}

