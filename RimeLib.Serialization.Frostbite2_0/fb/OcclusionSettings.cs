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
	[ContainerType(4, 12)]
	public partial class OcclusionSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _DrawZbuffer;

		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _DrawBinaryBuffer;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(Enable);
			p_Writer.Write(DrawZbuffer);
			p_Writer.Write(DrawBinaryBuffer);
			p_Writer.WriteNullBytes(1);
		}
	}
}
