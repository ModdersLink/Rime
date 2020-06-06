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
	public class VoiceOverTriggerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public RefArray<VoiceOverTriggerParameter> Parameters { get; set; } = new RefArray<VoiceOverTriggerParameter>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Delay { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new CtrRef<VoiceOverEvent>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3325515039:
					Parameters = (RefArray<VoiceOverTriggerParameter>) p_Value;
					break;

				case 208768368:
					Delay = (float) p_Value;
					break;

				case 201427689:
					Event = (CtrRef<VoiceOverEvent>) p_Value;
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
				case 3325515039:
					return Parameters;

				case 208768368:
					return Delay;

				case 201427689:
					return Event;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3325515039:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Parameters));

				case 208768368:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Delay));

				case 201427689:
					return typeof(VoiceOverTriggerNode).GetProperty(nameof(Event));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
