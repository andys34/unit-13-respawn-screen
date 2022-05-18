namespace Unit_13_Respawn_Screen.Data
{
    public class AppState
    {
        public Layout SelectedLayout { get; private set; } = new Layout("default", 0, new Marker[] { new Marker("Blue Objective", "Blue_Objective.svg", 0, 4), new Marker("Red Objective", "Red_Objective.svg", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.svg", 0, 4) });
        public string BrowseDialogShown = "display: block;";

        public event Action? LayoutChange;
        public event Action? BrowseDialogChange;

        public void SetLayout(Layout layout)
        {
            SelectedLayout = layout;
            LayoutStateChanged();
        }
        public void SetLayout(Preview preview)
        {
            SelectedLayout = BackendService.GetLayout(preview);
            LayoutStateChanged();
        }

        public void ShowBrowseDialog()
        {
            BrowseDialogShown = "display: block;";
            BrowseDialogStateChanged();
        }
        public void HideBrowseDialog()
        {
            BrowseDialogShown = "display: none;";
            BrowseDialogStateChanged();
        }

        private void LayoutStateChanged() => LayoutChange?.Invoke();
        private void BrowseDialogStateChanged() => BrowseDialogChange?.Invoke();
    }
}
