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
	public class HavokAsset : 
		Asset
	{
		protected float m_Scale = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(231223453)]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("HavokAsset." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0xC (12)
		
		protected RefArray<DataContainer> m_ExternalAssets = new RefArray<DataContainer>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(1938270811), ContainerRefArray]
		public RefArray<DataContainer> ExternalAssets { get { return m_ExternalAssets; } set { if (OnPropertyChanging("HavokAsset." + nameof(ExternalAssets), this, m_ExternalAssets, value)) m_ExternalAssets = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231223453:
					Scale = (float) p_Value;
					break;

				case 1938270811:
					ExternalAssets = (RefArray<DataContainer>) p_Value;
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
				case 231223453:
					return Scale;

				case 1938270811:
					return ExternalAssets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231223453:
					return typeof(HavokAsset).GetProperty(nameof(Scale));

				case 1938270811:
					return typeof(HavokAsset).GetProperty(nameof(ExternalAssets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
