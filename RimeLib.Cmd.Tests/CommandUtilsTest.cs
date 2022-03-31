using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using Xunit;
using Assert = Xunit.Assert;

namespace RimeLib.Cmd.Tests
{
    public class DebugTextWriter : StreamWriter
    {
        public DebugTextWriter()
            : base(new DebugOutStream(), Encoding.UTF8, 1024)
        {
            this.AutoFlush = true;
        }

        sealed class DebugOutStream : Stream
        {
            public override void Write(byte[] buffer, int offset, int count)
            {
                Debug.Write(Encoding.UTF8.GetString(buffer, offset, count));
            }

            public override bool CanRead => false;
            public override bool CanSeek => false;
            public override bool CanWrite => true;
            public override void Flush() => Debug.Flush();

            public override long Length => throw bad_op;
            public override int Read(byte[] buffer, int offset, int count) => throw bad_op;
            public override long Seek(long offset, SeekOrigin origin) => throw bad_op;
            public override void SetLength(long value) => throw bad_op;
            public override long Position
            {
                get => throw bad_op;
                set => throw bad_op;
            }

            static InvalidOperationException bad_op => new InvalidOperationException();
        };
    }

    public class CommandUtilsTest
    {
        [Fact]
        public void TestParseArguments()
        {
            Assert.Equal(
                CommandUtils.ParseArguments("one"),
                new[] { "one" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one    two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\""),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\" \"three spaced\""),
                new[] { "one", "two", "three spaced" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\" \"three \\\"spaced\\\"\""),
                new[] { "one", "two", "three \"spaced\"" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two\""),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two\"three"),
                new[] { "one", "two", "three" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one t\\wo"),
                new[] { "one", "t\\wo" }
            );
        }

        [Fact]
        public void TestThing()
        {
            ExecutionContext? s_Context = new BaseContext();
            using var s_Out = new DebugTextWriter();

            s_Context!.ProcessCommand("mount_game \"B:\\Games\\Battlefield 3\" Frostbite2_0", s_Out, out s_Context);
            s_Context!.ProcessCommand("select_game 1", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/xp1chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/xp4chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/mpchunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp1_002/xp1_002 false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp4_quake/xp4_quake false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/sp_bank/sp_bank false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/xp1_002", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/CQ_S", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/XP4_Quake", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/DeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/TeamDeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/SP_Bank", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/Passage_CUTSCENE", s_Out, out s_Context);
            s_Context!.ProcessCommand("list_duplicate_chunks", s_Out, out s_Context);
            s_Context!.ProcessCommand("help", s_Out, out s_Context);
        }

        [Fact]
        public void TestThing2()
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(EngineType.Frostbite2_0);
            s_Mounter.Mount("B:\\Games\\Battlefield 3", true, EngineType.Frostbite2_0).Wait();

            Parallel.ForEach(s_Mounter.GetPartitions(), (p_Partition) =>
            {
                var s_Path = Path.Join("C:\\Research\\Venice\\Dump", p_Partition.Key + ".ebx");
                var s_Dir = Path.GetDirectoryName(s_Path);

                if (s_Path.Length >= 260)
                {
                    Debug.WriteLine("wew");
                }

                Debug.WriteLine(s_Path);

                Directory.CreateDirectory(s_Dir!);
                using var s_File = File.Create(s_Path);
                using var s_EbxReader = p_Partition.Value.FirstVariant.GetReader();

                s_EbxReader.CopyTo(s_File);
            });
        }
    }
}
