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
	[ContainerType(4, 56)]
	public partial class StreamPoolAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _StreamPoolId;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _StreamBufferSizeXenon;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _StreamBufferSizePs3;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _StreamBufferSizeWin32;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _StreamCountXenon;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _StreamCountPs3;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _StreamCountWin32;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _StreamReadBlockSizeXenon;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _StreamReadBlockSizePs3;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _StreamReadBlockSizeWin32;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private StreamStarveMode _StreamStarveMode = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StreamPoolId);
			p_Writer.Write(StreamBufferSizeXenon);
			p_Writer.Write(StreamBufferSizePs3);
			p_Writer.Write(StreamBufferSizeWin32);
			p_Writer.Write(StreamCountXenon);
			p_Writer.Write(StreamCountPs3);
			p_Writer.Write(StreamCountWin32);
			p_Writer.Write(StreamReadBlockSizeXenon);
			p_Writer.Write(StreamReadBlockSizePs3);
			p_Writer.Write(StreamReadBlockSizeWin32);
			p_Writer.Write((int) StreamStarveMode);
		}
	}
}
