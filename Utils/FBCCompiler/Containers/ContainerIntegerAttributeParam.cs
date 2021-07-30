using System.Globalization;

namespace FBCC.Containers
{
	class ContainerIntegerAttributeParam : ContainerAttributeParam<long>
	{
		protected long m_Value;

		public ContainerIntegerAttributeParam(long p_Value) :
			base(ContainerAttributeParamType.IntegerAttribute)
		{
			m_Value = p_Value;
		}

		protected override string AsString()
		{
			return m_Value.ToString(CultureInfo.InvariantCulture);
		}

		public override long GetValue()
		{
			return m_Value;
		}
	}
}
