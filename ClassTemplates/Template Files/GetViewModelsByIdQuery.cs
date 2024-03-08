using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries.Get$fileinputname$ViewModelsById
{
	public record Get$fileinputname$ViewModelsByIdQuery(int Id) : IRequest <List<$fileinputname$ViewModel>>;
	//amend load method for id owner & model type as required
}
