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
	[ContainerType(4, 72)]
	public partial class NetworkSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _ProtocolVersion;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _TitleId = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _ClientPort;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _ServerPort;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _MaxGhostCount;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _MaxClientCount;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _MaxClientFrameSize;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _MaxServerFrameSize;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _XlspAddress = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _ServerAddress = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _ClientConnectionDebugFilePrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _ServerConnectionDebugFilePrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _TimeNudgeGhostFrequencyFactor;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _TimeNudgeBias;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _ConnectTimeout;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _UseFrameManager;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _TimeSyncEnabled;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _IncrementServerPortOnFail;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(ProtocolVersion);
			p_Writer.Write(p_EbxWriter.WriteString(TitleId));
			p_Writer.Write(ClientPort);
			p_Writer.Write(ServerPort);
			p_Writer.Write(MaxGhostCount);
			p_Writer.Write(MaxClientCount);
			p_Writer.Write(MaxClientFrameSize);
			p_Writer.Write(MaxServerFrameSize);
			p_Writer.Write(p_EbxWriter.WriteString(XlspAddress));
			p_Writer.Write(p_EbxWriter.WriteString(ServerAddress));
			p_Writer.Write(p_EbxWriter.WriteString(ClientConnectionDebugFilePrefix));
			p_Writer.Write(p_EbxWriter.WriteString(ServerConnectionDebugFilePrefix));
			p_Writer.Write(TimeNudgeGhostFrequencyFactor);
			p_Writer.Write(TimeNudgeBias);
			p_Writer.Write(ConnectTimeout);
			p_Writer.Write(UseFrameManager);
			p_Writer.Write(TimeSyncEnabled);
			p_Writer.Write(IncrementServerPortOnFail);
			p_Writer.WriteNullBytes(1);
		}
	}
}
