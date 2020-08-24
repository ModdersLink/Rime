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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class DestructionControllerComponentData : 
		ComponentData
	{
		protected RefArray<ObjectBlueprint> m_DebrisClusters = new RefArray<ObjectBlueprint>();
		[ContainerField(96), MemberInfoFlag(65), ContainerFieldNameHash(3290200503), ContainerRefArray]
		public RefArray<ObjectBlueprint> DebrisClusters { get { return m_DebrisClusters; } set { if (OnPropertyChanging("DestructionControllerComponentData." + nameof(DebrisClusters), this, m_DebrisClusters, value)) m_DebrisClusters = value; } } // 0x60 (96)
		
		protected bool m_AttachToNearbyObjects = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193040880)]
		public bool AttachToNearbyObjects { get { return m_AttachToNearbyObjects; } set { if (OnPropertyChanging("DestructionControllerComponentData." + nameof(AttachToNearbyObjects), this, m_AttachToNearbyObjects, value)) m_AttachToNearbyObjects = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3290200503:
					DebrisClusters = (RefArray<ObjectBlueprint>) p_Value;
					break;

				case 193040880:
					AttachToNearbyObjects = (bool) p_Value;
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
				case 3290200503:
					return DebrisClusters;

				case 193040880:
					return AttachToNearbyObjects;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3290200503:
					return typeof(DestructionControllerComponentData).GetProperty(nameof(DebrisClusters));

				case 193040880:
					return typeof(DestructionControllerComponentData).GetProperty(nameof(AttachToNearbyObjects));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
