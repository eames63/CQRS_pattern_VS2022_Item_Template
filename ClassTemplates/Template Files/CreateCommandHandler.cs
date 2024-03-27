using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using AutoMapper;
using $rootnamespace$.$fileinputname$.Models;
using $rootnamespace$.$fileinputname$.Validators;

namespace $rootnamespace$.$fileinputname$.Command.Create
{
	public class Create$fileinputname$CommandHandler: IRequestHandler<Create$fileinputname$Command,Create$fileinputname$CommandResponse>
{

	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly IMapper _mapper;
	private readonly ILogger<Create$fileinputname$CommandHandler> _logger;


	public Create$fileinputname$CommandHandler(IMapper mapper, I$fileinputname$Repository $fileinputname$Repository, ILogger<Create$fileinputname$CommandHandler> logger)
	{
		_mapper = mapper;
		_$fileinputname$Repository = $fileinputname$Repository;
		_logger = logger;
	}

	 public async Task<Create$fileinputname$CommandResponse> Handle(Create$fileinputname$Command request, CancellationToken cancellationToken)
 {
     var create$fileinputname$CommandResponse = new Create$fileinputname$CommandResponse();

     var validator = new $fileinputname$Validator();
     var validationResult = await validator.ValidateAsync(request.Model, cancellationToken);

     if (validationResult.Errors.Count > 0)
     {
         create$fileinputname$CommandResponse.Success = false;
         create$fileinputname$CommandResponse.Message = $"{Resources.Resources.DataValidationFailed}";
         create$fileinputname$CommandResponse.Alert = NotifyAlert.Warning;
         create$fileinputname$CommandResponse.ValidationErrors = new List<ValidationError>();
         create$fileinputname$CommandResponse.ValidationErrors.AddRange(validationResult.Errors.Select(e=> new ValidationError(e.PropertyName,e.ErrorMessage)));
     }
     if (create$fileinputname$CommandResponse.Success)
     {
         var model = request.Model;
         var entity = _$fileinputname$Repository.GetNew$fileinputname$();
         _mapper.Map(model, entity);
		entity.Save();

         model.Id = entity.Id;
         create$fileinputname$CommandResponse.Model=model;

         var msg = $"{Resources.Resources.$fileinputname$}{Resources.Resources.hasBeenAdded}";
         create$fileinputname$CommandResponse.Success = true;
         create$fileinputname$CommandResponse.Message = msg;
         create$fileinputname$CommandResponse.Alert = NotifyAlert.Success;
         _logger.Log(LogLevel.Information,msg);

     }

     return create$fileinputname$CommandResponse;

 }
}
}
