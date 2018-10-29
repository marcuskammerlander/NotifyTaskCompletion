using System;

using Xamarin.Forms;

namespace testing
{
    public class Testpage : ContentPage
    {
        Label TestLabel = new Label(){VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand};
        Label TestCount = new Label() { VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };

        public Testpage()
        {


            //Work
            this.BindingContext = new testpageViewModel();
            TestCount.SetBinding(Label.TextProperty, new Binding("UrlByteCount.Result", BindingMode.OneWay));

            //Doesent Work
            //testpageViewModel viewModel = new testpageViewModel();
            //this.BindingContext = viewModel;
            //TestCount.SetBinding(Label.TextProperty, new Binding(nameof(viewModel.UrlByteCount.Result), BindingMode.OneWay));


            Content = new StackLayout
            {
                Children = {
                    TestLabel, TestCount
                }
            };
        }
    }
}

