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
	[ContainerType(4, 12)]
	public class UnlockWeaponAndSlot
	{
		[ContainerField(0)]
		public CtrRef<SoldierWeaponUnlockAsset> Weapon { get; set; } = new();
		
		[ContainerField(4)]
		public WeaponSlot Slot { get; set; } = new();
		
		[ContainerField(8)]
		public List<CtrRef<UnlockAssetBase>> UnlockAssets { get; set; } = new();
		
		public static void Deserialize(UnlockWeaponAndSlot p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Weapon.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Slot = (WeaponSlot) p_Reader.ReadInt32();
			p_Instance.UnlockAssets.Clear();
			(RimeReader Reader, uint Count) s_UnlockAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockAssetBase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UnlockAssets.Reader.ReadUInt32()));
				p_Instance.UnlockAssets.Add(s_CtrRef);
			}
			
			s_UnlockAssets.Reader.Dispose();
		}
	}
}
