namespace FBCC.Containers
{
	interface IContainerAttributeParam
	{
		ContainerAttributeParamType ParamType { get; }

		ContainerAttribute ParentAttribute { get; set; }
	}

	abstract class ContainerAttributeParam<T> : IContainerAttributeParam
	{
		public ContainerAttributeParamType ParamType { get; protected set; }
		public ContainerAttribute ParentAttribute { get; set; }

		protected ContainerAttributeParam(ContainerAttributeParamType p_Type)
		{
			ParamType = p_Type;
		}

		protected abstract string AsString();

		public override string ToString()
		{
			return AsString();
		}

		public abstract T GetValue();
	}
}
