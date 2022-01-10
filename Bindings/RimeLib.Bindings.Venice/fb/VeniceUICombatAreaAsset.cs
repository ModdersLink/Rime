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
	[ContainerType(4, 24)]
	public class VeniceUICombatAreaAsset : 
		UICombatAreaAsset
	{
		[ContainerField(16)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<UIDistanceFieldAsset> SurroundingDistanceField { get; set; } = new();

		public static void Deserialize(VeniceUICombatAreaAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DistanceField.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SurroundingDistanceField.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
