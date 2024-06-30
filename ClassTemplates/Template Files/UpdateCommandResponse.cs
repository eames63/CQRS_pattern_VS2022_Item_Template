using MediatR;
using $rootnamespace$.$fileinputname$.Models;
using Hub.Application.Responses;


namespace $rootnamespace$.$fileinputname$.Command.Update
{
	public class Update$fileinputname$CommandResponse: BaseResponse
	{
		public Update$fileinputname$CommandResponse():base()
		{

		}

		public $fileinputname$ViewModel Model { get; set; } = default!;
	}
}


