﻿using System;
using System.Collections.Generic;
using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Queries;

	public record Get$fileinputname$ViewModelByIdQuery(int Id) : IRequest <$fileinputname$ViewModel>;


