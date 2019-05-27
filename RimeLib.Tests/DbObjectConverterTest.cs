using Newtonsoft.Json;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using System;
using System.IO;
using Xunit;

namespace RimeLib.Tests
{
    public class DbObjectConverterTest
    {
        private void Test(string p_Path)
        {
            using var s_Reader = new RimeReader(File.OpenRead(p_Path));

            var s_Magic = s_Reader.ReadUInt32();

            if (s_Magic == 0x00CED100 ||
                s_Magic == 0x01CED100)
            {
                // Read the signature and enable de-obfuscation by reading the XOR table.
                var s_Signature = s_Reader.ReadBytes(292);
                s_Reader.EnableDeobfuscation();
            }
            else if (s_Magic == 0x03CED100) // Signed
            {
                // Read the signature and skip the empty XOR table.
                var s_Signature = s_Reader.ReadBytes(292);
                s_Reader.Seek(260, SeekOrigin.Current);
            }
            else
            {
                throw new Exception("Could not find valid header magic for ToC file.");
            }

            var s_DbObject = new DbObject(s_Reader);

            var s_Json = JsonConvert.SerializeObject(s_DbObject, Formatting.Indented);

            File.WriteAllText(p_Path + ".json", s_Json);
        }

        [Fact]
        public void Test1()
        {
            Test(@"B:\Games\Battlefield 3\Data\layout.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Chunks0.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\default_settings_Win32.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Xp2Chunks.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Loc\en.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Levels\MP_Subway\MP_Subway.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Levels\XP4_Rubble\XP4_Rubble.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack1\Data\Win32\Xp1Chunks.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack2\Data\Win32\Xp2Chunks.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack5\Data\Win32\Xp5Chunks.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack1\Data\Win32\Levels\XP1_002\XP1_002.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack4\Data\Win32\Levels\XP4_Rubble\XP4_Rubble.toc");
            Test(@"B:\Games\Battlefield 3\Update\Xpack5\Data\Win32\Levels\XP5_001\XP5_001.toc");
            Test(@"B:\Games\Battlefield 3\Update\Patch\Data\Win32\Levels\XP3_Valley\XP3_Valley.toc");
        }
    }
}
