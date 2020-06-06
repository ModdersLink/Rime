///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class KitStateEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string Kit { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float SecondsAsKit { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457363:
					Kit = (string) p_Value;
					break;

				case 711562626:
					SecondsAsKit = (float) p_Value;
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
				case 193457363:
					return Kit;

				case 711562626:
					return SecondsAsKit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457363:
					return typeof(KitStateEvent).GetProperty(nameof(Kit));

				case 711562626:
					return typeof(KitStateEvent).GetProperty(nameof(SecondsAsKit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
