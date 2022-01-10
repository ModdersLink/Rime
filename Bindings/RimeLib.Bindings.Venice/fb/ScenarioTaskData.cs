///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 80)]
	public class ScenarioTaskData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EndPointWorldOffset { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StartPoint { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int ScenarioId { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int ActorId { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int PartId { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int LevelId { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float WorldAngle { get; set; }
		
		[ContainerField(52)]
		public List<LinearTransform> ConnectTransforms { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float StartTurnDistance { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float StartTimerDistance { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float TriggerScenarioDelay { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool TriggerScenario { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseClientPosition { get; set; }
		
		public static void Deserialize(ScenarioTaskData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.EndPointWorldOffset, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.StartPoint, p_Reader, p_Parser);
			p_Instance.ScenarioId = p_Reader.ReadInt32();
			p_Instance.ActorId = p_Reader.ReadInt32();
			p_Instance.PartId = p_Reader.ReadInt32();
			p_Instance.LevelId = p_Reader.ReadInt32();
			p_Instance.WorldAngle = p_Reader.ReadSingle();
			p_Instance.ConnectTransforms.Clear();
			(RimeReader Reader, uint Count) s_ConnectTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ConnectTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_ConnectTransforms.Reader, p_Parser);
				p_Instance.ConnectTransforms.Add(s_Value);
			}
			
			s_ConnectTransforms.Reader.Dispose();
			p_Instance.StartTurnDistance = p_Reader.ReadSingle();
			p_Instance.StartTimerDistance = p_Reader.ReadSingle();
			p_Instance.TriggerScenarioDelay = p_Reader.ReadSingle();
			p_Instance.TriggerScenario = p_Reader.ReadBool();
			p_Instance.UseClientPosition = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}
	}
}
