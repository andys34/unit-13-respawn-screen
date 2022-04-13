namespace Respawn_Screen.Data
{
    public class BackendService
    {
        public static readonly Scenario[] Scenarios =
        {
            new Scenario("Payload", new Layout[] { new Layout("#1 Small, quick, simple", new Marker[]{new Marker("i0030", 134.23f, 13.52f)}),new Layout("#2 Small, mirrored", new Marker[]{new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Capture The Flag", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Battle Royale", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Siege out", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Dogs out", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Royal Rumble", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Juice Mixer", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})}),
            new Scenario("Operation Loon", new Layout[] { new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f)})})
        };
    }
}
