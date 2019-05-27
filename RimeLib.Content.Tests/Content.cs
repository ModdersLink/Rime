using System;
using System.Diagnostics;
using System.IO;
using RimeLib.Content.Frostbite.Storage.Sb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using Xunit;

namespace RimeLib.Content.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var s_Reader = new RimeReader(File.Open(@"B:\Games\Battlefield 3\Update\Patch\Data\layout_new.toc", FileMode.Open, FileAccess.Read, FileShare.Read));
            var s_Toc = new TableOfContents<ContentManifest>(s_Reader);
            Debug.WriteLine(s_Toc);

            using var s_Writer = new RimeWriter(File.Open(@"B:\Games\Battlefield 3\Update\Patch\Data\layout_new2.toc", FileMode.Create));
            s_Toc.Serialize(s_Writer);
        }

        [Fact]
        public async void TestMount()
        {
            var s_Mounter = new ContentMounter(EngineType.Frostbite2_0);

            Assert.True(await s_Mounter.Mount(@"B:\Games\Battlefield 3\"));
        }
    }
}
