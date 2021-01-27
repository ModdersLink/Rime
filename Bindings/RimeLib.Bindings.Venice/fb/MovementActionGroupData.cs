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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class MovementActionGroupData : 
		MovementActionData
	{
		protected RefArray<MovementActionData> m_Actions = new RefArray<MovementActionData>();
		[ContainerField(Name: "Actions", Offset: 8, NameHash: 373511656, Flags: 65)]
		public RefArray<MovementActionData> Actions { get { return m_Actions; } set { if (OnPropertyChanging("MovementActionGroupData." + nameof(Actions), this, m_Actions, value)) m_Actions = value; } } // 0x8 (8)
		
		protected bool m_RunSimultaneously = new bool();
		[ContainerField(Name: "RunSimultaneously", Offset: 12, NameHash: 2322374336, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunSimultaneously { get { return m_RunSimultaneously; } set { if (OnPropertyChanging("MovementActionGroupData." + nameof(RunSimultaneously), this, m_RunSimultaneously, value)) m_RunSimultaneously = value; } } // 0xC (12)
		
		protected bool m_RestartChildren = new bool();
		[ContainerField(Name: "RestartChildren", Offset: 13, NameHash: 3914911489, Flags: 49325), LayoutImmutable, Blittable]
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
