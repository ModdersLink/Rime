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
	[ContainerType(4, 12)]
	public partial class CharacterStateData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private RefArray<CharacterStatePoseInfo> _PoseInfo = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_PoseInfo = p_EbxWriter.GetArrayWriter(PoseInfo.GetType(), PoseInfo.Count);
			p_Writer.Write(s_PoseInfo.ArrayIndex);
			foreach (var s_Entry in PoseInfo)
			{
				s_PoseInfo.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
