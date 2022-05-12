namespace Unit_13_Respawn_Screen.Data
{
    //create methods instead of taking raw mock data
    public static class BackendService
    {
        public static int IdIndex => id++;
        private static int id = 0;

        public static Layout CreateLayout(string name)
        {
            //If layout is valid send to server

            return new Layout(name, id++);
        }

        public static Layout GetLayout(int id) => MockData.Layouts.Where(x => x.Id == id).FirstOrDefault() ?? new Layout("ERROR", 9999);

        public static Layout GetLayout(Preview preview) => MockData.Layouts.Where(x => x.Id == preview.Id).FirstOrDefault() ?? new Layout("ERROR", 9999);

        public static Preview[] GetPreviews()
        {
            return MockData.Previews;
        }
    }
}