///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class LogicalExpressionNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<LogicalExpressionEntry> Inputs { get; set; } = new RefArray<LogicalExpressionEntry>(); // 0x8 (8)
		
		[ContainerField(12)]
		public AudioGraphNodePort Trigger { get; set; } = new AudioGraphNodePort(); // 0xC (12)
		
		[ContainerField(20)]
		public LogicalExpressionOperator Operator { get; set; } = new LogicalExpressionOperator(); // 0x14 (20)
		
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
