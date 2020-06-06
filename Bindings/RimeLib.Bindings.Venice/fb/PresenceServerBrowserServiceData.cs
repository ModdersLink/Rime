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
	public class PresenceServerBrowserServiceData : 
		PresenceServiceData
	{
		[ContainerField(12)]
		public MatchmakingCriteria FilterCriterias { get; set; } = new MatchmakingCriteria(); // 0xC (12)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint ListCapacity { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4095044485:
					FilterCriterias = (MatchmakingCriteria) p_Value;
					break;

				case 2930314355:
					ListCapacity = (uint) p_Value;
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
				case 4095044485:
					return FilterCriterias;

				case 2930314355:
					return ListCapacity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4095044485:
					return typeof(PresenceServerBrowserServiceData).GetProperty(nameof(FilterCriterias));

				case 2930314355:
					return typeof(PresenceServerBrowserServiceData).GetProperty(nameof(ListCapacity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
