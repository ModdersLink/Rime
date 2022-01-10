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
	[ContainerType(4, 20)]
	public class SoldierWeaponMultiUnlock : 
		UnlockUserDataBase
	{
		[ContainerField(12)]
		public CtrRef<UnlockAssetBase> First { get; set; } = new();

		[ContainerField(16)]
		public List<UnlockAssetPair> UnlockAssetPairs { get; set; } = new();

		public static void Deserialize(SoldierWeaponMultiUnlock p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.First.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UnlockAssetPairs.Clear();
			(RimeReader Reader, uint Count) s_UnlockAssetPairs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnlockAssetPairs.Count; ++i)
			{
				var s_Value = new UnlockAssetPair();
				fb.UnlockAssetPair.Deserialize(s_Value, s_UnlockAssetPairs.Reader, p_Parser);
				p_Instance.UnlockAssetPairs.Add(s_Value);
			}
			
			s_UnlockAssetPairs.Reader.Dispose();
		}

	}
}
