using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responses
{
	public class BaseResponse
	{
		public BaseResponse()
		{
			Success = true;
		}
		public BaseResponse(string message,NotifyAlert alert)
		{
			Success = true;
			Message = message;
			Alert = alert;
		}

		public BaseResponse(string message, bool success, NotifyAlert alert)
		{
			Success = success;
			Message = message;
			Alert = alert;
		}

		public bool Success { get; set; }
		public NotifyAlert Alert { get; set; }
		public string Message { get; set; } = string.Empty;
		public List<ValidationError>? ValidationErrors { get; set; }
	}

	public enum NotifyAlert
	{
		Warning,
		Danger,
		Success
	}
}
