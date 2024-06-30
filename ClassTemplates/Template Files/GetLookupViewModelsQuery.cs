using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$LookupViewModels
{
	public record Get$fileinputname$LookupViewModelsQuery() : IRequest <List<$fileinputname$LookupViewModel>>;

}
