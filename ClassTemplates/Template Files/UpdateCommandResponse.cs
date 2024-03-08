using MediatR;
using $rootnamespace$.$fileinputname$.Models;


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

	
