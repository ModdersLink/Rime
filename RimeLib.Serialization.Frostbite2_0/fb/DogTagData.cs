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
	[ContainerType(4, 68)]
	public partial class DogTagData :
		UnlockAssetBase
	{
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _NameSID = string.Empty;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		private string _DescriptionSID = string.Empty;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		private string _ImageName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, JsonProperty(Order = 52)]
		private string _SmallImageName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private DogTagCategory _Category = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _InvertText;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _IsAlwaysAvailable;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _ExcludedOnXenon;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _ExcludedOnPs3;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _ExcludedOnWin32;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(NameSID));
			p_Writer.Write(p_EbxWriter.WriteString(DescriptionSID));
			p_Writer.Write(p_EbxWriter.WriteString(ImageName));
			p_Writer.Write(p_EbxWriter.WriteString(SmallImageName));
			p_Writer.Write((int) Category);
			p_Writer.Write(InvertText);
			p_Writer.Write(IsAlwaysAvailable);
			p_Writer.Write(ExcludedOnXenon);
			p_Writer.Write(ExcludedOnPs3);
			p_Writer.Write(ExcludedOnWin32);
			p_Writer.WriteNullBytes(3);
		}
	}
}
