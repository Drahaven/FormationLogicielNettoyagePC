using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace FormationLogicielNettoyagePC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DirectoryInfo winTemp;
        public DirectoryInfo appTemp;

        public MainWindow()
        {
            InitializeComponent();
            winTemp = new DirectoryInfo(@"C:\Windows\Temp");
            appTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
        }

        //calcul taille dossier
        public long DirSize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(fi => fi.Length) + dir.GetDirectories().Sum(di => DirSize(di));
        }

        private void Button_Nettoyer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Maj_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Votre logiciel est à jour !", "Mise à jour", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Site_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/Drahaven/FormationLogicielNettoyagePC")
                {
                    UseShellExecute = true
                });
            } catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }

        private void Button_Historique_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO : Créer page d'historique", "Historique", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Analyser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
