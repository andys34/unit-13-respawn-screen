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

        public static Layout GetLayout(int id) => AppState.Instance.Layouts.Where(x => x.Id == id).FirstOrDefault() ?? new Layout("ERROR", 9999);

    }
}