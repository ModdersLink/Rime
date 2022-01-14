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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 96)]
	public class LookAtEntityData :
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool RunOnce { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool UseStaticDirection { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RunOnce);
			p_Writer.Write(UseStaticDirection);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(13);
		}
	}
}
