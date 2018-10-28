using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace testing
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            BindingContext = new testpageViewModel();
            InitializeComponent();
        }
    }
}
