///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PartComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RefArray<HealthStateData> HealthStates { get; set; } = new RefArray<HealthStateData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new RefArray<PartLinkData>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool IsSupported { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsFragile { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool IsNetworkable { get; set; } // 0x6A (106)
		
		[ContainerField(107), LayoutImmutable, Blittable]
		public bool IsWindow { get; set; } // 0x6B (107)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2256734877:
					HealthStates = (RefArray<HealthStateData>) p_Value;
					break;

				case 3210318177:
					PartLinks = (RefArray<PartLinkData>) p_Value;
					break;

				case 797903537:
					IsSupported = (bool) p_Value;
					break;

				case 3219228557:
					IsFragile = (bool) p_Value;
					break;

				case 4000919755:
					IsNetworkable = (bool) p_Value;
					break;

				case 290846451:
					IsWindow = (bool) p_Value;
					break;

				case 443997333:
					AnimatePhysics = (bool) p_Value;
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
				case 2256734877:
					return HealthStates;

				case 3210318177:
					return PartLinks;

				case 797903537:
					return IsSupported;

				case 3219228557:
					return IsFragile;

				case 4000919755:
					return IsNetworkable;

				case 290846451:
					return IsWindow;

				case 443997333:
					return AnimatePhysics;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2256734877:
					return typeof(PartComponentData).GetProperty(nameof(HealthStates));

				case 3210318177:
					return typeof(PartComponentData).GetProperty(nameof(PartLinks));

				case 797903537:
					return typeof(PartComponentData).GetProperty(nameof(IsSupported));

				case 3219228557:
					return typeof(PartComponentData).GetProperty(nameof(IsFragile));

				case 4000919755:
					return typeof(PartComponentData).GetProperty(nameof(IsNetworkable));

				case 290846451:
					return typeof(PartComponentData).GetProperty(nameof(IsWindow));

				case 443997333:
					return typeof(PartComponentData).GetProperty(nameof(AnimatePhysics));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
