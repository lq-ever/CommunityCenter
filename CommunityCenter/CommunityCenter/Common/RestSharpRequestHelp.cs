using System;
using RestSharp;
using System.Collections.Generic;

namespace CommunityCenter.Common
{
	public class RestSharpRequestHelp
	{
		private RestClient client;
		private RestRequest restRequest;

		public string Url;

		private Dictionary<string,string> requestParams;
		public Dictionary<string,string> RequestParams {
			get {
				return requestParams;
			}
			set {
				requestParams = value;
				CreateRestParams ();
			}
		}
		private void InitRestSharpRequest(string _url)
		{
			Url = _url;
			client = new RestClient(Url);
			restRequest = new RestRequest (Method.POST);
			restRequest.AddHeader ("Content-Type","application/x-www-form-urlencoded");
			restRequest.Timeout = 5000;
		}
		private RestSharpRequestHelp(string _url)
		{
			InitRestSharpRequest (_url);
		}

		public RestSharpRequestHelp (string _url,Dictionary<string,string> _requestParams):this(_url)
		{
			RequestParams = _requestParams;
		}

		/// <summary>
		/// 创建请求参数
		/// </summary>
		private void CreateRestParams()
		{
			if (restRequest.Parameters != null && restRequest.Parameters.Count > 0)
				restRequest.Parameters.Clear();

			if (RequestParams != null && RequestParams.Count > 0) {
				foreach (var key in RequestParams.Keys) {
					restRequest.AddParameter (key, RequestParams [key]);
				}
			}
		}


		/// <summary>
		/// 同步执行
		/// </summary>
		public string Excute()
		{
			return client.Execute (restRequest).Content;

		}

		/// <summary>
		/// 异步执行
		/// </summary>
		/// <returns>The async.</returns>
		public void ExcuteAsync(Action<IRestResponse> callback)
		{
			client.ExecuteAsync (restRequest, (response) => {

				callback(response);
			});

		}

	}
}

