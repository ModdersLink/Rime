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
	public partial class MovementActionRandomizerData :
		MovementActionData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<MovementActionData> _Actions = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _ReinsertIntoRandomizedListAfterUse;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Actions = p_EbxWriter.GetArrayWriter(Actions.GetType(), Actions.Count);
			p_Writer.Write(s_Actions.ArrayIndex);
			foreach (var s_Entry in Actions)
			{
				s_Actions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(ReinsertIntoRandomizedListAfterUse);
			p_Writer.WriteNullBytes(3);
		}
	}
}
