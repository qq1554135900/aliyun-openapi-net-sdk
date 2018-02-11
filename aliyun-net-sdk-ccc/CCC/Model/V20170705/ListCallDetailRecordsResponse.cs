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
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ListCallDetailRecordsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListCallDetailRecords_CallDetailRecords callDetailRecords;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public ListCallDetailRecords_CallDetailRecords CallDetailRecords
		{
			get
			{
				return callDetailRecords;
			}
			set	
			{
				callDetailRecords = value;
			}
		}

		public class ListCallDetailRecords_CallDetailRecords
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListCallDetailRecords_CallDetailRecord> list;

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public List<ListCallDetailRecords_CallDetailRecord> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListCallDetailRecords_CallDetailRecord
			{

				private string contactId;

				private long? startTime;

				private int? duration;

				private string contactType;

				private string contactDisposition;

				private string callingNumber;

				private string calledNumber;

				private string agentNames;

				private string skillGroupNames;

				private string instanceId;

				private List<ListCallDetailRecords_CallDetailAgent> agents;

				private List<ListCallDetailRecords_Recording> recordings;

				public string ContactId
				{
					get
					{
						return contactId;
					}
					set	
					{
						contactId = value;
					}
				}

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public int? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string ContactType
				{
					get
					{
						return contactType;
					}
					set	
					{
						contactType = value;
					}
				}

				public string ContactDisposition
				{
					get
					{
						return contactDisposition;
					}
					set	
					{
						contactDisposition = value;
					}
				}

				public string CallingNumber
				{
					get
					{
						return callingNumber;
					}
					set	
					{
						callingNumber = value;
					}
				}

				public string CalledNumber
				{
					get
					{
						return calledNumber;
					}
					set	
					{
						calledNumber = value;
					}
				}

				public string AgentNames
				{
					get
					{
						return agentNames;
					}
					set	
					{
						agentNames = value;
					}
				}

				public string SkillGroupNames
				{
					get
					{
						return skillGroupNames;
					}
					set	
					{
						skillGroupNames = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public List<ListCallDetailRecords_CallDetailAgent> Agents
				{
					get
					{
						return agents;
					}
					set	
					{
						agents = value;
					}
				}

				public List<ListCallDetailRecords_Recording> Recordings
				{
					get
					{
						return recordings;
					}
					set	
					{
						recordings = value;
					}
				}

				public class ListCallDetailRecords_CallDetailAgent
				{

					private string contactId;

					private string agentId;

					private string agentName;

					private string skillGroupName;

					private int? queueTime;

					private int? ringTime;

					private long? startTime;

					private int? talkTime;

					private int? holdTime;

					private int? workTime;

					public string ContactId
					{
						get
						{
							return contactId;
						}
						set	
						{
							contactId = value;
						}
					}

					public string AgentId
					{
						get
						{
							return agentId;
						}
						set	
						{
							agentId = value;
						}
					}

					public string AgentName
					{
						get
						{
							return agentName;
						}
						set	
						{
							agentName = value;
						}
					}

					public string SkillGroupName
					{
						get
						{
							return skillGroupName;
						}
						set	
						{
							skillGroupName = value;
						}
					}

					public int? QueueTime
					{
						get
						{
							return queueTime;
						}
						set	
						{
							queueTime = value;
						}
					}

					public int? RingTime
					{
						get
						{
							return ringTime;
						}
						set	
						{
							ringTime = value;
						}
					}

					public long? StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public int? TalkTime
					{
						get
						{
							return talkTime;
						}
						set	
						{
							talkTime = value;
						}
					}

					public int? HoldTime
					{
						get
						{
							return holdTime;
						}
						set	
						{
							holdTime = value;
						}
					}

					public int? WorkTime
					{
						get
						{
							return workTime;
						}
						set	
						{
							workTime = value;
						}
					}
				}

				public class ListCallDetailRecords_Recording
				{

					private string contactId;

					private string contactType;

					private string agentId;

					private string agentName;

					private string callingNumber;

					private string calledNumber;

					private long? startTime;

					private int? duration;

					private string fileName;

					private string filePath;

					private string fileDescription;

					private string channel;

					private string instanceId;

					public string ContactId
					{
						get
						{
							return contactId;
						}
						set	
						{
							contactId = value;
						}
					}

					public string ContactType
					{
						get
						{
							return contactType;
						}
						set	
						{
							contactType = value;
						}
					}

					public string AgentId
					{
						get
						{
							return agentId;
						}
						set	
						{
							agentId = value;
						}
					}

					public string AgentName
					{
						get
						{
							return agentName;
						}
						set	
						{
							agentName = value;
						}
					}

					public string CallingNumber
					{
						get
						{
							return callingNumber;
						}
						set	
						{
							callingNumber = value;
						}
					}

					public string CalledNumber
					{
						get
						{
							return calledNumber;
						}
						set	
						{
							calledNumber = value;
						}
					}

					public long? StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public int? Duration
					{
						get
						{
							return duration;
						}
						set	
						{
							duration = value;
						}
					}

					public string FileName
					{
						get
						{
							return fileName;
						}
						set	
						{
							fileName = value;
						}
					}

					public string FilePath
					{
						get
						{
							return filePath;
						}
						set	
						{
							filePath = value;
						}
					}

					public string FileDescription
					{
						get
						{
							return fileDescription;
						}
						set	
						{
							fileDescription = value;
						}
					}

					public string Channel
					{
						get
						{
							return channel;
						}
						set	
						{
							channel = value;
						}
					}

					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
						}
					}
				}
			}
		}
	}
}