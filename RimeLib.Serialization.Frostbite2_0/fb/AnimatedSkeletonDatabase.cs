///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 16)]
	public partial class AnimatedSkeletonDatabase :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<RagdollAsset> _Ragdolls = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<AnimatedSkeletonDatabaseItem> _Items = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_Ragdolls = p_EbxWriter.GetArrayWriter(Ragdolls.GetType(), Ragdolls.Count);
			p_Writer.Write(s_Ragdolls.ArrayIndex);
			foreach (var s_Entry in Ragdolls)
			{
				s_Ragdolls.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Items = p_EbxWriter.GetArrayWriter(Items.GetType(), Items.Count);
			p_Writer.Write(s_Items.ArrayIndex);
			foreach (var s_Entry in Items)
			{
				s_Entry.Serialize(s_Items.Writer, p_EbxWriter);
			}
		}
	}
}
