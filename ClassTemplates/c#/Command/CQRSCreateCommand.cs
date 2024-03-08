using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ClassTemplates
{
	public record CreateCommand() : IRequest<CreateCommandResponse>;

}
