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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SetScanModeRequest : RpcAcsRequest<SetScanModeResponse>
    {
        public SetScanModeRequest()
            : base("cloudwf", "2017-03-28", "SetScanMode", "cloudwf", "openAPI")
        {
        }

		private int? operation;

		private List<string> macLists;

		private string accessKeyId;

		public int? Operation
		{
			get
			{
				return operation;
			}
			set	
			{
				operation = value;
				DictionaryUtil.Add(QueryParameters, "Operation", value.ToString());
			}
		}

		public List<string> MacLists
		{
			get
			{
				return macLists;
			}

			set
			{
				macLists = value;
				for (int i = 0; i < macLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MacList." + (i + 1) , macLists[i]);
				}
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override SetScanModeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetScanModeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
