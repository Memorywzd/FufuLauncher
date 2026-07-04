/*
Copyright (c) FufuLauncher Dev Team. All rights reserved.
Licensed under the MIT License.
*/
using FufuLauncher.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media.Animation;

namespace FufuLauncher.Views
{
    public sealed partial class LanguageSelectionPage : Page
    {
        public LanguageSelectionViewModel ViewModel { get; }

        public LanguageSelectionPage()
        {
            ViewModel = App.GetService<LanguageSelectionViewModel>();
            InitializeComponent();
        }

        private void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            EntranceStoryboard.Begin();
        }

        private void OnLanguageItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is LanguageOption language)
            {
                ViewModel.SelectLanguage(language);
            }
        }

        private void OnCardPointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (sender is Border border)
            {
                var hoverIn = border.Resources["HoverInStoryboard"] as Storyboard;
                hoverIn?.Begin();
            }
        }

        private void OnCardPointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (sender is Border border)
            {
                var hoverOut = border.Resources["HoverOutStoryboard"] as Storyboard;
                hoverOut?.Begin();
            }
        }

        private async void OnConfirmClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedLanguage == null) return;

            await ViewModel.ConfirmLanguageCommand.ExecuteAsync(null);
            
            if (Frame.CanGoBack)
            {
                Frame.BackStack.Clear();
            }
            Frame.Navigate(typeof(AgreementPage));
        }
    }
}
