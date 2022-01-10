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
	[ContainerType(4, 16)]
	public class GameAnimationConfig : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ServerEnable { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool ClientEnable { get; set; }

		[ContainerField(14), LayoutImmutable, Blittable]
		public bool UseRawGamepadInput { get; set; }

		public static void Deserialize(GameAnimationConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ServerEnable = p_Reader.ReadBool();
			p_Instance.ClientEnable = p_Reader.ReadBool();
			p_Instance.UseRawGamepadInput = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
