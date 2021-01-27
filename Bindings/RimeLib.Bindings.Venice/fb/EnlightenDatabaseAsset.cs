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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class EnlightenDatabaseAsset : 
		Asset
	{
		protected uint m_DataVersion = new uint();
		[ContainerField(Name: "DataVersion", Offset: 12, NameHash: 3409245615, Flags: 49421), LayoutImmutable, Blittable]
		public uint DataVersion { get { return m_DataVersion; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(DataVersion), this, m_DataVersion, value)) m_DataVersion = value; } } // 0xC (12)
		
		protected uint m_DebugMeshDataVersion = new uint();
		[ContainerField(Name: "DebugMeshDataVersion", Offset: 16, NameHash: 2953964973, Flags: 49421), LayoutImmutable, Blittable]
		public uint DebugMeshDataVersion { get { return m_DebugMeshDataVersion; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(DebugMeshDataVersion), this, m_DebugMeshDataVersion, value)) m_DebugMeshDataVersion = value; } } // 0x10 (16)
		
		protected uint m_OutputSizeX = new uint();
		[ContainerField(Name: "OutputSizeX", Offset: 20, NameHash: 734302791, Flags: 49421), LayoutImmutable, Blittable]
		public uint OutputSizeX { get { return m_OutputSizeX; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(OutputSizeX), this, m_OutputSizeX, value)) m_OutputSizeX = value; } } // 0x14 (20)
		
		protected uint m_OutputSizeY = new uint();
		[ContainerField(Name: "OutputSizeY", Offset: 24, NameHash: 734302790, Flags: 49421), LayoutImmutable, Blittable]
		public uint OutputSizeY { get { return m_OutputSizeY; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(OutputSizeY), this, m_OutputSizeY, value)) m_OutputSizeY = value; } } // 0x18 (24)
		
		protected List<EnlightenDbSystem> m_Systems = new List<EnlightenDbSystem>();
		[ContainerField(Name: "Systems", Offset: 28, NameHash: 2622499059, Flags: 65)]
		public List<EnlightenDbSystem> Systems { get { return m_Systems; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(Systems), this, m_Systems, value)) m_Systems = value; } } // 0x1C (28)
		
		protected List<EnlightenLightProbeSet> m_LightProbeSets = new List<EnlightenLightProbeSet>();
		[ContainerField(Name: "LightProbeSets", Offset: 32, NameHash: 3933473824, Flags: 65)]
		public List<EnlightenLightProbeSet> LightProbeSets { get { return m_LightProbeSets; } set { if (OnPropertyChanging("EnlightenDatabaseAsset." + nameof(LightProbeSets), this, m_LightProbeSets, value)) m_LightProbeSets = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3409245615:
					DataVersion = (uint) p_Value;
					break;

				case 2953964973:
					DebugMeshDataVersion = (uint) p_Value;
					break;

				case 734302791:
					OutputSizeX = (uint) p_Value;
					break;

				case 734302790:
					OutputSizeY = (uint) p_Value;
					break;

				case 2622499059:
					Systems = (List<EnlightenDbSystem>) p_Value;
					break;

				case 3933473824:
					LightProbeSets = (List<EnlightenLightProbeSet>) p_Value;
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
				case 3409245615:
					return DataVersion;

				case 2953964973:
					return DebugMeshDataVersion;

				case 734302791:
					return OutputSizeX;

				case 734302790:
					return OutputSizeY;

				case 2622499059:
					return Systems;

				case 3933473824:
					return LightProbeSets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3409245615:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(DataVersion));

				case 2953964973:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(DebugMeshDataVersion));

				case 734302791:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(OutputSizeX));

				case 734302790:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(OutputSizeY));

				case 2622499059:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(Systems));

				case 3933473824:
					return typeof(EnlightenDatabaseAsset).GetProperty(nameof(LightProbeSets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
