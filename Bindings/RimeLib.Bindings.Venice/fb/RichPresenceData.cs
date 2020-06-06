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
    [ContainerType(4)]
	public class RichPresenceData : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<RichPresencePresenceString> PresenceModes { get; set; } = new RefArray<RichPresencePresenceString>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<RichPresencePresenceString> DefaultMode { get; set; } = new CtrRef<RichPresencePresenceString>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<RichPresencePresenceString> InactiveMode { get; set; } = new CtrRef<RichPresencePresenceString>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<RichPresenceContext> Contexts { get; set; } = new RefArray<RichPresenceContext>(); // 0x18 (24)
		
		[ContainerField(28)]
		public List<RichPresenceProperty> Properties { get; set; } = new List<RichPresenceProperty>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1792573772:
					PresenceModes = (RefArray<RichPresencePresenceString>) p_Value;
					break;

				case 2014189229:
					DefaultMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 2860645485:
					InactiveMode = (CtrRef<RichPresencePresenceString>) p_Value;
					break;

				case 333666601:
					Contexts = (RefArray<RichPresenceContext>) p_Value;
					break;

				case 1506334468:
					Properties = (List<RichPresenceProperty>) p_Value;
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
				case 1792573772:
					return PresenceModes;

				case 2014189229:
					return DefaultMode;

				case 2860645485:
					return InactiveMode;

				case 333666601:
					return Contexts;

				case 1506334468:
					return Properties;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1792573772:
					return typeof(RichPresenceData).GetProperty(nameof(PresenceModes));

				case 2014189229:
					return typeof(RichPresenceData).GetProperty(nameof(DefaultMode));

				case 2860645485:
					return typeof(RichPresenceData).GetProperty(nameof(InactiveMode));

				case 333666601:
					return typeof(RichPresenceData).GetProperty(nameof(Contexts));

				case 1506334468:
					return typeof(RichPresenceData).GetProperty(nameof(Properties));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
