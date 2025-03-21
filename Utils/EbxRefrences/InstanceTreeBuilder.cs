using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;

namespace EbxReferences;

public class InstanceTreeBuilder
{
	
	ConcurrentDictionary<CtrRefBase, List<CtrRefBase>> m_InstanceTree = new ();
	
	ConcurrentDictionary<GUID, ConcurrentBag<GUID>> m_PartitionTree = new ();
	
	private ConcurrentBag<DataContainerBase> m_ToProcess = new();
	
	public IDictionary<CtrRefBase, List<CtrRefBase>> InstanceGraph => m_InstanceTree;
	public IDictionary<GUID, ConcurrentBag<GUID>> PartitionGraph => m_PartitionTree;

	public void ProcessPartition(DatabasePartitionBase p_Partition)
	{
		foreach(var s_Object in p_Partition.Instances)
			m_ToProcess.Add(s_Object);
		
		Process();
		ReduceInstanceGraph();
	}

	protected void ReduceInstanceGraph()
	{
		var s_UniquePartitions = m_InstanceTree.Keys.GroupBy(x => x.PartitionGuid).Select(x => x.First().PartitionGuid);
			
		// initialize bags
		foreach (var s_UniquePartition in s_UniquePartitions)
			m_PartitionTree.AddOrUpdate(s_UniquePartition, new ConcurrentBag<GUID>(), (key, value) => value);


		Parallel.ForEach(m_InstanceTree, (p_Pair) =>
		{
			if (m_PartitionTree.TryGetValue(p_Pair.Key.PartitionGuid, out var s_PartitionList))
			{
				Parallel.ForEach(p_Pair.Value.GroupBy(x => x.PartitionGuid).Select(x => x.First().PartitionGuid),
					(p_Ent) => s_PartitionList.Add(p_Ent));

			}
		});
	}

	protected void Process()
	{
		// exhaust all containing bundles
		while (m_ToProcess.Count > 0)
		{
			var s_Local = new ConcurrentBag<DataContainerBase>(m_ToProcess);
			m_ToProcess.Clear();


			Parallel.ForEach(s_Local, (p_Container) => this.ProcessDataContainerInstance(p_Container));
			// Array.ForEach(s_Local.ToArray(), (p_Container) => this.ProcessDataContainerInstance(p_Container));
		}
	}


	private void ProcessDataContainerInstance(DataContainerBase p_Instance)
	{
		var s_CtrRefBase = new CtrRefBase(p_Instance.Partition.PartitionGuid, p_Instance.InstanceId);
		if (m_InstanceTree.ContainsKey(s_CtrRefBase))
			return;
		
		List<CtrRefBase> s_SubCtrs = new();
		ProcessEbxObject(p_Instance, null, ref s_SubCtrs);
		

		var s_FilteredCtrs = s_SubCtrs.Where(x => x != null && !x.IsNull());

		// do we want to create nodes for empty ones?
		// if (s_FilteredCtrs.Count() != 0)
		{
			m_InstanceTree.TryAdd(s_CtrRefBase, s_FilteredCtrs.ToList());

			foreach (var s_ReferenceField in s_FilteredCtrs)
			{
				var s_Object = s_ReferenceField.Get();
				if (s_Object == null)
					continue;

				m_ToProcess.Add(s_Object);
			}

		}
	}

	private void ProcessEbxObject(object p_Object, Type? p_Type, ref List<CtrRefBase> p_SubCtrs)
	{
		if (p_Type == null)
			p_Type = p_Object.GetType();
		
		if (p_Type.BaseType != typeof(EbxSerializable) &&
		    p_Type.BaseType != typeof(DataContainerBase))
			ProcessEbxObject(p_Object, p_Type.BaseType, ref p_SubCtrs);

		var s_InstanceProperties = p_Type.GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance)
			.Where(p_Property => p_Property.GetCustomAttribute<ContainerFieldAttribute>() != null);
		
		
		var s_References = s_InstanceProperties
			.Where(x => typeof(CtrRefBase).IsAssignableFrom(x.PropertyType))
			.Select(x => x.GetValue(p_Object) as CtrRefBase);
		p_SubCtrs.AddRange(s_References);
		
		// process sub types later
		var s_SubType = s_InstanceProperties
			.Where(x => typeof(EbxSerializable).IsAssignableFrom(x.PropertyType))
			.Select(x => x.GetValue(p_Object) as EbxSerializable);
		
		foreach (var s_SubInstance in s_SubType)
			ProcessEbxObject(s_SubInstance, null, ref p_SubCtrs);
		
		
		foreach (var s_Array in s_InstanceProperties.Where(x => x.PropertyType.IsGenericType && !typeof(CtrRefBase).IsAssignableFrom(x.PropertyType)))
		{
			var s_Type = s_Array.PropertyType.GetGenericArguments()[0];
			if (typeof(DataContainerBase).IsAssignableFrom(s_Type))
			{
				// c# generic types is annoying
				var s_RefList = s_Array.GetValue(p_Object) as IEnumerable;
				if (s_RefList == null)
					continue;
				foreach (var s_Ref in s_RefList)
				{
					var s_Ctr = s_Ref as CtrRefBase;
					if (s_Ctr == null)
						continue;
					 p_SubCtrs.Add(s_Ctr);
				}
			}
			else if (typeof(EbxSerializable).IsAssignableFrom(s_Type))
			{
				var s_StructList = s_Array.GetValue(p_Object) as IEnumerable;
				if (s_StructList == null)
					continue;
				foreach (var s_SubInstance in s_StructList)
					ProcessEbxObject(s_SubInstance as EbxSerializable, null, ref p_SubCtrs);
			}
		}
	}

}