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
	[ContainerType(16, 128)]
	public class WeaponEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<WeaponStateData> WeaponStates { get; set; } = new();

		[ContainerField(100)]
		public WeaponClassEnum WeaponClass { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new();

		public static void Deserialize(WeaponEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WeaponStates.Clear();
			(RimeReader Reader, uint Count) s_WeaponStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WeaponStates.Count; ++i)
			{
				var s_Value = new WeaponStateData();
				fb.WeaponStateData.Deserialize(s_Value, s_WeaponStates.Reader, p_Parser);
				p_Instance.WeaponStates.Add(s_Value);
			}
			
			s_WeaponStates.Reader.Dispose();
			p_Instance.WeaponClass = (WeaponClassEnum) p_Reader.ReadInt32();
			p_Instance.AIData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WeaponFiring.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CustomWeaponType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
