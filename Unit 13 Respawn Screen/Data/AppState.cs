using System.Text.Json;

namespace Unit_13_Respawn_Screen.Data
{
    public class AppState
    {
        private static readonly string fileName = "Appdata.json";
        private static AppState? _instance;
        private static readonly object Padlock = new object();
        public Layout? SelectedLayout { get; private set; }
        public List<Layout> Layouts { get; private set; }
        public string BrowseDialogShown = "display: block;";

        public event Action? LayoutChange;
        public event Action? BrowseDialogChange;
        public event Action? MarkerChange;

        public AppState()
        {
            Layouts = new List<Layout>();
        }

        public static AppState Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        string jsonString = File.ReadAllText(fileName);
                        _instance = JsonSerializer.Deserialize<AppState>(jsonString);
                        if (_instance == null) _instance = new AppState();
                    }
                    return _instance;
                }
            }
        }

        private static void SaveData()
        {
            string jsonString = JsonSerializer.Serialize(Instance);
            File.WriteAllText(fileName, jsonString);
        }

        public void AddMarker(Marker m)
        {
            SelectedLayout?.AddMarker(m);
            MarkerStateChanged();
            SaveData();
        }
        public void SetLayout(Layout layout)
        {
            SelectedLayout = layout;
            LayoutStateChanged();
            SaveData();
        }

        public void ShowBrowseDialog()
        {
            BrowseDialogShown = "display: block;";
            BrowseDialogStateChanged();
            SaveData();
        }
        public void HideBrowseDialog()
        {
            BrowseDialogShown = "display: none;";
            BrowseDialogStateChanged();
            SaveData();
        }

        private void LayoutStateChanged() => LayoutChange?.Invoke();
        private void BrowseDialogStateChanged() => BrowseDialogChange?.Invoke();
        private void MarkerStateChanged() => MarkerChange?.Invoke();
    }
}
