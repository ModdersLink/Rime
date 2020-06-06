///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AwardHeaderData : 
		AbstractAwardData
	{
		[ContainerField(12)]
		public AwardGroup Group { get; set; } = new AwardGroup(); // 0xC (12)
		
		[ContainerField(16)]
		public StatsMultiplicity Multiplicity { get; set; } = new StatsMultiplicity(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208130522:
					Group = (AwardGroup) Enum.ToObject(typeof(AwardGroup), p_Value);
					break;

				case 2648087582:
					Multiplicity = (StatsMultiplicity) Enum.ToObject(typeof(StatsMultiplicity), p_Value);
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
				case 208130522:
					return Group;

				case 2648087582:
					return Multiplicity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208130522:
					return typeof(AwardHeaderData).GetProperty(nameof(Group));

				case 2648087582:
					return typeof(AwardHeaderData).GetProperty(nameof(Multiplicity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
