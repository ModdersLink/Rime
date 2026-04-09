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
	[ContainerType(4, 52)]
	public partial class SearchAndDestroyOrderEntityData :
		BFOrderEntityData
	{
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private TargetPosKnowledgeType _TargetPosKnowledge = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _FindTargetTime;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _TargetAreaFollowsTarget;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _Aggressive;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) TargetPosKnowledge);
			p_Writer.Write(FindTargetTime);
			p_Writer.Write(TargetAreaFollowsTarget);
			p_Writer.Write(Aggressive);
			p_Writer.WriteNullBytes(2);
		}
	}
}
