namespace Unit_13_Respawn_Screen.Data
{
    public class Scenario
    {
        public string Name;
        public string Briefing = "";
        public Layout[] Layouts { get => layouts.ToArray(); }
        private List<Layout> layouts;

        public Scenario(string name)
        {
            Name = name;
            layouts = new List<Layout>();
        }

        public Scenario(string name, Layout[] layouts)
        {
            Name = name;
            this.layouts = layouts.ToList();
        }
    }
}
