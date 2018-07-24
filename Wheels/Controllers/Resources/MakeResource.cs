using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Models;

namespace Wheels.Controllers.Resources
{
    public class MakeResource
    {
			public int Id { get; set; }
			public string Name { get; set; }

			public ICollection<Model> Models { get; set; }

			public MakeResource()
			{
				Models = new Collection<Model>();
			}
	}
}
