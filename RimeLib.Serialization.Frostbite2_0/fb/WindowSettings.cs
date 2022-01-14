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
	[ContainerType(4, 40)]
	public class WindowSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public int PosX { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int PosY { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint Width { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint Height { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool BordersEnable { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool AutoSize { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		public bool FullscreenAutoSize { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		public bool FullscreenWhenJoiningServer { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool EnableEscape { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool EnableInputOnActivate { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool HibernateOnClose { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		public bool Hidden { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool Minimized { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PosX);
			p_Writer.Write(PosY);
			p_Writer.Write(Width);
			p_Writer.Write(Height);
			p_Writer.Write(BordersEnable);
			p_Writer.Write(AutoSize);
			p_Writer.Write(FullscreenAutoSize);
			p_Writer.Write(FullscreenWhenJoiningServer);
			p_Writer.Write(EnableEscape);
			p_Writer.Write(EnableInputOnActivate);
			p_Writer.Write(HibernateOnClose);
			p_Writer.Write(Hidden);
			p_Writer.Write(Minimized);
			p_Writer.WriteNullBytes(3);
		}
	}
}
