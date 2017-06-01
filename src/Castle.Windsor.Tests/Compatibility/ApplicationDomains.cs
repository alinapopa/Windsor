using System;

namespace CastleTests
{
    internal static class ApplicationDomains
    {
        public static string BaseDirectory
        {
            get
            {
#if FEATURE_APPDOMAIN
                return  AppDomain.CurrentDomain.BaseDirectory;
#else
				return AppContext.BaseDirectory;
#endif
            }
        }
    }
}