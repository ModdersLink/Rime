///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MobileSpawnComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMin { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float ParachuteSpawnDistance { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string NameSid { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMax { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool EnterMobileSpawnPoint { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4214298113:
					ParachuteSpawnRadiusMin = (float) p_Value;
					break;

				case 432257168:
					ParachuteSpawnDistance = (float) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 4214297887:
					ParachuteSpawnRadiusMax = (float) p_Value;
					break;

				case 1286056314:
					EnterMobileSpawnPoint = (bool) p_Value;
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
				case 4214298113:
					return ParachuteSpawnRadiusMin;

				case 432257168:
					return ParachuteSpawnDistance;

				case 3153745340:
					return NameSid;

				case 4214297887:
					return ParachuteSpawnRadiusMax;

				case 1286056314:
					return EnterMobileSpawnPoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4214298113:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnRadiusMin));

				case 432257168:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnDistance));

				case 3153745340:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(NameSid));

				case 4214297887:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnRadiusMax));

				case 1286056314:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(EnterMobileSpawnPoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
