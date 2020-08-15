namespace FBCC.Containers
{
	class ContainerBooleanAttributeParam : ContainerAttributeParam<bool>
	{
		protected bool m_Value;

		public ContainerBooleanAttributeParam(bool p_Value) :
			base(ContainerAttributeParamType.BooleanAttribute)
		{
			m_Value = p_Value;
		}

		protected override string AsString()
		{
			return m_Value ? "true" : "false";
		}

		public override bool GetValue()
		{
			return m_Value;
		}
	}
}
