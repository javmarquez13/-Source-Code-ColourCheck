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
using System.IO;

namespace ColourCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// 
    /// RELEASE 1.0.0.0
    /// 
    /// 01 septiembre 2020
    /// Se agrega feat de color 7358 COLOR_NO_BAG_NCRWHITE 
    /// 1.0.0.1
    /// 
    /// 24 JUNIO 2021
    /// SE AGREGA COLOR OBSCURO PARA LAS UNIDADES AUSTRALIANAS
    /// 1.0.0.2
    /// 1.0.0.3
    /// 1.0.0.3
    /// 1.0.0.4
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    public partial class MainWindow : Window
    {
        string[] _InputArgs;

        public MainWindow(string[] InputArgs)
        {
            InitializeComponent();
            _InputArgs = InputArgs;
        }

        int result;
        string BuildTyp;
        string ColourExpected;
        string ColourAnswer;
        string PathBuildTyp = @"C:\Build.typ";
        List<string> Uris = new List<string>();

        //7360
        string NCR_DARK_WHITE_31 = "SCO_COL_NCR_DARK_WHITE_31";
        string DECA_JAVA = "SCO_COL_DECA_JAVA";
        string HANNAFORD_BURGUNDY_25 = "SCO_COL_HANNAFORD_BURGUNDY_25";
        string RAL7021_BLACK_07 = "SCO_COL_RAL7021_BLACK_07";

        //7358
        string NO_BAG_WM_MEDIUM_GRAY = "COLOR_NO_BAG_WM_MEDIUM_GRAY";
        string ONE_BAG_WM_LIGHT_BLUE = "COLOR_ONE_BAG_WM_LIGHT_BLUE";
        string NO_BAG_NCRWHITE = "COLOR_NO_BAG_NCRWHITE";
        //new for feature 7358-F713
        string SCO_COL_ANODIC_CHARCOAL_11 = "SCO_COL_ANODIC_CHARCOAL_11";


        //7350 
        string WM_LIGHT_BLUE_12 = "SCO_COL_WM_LIGHT_BLUE_12";
        string NCR_G11_01 = "SCO_COL_NCR_G11_01";
        string DARK_RED_18 = "SCO_COL_DARK_RED_18";

 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lblVersion.Content = "Version 1.0.0.4";

                ColourExpected = _InputArgs[0];

                string Mavis = @"C:\Mavis\SCO_Apps\SCO_ColourCheck\Images\";


                Uris.Add(Mavis + "!Gris.jpeg");
                Uris.Add(Mavis + "!Blanco.jpeg");
                Uris.Add(Mavis + "!Negro.jpeg");
                Uris.Add(Mavis + "!Cafe.jpeg");
                Uris.Add(Mavis + "!CafeObscuro.jpeg");
                Uris.Add(Mavis + "Loading.jpg");


                BuildTyp = File.ReadAllText(PathBuildTyp);

                int i = 0;
                string[] UrisRandom = new string[6];
                Random random = new Random();

                i = random.Next(0, Uris.Count);
                MediaElement_Colour1.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                i = random.Next(0, Uris.Count);
                MediaElement_Colour2.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                i = random.Next(0, Uris.Count);
                MediaElement_Colour3.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                i = random.Next(0, Uris.Count);
                MediaElement_Colour4.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                i = random.Next(0, Uris.Count);
                MediaElement_Colour5.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                i = random.Next(0, Uris.Count);
                MediaElement_Colour6.Source = new Uri(Uris[i]);
                Uris.RemoveAt(i);

                MediaElement_Colour1.Play();
                MediaElement_Colour2.Play();
                MediaElement_Colour3.Play();
                MediaElement_Colour4.Play();
                MediaElement_Colour5.Play();
                MediaElement_Colour6.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }


        private void MediaElement_Colour1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour1.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }

        private void MediaElement_Colour2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour2.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }

        private void MediaElement_Colour3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour3.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }

        private void MediaElement_Colour4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour4.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }

        private void MediaElement_Colour5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour5.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }

        private void MediaElement_Colour6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ColourAnswer = MediaElement_Colour6.Source.ToString();

            if (ColourAnswer.Contains(ColourExpected))
                Environment.Exit(0);
            else
                Environment.Exit(1);
        }
    }
}
