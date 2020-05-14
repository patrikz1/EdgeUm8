﻿using EdgeUm8.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using EdgeUm8.Models;

namespace EdgeUm8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FreeTimes : ContentPage 
    {
        //private string apiUrl = "https://localhost:44340/";
        private List<House> data { get; set; }
        public FreeTimes()
        {
            InitializeComponent();
            BindingContext = new FreeTimesViewModel();
            FetchHouseData(); 
        }

        public async void FetchHouseData() {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://edgeum8remotedb.azurewebsites.net/api/HouseApi");
            var houseData = JsonConvert.DeserializeObject<List<House>>(response);
            data = houseData;
        }



        /*När man trycker på en rad i listview så är den raden färgad annorlunda. Kan använda denna för att navigera till rum-sida.*/
        ViewCell lastCell;
        private void ViewCell_Tapped(object sender, System.EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.BlueViolet;
                lastCell = viewCell;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Profile());

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdvFreeTimes());
        }
    }
}