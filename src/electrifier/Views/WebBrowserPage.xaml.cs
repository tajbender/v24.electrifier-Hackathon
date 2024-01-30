﻿using Microsoft.UI.Xaml.Controls;
using electrifier.ViewModels;

namespace electrifier.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class WebBrowserPage : Page
{
    public WebBrowserViewModel ViewModel
    {
        get;
    }

    public WebBrowserPage()
    {
        ViewModel = App.GetService<WebBrowserViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
