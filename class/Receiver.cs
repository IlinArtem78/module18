using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace module18
{
    public class Receiver
    {
        public string url { get; }
        public string outputFilePath { get; }

       
       YoutubeClient videos = new YoutubeClient();
       
       public async void DownloadOperation()
        {
            await videos.Videos.DownloadAsync(url, outputFilePath); 
                
        }
        public async void DescOperation()
        {
            videos.Videos.GetAsync(url);
        }

    }
}
