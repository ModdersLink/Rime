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
	public class UrgencyUserData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<UrgencyUserData> Base { get; set; } = new();

		[ContainerField(12)]
		public List<UrgencyModifierData> UrgencyModifiers { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<UrgencySetData>> ModifierSets { get; set; } = new();

		public static void Deserialize(UrgencyUserData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Base.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UrgencyModifiers.Clear();
			(RimeReader Reader, uint Count) s_UrgencyModifiers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UrgencyModifiers.Count; ++i)
			{
				var s_Value = new UrgencyModifierData();
				fb.UrgencyModifierData.Deserialize(s_Value, s_UrgencyModifiers.Reader, p_Parser);
				p_Instance.UrgencyModifiers.Add(s_Value);
			}
			
			s_UrgencyModifiers.Reader.Dispose();
			p_Instance.ModifierSets.Clear();
			(RimeReader Reader, uint Count) s_ModifierSets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ModifierSets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UrgencySetData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ModifierSets.Reader.ReadUInt32()));
				p_Instance.ModifierSets.Add(s_CtrRef);
			}
			
			s_ModifierSets.Reader.Dispose();
		}

	}
}
