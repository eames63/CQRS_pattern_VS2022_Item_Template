using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Command.Create
{
	public class Create$fileinputname$CommandResponse: BaseResponse
{
	public Create$fileinputname$CommandResponse():base()
	{

	}

	public $fileinputname$ViewModel Model { get; set; } = default!;
}
}
