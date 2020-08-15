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
	public class LogicalExpressionNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<LogicalExpressionEntry> m_Inputs = new RefArray<LogicalExpressionEntry>();
		[ContainerField(8), ContainerFieldNameHash(2784267136)]
		public RefArray<LogicalExpressionEntry> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("LogicalExpressionNodeData." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(12), ContainerFieldNameHash(2606354109)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("LogicalExpressionNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0xC (12)
		
		protected LogicalExpressionOperator m_Operator = new LogicalExpressionOperator();
		[ContainerField(20), ContainerFieldNameHash(2153507813)]
		public LogicalExpressionOperator Operator { get { return m_Operator; } set { if (OnPropertyChanging("LogicalExpressionNodeData." + nameof(Operator), this, m_Operator, value)) m_Operator = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2784267136:
					Inputs = (RefArray<LogicalExpressionEntry>) p_Value;
					break;

				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 2153507813:
					Operator = (LogicalExpressionOperator) Enum.ToObject(typeof(LogicalExpressionOperator), p_Value);
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
				case 2784267136:
					return Inputs;

				case 2606354109:
					return Trigger;

				case 2153507813:
					return Operator;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2784267136:
					return typeof(LogicalExpressionNodeData).GetProperty(nameof(Inputs));

				case 2606354109:
					return typeof(LogicalExpressionNodeData).GetProperty(nameof(Trigger));

				case 2153507813:
					return typeof(LogicalExpressionNodeData).GetProperty(nameof(Operator));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
