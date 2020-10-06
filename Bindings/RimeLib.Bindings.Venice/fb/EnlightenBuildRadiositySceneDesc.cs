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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class EnlightenBuildRadiositySceneDesc : 
		DataContainer
	{
		protected List<EnlightenLightProbeSet> m_LightProbeSets = new List<EnlightenLightProbeSet>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(3933473824), ContainerArray]
		public List<EnlightenLightProbeSet> LightProbeSets { get { return m_LightProbeSets; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(LightProbeSets), this, m_LightProbeSets, value)) m_LightProbeSets = value; } } // 0x8 (8)
		
		protected List<EnlightenInputInstance> m_Instances = new List<EnlightenInputInstance>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(3890087583), ContainerArray]
		public List<EnlightenInputInstance> Instances { get { return m_Instances; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(Instances), this, m_Instances, value)) m_Instances = value; } } // 0xC (12)
		
		protected List<Vec3> m_StaticLightProbes = new List<Vec3>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2948767738), ContainerArray]
		public List<Vec3> StaticLightProbes { get { return m_StaticLightProbes; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(StaticLightProbes), this, m_StaticLightProbes, value)) m_StaticLightProbes = value; } } // 0x10 (16)
		
		protected string m_Terrain = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3173545970)]
		public string Terrain { get { return m_Terrain; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(Terrain), this, m_Terrain, value)) m_Terrain = value; } } // 0x14 (20)
		
		protected uint m_SamplesPerCluster = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4004061885)]
		public uint SamplesPerCluster { get { return m_SamplesPerCluster; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(SamplesPerCluster), this, m_SamplesPerCluster, value)) m_SamplesPerCluster = value; } } // 0x18 (24)
		
		protected float m_SystemInfluenceRadius = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4129099021)]
		public float SystemInfluenceRadius { get { return m_SystemInfluenceRadius; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(SystemInfluenceRadius), this, m_SystemInfluenceRadius, value)) m_SystemInfluenceRadius = value; } } // 0x1C (28)
		
		protected uint m_SystemSize = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(280201861)]
		public uint SystemSize { get { return m_SystemSize; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(SystemSize), this, m_SystemSize, value)) m_SystemSize = value; } } // 0x20 (32)
		
		protected uint m_IrBudget = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4184612187)]
		public uint IrBudget { get { return m_IrBudget; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(IrBudget), this, m_IrBudget, value)) m_IrBudget = value; } } // 0x24 (36)
		
		protected float m_ClusterSize = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2116207210)]
		public float ClusterSize { get { return m_ClusterSize; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(ClusterSize), this, m_ClusterSize, value)) m_ClusterSize = value; } } // 0x28 (40)
		
		protected bool m_SaveDebugData = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4026935077)]
		public bool SaveDebugData { get { return m_SaveDebugData; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(SaveDebugData), this, m_SaveDebugData, value)) m_SaveDebugData = value; } } // 0x2C (44)
		
		protected bool m_DistributedBuild = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3046543104)]
		public bool DistributedBuild { get { return m_DistributedBuild; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(DistributedBuild), this, m_DistributedBuild, value)) m_DistributedBuild = value; } } // 0x2D (45)
		
		protected bool m_CacheEnable = new bool();
		[ContainerField(46), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2232305320)]
		public bool CacheEnable { get { return m_CacheEnable; } set { if (OnPropertyChanging("EnlightenBuildRadiositySceneDesc." + nameof(CacheEnable), this, m_CacheEnable, value)) m_CacheEnable = value; } } // 0x2E (46)
		
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
