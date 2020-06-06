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
	public class EntitySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint OutOfEntityBusNetworkIdThreshold { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public ExecutionModeType ExecutionMode { get; set; } = new ExecutionModeType(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool SpawnSubLevelsFromLogic { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool EditorGameViewEnable { get; set; } // 0x15 (21)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2379599769:
					OutOfEntityBusNetworkIdThreshold = (uint) p_Value;
					break;

				case 3634549556:
					ExecutionMode = (ExecutionModeType) Enum.ToObject(typeof(ExecutionModeType), p_Value);
					break;

				case 1806867047:
					SpawnSubLevelsFromLogic = (bool) p_Value;
					break;

				case 1497073094:
					EditorGameViewEnable = (bool) p_Value;
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
				case 2379599769:
					return OutOfEntityBusNetworkIdThreshold;

				case 3634549556:
					return ExecutionMode;

				case 1806867047:
					return SpawnSubLevelsFromLogic;

				case 1497073094:
					return EditorGameViewEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2379599769:
					return typeof(EntitySettings).GetProperty(nameof(OutOfEntityBusNetworkIdThreshold));

				case 3634549556:
					return typeof(EntitySettings).GetProperty(nameof(ExecutionMode));

				case 1806867047:
					return typeof(EntitySettings).GetProperty(nameof(SpawnSubLevelsFromLogic));

				case 1497073094:
					return typeof(EntitySettings).GetProperty(nameof(EditorGameViewEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
