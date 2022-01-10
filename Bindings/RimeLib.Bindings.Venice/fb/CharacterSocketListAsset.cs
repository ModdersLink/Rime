///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class CharacterSocketListAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<SocketData>> GameplaySockets { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<SocketData>> RigidVisualSockets { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<SocketData>> SkinnedVisualSockets { get; set; } = new();

		public static void Deserialize(CharacterSocketListAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.GameplaySockets.Clear();
			(RimeReader Reader, uint Count) s_GameplaySockets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GameplaySockets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SocketData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_GameplaySockets.Reader.ReadUInt32()));
				p_Instance.GameplaySockets.Add(s_CtrRef);
			}
			
			s_GameplaySockets.Reader.Dispose();
			p_Instance.RigidVisualSockets.Clear();
			(RimeReader Reader, uint Count) s_RigidVisualSockets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_RigidVisualSockets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SocketData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_RigidVisualSockets.Reader.ReadUInt32()));
				p_Instance.RigidVisualSockets.Add(s_CtrRef);
			}
			
			s_RigidVisualSockets.Reader.Dispose();
			p_Instance.SkinnedVisualSockets.Clear();
			(RimeReader Reader, uint Count) s_SkinnedVisualSockets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SkinnedVisualSockets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SocketData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SkinnedVisualSockets.Reader.ReadUInt32()));
				p_Instance.SkinnedVisualSockets.Add(s_CtrRef);
			}
			
			s_SkinnedVisualSockets.Reader.Dispose();
		}

	}
}
