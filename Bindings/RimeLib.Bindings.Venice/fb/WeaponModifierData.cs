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
	[ContainerType(4, 8)]
	public class WeaponModifierData
	{
		[ContainerField(0)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();
		
		[ContainerField(4)]
		public List<CtrRef<WeaponModifierBase>> Modifiers { get; set; } = new();
		
		public static void Deserialize(WeaponModifierData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Modifiers.Clear();
			(RimeReader Reader, uint Count) s_Modifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Modifiers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<WeaponModifierBase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Modifiers.Reader.ReadUInt32()));
				p_Instance.Modifiers.Add(s_CtrRef);
			}
			
			s_Modifiers.Reader.Dispose();
		}
	}
}
