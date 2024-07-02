using MediatR;
using $rootnamespace$.$fileinputname$.Models;

namespace $rootnamespace$.$fileinputname$.Command.Update

	public record Update$fileinputname$Command($fileinputname$ViewModel Model) : IRequest <Update$fileinputname$CommandResponse>;

