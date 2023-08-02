namespace TestRepro.Domain
{
    public class _AppConfig
    {
        private static _AppConfig _config;
        public static _AppConfig GetConfig { get { if (_config == null) _config = new _AppConfig(); return _config; } }


        public bool IsConnected { get; set; }

    }
}
