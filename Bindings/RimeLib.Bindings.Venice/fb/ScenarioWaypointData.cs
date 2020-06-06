///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ScenarioWaypointData : 
		AbstractLocoWaypointData
	{
		[ContainerField(48)]
		public AntRef ScenarioAntRef { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(64)]
		public ScenarioTaskData ScenarioTask { get; set; } = new ScenarioTaskData(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3249359201:
					ScenarioAntRef = (AntRef) p_Value;
					break;

				case 764854566:
					ScenarioTask = (ScenarioTaskData) p_Value;
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
				case 3249359201:
					return ScenarioAntRef;

				case 764854566:
					return ScenarioTask;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3249359201:
					return typeof(ScenarioWaypointData).GetProperty(nameof(ScenarioAntRef));

				case 764854566:
					return typeof(ScenarioWaypointData).GetProperty(nameof(ScenarioTask));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
