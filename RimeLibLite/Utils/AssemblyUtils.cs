using System;
using System.IO;
using System.Reflection;
using RimeLib.Frostbite;

namespace RimeLib.Utils
{
    public static class AssemblyUtils
    {
        public static bool LoadSupportAssembly(AssemblyType p_AssemblyType, EngineType p_Engine)
        {
            var s_BaseAssembly = "RimeLib." + p_AssemblyType;

            if (!LoadAssembly(s_BaseAssembly))
                return false;

            var s_SupportAssembly = s_BaseAssembly + "." + p_Engine;

            return LoadAssembly(s_SupportAssembly);
        }

        public static string? GetAssemblyPath(string p_Name)
        {
            var s_DllName = p_Name + ".dll";

            // If this exists in our working directory then return that path.
            if (File.Exists(s_DllName))
                return Path.GetFullPath(s_DllName);

            // Otherwise, look in all system PATH folders.
            var s_Path = Environment.GetEnvironmentVariable("PATH");

            if (string.IsNullOrWhiteSpace(s_Path))
                return null;

            var s_PathFolders = s_Path.Split(Path.PathSeparator);

            foreach (var s_Folder in s_PathFolders)
            {
                var s_AssemblyPath = Path.Combine(s_Folder, s_DllName);

                if (File.Exists(s_AssemblyPath))
                    return s_AssemblyPath;
            }

            return null;
        }

        private static bool LoadAssembly(string p_Name)
        {
            try
            {
                // Try using just its assembly name first.
                Assembly.Load(p_Name);
                return true;
            }
            catch
            {
                // If that fails, try loading the file.
                try
                {
                    var s_Path = GetAssemblyPath(p_Name);
                    if (s_Path is null)
                        return false;

                    Assembly.LoadFile(s_Path);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
