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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class MovementActionGroupData : 
		MovementActionData
	{
		protected RefArray<MovementActionData> m_Actions = new RefArray<MovementActionData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(373511656), ContainerRefArray]
		public RefArray<MovementActionData> Actions { get { return m_Actions; } set { if (OnPropertyChanging("MovementActionGroupData." + nameof(Actions), this, m_Actions, value)) m_Actions = value; } } // 0x8 (8)
		
		protected bool m_RunSimultaneously = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2322374336)]
		public bool RunSimultaneously { get { return m_RunSimultaneously; } set { if (OnPropertyChanging("MovementActionGroupData." + nameof(RunSimultaneously), this, m_RunSimultaneously, value)) m_RunSimultaneously = value; } } // 0xC (12)
		
		protected bool m_RestartChildren = new bool();
		[ContainerField(13), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3914911489)]
		public bool RestartChildren { get { return m_RestartChildren; } set { if (OnPropertyChanging("MovementActionGroupData." + nameof(RestartChildren), this, m_RestartChildren, value)) m_RestartChildren = value; } } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 373511656:
					Actions = (RefArray<MovementActionData>) p_Value;
					break;

				case 2322374336:
					RunSimultaneously = (bool) p_Value;
					break;

				case 3914911489:
					RestartChildren = (bool) p_Value;
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
				case 373511656:
					return Actions;

				case 2322374336:
					return RunSimultaneously;

				case 3914911489:
					return RestartChildren;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 373511656:
					return typeof(MovementActionGroupData).GetProperty(nameof(Actions));

				case 2322374336:
					return typeof(MovementActionGroupData).GetProperty(nameof(RunSimultaneously));

				case 3914911489:
					return typeof(MovementActionGroupData).GetProperty(nameof(RestartChildren));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
