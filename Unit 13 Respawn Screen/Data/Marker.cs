namespace Unit_13_Respawn_Screen.Data
{
    public class Marker
    {
        public string Name;
        public string Icon = "i0000";
        public float X = 0f;
        public float Y = 0f;

        public Marker(string name, string icon, float x, float y)
        {
            Name = name;
            Icon = icon;
            X = x;
            Y = y;
        }
    }
}
