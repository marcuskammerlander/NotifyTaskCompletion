using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace testing
{
    public class testpageViewModel
    {
        public testpageViewModel()
        {
            /*text = "This is a Test";
            Task.Run(async () =>
            {
                textCount = await CountBytesInUrlAsync("https://www.golem.de");
            });*/

            UrlByteCount = new NotifyTaskCompletion<string>(CountBytesInUrlAsync("https://www.stackoverflow.com"));
        }


        NotifyTaskCompletion<string> _UrlByteCount;
        public NotifyTaskCompletion<string> UrlByteCount         
        {
            get 
            { 
                Debug.WriteLine("getter");
                return _UrlByteCount;
            }
            set
            {
                _UrlByteCount = value;
                NotifyPropertyChanged("UrlByteCount");
            }
        }

        /*
        string _text;
        public string text
        {
            get { return _text; }
            set
            {
                _text = value;
                NotifyPropertyChanged("text");
            }
        }


        string _textCount;
        public string textCount
        {
            get { return _textCount; }
            set
            {
                _textCount = value;
                NotifyPropertyChanged("textCount");
            }
        }*/



        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                // property changed
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }


        public static async Task<string> CountBytesInUrlAsync(string url)
        {
            // Artificial delay to show responsiveness.
            await Task.Delay(TimeSpan.FromSeconds(3)).ConfigureAwait(false);
            // Download the actual data and count it.
            using (var client = new HttpClient())
            {
                var data = await client.GetByteArrayAsync(url).ConfigureAwait(false);
                return data.Length.ToString();
            }
        }
    }
}
