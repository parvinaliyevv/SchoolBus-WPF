﻿namespace SchoolBus.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();

        DataContext = new MainViewModel();
    }
}
