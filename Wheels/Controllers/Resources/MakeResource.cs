using System.Collections.Generic;
using System.Collections.ObjectModel;
using Wheels.Controllers.Resources;

namespace Whels.Controllers.Resources
{
	public class MakeResource
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<ModelResource> Models { get; set; }

		public MakeResource()
		{
			Models = new Collection<ModelResource>();
		}

	}
}