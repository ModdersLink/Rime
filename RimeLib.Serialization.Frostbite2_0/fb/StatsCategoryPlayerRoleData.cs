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
	[ContainerType(4, 24)]
	public partial class StatsCategoryPlayerRoleData :
		StatsCategoryBaseData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<PlayerRole> _Roles = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Roles = p_EbxWriter.GetArrayWriter(Roles.GetType(), Roles.Count);
			p_Writer.Write(s_Roles.ArrayIndex);
			foreach (var s_Entry in Roles)
			{
				s_Roles.Writer.Write((int) s_Entry);
			}
		}
	}
}
