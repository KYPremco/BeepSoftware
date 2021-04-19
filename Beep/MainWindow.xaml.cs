using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows;
using System.Windows.Threading;
using Beep.Classes;
using Beep.Classes.Beep.Emotions;
using Beep.UiClasses;

namespace Beep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private SerialPort _beepConnection;
        private Classes.Beep.Beep _beep;

        readonly SerialPort serialPort = new SerialPort();

        public MainWindow()
        {
            InitializeComponent();
            ActivateAutoConnector();
        }

        private void ActivateAutoConnector()
        {
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_HandlerConnection);
            dispatcherTimer.Interval = new TimeSpan(0,0,5);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_HandlerConnection(object sender, EventArgs e)
        {
            SerialPort sp = BeepConnector.connect();
            if (sp != null)
            {
                sp.DataReceived += SerialDataReceivedEventHandler;
                _beep = new Classes.Beep.Beep();
                _beepConnection = sp;

                gridPreview.Visibility = Visibility.Hidden;
            }
            
            
            if (_beepConnection != null && !_beepConnection.IsOpen)
            {
                _beepConnection = null;
                _beep = null;
                gridPreview.Visibility = Visibility.Visible;
            }
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                switch ((TransmissionAction)int.Parse(serialPort.ReadLine()))
                {
                    
                    default:
                        MessageBox.Show("UNKNOWN:" + serialPort.ReadLine());
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        
        private void SendTransmissionToArduino(TransmissionAction action)
        {
            serialPort.WriteLine(((int) action).ToString());
        }

        private void BtnHappy_OnClick(object sender, RoutedEventArgs e)
        {
            beepGrid.Children.Clear();
            beepGrid.Children.Add(BeepDrawer.DrawEmotion(new Happy()));
            
        }

        private void BtnSad_OnClick(object sender, RoutedEventArgs e)
        {
            beepGrid.Children.Clear();
            beepGrid.Children.Add(BeepDrawer.DrawEmotion(new Sad()));
        }

        private void BtnNeutral_OnClick(object sender, RoutedEventArgs e)
        {
            beepGrid.Children.Clear();
            beepGrid.Children.Add(BeepDrawer.DrawEmotion(new Neutral()));
        }

        private void BtnThirsty_OnClick(object sender, RoutedEventArgs e)
        {
            beepGrid.Children.Clear();
            beepGrid.Children.Add(BeepDrawer.DrawEmotion(new Thirsty()));
        }
    }
}