﻿using DevDaysWorkshop.Models;
using DevDaysWorkshop.Services;
using DevDaysWorkshop.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DevDaysWorkshop.ViewModels
{
    public class SpeakersViewModel : ViewModelBase
    {
        private bool _isBusy;
        private Speaker _selectedItem;

        public SpeakersViewModel()
        {
            Speakers = new ObservableCollection<Speaker>();
            GetSpeakersCommand = new Command(
                async 
                () => await GetSpeakersAsync(),
                () => !IsBusy);
        }

        public ObservableCollection<Speaker> Speakers { get; set; }

        public Speaker SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                NavigationService.Instance.NavigateTo<SpeakerDetailViewModel>(_selectedItem);
            }
        }

        public Command GetSpeakersCommand { get; set; }

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
                GetSpeakersCommand.ChangeCanExecute();
            }
        }

        private async Task GetSpeakersAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var items = await AzureService.Instance.ReadSpeakersAsync();

                Speakers.Clear();

                foreach (var item in items)
                    Speakers.Add(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}