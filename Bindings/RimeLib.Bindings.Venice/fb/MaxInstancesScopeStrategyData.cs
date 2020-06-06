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
	public class MaxInstancesScopeStrategyData : 
		SoundScopeStrategyData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint Count { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool KeepOldest { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 212413894:
					Count = (uint) p_Value;
					break;

				case 135411227:
					KeepOldest = (bool) p_Value;
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
				case 212413894:
					return Count;

				case 135411227:
					return KeepOldest;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 212413894:
					return typeof(MaxInstancesScopeStrategyData).GetProperty(nameof(Count));

				case 135411227:
					return typeof(MaxInstancesScopeStrategyData).GetProperty(nameof(KeepOldest));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
