///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 40)]
	public class WindowSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int PosX { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int PosY { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Width { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint Height { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool BordersEnable { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool AutoSize { get; set; }

		[ContainerField(30), LayoutImmutable, Blittable]
		public bool FullscreenAutoSize { get; set; }

		[ContainerField(31), LayoutImmutable, Blittable]
		public bool FullscreenWhenJoiningServer { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool EnableEscape { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnableInputOnActivate { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool HibernateOnClose { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool Hidden { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Minimized { get; set; }

		public static void Deserialize(WindowSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PosX = p_Reader.ReadInt32();
			p_Instance.PosY = p_Reader.ReadInt32();
			p_Instance.Width = p_Reader.ReadUInt32();
			p_Instance.Height = p_Reader.ReadUInt32();
			p_Instance.BordersEnable = p_Reader.ReadBool();
			p_Instance.AutoSize = p_Reader.ReadBool();
			p_Instance.FullscreenAutoSize = p_Reader.ReadBool();
			p_Instance.FullscreenWhenJoiningServer = p_Reader.ReadBool();
			p_Instance.EnableEscape = p_Reader.ReadBool();
			p_Instance.EnableInputOnActivate = p_Reader.ReadBool();
			p_Instance.HibernateOnClose = p_Reader.ReadBool();
			p_Instance.Hidden = p_Reader.ReadBool();
			p_Instance.Minimized = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
