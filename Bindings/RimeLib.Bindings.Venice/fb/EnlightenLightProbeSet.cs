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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(160), ContainerStruct]
	public class EnlightenLightProbeSet : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x0 (0)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox(); // 0x40 (64)
		
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint SizeX { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint SizeZ { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint SizeY { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int SystemId { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float BlendDistance { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int Priority { get; set; } // 0x74 (116)
		
		[ContainerField(120), MemberInfoFlag(65), ContainerArray]
		public List<Vec3> Positions { get; set; } = new List<Vec3>(); // 0x78 (120)
		
		[ContainerField(124), MemberInfoFlag(65), ContainerArray]
		public List<uint> ValidIndices { get; set; } = new List<uint>(); // 0x7C (124)
		
		[ContainerField(128), MemberInfoFlag(65), ContainerArray]
		public List<int> InputSystems { get; set; } = new List<int>(); // 0x80 (128)
		
		[ContainerField(132), MemberInfoFlag(41)]
		public PrecomputeCache Cache { get; set; } = new PrecomputeCache(); // 0x84 (132)
		
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool StaticProbeSet { get; set; } // 0x9C (156)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 2648132290:
					BoundingBox = (AxisAlignedBox) p_Value;
					break;

				case 231688536:
					SizeX = (uint) p_Value;
					break;

				case 231688538:
					SizeZ = (uint) p_Value;
					break;

				case 231688537:
					SizeY = (uint) p_Value;
					break;

				case 643121549:
					SystemId = (int) p_Value;
					break;

				case 1435233063:
					BlendDistance = (float) p_Value;
					break;

				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 616073487:
					Positions = (List<Vec3>) p_Value;
					break;

				case 1822652428:
					ValidIndices = (List<uint>) p_Value;
					break;

				case 3312183461:
					InputSystems = (List<int>) p_Value;
					break;

				case 212453833:
					Cache = (PrecomputeCache) p_Value;
					break;

				case 928615733:
					StaticProbeSet = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 2648132290:
					return BoundingBox;

				case 231688536:
					return SizeX;

				case 231688538:
					return SizeZ;

				case 231688537:
					return SizeY;

				case 643121549:
					return SystemId;

				case 1435233063:
					return BlendDistance;

				case 3062102871:
					return Priority;

				case 616073487:
					return Positions;

				case 1822652428:
					return ValidIndices;

				case 3312183461:
					return InputSystems;

				case 212453833:
					return Cache;

				case 928615733:
					return StaticProbeSet;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(Transform));

				case 2648132290:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(BoundingBox));

				case 231688536:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(SizeX));

				case 231688538:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(SizeZ));

				case 231688537:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(SizeY));

				case 643121549:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(SystemId));

				case 1435233063:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(BlendDistance));

				case 3062102871:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(Priority));

				case 616073487:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(Positions));

				case 1822652428:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(ValidIndices));

				case 3312183461:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(InputSystems));

				case 212453833:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(Cache));

				case 928615733:
					return typeof(EnlightenLightProbeSet).GetProperty(nameof(StaticProbeSet));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
