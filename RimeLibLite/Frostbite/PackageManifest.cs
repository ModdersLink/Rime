using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Frostbite
{
    public class PackageManifest
    {
        public String Path { get; set; }

        public bool Authoritative { get; set; }

        public bool HasContent { get; set; }

        public String Name 
        { 
            get { return m_Name; } 
            set { m_Name = value; m_HasName = true; } 
        }

        public int Version 
        {
            get { return m_Version; }
            set { m_Version = value; m_HasVersion = true; } 
        }

        public int MountOrder 
        {
            get { return m_MountOrder; }
            set { m_MountOrder = value; m_HasMountOrder = true; } 
        }

        public int RequireVersion 
        {
            get { return m_RequireVersion; }
            set { m_RequireVersion = value; m_HasRequireVersion = true; } 
        }

        private String m_Name;
        private bool m_HasName;

        private int m_Version;
        private bool m_HasVersion;

        private int m_MountOrder;
        private bool m_HasMountOrder;

        private int m_RequireVersion;
        private bool m_HasRequireVersion;

        public PackageManifest(String p_Path)
        {
            Path = p_Path;
        }

        public PackageManifest(byte[] p_Data, String p_Path)
        {
            Path = p_Path;
            ParseManifest(Encoding.UTF8.GetString(p_Data));   
        }

        public PackageManifest(String p_Data, String p_Path)
        {
            Path = p_Path;
            ParseManifest(p_Data);
        }

        private void ParseManifest(String p_Data)
        {
            var s_Lines = p_Data.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p_Line => p_Line.Replace("\r", "").Trim())
                    .Where(p_Line => !String.IsNullOrWhiteSpace(p_Line));

            var s_Entries = new Dictionary<String, String>();

            foreach (var s_Line in s_Lines)
            {
                // Changed to accomidate Battlefield 4, and DAI (thx dawnless sky)
                var s_Index = s_Line.LastIndexOf(" ");

                if (s_Index == -1)
                {
                    s_Entries.Add(s_Line, null);
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
                        Version = Int32.Parse(s_Value);
                        break;

                    case "MountOrder":
                        MountOrder = Int32.Parse(s_Value);
                        break;

                    case "RequireVersion":
                        RequireVersion = Int32.Parse(s_Value);
                        break;
                    
                    default:
                        continue;
                }

                s_Entries.Remove(s_Key);
            }

            // Ignore unknown attributes, do not error
            //if (s_Entries.Count > 0)
            //    throw new Exception("Tried to load a package with unknown attributes: " + String.Join(", ", s_Entries.Keys) + ". This probably means this engine version is not supported yet.");
        }

        public String Generate()
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
