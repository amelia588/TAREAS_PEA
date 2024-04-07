using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtén los valores ingresados
            var username = UsernameTextBox.Text;
            var password = PasswordBox.Password;

            // Aquí iría la lógica para verificar las credenciales
            if (username == "usuario" && password == "contraseña") // Ejemplo básico
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                // Aquí podrías redirigir al usuario a otra ventana de tu aplicación
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
