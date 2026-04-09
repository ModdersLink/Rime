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
	public partial class EntitlementQuery :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<EntitlementData> _EntitlementsData = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<string> _GroupNames = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private GamePlatform _Platform = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _EntitlementTag = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _ProductId = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _ProjectId = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_EntitlementsData = p_EbxWriter.GetArrayWriter(EntitlementsData.GetType(), EntitlementsData.Count);
			p_Writer.Write(s_EntitlementsData.ArrayIndex);
			foreach (var s_Entry in EntitlementsData)
			{
				s_Entry.Serialize(s_EntitlementsData.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_GroupNames = p_EbxWriter.GetArrayWriter(GroupNames.GetType(), GroupNames.Count);
			p_Writer.Write(s_GroupNames.ArrayIndex);
			foreach (var s_Entry in GroupNames)
			{
				s_GroupNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write((int) Platform);
			p_Writer.Write(p_EbxWriter.WriteString(EntitlementTag));
			p_Writer.Write(p_EbxWriter.WriteString(ProductId));
			p_Writer.Write(p_EbxWriter.WriteString(ProjectId));
		}
	}
}
