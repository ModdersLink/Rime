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
	[ContainerType(4, 36)]
	public partial class ConditionGroup :
		AudioGraphNodePortGroup
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _X = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Y = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _True = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private ConditionType _Condition = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			X.Serialize(p_Writer, p_EbxWriter);
			Y.Serialize(p_Writer, p_EbxWriter);
			True.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Condition);
		}
	}
}
