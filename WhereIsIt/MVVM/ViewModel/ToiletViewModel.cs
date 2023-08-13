using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using WhereIsIt.MVVM.Model;

namespace WhereIsIt.MVVM.ViewModel
{
	public class ToiletViewModel
	{
		public ToiletViewModel()
		{
			ToiletList = new ObservableCollection<Toilet>();
			OnLoadedCommand = new RelayCommand<object>(OnLoaded);
		}

        private void OnLoaded(object obj)
        {
            
        }

        public RelayCommand<object> OnLoadedCommand { get; private set; }
		public ObservableCollection<Toilet> ToiletList { get; set; }
	}
}

