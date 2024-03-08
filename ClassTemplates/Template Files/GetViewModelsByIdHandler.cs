using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.Queries.Get$fileinputname$ViewModelsById
{
	public class Get$fileinputname$ViewModelsByIdHandler: IRequestHandler<Get$fileinputname$ViewModelsByIdQuery, List<$fileinputname$ViewModel>>
	{
	
	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;
	
 
 
	public Get$fileinputname$ViewModelsByIdHandler(I$fileinputname$Repository $fileinputname$Repository, IMapper mapper)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
	}

	 public async Task<List<$fileinputname$ViewModel>> Handle(Get$fileinputname$ViewModelsByIdQuery request, CancellationToken cancellationToken)
		{
			var entities = _$fileinputname$Repository.LoadById(request.Id); //amend repo load method for id owner
			if (entities == null)
			{
				throw new NotFoundException(nameof(entities), request.Id);
			}

			var models = new List<$fileinputname$ViewModel>();
			_mapper.Map(entities, models);

			return await Task.FromResult(models);
		}
	}

}
