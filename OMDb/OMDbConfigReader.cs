﻿using System;
using System.Configuration;

namespace OMDb
{
	public static class OMDbConfigReader
	{
		public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
		public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
		public static readonly string ApiUrlMod = ConfigurationManager.AppSettings["access_key_url_mod"];
	}
}