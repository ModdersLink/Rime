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
	public class CameraParamsComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearPlane { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float SunShadowmapViewDistance { get; set; } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 3156145579:
					NearPlane = (float) p_Value;
					break;

				case 2626774393:
					SunShadowmapViewDistance = (float) p_Value;
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
				case 2201945291:
					return ViewDistance;

				case 3156145579:
					return NearPlane;

				case 2626774393:
					return SunShadowmapViewDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2201945291:
					return typeof(CameraParamsComponentData).GetProperty(nameof(ViewDistance));

				case 3156145579:
					return typeof(CameraParamsComponentData).GetProperty(nameof(NearPlane));

				case 2626774393:
					return typeof(CameraParamsComponentData).GetProperty(nameof(SunShadowmapViewDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
