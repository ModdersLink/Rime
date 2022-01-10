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
	[ContainerType(4, 40)]
	public class InspectViewPointData
	{
		[ContainerField(0), LayoutImmutable]
		public string ViewPointID { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public List<InspectAnimationTriggerData> AnimationTriggers { get; set; } = new();
		
		[ContainerField(8)]
		public List<AntRef> ContinuousAnimationSignal { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LookAtHeight { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Yaw { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Pitch { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Distance { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FovOffset { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float AdjustmentYaw { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Fixed { get; set; }
		
		public static void Deserialize(InspectViewPointData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ViewPointID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AnimationTriggers.Clear();
			(RimeReader Reader, uint Count) s_AnimationTriggers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AnimationTriggers.Count; ++i)
			{
				var s_Value = new InspectAnimationTriggerData();
				fb.InspectAnimationTriggerData.Deserialize(s_Value, s_AnimationTriggers.Reader, p_Parser);
				p_Instance.AnimationTriggers.Add(s_Value);
			}
			
			s_AnimationTriggers.Reader.Dispose();
			p_Instance.ContinuousAnimationSignal.Clear();
			(RimeReader Reader, uint Count) s_ContinuousAnimationSignal = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ContinuousAnimationSignal.Count; ++i)
			{
				var s_Value = new AntRef();
				fb.AntRef.Deserialize(s_Value, s_ContinuousAnimationSignal.Reader, p_Parser);
				p_Instance.ContinuousAnimationSignal.Add(s_Value);
			}
			
			s_ContinuousAnimationSignal.Reader.Dispose();
			p_Instance.LookAtHeight = p_Reader.ReadSingle();
			p_Instance.Yaw = p_Reader.ReadSingle();
			p_Instance.Pitch = p_Reader.ReadSingle();
			p_Instance.Distance = p_Reader.ReadSingle();
			p_Instance.FovOffset = p_Reader.ReadSingle();
			p_Instance.AdjustmentYaw = p_Reader.ReadSingle();
			p_Instance.Fixed = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
