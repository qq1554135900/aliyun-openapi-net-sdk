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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListOutboundOrdersResponse : AcsResponse
	{

		private int? pageSize;

		private int? totalCount;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private List<ListOutboundOrders_OutboundOrder> outboundOrders;

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

		public List<ListOutboundOrders_OutboundOrder> OutboundOrders
		{
			get
			{
				return outboundOrders;
			}
			set	
			{
				outboundOrders = value;
			}
		}

		public class ListOutboundOrders_OutboundOrder
		{

			private string toWarehouseName;

			private string confirmTime;

			private string orderSubTypeCode;

			private string orderStatus;

			private string description;

			private int? operateQuantity;

			private string fromWarehouseId;

			private string lastSyncTime;

			private int? confirmQuantity;

			private string updateDate;

			private string fromBusinessUnitId;

			private string id;

			private string fromBusinessUnitName;

			private string orderCode;

			private string createDate;

			private string toWarehouseId;

			private string syncStatus;

			private string fromWarehouseName;

			private int? quantity;

			private string sourceOrderCode;

			private string orderId;

			private string toBusinessUnitId;

			public string ToWarehouseName
			{
				get
				{
					return toWarehouseName;
				}
				set	
				{
					toWarehouseName = value;
				}
			}

			public string ConfirmTime
			{
				get
				{
					return confirmTime;
				}
				set	
				{
					confirmTime = value;
				}
			}

			public string OrderSubTypeCode
			{
				get
				{
					return orderSubTypeCode;
				}
				set	
				{
					orderSubTypeCode = value;
				}
			}

			public string OrderStatus
			{
				get
				{
					return orderStatus;
				}
				set	
				{
					orderStatus = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? OperateQuantity
			{
				get
				{
					return operateQuantity;
				}
				set	
				{
					operateQuantity = value;
				}
			}

			public string FromWarehouseId
			{
				get
				{
					return fromWarehouseId;
				}
				set	
				{
					fromWarehouseId = value;
				}
			}

			public string LastSyncTime
			{
				get
				{
					return lastSyncTime;
				}
				set	
				{
					lastSyncTime = value;
				}
			}

			public int? ConfirmQuantity
			{
				get
				{
					return confirmQuantity;
				}
				set	
				{
					confirmQuantity = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string FromBusinessUnitId
			{
				get
				{
					return fromBusinessUnitId;
				}
				set	
				{
					fromBusinessUnitId = value;
				}
			}

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string FromBusinessUnitName
			{
				get
				{
					return fromBusinessUnitName;
				}
				set	
				{
					fromBusinessUnitName = value;
				}
			}

			public string OrderCode
			{
				get
				{
					return orderCode;
				}
				set	
				{
					orderCode = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string ToWarehouseId
			{
				get
				{
					return toWarehouseId;
				}
				set	
				{
					toWarehouseId = value;
				}
			}

			public string SyncStatus
			{
				get
				{
					return syncStatus;
				}
				set	
				{
					syncStatus = value;
				}
			}

			public string FromWarehouseName
			{
				get
				{
					return fromWarehouseName;
				}
				set	
				{
					fromWarehouseName = value;
				}
			}

			public int? Quantity
			{
				get
				{
					return quantity;
				}
				set	
				{
					quantity = value;
				}
			}

			public string SourceOrderCode
			{
				get
				{
					return sourceOrderCode;
				}
				set	
				{
					sourceOrderCode = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string ToBusinessUnitId
			{
				get
				{
					return toBusinessUnitId;
				}
				set	
				{
					toBusinessUnitId = value;
				}
			}
		}
	}
}
