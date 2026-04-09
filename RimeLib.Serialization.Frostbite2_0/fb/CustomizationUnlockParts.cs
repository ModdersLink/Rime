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
	[ContainerType(4, 16)]
	public partial class CustomizationUnlockParts :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _UICategorySid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<UnlockAssetBase> _SelectableUnlocks = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteString(UICategorySid));
			(RimeWriter Writer, uint ArrayIndex) s_SelectableUnlocks = p_EbxWriter.GetArrayWriter(SelectableUnlocks.GetType(), SelectableUnlocks.Count);
			p_Writer.Write(s_SelectableUnlocks.ArrayIndex);
			foreach (var s_Entry in SelectableUnlocks)
			{
				s_SelectableUnlocks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
