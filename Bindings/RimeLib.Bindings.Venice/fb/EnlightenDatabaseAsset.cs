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
	[ContainerType(4, 36)]
	public class EnlightenDatabaseAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint DataVersion { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint DebugMeshDataVersion { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint OutputSizeX { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint OutputSizeY { get; set; }

		[ContainerField(28)]
		public List<EnlightenDbSystem> Systems { get; set; } = new();

		[ContainerField(32)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new();

		public static void Deserialize(EnlightenDatabaseAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DataVersion = p_Reader.ReadUInt32();
			p_Instance.DebugMeshDataVersion = p_Reader.ReadUInt32();
			p_Instance.OutputSizeX = p_Reader.ReadUInt32();
			p_Instance.OutputSizeY = p_Reader.ReadUInt32();
			p_Instance.Systems.Clear();
			(RimeReader Reader, uint Count) s_Systems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Systems.Count; ++i)
			{
				var s_Value = new EnlightenDbSystem();
				fb.EnlightenDbSystem.Deserialize(s_Value, s_Systems.Reader, p_Parser);
				p_Instance.Systems.Add(s_Value);
			}
			
			s_Systems.Reader.Dispose();
			p_Instance.LightProbeSets.Clear();
			(RimeReader Reader, uint Count) s_LightProbeSets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LightProbeSets.Count; ++i)
			{
				var s_Value = new EnlightenLightProbeSet();
				fb.EnlightenLightProbeSet.Deserialize(s_Value, s_LightProbeSets.Reader, p_Parser);
				p_Instance.LightProbeSets.Add(s_Value);
			}
			
			s_LightProbeSets.Reader.Dispose();
		}

	}
}
