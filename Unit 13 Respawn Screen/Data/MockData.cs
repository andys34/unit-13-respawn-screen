namespace Unit_13_Respawn_Screen.Data
{
    public static class MockData
    {
        public static Layout[] Layouts = new Layout[]
            {
                new Layout("#1 Small, quick, simple", 0 , new Marker[] { new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("#2 Small, mirrored", 1 ,new Marker[] { new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("This a layout", 2 , new Marker[] { new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("And another", 3 , new Marker[] { new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("Cool layout", 4 , new Marker[] {new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("Lame layout", 5 , new Marker[] {new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4)}),
                new Layout("Nice layout", 6 ,new Marker[] {new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) }),
                new Layout("That layout", 7 , new Marker[] {new Marker("Blue Objective", "Blue_Objective.png", 0, 4), new Marker("Red Objective", "Red_Objective.png", 0, 4), new Marker("Blue Checkpoint", "Blue_Checkpoint.png", 0, 4) })
            };

        public static Preview[] Previews = new Preview[]
            {
                new Preview("#1 Small, quick, simple", 0),
            new Preview("#2 Small, mirrored", 1),
            new Preview("This a layout", 2),
            new Preview("And another", 3),
            new Preview("Cool layout", 4),
            new Preview("Lame layout", 5),
            new Preview("Nice layout", 6),
            new Preview("That layout", 7)
            };
    }
}