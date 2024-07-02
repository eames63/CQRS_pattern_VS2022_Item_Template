using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;


namespace $rootnamespace$.$fileinputname$.Command.Delete

	public class Delete$fileinputname$CommandHandler: IRequestHandler<Delete$fileinputname$Command,Delete$fileinputname$CommandResponse>
{
	private readonly I$fileinputname$Repository _$fileinputname$Repository;
	private readonly ILogger<Delete$fileinputname$CommandHandler> _logger;

	public Delete$fileinputname$CommandHandler(I$fileinputname$Repository $fileinputname$Repository, ILogger<Delete$fileinputname$CommandHandler> logger)
	{

		_$fileinputname$Repository = $fileinputname$Repository;
		_logger = logger;
	}

	 public async Task<Delete$fileinputname$CommandResponse> Handle(Delete$fileinputname$Command request, CancellationToken cancellationToken)
 {
     var delete$fileinputname$CommandResponse = new Delete$fileinputname$CommandResponse();


			var entity =  _$fileinputname$Repository.LoadById(request.Id);
			if (entity == null)
			{
				throw new NotFoundException(nameof($fileinputname$), request.Id);
			}

			//ToDo complete or delete as needed
			if (entity.Any())
			{
				var msg =$"{entity.Name}-{Resources.Resources.DeleteFailureUsed}";
				delete$fileinputname$CommandResponse.Success=false;
				delete$fileinputname$CommandResponse.Message = msg;
				delete$fileinputname$CommandResponse.Alert =  NotifyAlert.Warning;

			}
			else
			{
				var msg = $"{entity.Name}{Resources.Resources.hasBeenDeleted}";
				entity.Delete();
				delete$fileinputname$CommandResponse.Success = true;
				delete$fileinputname$CommandResponse.Message = msg;
				delete$fileinputname$CommandResponse.Alert = NotifyAlert.Success;
				_logger.Log(LogLevel.Information, msg);
			}

			return await Task.FromResult(delete$fileinputname$CommandResponse);

 }
}

