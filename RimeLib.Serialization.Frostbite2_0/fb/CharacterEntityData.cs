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
	[ContainerType(16, 160)]
	public partial class CharacterEntityData :
		ControllableEntityData
	{
		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private PersonViewMode _DefaultViewMode = new();

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private PlayerSpawnType _PlayerSpawnType = new();

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _CharacterLightingEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) DefaultViewMode);
			p_Writer.Write((int) PlayerSpawnType);
			p_Writer.Write(CharacterLightingEnable);
			p_Writer.WriteNullBytes(7);
		}
	}
}
