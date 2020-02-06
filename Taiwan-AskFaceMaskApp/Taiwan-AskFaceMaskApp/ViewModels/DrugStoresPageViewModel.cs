﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xam.Plugin.BaseBindingLibrary;
using Taiwan_AskFaceMaskApp.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Taiwan_AskFaceMaskApp.ViewModels
{
    public class DrugStoresPageViewModel : BaseNotifyProperty
    {
		private ObservableCollection<Models.DrugStore> _drugStores;
		public ObservableCollection<Models.DrugStore> DrugStores
		{
			get { return _drugStores; }
			set => OnPropertyChanged(ref _drugStores, value);
		}

		public DrugStoresPageViewModel()
		{
			DrugStores = DbService.Instance.GetDrugStoreData();
			System.Diagnostics.Debug.WriteLine(DrugStores?.Count);
		}

		public ICommand SearchCommand
		{
			get
			{
				return new Command<string>((query) =>
				{
					DrugStores = DbService.Instance.GetDrugStoreData(query);
				});
			}
		}
	}
}
