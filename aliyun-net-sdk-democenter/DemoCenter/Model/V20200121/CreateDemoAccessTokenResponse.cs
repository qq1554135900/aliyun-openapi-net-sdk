/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.DemoCenter.Model.V20200121
{
	public class CreateDemoAccessTokenResponse : AcsResponse
	{

		private string requestId;

		private string demoAccessToken;

		private string expiredDate;

		private string openUserId;

		private string demoTrialPage;

		private string demoDetailPage;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string DemoAccessToken
		{
			get
			{
				return demoAccessToken;
			}
			set	
			{
				demoAccessToken = value;
			}
		}

		public string ExpiredDate
		{
			get
			{
				return expiredDate;
			}
			set	
			{
				expiredDate = value;
			}
		}

		public string OpenUserId
		{
			get
			{
				return openUserId;
			}
			set	
			{
				openUserId = value;
			}
		}

		public string DemoTrialPage
		{
			get
			{
				return demoTrialPage;
			}
			set	
			{
				demoTrialPage = value;
			}
		}

		public string DemoDetailPage
		{
			get
			{
				return demoDetailPage;
			}
			set	
			{
				demoDetailPage = value;
			}
		}
	}
}
