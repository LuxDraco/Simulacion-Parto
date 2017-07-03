using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Charts;
using System.ComponentModel;

namespace Simulacion_Parto
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Demands = new ObservableCollection<GoldDemand>
            {
                new GoldDemand()
                {
                    Demand = "Sim 1", Year2010 = 1998.0, Year2011 = 2361.2
                },
                new GoldDemand()
                {
                    Demand = "Sim 2",Year2010 = 1284.0, Year2011 = 1328.0
                }
            };

            this.DataPartos = new ObservableCollection<DataValuesColumn>
            {
                new DataValuesColumn()
                {
                    Gadget = "Sim 1", Month = "2010", Value1 = 100, Value2 = 24
                },
                new DataValuesColumn()
                {
                    Gadget = "Sim 2", Month = "2011", Value1 = 100, Value2 = 10
                }
            };

            this.CantidadxGenero = new ObservableCollection<NacimientosGenero>
            {
                new NacimientosGenero()
                {
                    ItemsCount= 52, Sexo = "Niño"
                },
                new NacimientosGenero()
                {
                    ItemsCount= 48, Sexo = "Niña"
                },
                new NacimientosGenero()
                {
                    ItemsCount= 43, Sexo = "Niño"
                },
                new NacimientosGenero()
                {
                    ItemsCount= 57, Sexo = "Niña"
                }
            };

            this.Countries = new ObservableCollection<Country>();
            this.Countries = GetCountriesAndPopulation();

            this.Hospital = new ObservableCollection<Model>
            {
                new Model()
                {
                   Percentage = 62, Category = "Público"
                },
                new Model()
                {
                    Percentage = 31, Category = "Privado"
                },
                new Model()
                {
                    Percentage = 7, Category = "Casa"
                }
            };

            this.DataContext = this;
        }

        public ObservableCollection<GoldDemand> Demands { get; set; }

        public ObservableCollection<DataValuesColumn> DataPartos { get; set; }

        public ObservableCollection<NacimientosGenero> CantidadxGenero { get; set; }

        public ObservableCollection<Model> Hospital { get; set; }

        public ObservableCollection<Country> Countries { get; set; }

        private ObservableCollection<Country> GetCountriesAndPopulation()
        {
            ObservableCollection<Country> countries = new ObservableCollection<Country>();
            countries.Add(new Country() { ESTADO = "Tamaulipas", Population = 1 });
            countries.Add(new Country() { ESTADO = "Yucatán", Population = 3 });
            countries.Add(new Country() { ESTADO = "Jalisco", Population = 5 });
            countries.Add(new Country() { ESTADO = "Puebla", Population = 7 });
            countries.Add(new Country() { ESTADO = "Chihuahua", Population = 9 });
            countries.Add(new Country() { ESTADO = "Sonora", Population = 4 });
            countries.Add(new Country() { ESTADO = "Oaxaca", Population = 11 });
            countries.Add(new Country() { ESTADO = "Baja California Sur", Population = 2 });
            return countries;
        }

        private void boton_cerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void boton_cerrar_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rect_title.Fill = SystemParameters.WindowGlassBrush;
        }
    }

    internal static class ChartDictionary
    {
        internal static ResourceDictionary GenericDictionary = new ResourceDictionary()
        {
            Source = new Uri(@"../../Resources/CustomTemplate.xaml", UriKind.Relative)
        };
    }

    public class DataValuesColumn
    {
        public String Gadget { get; set; }

        public String Month { get; set; }

        public double Value1 { get; set; }

        public double Value2 { get; set; }
    }
    

    public class GoldDemand
    {
        public string Demand { get; set; }
        public double Year2010 { get; set; }
        public double Year2011 { get; set; }
    }

    public class Model
    {
        public string Category { get; set; }

        public double Percentage { get; set; }
    }

    public class NacimientosGenero
    {
        public double ItemsCount { get; set; }

        public string Sexo { get; set; }
    }

    public class Country : INotifyPropertyChanged
    {
        public string ESTADO { get; set; }

        private Visibility itemsvisibility = Visibility.Visible;
        public Visibility ItemsVisibility
        {
            get { return itemsvisibility; }
            set { itemsvisibility = value; }
        }

        private double weather { get; set; }
        public double Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
            }
        }

        private double population { get; set; }
        public double Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Population"));
            }

        }
        public string PopulationFormat { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            this.PopulationFormat = (String.Format("{0:0,0}", this.Population).Trim('$'));
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }


}