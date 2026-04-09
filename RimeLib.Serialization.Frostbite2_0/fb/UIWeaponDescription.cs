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
	[ContainerType(4, 60)]
	public partial class UIWeaponDescription :
		UIItemDescription
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _Name = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _UnlockName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _Description = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _Category = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _TexturePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _IconTexturePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _UnlockTexturePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _Ammo = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _RateOfFire = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _Range = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _FireModeSingle;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _FireModeBurst;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _FireModeAuto;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _HiddenInProgression;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(UnlockName));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			p_Writer.Write(p_EbxWriter.WriteString(Category));
			p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(IconTexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(UnlockTexturePath));
			p_Writer.Write(p_EbxWriter.WriteString(Ammo));
			p_Writer.Write(p_EbxWriter.WriteString(RateOfFire));
			p_Writer.Write(p_EbxWriter.WriteString(Range));
			p_Writer.Write(FireModeSingle);
			p_Writer.Write(FireModeBurst);
			p_Writer.Write(FireModeAuto);
			p_Writer.Write(HiddenInProgression);
		}
	}
}
