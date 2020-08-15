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
	public class MaterialRelationTerrainDestructionData : 
		PhysicsPropertyRelationPropertyData
	{
		protected float m_Width = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(226981187)]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("MaterialRelationTerrainDestructionData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x8 (8)
		
		protected float m_Depth = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(208780552)]
		public float Depth { get { return m_Depth; } set { if (OnPropertyChanging("MaterialRelationTerrainDestructionData." + nameof(Depth), this, m_Depth, value)) m_Depth = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 208780552:
					Depth = (float) p_Value;
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
				case 226981187:
					return Width;

				case 208780552:
					return Depth;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(MaterialRelationTerrainDestructionData).GetProperty(nameof(Width));

				case 208780552:
					return typeof(MaterialRelationTerrainDestructionData).GetProperty(nameof(Depth));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
