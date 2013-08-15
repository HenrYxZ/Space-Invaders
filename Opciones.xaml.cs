using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tarea5
{
    /// <summary>
    /// Interaction logic for Opciones.xaml
    /// </summary>
    public partial class Opciones : Window
    {

        int recursos;

        public int Recursos
        {
            get { return recursos; }
            set { recursos = value; }
        }


        public Opciones()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            recursos = int.Parse(textRecursos.Text);
            mandarOpciones();

            
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            cierraTodo();
        }

        public event Action mandarOpciones;
        public event Action cierraTodo;

        private void Window_Closed(object sender, EventArgs e)
        {
            if(recursos == 0)
            cierraTodo();
        }


    }

    
}
