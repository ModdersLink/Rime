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

namespace fb
{
	[ContainerType(4, 24)]
	public class CharacterSocketListAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<SocketData> GameplaySockets { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<SocketData> RigidVisualSockets { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<SocketData> SkinnedVisualSockets { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_GameplaySockets = p_EbxWriter.GetArrayWriter(GameplaySockets.GetType(), GameplaySockets.Count);
			p_Writer.Write(s_GameplaySockets.ArrayIndex);
			foreach (var s_Entry in GameplaySockets)
			{
				s_GameplaySockets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_RigidVisualSockets = p_EbxWriter.GetArrayWriter(RigidVisualSockets.GetType(), RigidVisualSockets.Count);
			p_Writer.Write(s_RigidVisualSockets.ArrayIndex);
			foreach (var s_Entry in RigidVisualSockets)
			{
				s_RigidVisualSockets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_SkinnedVisualSockets = p_EbxWriter.GetArrayWriter(SkinnedVisualSockets.GetType(), SkinnedVisualSockets.Count);
			p_Writer.Write(s_SkinnedVisualSockets.ArrayIndex);
			foreach (var s_Entry in SkinnedVisualSockets)
			{
				s_SkinnedVisualSockets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
