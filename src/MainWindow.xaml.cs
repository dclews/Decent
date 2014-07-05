using Decent.dotNET.ui;
using Decent.dotNET.ui.windowFrame;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Decent.dotNET.ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : modernWindowFrame
    {
        public MainWindow()
        {
            InitializeComponent();
            setWindowAppearance();
        }

        private void centerWindowOnDisplay()
        {
            Left = ((FormsScreenInterface.currentDisplayAvailableBounds()[2] / 2) - (Width / 2));
            Top  = ((FormsScreenInterface.currentDisplayAvailableBounds()[3] / 2) - (Height / 2));
        }

        private void setWindowAppearance()
        {
            BorderThickness = new Thickness(1);
            BorderBrush     = new SolidColorBrush(Colors.Black);

            // ^ should be set via theme manager

            ResizeHandle = resizeHandle.ResizeGrip;
            MinHeight    = 530;
            MinWidth     = 730;

            setWindowDimentions();
            centerWindowOnDisplay();
        }

        private void setWindowDimentions()
        {
            // needs to be changed to fetch dimentions from prior run
            Height = 530;
            Width  = 730;
        }
    }
}
