namespace Unit_13_Respawn_Screen.Data
{
    public class Marker
    {
        public string Icon = "i0000";
        public float X = 0f;
        public float Y = 0f;

        public Marker()
        {

        }
        public Marker(string icon)
        {
            Icon = icon;
        }

        public Marker(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Marker(string icon, float x, float y)
        {
            Icon = icon;
            X = x;
            Y = y;
        }
    }
}
