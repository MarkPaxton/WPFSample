using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApp
{
   /// <summary>
   /// Interaction logic for DemoControl.xaml
   /// </summary>
   public partial class DemoControl : UserControl
   {
      public DemoControl()
      {
         InitializeComponent();
         button1.Click += button1_Click;
      }

      private void button1_Click(object sender, RoutedEventArgs e)
      {
         ControlValue.AvailableItems.Remove(ControlValue.SelectedItem);
         ControlValue.SelectedItem = null;
      }

      public static readonly DependencyProperty ControlValueProperty =
       DependencyProperty.Register("ControlValue", typeof(ApplicationStatePlaceholder), typeof(DemoControl),
          new FrameworkPropertyMetadata(new ApplicationStatePlaceholder()));

      public ApplicationStatePlaceholder ControlValue
      {
         get { return (ApplicationStatePlaceholder)GetValue(ControlValueProperty); }
         set { SetValue(ControlValueProperty, value); }
      }
   }
}
