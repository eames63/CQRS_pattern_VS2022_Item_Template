using MediatR;

namespace $rootnamespace$.$fileinputname$.Command;

	public record Delete$fileinputname$Command(int Id) : IRequest <Delete$fileinputname$CommandResponse>;

