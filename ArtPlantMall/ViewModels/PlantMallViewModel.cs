using ArtPlantMall.Models;
using ArtPlantMall.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArtPlantMall.ViewModels
{
    public class PlantMallViewModel : BindableObject
    {

        public PlantMallViewModel()
        {
            LoadData();
        }
        private Plant _selectedPlant;
        private ObservableCollection<Plant> _plants;
        private ObservableCollection<BasketItem> _basket;

        public ObservableCollection<Plant> Plants
        {
            get 
            { 
                return _plants; 
            }
            set
            {
                _plants = value;
                OnPropertyChanged();
            }
        }
        public Plant SelectedPlant
        {
            get
            {
                return _selectedPlant;
            }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BasketItem> Basket
        {
            get
            {
                return _basket;
            }
            set
            {
                _basket = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlantDetailCommand => new Command(NavigateToPlantDetail);
        private void LoadData()
        {
            Plants = new ObservableCollection<Plant>(PlantsService.Instance.GetPlants());
            Basket = new ObservableCollection<BasketItem>(BasketService.Instance.GetActualBasket());
        }
        private void NavigateToPlantDetail()
        {

        }
    }
}
