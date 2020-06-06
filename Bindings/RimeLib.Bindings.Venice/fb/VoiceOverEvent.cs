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
	public class VoiceOverEvent : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<VoiceOverNamedValue> Parameters { get; set; } = new RefArray<VoiceOverNamedValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverLogicAsset> Owner { get; set; } = new CtrRef<VoiceOverLogicAsset>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3325515039:
					Parameters = (RefArray<VoiceOverNamedValue>) p_Value;
					break;

				case 217695012:
					Owner = (CtrRef<VoiceOverLogicAsset>) p_Value;
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
				case 2088949890:
					return Name;

				case 3325515039:
					return Parameters;

				case 217695012:
					return Owner;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(VoiceOverEvent).GetProperty(nameof(Name));

				case 3325515039:
					return typeof(VoiceOverEvent).GetProperty(nameof(Parameters));

				case 217695012:
					return typeof(VoiceOverEvent).GetProperty(nameof(Owner));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
