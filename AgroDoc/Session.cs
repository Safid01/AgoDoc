namespace AgroDoc
{
    public static class Session
    {
        // 1. Static Properties (Global Memory)
        public static int FarmerId { get; set; } = 0;
        public static string FullName { get; set; } = "";
        public static string Username { get; set; } = "";
        public static string Location { get; set; } = "";

        // 2. Quick Status Check
        public static bool IsLoggedIn => FarmerId > 0;

        // 3. Reset on Logout
        public static void Clear()
        {
            FarmerId = 0;
            FullName = "";
            Username = "";
            Location = "";
        }
    }
}