///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SyncAnimationsEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float NearEndEventTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool StartServerPaused { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 960001067:
					NearEndEventTime = (float) p_Value;
					break;

				case 2407205110:
					StartServerPaused = (bool) p_Value;
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
				case 2162678253:
					return ExternalTime;

				case 960001067:
					return NearEndEventTime;

				case 2407205110:
					return StartServerPaused;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2162678253:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(ExternalTime));

				case 960001067:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(NearEndEventTime));

				case 2407205110:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(StartServerPaused));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
