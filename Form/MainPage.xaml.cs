using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnEnviarClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string apellido = ApellidoEntry.Text;
            string direccion = DireccionEntry.Text;
            string correo = CorreoEntry.Text;
            string telefono = TelefonoEntry.Text;
            DateTime fechaNacimiento = FechaNacimientoPicker.Date;
            string genero = GeneroPicker.SelectedItem as string;
            string idioma = IdiomaPicker.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(genero) ||
                string.IsNullOrWhiteSpace(idioma))
            {
                string mensaje = "Todos los campos son obligatorios!";
                DisplayAlert("AVISO", mensaje, "OK");
            }
            else
            {
                string mensaje = $"Nombre: {nombre}\n" +
                    $"Apellido: {apellido}\n" +
                    $"Dirección: {direccion}\n" +
                    $"Correo Electrónico: {correo}\n" +
                    $"Teléfono: {telefono}\n" +
                    $"Fecha de Nacimiento: {fechaNacimiento:dd/MM/yyyy}\n" +
                    $"Género: {genero}\n" +
                    $"Idioma: {idioma}";
                DisplayAlert("DATOS", mensaje, "OK");
            }

        }
    }
}
