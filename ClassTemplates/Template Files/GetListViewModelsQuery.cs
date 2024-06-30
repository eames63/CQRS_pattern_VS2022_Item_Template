using System;
using System.Collections.Generic;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$ListViewModels
{
	public record Get$fileinputname$ListViewModelsQuery() : IRequest <List<$fileinputname$ListViewModel>>;

}
