
namespace Unit_13_Respawn_Screen.Data
{
    //create methods instead of taking raw mock data
    public class BackendService
    {
        public static readonly Layout[] Layouts =
        {
            new Layout("#1 Small, quick, simple", new Marker[]{new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("#2 Small, mirrored", new Marker[]{new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) }),
            new Layout("Payload", new Marker[] { new Marker("i0030", 134.23f, 13.52f) })
        };
    }
}