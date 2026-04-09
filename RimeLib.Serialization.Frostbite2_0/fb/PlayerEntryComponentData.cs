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
	[ContainerType(16, 224)]
	public partial class PlayerEntryComponentData :
		EntryComponentData
	{
		[ObservableProperty]
		[property: ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private Vec3 _AnimationAccelerationMultiplier = new();

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private AntEntryIdEnum _AntEntryId = new();

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, JsonProperty(Order = 212)]
		private string _AntEntryID = string.Empty;

		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private CtrRef<AntEnumeration> _AntEntryEnumeration = new();

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _ShieldedTransitionExitTime;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AnimationAccelerationMultiplier.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) AntEntryId);
			p_Writer.Write(p_EbxWriter.WriteString(AntEntryID));
			p_Writer.Write(p_EbxWriter.WriteImport(AntEntryEnumeration));
			p_Writer.Write(ShieldedTransitionExitTime);
		}
	}
}
