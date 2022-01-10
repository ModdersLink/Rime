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
	[ContainerType(16, 112)]
	public class AntDrivenComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AnimationDrivenBinding CharacterGameState { get; set; } = new();

		public static void Deserialize(AntDrivenComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AnimationDrivenBinding.Deserialize(p_Instance.CharacterGameState, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
