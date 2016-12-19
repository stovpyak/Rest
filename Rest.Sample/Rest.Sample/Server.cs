using System;
using Microsoft.Owin.Hosting;

namespace Rest.Sample
{
    public sealed class Server: IDisposable
    {
        private readonly string _baseAddress;
        private IDisposable _webApp;
        
        public Server(string baseAddress)
        {
            _baseAddress = baseAddress;
        }

        public void Start()
        {
            _webApp = WebApp.Start<Startup>(url: _baseAddress);
        }

        public void Stop()
        {
            Close();
        }

        public void Dispose()
        {
            Close();
        }

        private void Close()
        {
            if (_webApp != null)
            {
                var temp = _webApp;
                _webApp = null;
                temp.Dispose();
            }
        }
    }
}
