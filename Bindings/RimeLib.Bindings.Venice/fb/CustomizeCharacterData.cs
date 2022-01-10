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
	[ContainerType(4, 32)]
	public class CustomizeCharacterData : 
		Asset
	{
		[ContainerField(12)]
		public List<CustomizeVisual> VisualGroups { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float OverrideCriticalHealthThreshold { get; set; }

		[ContainerField(20)]
		public List<CtrRef<UnlockAssetBase>> Unlocks { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float OverrideMaxHealth { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool ClearVisualState { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool RestoreToOriginalVisualState { get; set; }

		public static void Deserialize(CustomizeCharacterData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VisualGroups.Clear();
			(RimeReader Reader, uint Count) s_VisualGroups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VisualGroups.Count; ++i)
			{
				var s_Value = new CustomizeVisual();
				fb.CustomizeVisual.Deserialize(s_Value, s_VisualGroups.Reader, p_Parser);
				p_Instance.VisualGroups.Add(s_Value);
			}
			
			s_VisualGroups.Reader.Dispose();
			p_Instance.OverrideCriticalHealthThreshold = p_Reader.ReadSingle();
			p_Instance.Unlocks.Clear();
			(RimeReader Reader, uint Count) s_Unlocks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Unlocks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UnlockAssetBase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Unlocks.Reader.ReadUInt32()));
				p_Instance.Unlocks.Add(s_CtrRef);
			}
			
			s_Unlocks.Reader.Dispose();
			p_Instance.OverrideMaxHealth = p_Reader.ReadSingle();
			p_Instance.ClearVisualState = p_Reader.ReadBool();
			p_Instance.RestoreToOriginalVisualState = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
