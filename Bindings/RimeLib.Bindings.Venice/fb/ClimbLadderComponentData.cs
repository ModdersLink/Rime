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
	[ContainerType(16)]
	public class ClimbLadderComponentData : 
		ComponentData
	{
		protected int m_ClimbPhase = new int();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(2435927203)]
		public int ClimbPhase { get { return m_ClimbPhase; } set { if (OnPropertyChanging("ClimbLadderComponentData." + nameof(ClimbPhase), this, m_ClimbPhase, value)) m_ClimbPhase = value; } } // 0x60 (96)
		
		protected int m_ConnectPhase = new int();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(990855988)]
		public int ConnectPhase { get { return m_ConnectPhase; } set { if (OnPropertyChanging("ClimbLadderComponentData." + nameof(ConnectPhase), this, m_ConnectPhase, value)) m_ConnectPhase = value; } } // 0x64 (100)
		
		protected float m_ConnectJointDisplacement = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(1469536954)]
		public float ConnectJointDisplacement { get { return m_ConnectJointDisplacement; } set { if (OnPropertyChanging("ClimbLadderComponentData." + nameof(ConnectJointDisplacement), this, m_ConnectJointDisplacement, value)) m_ConnectJointDisplacement = value; } } // 0x68 (104)
		
		protected ClimbLadderBinding m_Binding = new ClimbLadderBinding();
		[ContainerField(108), ContainerFieldNameHash(2590060228)]
		public ClimbLadderBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("ClimbLadderComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2435927203:
					ClimbPhase = (int) p_Value;
					break;

				case 990855988:
					ConnectPhase = (int) p_Value;
					break;

				case 1469536954:
					ConnectJointDisplacement = (float) p_Value;
					break;

				case 2590060228:
					Binding = (ClimbLadderBinding) p_Value;
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
				case 2435927203:
					return ClimbPhase;

				case 990855988:
					return ConnectPhase;

				case 1469536954:
					return ConnectJointDisplacement;

				case 2590060228:
					return Binding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2435927203:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ClimbPhase));

				case 990855988:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ConnectPhase));

				case 1469536954:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ConnectJointDisplacement));

				case 2590060228:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(Binding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
