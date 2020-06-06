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
	public class RichPresenceContext : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<RichPresenceContextValue> Values { get; set; } = new RefArray<RichPresenceContextValue>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<RichPresenceContextValue> DefaultValue { get; set; } = new CtrRef<RichPresenceContextValue>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public sbyte Index { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3142410589:
					Values = (RefArray<RichPresenceContextValue>) p_Value;
					break;

				case 2066049125:
					DefaultValue = (CtrRef<RichPresenceContextValue>) p_Value;
					break;

				case 214509467:
					Index = (sbyte) p_Value;
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

				case 3142410589:
					return Values;

				case 2066049125:
					return DefaultValue;

				case 214509467:
					return Index;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(RichPresenceContext).GetProperty(nameof(Name));

				case 3142410589:
					return typeof(RichPresenceContext).GetProperty(nameof(Values));

				case 2066049125:
					return typeof(RichPresenceContext).GetProperty(nameof(DefaultValue));

				case 214509467:
					return typeof(RichPresenceContext).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
