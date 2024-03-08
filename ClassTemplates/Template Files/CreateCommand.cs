using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Command.Create
{
	public record Create$fileinputname$Command($fileinputname$ViewModel Model) : IRequest <Create$fileinputname$CommandResponse>;
}
