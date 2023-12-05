using System;

namespace MelonLoader.Fixes
{
    public static class UnhandledException
    {
        public static void Install(AppDomain domain) =>
            domain.UnhandledException +=
                (sender, args) =>
                    Console.WriteLine((args.ExceptionObject as Exception).ToString());
    }
}