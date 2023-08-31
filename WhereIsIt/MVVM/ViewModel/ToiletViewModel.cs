using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WhereIsIt.MVVM.Model;

namespace WhereIsIt.MVVM.ViewModel
{
	public class ToiletViewModel : ObservableObject
	{
		public ToiletViewModel()
		{
			ToiletList = new ObservableCollection<Toilet>();
			OnLoadedCommand = new RelayCommand<object>(OnLoaded);
		}

        private async void OnLoaded(object obj)
        {
            
        }

		private bool _isLoading;
		public bool IsLoading
		{
			get => _isLoading;
			set => SetProperty(ref _isLoading, value);
		}

		private MapProperties _mapProperties;
		public MapProperties MapProperties
		{
			get => _mapProperties;
			set => SetProperty(ref _mapProperties, value);
		}
        public RelayCommand<object> OnLoadedCommand { get; private set; }

		private ObservableCollection<Toilet> _toiletList;
		public ObservableCollection<Toilet> ToiletList
		{
			get => _toiletList;
			set => SetProperty(ref _toiletList, value);
		}
	}
}

