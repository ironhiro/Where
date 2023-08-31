using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Maps;
using System.Collections.ObjectModel;

namespace WhereIsIt.MVVM.Model
{
    public class MapProperties : ObservableObject
    {
        private ObservableCollection<Pin> _markers;
        public ObservableCollection<Pin> MarkerList {
            get => _markers;
            set => SetProperty(ref _markers, value);
        }
    }
}
