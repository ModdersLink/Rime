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
	[ContainerType(16, 144)]
	public class BangerEntityData : 
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<float> Scales { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint DestructiblePartCount { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool UseVariableNetworkFrequency { get; set; }

		public static void Deserialize(BangerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Scales.Clear();
			(RimeReader Reader, uint Count) s_Scales = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Scales.Count; ++i)
			{
				var s_Value = s_Scales.Reader.ReadSingle();
				p_Instance.Scales.Add(s_Value);
			}
			
			s_Scales.Reader.Dispose();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Explosion.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TimeToLive = p_Reader.ReadSingle();
			p_Instance.DestructiblePartCount = p_Reader.ReadUInt32();
			p_Instance.UseVariableNetworkFrequency = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
