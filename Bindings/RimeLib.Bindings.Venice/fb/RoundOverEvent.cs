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
	public class RoundOverEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public int WinningTeam { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int TicketsLeft { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2949944838:
					WinningTeam = (int) p_Value;
					break;

				case 715127049:
					TicketsLeft = (int) p_Value;
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
				case 2949944838:
					return WinningTeam;

				case 715127049:
					return TicketsLeft;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2949944838:
					return typeof(RoundOverEvent).GetProperty(nameof(WinningTeam));

				case 715127049:
					return typeof(RoundOverEvent).GetProperty(nameof(TicketsLeft));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
