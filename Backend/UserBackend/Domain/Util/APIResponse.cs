using System;
namespace Domain.Util
{
	public class APIResponse
	{
		public string Message { get; set; }
		public HTTP_STATUS Code { get; set; }

		public APIResponse(string Message, HTTP_STATUS Code)
		{
			this.Message = Message;
			this.Code = Code;
		}
	}
}

