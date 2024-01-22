using FullCart.Debugging;

namespace FullCart
{
    public class FullCartConsts
    {
        public const string LocalizationSourceName = "FullCart";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7d93aed3537e4d6892e4f3e3ac75a95f";
    }
}
