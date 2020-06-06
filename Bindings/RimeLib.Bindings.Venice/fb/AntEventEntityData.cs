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
	public class AntEventEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<AntEventData> OnEnterEvents { get; set; } = new List<AntEventData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public List<AntEventData> OnUpdateEvents { get; set; } = new List<AntEventData>(); // 0x64 (100)
		
		[ContainerField(104)]
		public List<AntEventData> OnLeaveEvents { get; set; } = new List<AntEventData>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SendAsPlayerEvent { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool AutoActivate { get; set; } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3335046611:
					OnEnterEvents = (List<AntEventData>) p_Value;
					break;

				case 1556391722:
					OnUpdateEvents = (List<AntEventData>) p_Value;
					break;

				case 514519232:
					OnLeaveEvents = (List<AntEventData>) p_Value;
					break;

				case 2177775476:
					SendAsPlayerEvent = (bool) p_Value;
					break;

				case 778899923:
					AutoActivate = (bool) p_Value;
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
				case 3335046611:
					return OnEnterEvents;

				case 1556391722:
					return OnUpdateEvents;

				case 514519232:
					return OnLeaveEvents;

				case 2177775476:
					return SendAsPlayerEvent;

				case 778899923:
					return AutoActivate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3335046611:
					return typeof(AntEventEntityData).GetProperty(nameof(OnEnterEvents));

				case 1556391722:
					return typeof(AntEventEntityData).GetProperty(nameof(OnUpdateEvents));

				case 514519232:
					return typeof(AntEventEntityData).GetProperty(nameof(OnLeaveEvents));

				case 2177775476:
					return typeof(AntEventEntityData).GetProperty(nameof(SendAsPlayerEvent));

				case 778899923:
					return typeof(AntEventEntityData).GetProperty(nameof(AutoActivate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
