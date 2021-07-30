using System.Globalization;

namespace FBCC.Containers
{
	class ContainerFloatAttributeParam : ContainerAttributeParam<double>
	{
		protected double m_Value;

		public ContainerFloatAttributeParam(double p_Value) :
			base(ContainerAttributeParamType.FloatAttribute)
		{
			m_Value = p_Value;
		}

		protected override string AsString()
		{
			return m_Value.ToString(CultureInfo.InvariantCulture);
		}

		public override double GetValue()
		{
			return m_Value;
		}
	}
}
