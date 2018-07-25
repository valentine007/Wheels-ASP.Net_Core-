using AutoMapper;
using Wheels.Controllers.Resources;
using Wheels.Models;
using Whels.Controllers.Resources;

namespace vega.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Make, MakeResource>();
			CreateMap<Model, ModelResource>();
			CreateMap<Feature, FeatureResource>();
		}
	}
}