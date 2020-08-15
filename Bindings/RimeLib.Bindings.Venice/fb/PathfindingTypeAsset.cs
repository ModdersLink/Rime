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
	[ContainerType(4)]
	public class PathfindingTypeAsset : 
		Asset
	{
		protected uint m_Index = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(214509467)]
		public uint Index { get { return m_Index; } set { if (OnPropertyChanging("PathfindingTypeAsset." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 214509467:
					Index = (uint) p_Value;
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
				case 214509467:
					return Index;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 214509467:
					return typeof(PathfindingTypeAsset).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
