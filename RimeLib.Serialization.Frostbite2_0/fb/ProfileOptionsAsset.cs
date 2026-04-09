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
	[ContainerType(4, 32)]
	public partial class ProfileOptionsAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _FileName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _ContentName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _FileSize;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<ProfileOptionData> _Options = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _AutoSaveOnQuit;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(FileName));
			p_Writer.Write(p_EbxWriter.WriteString(ContentName));
			p_Writer.Write(FileSize);
			(RimeWriter Writer, uint ArrayIndex) s_Options = p_EbxWriter.GetArrayWriter(Options.GetType(), Options.Count);
			p_Writer.Write(s_Options.ArrayIndex);
			foreach (var s_Entry in Options)
			{
				s_Options.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AutoSaveOnQuit);
			p_Writer.WriteNullBytes(3);
		}
	}
}
