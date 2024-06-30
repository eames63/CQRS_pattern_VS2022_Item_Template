using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.Queries.Get$fileinputname$ListViewModels
{
	public class Get$fileinputname$ListViewModelsHandler: IRequestHandler<Get$fileinputname$ListViewModelsQuery, List<$fileinputname$ListViewModel>>
	{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;



	public Get$fileinputname$ListViewModelsHandler(I$fileinputname$Repository $fileinputname$Repository, IMapper mapper)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
	}

	 public async Task<List<$fileinputname$ListViewModel>> Handle(Get$fileinputname$ListViewModelsQuery request, CancellationToken cancellationToken)
		{
			var entities = _$fileinputname$Repository.LoadAll();
			if (entities == null)
			{
				throw new NotFoundException(nameof($fileinputname$), "NoParams");
			}

			var models = new List<$fileinputname$ListViewModel>();
			_mapper.Map(entities, models);

			return await Task.FromResult(models);
		}
	}

}
