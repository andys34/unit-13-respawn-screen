namespace Unit_13_Respawn_Screen.Data
{
    public class Layout
    {
        public string Name;
        public string Briefing = "Brief briefing";
        public int Id { get; private set; }
        public Marker[] Markers { get => markers.ToArray(); }
        private List<Marker> markers = new List<Marker>();
        public Layout(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public Layout(string name, int id, Marker[] markers)
        {
            Name = name;
            Id = id;
            this.markers = markers.ToList();
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
