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
	public class DuplicateSpawnScopeStrategyData : 
		SoundScopeStrategyData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Distance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ClosestCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool GroupTypes { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089313744:
					Time = (float) p_Value;
					break;

				case 408560070:
					Distance = (float) p_Value;
					break;

				case 4143870103:
					ClosestCount = (uint) p_Value;
					break;

				case 1801246673:
					GroupTypes = (bool) p_Value;
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
				case 2089313744:
					return Time;

				case 408560070:
					return Distance;

				case 4143870103:
					return ClosestCount;

				case 1801246673:
					return GroupTypes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089313744:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(Time));

				case 408560070:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(Distance));

				case 4143870103:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(ClosestCount));

				case 1801246673:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(GroupTypes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
