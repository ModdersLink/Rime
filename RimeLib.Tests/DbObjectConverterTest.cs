using Newtonsoft.Json;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace RimeLib.Tests
{
    public class DbObjectConverterTest
    {
        [Fact]
        public void Test1()
        {
            using var s_Reader = new RimeReader(File.OpenRead(@"B:\Games\Battlefield 3\Data\Win32"));

            var s_Magic = s_Reader.ReadUInt32();

            if (s_Magic == 0x00CED100 ||
                s_Magic == 0x01CED100)
            {
                s_Reader.EnableDeobfuscation();
            }
            else if (s_Magic == 0x03CED100) // Signed
            {
                s_Reader.Seek(0x228, SeekOrigin.Current);
            }
            else
            {
                throw new Exception("The provided DbObject file is invalid.");
            }

            var s_DbObject = new DbObject(s_Reader);

            var s_Json = JsonConvert.SerializeObject(s_DbObject);

            Debug.WriteLine(s_Json);
        }
    }
}
