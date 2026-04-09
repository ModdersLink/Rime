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
	public partial class SoldierHeadCollisionData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _HeadRadius;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<SoldierHeadCollisionPoseData> _PoseStates = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(HeadRadius);
			(RimeWriter Writer, uint ArrayIndex) s_PoseStates = p_EbxWriter.GetArrayWriter(PoseStates.GetType(), PoseStates.Count);
			p_Writer.Write(s_PoseStates.ArrayIndex);
			foreach (var s_Entry in PoseStates)
			{
				s_Entry.Serialize(s_PoseStates.Writer, p_EbxWriter);
			}
		}
	}
}
