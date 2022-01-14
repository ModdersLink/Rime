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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class TargetCameraData :
		CameraData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public HudData Hud { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public RefArray<UIPartData> UIParts { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Hud.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_UIParts = p_EbxWriter.GetArrayWriter(UIParts.GetType(), UIParts.Count);
			p_Writer.Write(s_UIParts.ArrayIndex);
			foreach (var s_Entry in UIParts)
			{
				s_UIParts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.WriteNullBytes(8);
		}
	}
}
