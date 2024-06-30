using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$ViewModelsById
{
	public class Get$fileinputname$ViewModelByIdHandler: IRequestHandler<Get$fileinputname$ViewModelByIdQuery, $fileinputname$ViewModel>
	{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;



	public Get$fileinputname$ViewModelsByIdHandler(I$fileinputname$Repository $fileinputname$Repository, IMapper mapper)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
	}

	public async Task<$fileinputname$ViewModel> Handle(Get$fileinputname$ViewModelByIdQuery request, CancellationToken cancellationToken)
	{
		var entity = _$fileinputname$Repository.LoadById(request.Id); //amend repo load method for id owner
		if (entity == null)
		{
			throw new NotFoundException(nameof($fileinputname$), request.Id);
		}

		var model = new $fileinputname$ViewModel();
		_mapper.Map(entity, model);

		return await Task.FromResult(model);
	}
}

}
