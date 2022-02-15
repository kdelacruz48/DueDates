using DueDates.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DueDates.Views
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