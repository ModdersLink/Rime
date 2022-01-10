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
	public class AnimatedSkeletonDatabase : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<RagdollAsset>> Ragdolls { get; set; } = new();

		[ContainerField(12)]
		public List<AnimatedSkeletonDatabaseItem> Items { get; set; } = new();

		public static void Deserialize(AnimatedSkeletonDatabase p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Ragdolls.Clear();
			(RimeReader Reader, uint Count) s_Ragdolls = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Ragdolls.Count; ++i)
			{
				var s_CtrRef = new CtrRef<RagdollAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Ragdolls.Reader.ReadUInt32()));
				p_Instance.Ragdolls.Add(s_CtrRef);
			}
			
			s_Ragdolls.Reader.Dispose();
			p_Instance.Items.Clear();
			(RimeReader Reader, uint Count) s_Items = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Items.Count; ++i)
			{
				var s_Value = new AnimatedSkeletonDatabaseItem();
				fb.AnimatedSkeletonDatabaseItem.Deserialize(s_Value, s_Items.Reader, p_Parser);
				p_Instance.Items.Add(s_Value);
			}
			
			s_Items.Reader.Dispose();
		}

	}
}
