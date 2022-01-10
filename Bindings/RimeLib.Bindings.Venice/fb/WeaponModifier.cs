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
	[ContainerType(4, 232)]
	public class WeaponModifier
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int DummyToMakeFrostEDcompile { get; set; }
		
		public static void Deserialize(WeaponModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DummyToMakeFrostEDcompile = p_Reader.ReadInt32();
			p_Reader.Seek(228, SeekOrigin.Current);
		}
	}
}
