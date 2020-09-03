using System.Xml;
using System.Xml.Serialization;

namespace scdb.Xml.Entities
{
	public class ClassBase
	{
		public string ClassName;

		[XmlAttribute]
		public string __ref;

		[XmlAttribute]
		public string __type;
	}

	public class EntityClassDefinition : ClassBase
	{
		public StaticEntityClassData StaticEntityClassData;
		public Reference[] tags;
		public Components Components;

		[XmlAttribute]
		public string __ref;

		public string ClassName;
	}

	public class StaticEntityClassData
	{
		public DefaultEntitlementEntityParams DefaultEntitlementEntityParams;
	}

	public class DefaultEntitlementEntityParams
	{
		[XmlAttribute]
		public string entitlementPolicy;
	}

	public class Reference
	{
		[XmlAttribute]
		public string value;
	}
}
