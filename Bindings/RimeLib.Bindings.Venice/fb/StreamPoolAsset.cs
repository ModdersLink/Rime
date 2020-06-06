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
	public class StreamPoolAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint StreamPoolId { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint StreamBufferSizeXenon { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint StreamBufferSizePs3 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint StreamBufferSizeWin32 { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint StreamCountXenon { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint StreamCountPs3 { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint StreamCountWin32 { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizeXenon { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizePs3 { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint StreamReadBlockSizeWin32 { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public StreamStarveMode StreamStarveMode { get; set; } = new StreamStarveMode(); // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 797330728:
					StreamPoolId = (uint) p_Value;
					break;

				case 3173825006:
					StreamBufferSizeXenon = (uint) p_Value;
					break;

				case 4167740684:
					StreamBufferSizePs3 = (uint) p_Value;
					break;

				case 3184351085:
					StreamBufferSizeWin32 = (uint) p_Value;
					break;

				case 1930216744:
					StreamCountXenon = (uint) p_Value;
					break;

				case 2624511690:
					StreamCountPs3 = (uint) p_Value;
					break;

				case 1944928555:
					StreamCountWin32 = (uint) p_Value;
					break;

				case 3422200789:
					StreamReadBlockSizeXenon = (uint) p_Value;
					break;

				case 2006662711:
					StreamReadBlockSizePs3 = (uint) p_Value;
					break;

				case 3411957846:
					StreamReadBlockSizeWin32 = (uint) p_Value;
					break;

				case 577139037:
					StreamStarveMode = (StreamStarveMode) Enum.ToObject(typeof(StreamStarveMode), p_Value);
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
				case 797330728:
					return StreamPoolId;

				case 3173825006:
					return StreamBufferSizeXenon;

				case 4167740684:
					return StreamBufferSizePs3;

				case 3184351085:
					return StreamBufferSizeWin32;

				case 1930216744:
					return StreamCountXenon;

				case 2624511690:
					return StreamCountPs3;

				case 1944928555:
					return StreamCountWin32;

				case 3422200789:
					return StreamReadBlockSizeXenon;

				case 2006662711:
					return StreamReadBlockSizePs3;

				case 3411957846:
					return StreamReadBlockSizeWin32;

				case 577139037:
					return StreamStarveMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 797330728:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamPoolId));

				case 3173825006:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamBufferSizeXenon));

				case 4167740684:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamBufferSizePs3));

				case 3184351085:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamBufferSizeWin32));

				case 1930216744:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamCountXenon));

				case 2624511690:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamCountPs3));

				case 1944928555:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamCountWin32));

				case 3422200789:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamReadBlockSizeXenon));

				case 2006662711:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamReadBlockSizePs3));

				case 3411957846:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamReadBlockSizeWin32));

				case 577139037:
					return typeof(StreamPoolAsset).GetProperty(nameof(StreamStarveMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
