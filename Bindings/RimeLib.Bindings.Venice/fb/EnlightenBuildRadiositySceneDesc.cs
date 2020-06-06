///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class EnlightenBuildRadiositySceneDesc : 
		DataContainer
	{
		[ContainerField(8)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new List<EnlightenLightProbeSet>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<EnlightenInputInstance> Instances { get; set; } = new List<EnlightenInputInstance>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<Vec3> StaticLightProbes { get; set; } = new List<Vec3>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string Terrain { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint SamplesPerCluster { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float SystemInfluenceRadius { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint SystemSize { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint IrBudget { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ClusterSize { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool SaveDebugData { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool DistributedBuild { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool CacheEnable { get; set; } // 0x2E (46)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3933473824:
					LightProbeSets = (List<EnlightenLightProbeSet>) p_Value;
					break;

				case 3890087583:
					Instances = (List<EnlightenInputInstance>) p_Value;
					break;

				case 2948767738:
					StaticLightProbes = (List<Vec3>) p_Value;
					break;

				case 3173545970:
					Terrain = (string) p_Value;
					break;

				case 4004061885:
					SamplesPerCluster = (uint) p_Value;
					break;

				case 4129099021:
					SystemInfluenceRadius = (float) p_Value;
					break;

				case 280201861:
					SystemSize = (uint) p_Value;
					break;

				case 4184612187:
					IrBudget = (uint) p_Value;
					break;

				case 2116207210:
					ClusterSize = (float) p_Value;
					break;

				case 4026935077:
					SaveDebugData = (bool) p_Value;
					break;

				case 3046543104:
					DistributedBuild = (bool) p_Value;
					break;

				case 2232305320:
					CacheEnable = (bool) p_Value;
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
				case 3933473824:
					return LightProbeSets;

				case 3890087583:
					return Instances;

				case 2948767738:
					return StaticLightProbes;

				case 3173545970:
					return Terrain;

				case 4004061885:
					return SamplesPerCluster;

				case 4129099021:
					return SystemInfluenceRadius;

				case 280201861:
					return SystemSize;

				case 4184612187:
					return IrBudget;

				case 2116207210:
					return ClusterSize;

				case 4026935077:
					return SaveDebugData;

				case 3046543104:
					return DistributedBuild;

				case 2232305320:
					return CacheEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3933473824:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(LightProbeSets));

				case 3890087583:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(Instances));

				case 2948767738:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(StaticLightProbes));

				case 3173545970:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(Terrain));

				case 4004061885:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(SamplesPerCluster));

				case 4129099021:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(SystemInfluenceRadius));

				case 280201861:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(SystemSize));

				case 4184612187:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(IrBudget));

				case 2116207210:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(ClusterSize));

				case 4026935077:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(SaveDebugData));

				case 3046543104:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(DistributedBuild));

				case 2232305320:
					return typeof(EnlightenBuildRadiositySceneDesc).GetProperty(nameof(CacheEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
