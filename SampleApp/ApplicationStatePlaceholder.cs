using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SampleApp
{
   public class ApplicationStatePlaceholder : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private bool boolValue;
      public bool BoolValue
      {
         get => boolValue; set
         {
            boolValue = value;
            OnPropertyChanged();
         }
      }

      ObservableCollection<string> availableItems = new ObservableCollection<string> { "Item1", "Item2", "Item3", "Item4", "Item5" };
      public ObservableCollection<string> AvailableItems
      {
         get => availableItems;
         set
         {
            availableItems = value;
            OnPropertyChanged();
         }
      }
      private string selectedItem;
      public string SelectedItem
      {
         get => selectedItem;
         set
         {
            selectedItem = value;
            OnPropertyChanged();
         }
      }

      private int max = 5;
      public int Max
      {
         get => max;
         set
         {
            max = value;
            OnPropertyChanged();
         }
      }



      protected void OnPropertyChanged([CallerMemberName] string name = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
      }


   }
}
