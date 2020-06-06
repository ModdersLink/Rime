///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PresenceBackendData : 
		Asset
	{
		[ContainerField(12)]
		public List<PresenceRequest> Requests { get; set; } = new List<PresenceRequest>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3064423:
					if (p_Value.GetType() == typeof (List<uint>))
						Requests = ((List<uint>) p_Value).Select(x => (PresenceRequest) Enum.ToObject(typeof(PresenceRequest), x)).ToList();
					else
						Requests = (List<PresenceRequest>) p_Value;
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
				case 3064423:
					return Requests;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3064423:
					return typeof(PresenceBackendData).GetProperty(nameof(Requests));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
