///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 52)]
	public partial class DemoSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _RecordDemoFileName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _PlaybackDemoFileName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _TimeDemo = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _LockToPlayerName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _ChangePlayerInterval;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _ForcedDeltaTickCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _StartProfilingOnFrame;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _StopProfilingOnFrame;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _TakeScreenshotOnFrame;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _AllowOverwrite;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _LogPerformance;

		[ObservableProperty]
		[property: ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		private bool _SuppressDebugLog;

		[ObservableProperty]
		[property: ContainerField(47), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
		private bool _ShutdownOnDemoComplete;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _LoopingDemo;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _LockToRandomPlayer;

		[ObservableProperty]
		[property: ContainerField(50), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
		private bool _PauseOnStartup;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteString(RecordDemoFileName));
			p_Writer.Write(p_EbxWriter.WriteString(PlaybackDemoFileName));
			p_Writer.Write(p_EbxWriter.WriteString(TimeDemo));
			p_Writer.Write(p_EbxWriter.WriteString(LockToPlayerName));
			p_Writer.Write(ChangePlayerInterval);
			p_Writer.Write(ForcedDeltaTickCount);
			p_Writer.Write(StartProfilingOnFrame);
			p_Writer.Write(StopProfilingOnFrame);
			p_Writer.Write(TakeScreenshotOnFrame);
			p_Writer.Write(AllowOverwrite);
			p_Writer.Write(LogPerformance);
			p_Writer.Write(SuppressDebugLog);
			p_Writer.Write(ShutdownOnDemoComplete);
			p_Writer.Write(LoopingDemo);
			p_Writer.Write(LockToRandomPlayer);
			p_Writer.Write(PauseOnStartup);
			p_Writer.WriteNullBytes(1);
		}
	}
}
