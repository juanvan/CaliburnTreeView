using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaliburnTreeView.Models
{
    public class Artist
    {
        private readonly ICollection<Album> _children = new ObservableCollection<Album>();
        public string Name { get; set; }

        public ICollection<Album> Albums
        {
            get { return _children; }
        }
    }

    public class Album
    {
        private readonly ICollection<Track> _children = new ObservableCollection<Track>();
        public string Name { get; set; }

        public ICollection<Track> Tracks
        {
            get { return _children; }
        }
    }

    public class Track
    {
        public string Name { get; set; }
        public string Length { get; set; }
    }
}
