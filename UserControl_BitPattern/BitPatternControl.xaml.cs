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

namespace UserControl_BitPattern
{
    /// <summary>
    /// Interaction logic for BitPatternControl.xaml
    /// </summary>
    public partial class BitPatternControl : UserControl
    {
        public enum BitSizes
        {
            _8=8,_16=16,_32=32
        }

        public BitPatternControl()
        {
            InitializeComponent();
            spCheckBoxes.AddHandler(CheckBox.ClickEvent, new RoutedEventHandler(UpdateValue),true);
        }

        private void UpdateValue(object sender, RoutedEventArgs e)
        {
            string binaryString = string.Empty;
            foreach (var item in spCheckBoxes.Children)
            {
                if (item is CheckBox box)
                {
                    if (box.IsChecked == true)
                    {
                        binaryString += 1;
                    }
                    else
                    {
                        binaryString += 0;
                    }

                }
            }
            Value = Convert.ToInt32(binaryString, 2);
        }

        private BitSizes bits = BitSizes._8;

        public BitSizes Bits
        {
            get { return bits; }
            set {
                bits = value;
                RefreshCheckBoxes();
            }
        }

        //Dependency Property, damit Bindung später mgl
        //propdp


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(BitPatternControl), new PropertyMetadata(0,ValueChangedHandler));

        private static void ValueChangedHandler(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is BitPatternControl control)
            {
                if (e.NewValue==e.OldValue)
                {
                    return;
                }
                control.UpdateBitValues();
            }
        }

        private void UpdateBitValues()
        {
            // prüfe ob Zahl reinpasst

            if (Value > Math.Pow(2, (int)Bits) ){
                this.Background = Brushes.Red;
                MessageBox.Show("Impossibru!");
                return;
            }
            else
            {
                this.Background = Brushes.Transparent;
            }
            string binary = Convert.ToString(Value, 2);
            if (spCheckBoxes.Children.Count>binary.Length)
            {
                int fehlendeStellen = spCheckBoxes.Children.Count - binary.Length;
                for (int i = 0; i < fehlendeStellen; i++)
                {
                    binary = '0' + binary;
                }
            }
            for (int i = 0; i < spCheckBoxes.Children.Count; i++)
            {
                if (spCheckBoxes.Children[i] is CheckBox box)
                {
                    box.IsChecked = binary[i] == '0' ? false : true;
                }
            }
        }

        private void RefreshCheckBoxes()
        {
            int anzahl = (int)Bits;
            spCheckBoxes.Children.Clear();
            for (int i = 0; i < anzahl; i++)
            {
                CheckBox box = new CheckBox();
                box.Tag = Math.Pow(2, i);
                spCheckBoxes.Children.Add(box);
            }
        }

    }
}
