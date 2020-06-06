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
	public class DebugEventInput : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort E { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RequireTriggeredAndSet { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177632:
					E = (AudioGraphNodePort) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 850664216:
					RequireTriggeredAndSet = (bool) p_Value;
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
				case 177632:
					return E;

				case 2088949890:
					return Name;

				case 850664216:
					return RequireTriggeredAndSet;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177632:
					return typeof(DebugEventInput).GetProperty(nameof(E));

				case 2088949890:
					return typeof(DebugEventInput).GetProperty(nameof(Name));

				case 850664216:
					return typeof(DebugEventInput).GetProperty(nameof(RequireTriggeredAndSet));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
