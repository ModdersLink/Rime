///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class StreamPoolAsset : 
		Asset
	{
		protected uint m_StreamPoolId = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(797330728)]
		public uint StreamPoolId { get { return m_StreamPoolId; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamPoolId), this, m_StreamPoolId, value)) m_StreamPoolId = value; } } // 0xC (12)
		
		protected uint m_StreamBufferSizeXenon = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3173825006)]
		public uint StreamBufferSizeXenon { get { return m_StreamBufferSizeXenon; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamBufferSizeXenon), this, m_StreamBufferSizeXenon, value)) m_StreamBufferSizeXenon = value; } } // 0x10 (16)
		
		protected uint m_StreamBufferSizePs3 = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4167740684)]
		public uint StreamBufferSizePs3 { get { return m_StreamBufferSizePs3; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamBufferSizePs3), this, m_StreamBufferSizePs3, value)) m_StreamBufferSizePs3 = value; } } // 0x14 (20)
		
		protected uint m_StreamBufferSizeWin32 = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3184351085)]
		public uint StreamBufferSizeWin32 { get { return m_StreamBufferSizeWin32; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamBufferSizeWin32), this, m_StreamBufferSizeWin32, value)) m_StreamBufferSizeWin32 = value; } } // 0x18 (24)
		
		protected uint m_StreamCountXenon = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1930216744)]
		public uint StreamCountXenon { get { return m_StreamCountXenon; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamCountXenon), this, m_StreamCountXenon, value)) m_StreamCountXenon = value; } } // 0x1C (28)
		
		protected uint m_StreamCountPs3 = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2624511690)]
		public uint StreamCountPs3 { get { return m_StreamCountPs3; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamCountPs3), this, m_StreamCountPs3, value)) m_StreamCountPs3 = value; } } // 0x20 (32)
		
		protected uint m_StreamCountWin32 = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1944928555)]
		public uint StreamCountWin32 { get { return m_StreamCountWin32; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamCountWin32), this, m_StreamCountWin32, value)) m_StreamCountWin32 = value; } } // 0x24 (36)
		
		protected uint m_StreamReadBlockSizeXenon = new uint();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3422200789)]
		public uint StreamReadBlockSizeXenon { get { return m_StreamReadBlockSizeXenon; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamReadBlockSizeXenon), this, m_StreamReadBlockSizeXenon, value)) m_StreamReadBlockSizeXenon = value; } } // 0x28 (40)
		
		protected uint m_StreamReadBlockSizePs3 = new uint();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2006662711)]
		public uint StreamReadBlockSizePs3 { get { return m_StreamReadBlockSizePs3; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamReadBlockSizePs3), this, m_StreamReadBlockSizePs3, value)) m_StreamReadBlockSizePs3 = value; } } // 0x2C (44)
		
		protected uint m_StreamReadBlockSizeWin32 = new uint();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3411957846)]
		public uint StreamReadBlockSizeWin32 { get { return m_StreamReadBlockSizeWin32; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamReadBlockSizeWin32), this, m_StreamReadBlockSizeWin32, value)) m_StreamReadBlockSizeWin32 = value; } } // 0x30 (48)
		
		protected StreamStarveMode m_StreamStarveMode = new StreamStarveMode();
		[ContainerField(52), MemberInfoFlag(137), ContainerFieldNameHash(577139037)]
		public StreamStarveMode StreamStarveMode { get { return m_StreamStarveMode; } set { if (OnPropertyChanging("StreamPoolAsset." + nameof(StreamStarveMode), this, m_StreamStarveMode, value)) m_StreamStarveMode = value; } } // 0x34 (52)
		
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
