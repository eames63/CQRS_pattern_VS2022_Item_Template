using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;
using Hub.Application.Responses;

namespace $rootnamespace$.$fileinputname$.Command;

	public class Create$fileinputname$CommandResponse: BaseResponse
{
	public Create$fileinputname$CommandResponse():base()
	{

	}

	public $fileinputname$ViewModel Model { get; set; } = default!;
}

