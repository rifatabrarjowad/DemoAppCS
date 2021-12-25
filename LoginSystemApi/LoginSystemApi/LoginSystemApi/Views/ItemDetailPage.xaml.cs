﻿using LoginSystemApi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginSystemApi.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}