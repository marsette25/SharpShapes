using System;
using System.Collections.Generic; // stuff like lists
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
//using System.Windows.Shapes;
using Shapes;
using System.Reflection;



namespace SharpShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBox1Items();
        }

        private void SetComboBox1Items()
        {

            List<string> stuff = new List<string>();

            //stuff.Add("Square");
            //stuff.Add("Rectangle");
           
            var quadType = typeof(Quadrilateral);
            //combo1.ItemsSource = stuff; //combo1 came from <combobox>x:Name ="Combo1...."
            //combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes(); //Gets me the types in the drop down
            combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.IsSubclassOf(typeof(Quadrilateral)));


        }

        public int NumberOfArguments(string className)
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == className).First(); // This is a Collection. Get the First
            var theClassConstructor = theClass.GetConstructors().First();
            return theClassConstructor.GetParameters().Length;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var classType = combo1.SelectedValue as Type;
            shapeWidth.IsEnabled = true;
            int argCount = NumberOfArguments(classType.Name);
            shapeHeight.IsEnabled = (argCount > 1);
        }
    }
}
