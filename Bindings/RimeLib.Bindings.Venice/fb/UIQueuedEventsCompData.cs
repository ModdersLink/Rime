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
	public class UIQueuedEventsCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float InitialQueueDelay { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool ShowUnlocksBecomingAvailable { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3503517055:
					InitialQueueDelay = (float) p_Value;
					break;

				case 3270144506:
					ShowUnlocksBecomingAvailable = (bool) p_Value;
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
				case 3503517055:
					return InitialQueueDelay;

				case 3270144506:
					return ShowUnlocksBecomingAvailable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3503517055:
					return typeof(UIQueuedEventsCompData).GetProperty(nameof(InitialQueueDelay));

				case 3270144506:
					return typeof(UIQueuedEventsCompData).GetProperty(nameof(ShowUnlocksBecomingAvailable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
