namespace Unit_13_Respawn_Screen.Data
{
    public class AppState
    {
        public Layout SelectedLayout { get; private set; } = new Layout("default", new Marker[] { new Marker(0, 4), new Marker(0, 4), new Marker(0, 4) });

        public event Action OnChange;

        public void SetLayout(Layout layout)
        {
            SelectedLayout = layout;
            NotifyStateChanged();
            
        }

        private void NotifyStateChanged() =>  OnChange?.Invoke();
    }
}
