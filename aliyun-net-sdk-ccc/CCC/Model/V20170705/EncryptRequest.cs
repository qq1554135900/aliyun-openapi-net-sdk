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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class EncryptRequest : RpcAcsRequest<EncryptResponse>
    {
        public EncryptRequest()
            : base("CCC", "2017-07-05", "Encrypt", "ccc", "openAPI")
        {
        }

		private string publicKey;

		private List<string> plainTexts;

		private string accessKeyId;

		public string PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
				DictionaryUtil.Add(QueryParameters, "PublicKey", value);
			}
		}

		public List<string> PlainTexts
		{
			get
			{
				return plainTexts;
			}

			set
			{
				plainTexts = value;
				for (int i = 0; i < plainTexts.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PlainText." + (i + 1) , plainTexts[i]);
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

        public override EncryptResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return EncryptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}