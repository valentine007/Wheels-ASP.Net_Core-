using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Wheels.Controllers.Resources
{
    public class ModelResource
    {
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<ModelResource> Models { get; set; }

		public ModelResource()
		{
			Models = new Collection<ModelResource>();
		}
	}
}
