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
	public partial class UISettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private UISystemType _System = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<UIBundlesAsset> _Bundles = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<ProfileOptionsAsset> _ProfileOptions = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private LanguageFormat _Language = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private DataCopSettings _DataCop = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _OneBundlePerGraph;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _DrawEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) System);
			p_Writer.Write(p_EbxWriter.WriteImport(Bundles));
			p_Writer.Write(p_EbxWriter.WriteImport(ProfileOptions));
			p_Writer.Write((int) Language);
			DataCop.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(OneBundlePerGraph);
			p_Writer.Write(DrawEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
