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
	[ContainerType(4, 48)]
	public partial class RibbonData :
		VisualVectorShapeData
	{
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private List<RibbonPointData> _RibbonPoints = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_RibbonPoints = p_EbxWriter.GetArrayWriter(RibbonPoints.GetType(), RibbonPoints.Count);
			p_Writer.Write(s_RibbonPoints.ArrayIndex);
			foreach (var s_Entry in RibbonPoints)
			{
				s_Entry.Serialize(s_RibbonPoints.Writer, p_EbxWriter);
			}
		}
	}
}
