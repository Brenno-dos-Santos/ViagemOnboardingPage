using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemOnboardingPage.Models;

namespace ViagemOnboardingPage.ViewModels
{
    public partial class ViagemItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ViagemItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosition))]
        [NotifyPropertyChangedFor(nameof(ShowButton))]
        private int _position;

        public bool IsLastPosition => Position == Itens.Count - 1;

        public bool ShowButton => !IsLastPosition;

        public ViagemItemViewModel()
        {
            Itens = new List<ViagemItem>
            {
                new ViagemItem
                {
                    UrlImage = "explore.png",
                    Title = "Explore Exotic Destinations",
                    Description = "Embark on a virtual journey through stunning destinations worldwide.."
                },
                new ViagemItem
                {
                    UrlImage = "discovery.png",
                    Title = "Discover Local Gems",
                    Description = "Uncover hidden gems and local favorites recommended by fellow travelers."
                },
                new ViagemItem
                {
                    UrlImage = "train.png",
                    Title = "Plan Your Perfect Trip",
                    Description = "Create personalized itineraries tailored to your preferences and interests."
                },new ViagemItem
                {
                    UrlImage = "vacation.png",
                    Title = "Capture and Share Memories",
                    Description = "Preserve your travel memories with our in-app photo and journaling features."
                }
                
            };
        }

        [RelayCommand]
        private void NextPosition()
        {
            if (Position < Itens.Count - 1)
            {
                Position++;
            }
        }

        [RelayCommand]
        private void PreviousPosition()
        {
            if (Position > 0)
            {
                Position--;
            }
        }
    }
}
