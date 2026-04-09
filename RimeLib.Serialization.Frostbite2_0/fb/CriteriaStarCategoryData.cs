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
	public partial class CriteriaStarCategoryData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<CriteriaStarCategoryInstance> _CriteriaInstances = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_CriteriaInstances = p_EbxWriter.GetArrayWriter(CriteriaInstances.GetType(), CriteriaInstances.Count);
			p_Writer.Write(s_CriteriaInstances.ArrayIndex);
			foreach (var s_Entry in CriteriaInstances)
			{
				s_Entry.Serialize(s_CriteriaInstances.Writer, p_EbxWriter);
			}
		}
	}
}
