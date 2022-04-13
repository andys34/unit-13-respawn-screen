using System.Collections.Generic;
using System.Linq;

namespace Respawn_Screen.Data
{
    public class Layout
    {
        public string Name;

        public Marker[] Markers { get => markers.ToArray(); }
        private List<Marker> markers = new List<Marker>();
        public Layout(string name)
        {
            Name = name;
        }

        public Layout(string name, Marker[] markers)
        {
            Name = name;
            this.markers = markers.ToList();
        }
        public Layout(string name, List<Marker> markers)
        {
            Name = name;
            this.markers = markers;
        }

        public void AddMarker(Marker marker)
        {
            markers.Add(marker);
        }

        public void RemoveMarker(Marker marker)
        {
            markers.Remove(marker);
        }
    }
}
