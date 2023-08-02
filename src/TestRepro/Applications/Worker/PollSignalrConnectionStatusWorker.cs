using System.Timers;
using TestRepro.Domain;
using TestRepro.ViewModel;

namespace TestRepro.Applications.Worker
{
    public class PollSignalrConnectionStatusWorker
    {
        public delegate void SignalREventHanlder();
        public event SignalREventHanlder SignalREvent;

        private static readonly System.Timers.Timer timer = new System.Timers.Timer(50000);
        public PollSignalrConnectionStatusWorker()
        {
            timer.Elapsed += TestSignalRConnection;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
            SignalREvent += new AppShellViewModel().ChangeConnectionStatus;
        }

        private void TestSignalRConnection(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (!_AppConfig.GetConfig.IsConnected)
                {
                    _AppConfig.GetConfig.IsConnected = true;
                    SignalREvent();
                }
                else
                {
                    _AppConfig.GetConfig.IsConnected = false;
                    SignalREvent();
                }
            }
            catch (Exception ex)
            {

            }
        }


    }
}
