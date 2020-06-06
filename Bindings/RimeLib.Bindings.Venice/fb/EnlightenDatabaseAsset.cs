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
	public class EnlightenDatabaseAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint DataVersion { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint DebugMeshDataVersion { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint OutputSizeX { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint OutputSizeY { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public List<EnlightenDbSystem> Systems { get; set; } = new List<EnlightenDbSystem>(); // 0x1C (28)
		
		[ContainerField(32)]
		public List<EnlightenLightProbeSet> LightProbeSets { get; set; } = new List<EnlightenLightProbeSet>(); // 0x20 (32)
		
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
