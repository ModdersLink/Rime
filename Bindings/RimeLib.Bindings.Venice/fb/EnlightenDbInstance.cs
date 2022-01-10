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
	[ContainerType(16, 192)]
	public class EnlightenDbInstance
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox WorldBoundingbox { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform WorldTransform { get; set; } = new();
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 UvTranslation { get; set; } = new();
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UvTransform { get; set; } = new();
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint GeometryId { get; set; }
		
		[ContainerField(132), LayoutImmutable]
		public string ObjectVariation { get; set; } = string.Empty;
		
		[ContainerField(136), LayoutImmutable]
		public string GuidString { get; set; } = string.Empty;
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public uint UvSizeX { get; set; }
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint UvSizeY { get; set; }
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float PixelSize { get; set; }
		
		[ContainerField(152), LayoutImmutable]
		public string EnlightenMeshName { get; set; } = string.Empty;
		
		[ContainerField(156), LayoutImmutable]
		public string MeshAsset { get; set; } = string.Empty;
		
		[ContainerField(160)]
		public List<ulong> InstanceAlbedos { get; set; } = new();
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public GUID CacheKey { get; set; }
		
		public static void Deserialize(EnlightenDbInstance p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AxisAlignedBox.Deserialize(p_Instance.WorldBoundingbox, p_Reader, p_Parser);
			fb.LinearTransform.Deserialize(p_Instance.WorldTransform, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.UvTranslation, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.UvTransform, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.GeometryId = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ObjectVariation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.GuidString = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UvSizeX = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UvSizeY = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PixelSize = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.EnlightenMeshName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.MeshAsset = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.InstanceAlbedos.Clear();
			(RimeReader Reader, uint Count) s_InstanceAlbedos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InstanceAlbedos.Count; ++i)
			{
				var s_Value = s_InstanceAlbedos.Reader.ReadUInt64();
				p_Instance.InstanceAlbedos.Add(s_Value);
			}
			
			s_InstanceAlbedos.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CacheKey = new GUID(p_Reader);
			p_Reader.Seek(20, SeekOrigin.Current);
		}
	}
}
