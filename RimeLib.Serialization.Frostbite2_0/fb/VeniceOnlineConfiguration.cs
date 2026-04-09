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
	[ContainerType(4, 40)]
	public partial class VeniceOnlineConfiguration :
		OnlineConfiguration
	{
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<OnlinePlatformConfiguration> _Platforms = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<EntitlementQuery> _EntitlementQueries = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _UseFallback;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Platforms = p_EbxWriter.GetArrayWriter(Platforms.GetType(), Platforms.Count);
			p_Writer.Write(s_Platforms.ArrayIndex);
			foreach (var s_Entry in Platforms)
			{
				s_Entry.Serialize(s_Platforms.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_EntitlementQueries = p_EbxWriter.GetArrayWriter(EntitlementQueries.GetType(), EntitlementQueries.Count);
			p_Writer.Write(s_EntitlementQueries.ArrayIndex);
			foreach (var s_Entry in EntitlementQueries)
			{
				s_EntitlementQueries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(UseFallback);
			p_Writer.WriteNullBytes(3);
		}
	}
}
