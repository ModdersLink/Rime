using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Content.Frostbite2_0.Frostbite
{
    public class PackageManifest
    {
        public string Path { get; set; }

        public bool Authoritative { get; set; }

        public bool HasContent { get; set; }

        public string Name 
        { 
            get => m_HasName ? m_Name! : "";
            set { m_Name = value; m_HasName = true; } 
        }

        public int Version 
        {
            get => m_Version;
            set { m_Version = value; m_HasVersion = true; } 
        }

        public int MountOrder 
        {
            get => m_MountOrder;
            set { m_MountOrder = value; m_HasMountOrder = true; } 
        }

        public int RequireVersion 
        {
            get => m_RequireVersion;
            set { m_RequireVersion = value; m_HasRequireVersion = true; } 
        }

        private string? m_Name;
        private bool m_HasName;

        private int m_Version;
        private bool m_HasVersion;

        private int m_MountOrder;
        private bool m_HasMountOrder;

        private int m_RequireVersion;
        private bool m_HasRequireVersion;

        public PackageManifest(string p_Path)
        {
            Path = p_Path;
            ParseManifest(File.ReadAllText(Path));
        }

        public PackageManifest(byte[] p_Data, string p_Path)
        {
            Path = p_Path;
            ParseManifest(Encoding.UTF8.GetString(p_Data));   
        }

        public PackageManifest(string p_Data, string p_Path)
        {
            Path = p_Path;
            ParseManifest(p_Data);
        }

        private void ParseManifest(string p_Data)
        {
            var s_Lines = p_Data.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p_Line => p_Line.Replace("\r", "").Trim())
                    .Where(p_Line => !string.IsNullOrWhiteSpace(p_Line));

            var s_Entries = new Dictionary<string, string>();

            foreach (var s_Line in s_Lines)
            {
                // Changed to accomodate Battlefield 4, and DAI (thx dawnless sky)
                var s_Index = s_Line.LastIndexOf(" ", StringComparison.Ordinal);

                if (s_Index == -1)
                {
                    s_Entries.Add(s_Line, "");
                    continue;
                }

                var s_Key = s_Line.Substring(0, s_Index).Trim();
                var s_Value = s_Line.Substring(s_Index).Trim();

                s_Entries.Add(s_Key, s_Value);
            }

            var s_Keys = new string[s_Entries.Keys.Count];
            s_Entries.Keys.CopyTo(s_Keys, 0);

            foreach (var s_Key in s_Keys)
            {
                var s_Value = s_Entries[s_Key];

                switch (s_Key)
                {
                    case "Authoritative":
                        Authoritative = true;
                        break;

                    case "HasContent":
                        HasContent = true;
                        break;

                    case "Name":
                        Name = s_Value;
                        break;

                    case "Version":
                        Version = int.Parse(s_Value);
                        break;

                    case "MountOrder":
                        MountOrder = int.Parse(s_Value);
                        break;

                    case "RequireVersion":
                        RequireVersion = int.Parse(s_Value);
                        break;
                    
                    default:
                        throw new Exception($"Tried to load a package with unknown attribute '{s_Key}'.");
                }

                s_Entries.Remove(s_Key);
            }
        }

        public string Serialize()
        {
            using (var s_Writer = new StringWriter())
            {
                if (Authoritative)
                    s_Writer.WriteLine("Authoritative");

                if (HasContent)
                    s_Writer.WriteLine("HasContent");

                if (m_HasName)
                    s_Writer.WriteLine("Name " + Name);

                if (m_HasVersion)
                    s_Writer.WriteLine("Version " + Version);

                if (m_HasMountOrder)
                    s_Writer.WriteLine("MountOrder " + MountOrder);

                if (m_HasRequireVersion)
                    s_Writer.WriteLine("RequireVersion " + RequireVersion);

                s_Writer.Flush();

                return s_Writer.ToString();
            }
        }
    }
}
