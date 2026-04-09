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
	[ContainerType(16, 128)]
	public partial class InteractionEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _UseWithinRadius;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _UseWithinAngle;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private CtrRef<SoundAsset> _PreInteractionSoundEffect = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private uint _MaxUses;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _AllowInteractionViaRemoteEntry;

		[ObservableProperty]
		[property: ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		private bool _TestIfOccluded;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseWithinRadius);
			p_Writer.Write(UseWithinAngle);
			p_Writer.Write(p_EbxWriter.WriteImport(PreInteractionSoundEffect));
			p_Writer.Write(MaxUses);
			p_Writer.Write(AllowInteractionViaRemoteEntry);
			p_Writer.Write(TestIfOccluded);
			p_Writer.WriteNullBytes(14);
		}
	}
}
