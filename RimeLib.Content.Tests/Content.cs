using System;
using System.Diagnostics;
using System.IO;
using RimeLib.Content.Frostbite.Storage.Sb;
using RimeLib.IO;
using Xunit;

namespace RimeLib.Content.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var s_Reader = new RimeReader(File.Open(@"B:\Games\Battlefield 3\Data\Win32\Chunks0.toc", FileMode.Open));
            var s_Toc = new TableOfContents<SuperbundleLayout>(s_Reader);
            Debug.WriteLine(s_Toc);
        }
    }
}
