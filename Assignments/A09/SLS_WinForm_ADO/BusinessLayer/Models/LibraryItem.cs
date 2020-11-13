using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    [Serializable]
    public class LibraryItem
    {
        public int LibraryItemId { get; set; }
        public int Edition { get; set; }
        public int VolumeNum { get; set; }

        public string Type { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }
        public string ISBN { get; set; }
        public string WebUrl { get; set; }
        public string Advertisers { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string ISSN { get; set; }
        public int NumArticles { get; internal set; }
    }
}
