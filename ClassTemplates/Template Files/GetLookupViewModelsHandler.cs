using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries;

	public class Get$fileinputname$LookupViewModelsHandler: IRequestHandler<Get$fileinputname$LookupViewModelsQuery, List<$fileinputname$LookupViewModel>>
	{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;



	public Get$fileinputname$LookupViewModelsHandler(I$fileinputname$Repository $fileinputname$Repository, IMapper mapper)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
	}

	 public async Task<List<$fileinputname$LookupViewModel>> Handle(Get$fileinputname$LookupViewModelsQuery request, CancellationToken cancellationToken)
		{
			var entities = _$fileinputname$Repository.LoadAll();
			if (entities == null)
			{
				throw new NotFoundException(nameof($fileinputname$), "NoParams");
			}

			var models = new List<$fileinputname$LookupViewModel>();
			_mapper.Map(entities, models);

			return await Task.FromResult(models);
		}
	}


