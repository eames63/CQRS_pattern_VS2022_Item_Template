using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;
using $rootnamespace$.$fileinputname$.Validators;

namespace $rootnamespace$.$fileinputname$.Command.Update

	public class Update$fileinputname$CommandHandler: IRequestHandler<Update$fileinputname$Command,Update$fileinputname$CommandResponse>
{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;
	private readonly ILogger<Update$fileinputname$CommandHandler> _logger;


	public Update$fileinputname$CommandHandler(IMapper mapper, I$fileinputname$Repository $fileinputname$Repository, ILogger<Update$fileinputname$CommandHandler> logger)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
		_logger = logger;
	}

	 public async Task<Update$fileinputname$CommandResponse> Handle(Update$fileinputname$Command request, CancellationToken cancellationToken)
	{
     var update$fileinputname$CommandResponse = new Update$fileinputname$CommandResponse();
	 var model = request.Model;

     var validator = new $fileinputname$Validator();
     var validationResult = await validator.ValidateAsync(request.Model, cancellationToken);

     if (validationResult.Errors.Count > 0)
     {
         update$fileinputname$CommandResponse.Success = false;
         update$fileinputname$CommandResponse.Message = $"{Resources.Resources.DataValidationFailed}";
         update$fileinputname$CommandResponse.Alert = NotifyAlert.Warning;
         update$fileinputname$CommandResponse.ValidationErrors = new List<ValidationError>();
         update$fileinputname$CommandResponse.ValidationErrors.AddRange(validationResult.Errors.Select(e=> new ValidationError(e.PropertyName,e.ErrorMessage)));
         return update$fileinputname$CommandResponse;
     }

        var entity = _$fileinputname$Repository.LoadById(model.Id);
		if (entity == null)
		{
			throw new NotFoundException(nameof($fileinputname$), request.Model.Id);
		}

		_mapper.Map(model, entity);
		entity.Save();


		var msg = $"{Resources.Resources.$fileinputname$}{Resources.Resources.hasBeenUpdated}";
		update$fileinputname$CommandResponse.Success = true;
		update$fileinputname$CommandResponse.Model = model;
		update$fileinputname$CommandResponse.Message = msg;
		update$fileinputname$CommandResponse.Alert = NotifyAlert.Success;
		_logger.Log(LogLevel.Information, msg);



     return update$fileinputname$CommandResponse;

	}
}

