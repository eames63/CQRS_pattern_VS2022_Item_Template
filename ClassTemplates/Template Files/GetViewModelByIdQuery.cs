using System;
using System.Collections.Generic;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$ViewModelById

	public record Get$fileinputname$ViewModelByIdQuery(int Id) : IRequest <List<$fileinputname$ViewModel>>;


