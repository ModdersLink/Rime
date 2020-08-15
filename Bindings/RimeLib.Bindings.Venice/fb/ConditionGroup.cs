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
	public class ConditionGroup : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_X = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(177661)]
		public AudioGraphNodePort X { get { return m_X; } set { if (OnPropertyChanging("ConditionGroup." + nameof(X), this, m_X, value)) m_X = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(177660)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("ConditionGroup." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_True = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(2089293587)]
		public AudioGraphNodePort True { get { return m_True; } set { if (OnPropertyChanging("ConditionGroup." + nameof(True), this, m_True, value)) m_True = value; } } // 0x18 (24)
		
		protected ConditionType m_Condition = new ConditionType();
		[ContainerField(32), ContainerFieldNameHash(1800624758)]
		public ConditionType Condition { get { return m_Condition; } set { if (OnPropertyChanging("ConditionGroup." + nameof(Condition), this, m_Condition, value)) m_Condition = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (AudioGraphNodePort) p_Value;
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
					break;

				case 2089293587:
					True = (AudioGraphNodePort) p_Value;
					break;

				case 1800624758:
					Condition = (ConditionType) Enum.ToObject(typeof(ConditionType), p_Value);
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
				case 177661:
					return X;

				case 177660:
					return Y;

				case 2089293587:
					return True;

				case 1800624758:
					return Condition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(ConditionGroup).GetProperty(nameof(X));

				case 177660:
					return typeof(ConditionGroup).GetProperty(nameof(Y));

				case 2089293587:
					return typeof(ConditionGroup).GetProperty(nameof(True));

				case 1800624758:
					return typeof(ConditionGroup).GetProperty(nameof(Condition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
