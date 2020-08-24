///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class EnlightenPipelineTerrainMesh : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 UvTranslation { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox(); // 0x10 (16)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec4 UvTransform { get; set; } = new Vec4(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint LightMapResolution { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, MemberInfoFlag(16509)]
		public string TerrainMeshName { get; set; } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2805972397:
					UvTranslation = (Vec2) p_Value;
					break;

				case 2648132290:
					BoundingBox = (AxisAlignedBox) p_Value;
					break;

				case 2858488202:
					UvTransform = (Vec4) p_Value;
					break;

				case 2797852905:
					LightMapResolution = (uint) p_Value;
					break;

				case 1156977350:
					TerrainMeshName = (string) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2805972397:
					return UvTranslation;

				case 2648132290:
					return BoundingBox;

				case 2858488202:
					return UvTransform;

				case 2797852905:
					return LightMapResolution;

				case 1156977350:
					return TerrainMeshName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2805972397:
					return typeof(EnlightenPipelineTerrainMesh).GetProperty(nameof(UvTranslation));

				case 2648132290:
					return typeof(EnlightenPipelineTerrainMesh).GetProperty(nameof(BoundingBox));

				case 2858488202:
					return typeof(EnlightenPipelineTerrainMesh).GetProperty(nameof(UvTransform));

				case 2797852905:
					return typeof(EnlightenPipelineTerrainMesh).GetProperty(nameof(LightMapResolution));

				case 1156977350:
					return typeof(EnlightenPipelineTerrainMesh).GetProperty(nameof(TerrainMeshName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
