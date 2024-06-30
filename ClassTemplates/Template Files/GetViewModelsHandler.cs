using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$ViewModels
{
	public class Get$fileinputname$ViewModelsHandler: IRequestHandler<Get$fileinputname$ViewModelsQuery, List<$fileinputname$ViewModel>>
	{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;



	public Get$fileinputname$ViewModelsHandler(I$fileinputname$Repository $fileinputname$Repository, IMapper mapper)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
	}

	 public async Task<List<$fileinputname$ViewModel>> Handle(Get$fileinputname$ViewModelsQuery request, CancellationToken cancellationToken)
		{
			var entities = _$fileinputname$Repository.LoadAll();
			if (entities == null)
			{
				throw new NotFoundException(nameof($fileinputname$), "NoParams");
			}

			var models = new List<$fileinputname$ViewModel>();
			_mapper.Map(entities, models);

			return await Task.FromResult(models);
		}
	}

}
