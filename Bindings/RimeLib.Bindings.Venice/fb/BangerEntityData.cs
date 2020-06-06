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
    [ContainerType(16)]
	public class BangerEntityData : 
		DynamicGamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<float> Scales { get; set; } = new List<float>(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint DestructiblePartCount { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool UseVariableNetworkFrequency { get; set; } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3335406670:
					Scales = (List<float>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 2222171184:
					Explosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 1571456733:
					TimeToLive = (float) p_Value;
					break;

				case 539039685:
					DestructiblePartCount = (uint) p_Value;
					break;

				case 1010950522:
					UseVariableNetworkFrequency = (bool) p_Value;
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
				case 3335406670:
					return Scales;

				case 2088783990:
					return Mesh;

				case 2222171184:
					return Explosion;

				case 1571456733:
					return TimeToLive;

				case 539039685:
					return DestructiblePartCount;

				case 1010950522:
					return UseVariableNetworkFrequency;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3335406670:
					return typeof(BangerEntityData).GetProperty(nameof(Scales));

				case 2088783990:
					return typeof(BangerEntityData).GetProperty(nameof(Mesh));

				case 2222171184:
					return typeof(BangerEntityData).GetProperty(nameof(Explosion));

				case 1571456733:
					return typeof(BangerEntityData).GetProperty(nameof(TimeToLive));

				case 539039685:
					return typeof(BangerEntityData).GetProperty(nameof(DestructiblePartCount));

				case 1010950522:
					return typeof(BangerEntityData).GetProperty(nameof(UseVariableNetworkFrequency));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
