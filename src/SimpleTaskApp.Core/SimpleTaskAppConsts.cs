using SimpleTaskApp.Debugging;

namespace SimpleTaskApp
{
    public class SimpleTaskAppConsts
    {
        public const string LocalizationSourceName = "SimpleTaskApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "661dc15b20e64cde9518ef5e4fe85a06";
    }
}
