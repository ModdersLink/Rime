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
	[ContainerType(4, 28)]
	public partial class DecalSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _StaticBufferMaxVertexCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _RingBufferMaxVertexCount;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private bool _DrawEnable;

		[ObservableProperty]
		[property: ContainerField(21), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
		private bool _SystemEnable2;

		[ObservableProperty]
		[property: ContainerField(22), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
		private bool _SystemEnable;

		[ObservableProperty]
		[property: ContainerField(23), LayoutImmutable, Blittable, JsonProperty(Order = 23)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _DebugMemUsageEnable;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _DebugWarningsEnable;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private bool _NvidiaStreamOutputWorkaroundEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StaticBufferMaxVertexCount);
			p_Writer.Write(RingBufferMaxVertexCount);
			p_Writer.Write(DrawEnable);
			p_Writer.Write(SystemEnable2);
			p_Writer.Write(SystemEnable);
			p_Writer.Write(Enable);
			p_Writer.Write(DebugMemUsageEnable);
			p_Writer.Write(DebugWarningsEnable);
			p_Writer.Write(NvidiaStreamOutputWorkaroundEnable);
			p_Writer.WriteNullBytes(1);
		}
	}
}
