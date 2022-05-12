namespace Unit_13_Respawn_Screen.Data
{
    public class Preview
    {
        public string LayoutName { get; set; }
        public int Id { get; set; }
        
        public Preview(string layoutName, int id)
        {
            LayoutName = layoutName;
            Id = id;
        }
    }
}
