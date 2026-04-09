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
	[ContainerType(4, 20)]
	public partial class MeleeWeaponData :
		WeaponData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _UseCannedAnimation;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _UseSphereDamage;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseCannedAnimation);
			p_Writer.Write(UseSphereDamage);
			p_Writer.WriteNullBytes(2);
		}
	}
}
