using System;

using Xamarin.Forms;

namespace testing
{
    public class Testpage : ContentPage
    {
        Label TestLabel = new Label(){VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand};
        Label TestCount = new Label() { VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
        testpageViewModel viewModel = new testpageViewModel();
        public Testpage()
        {
            
            //TestLabel.SetBinding(Label.TextProperty, nameof(viewModel.text));
            TestCount.SetBinding(Label.TextProperty, "UrlByteCount.Result", BindingMode.OneWay);

            Content = new StackLayout
            {
                Children = {
                    TestLabel, TestCount
                }
            };
        }
    }
}

