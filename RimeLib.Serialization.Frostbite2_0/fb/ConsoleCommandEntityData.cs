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
	public partial class ConsoleCommandEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<string> _Commands = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private Realm _Realm = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Commands = p_EbxWriter.GetArrayWriter(Commands.GetType(), Commands.Count);
			p_Writer.Write(s_Commands.ArrayIndex);
			foreach (var s_Entry in Commands)
			{
				s_Commands.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write((int) Realm);
		}
	}
}
