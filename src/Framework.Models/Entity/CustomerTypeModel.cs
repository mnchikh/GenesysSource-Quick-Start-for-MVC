//-----------------------------------------------------------------------
// <copyright file="CustomerTypeModel.cs" company="Genesys Source">
//      Licensed to the Apache Software Foundation (ASF) under one or more 
//      contributor license agreements.  See the NOTICE file distributed with 
//      this work for additional information regarding copyright ownership.
//      The ASF licenses this file to You under the Apache License, Version 2.0 
//      (the 'License'); you may not use this file except in compliance with 
//      the License.  You may obtain a copy of the License at 
//       
//        http://www.apache.org/licenses/LICENSE-2.0 
//       
//       Unless required by applicable law or agreed to in writing, software  
//       distributed under the License is distributed on an 'AS IS' BASIS, 
//       WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
//       See the License for the specific language governing permissions and  
//       limitations under the License. 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Genesys.Foundation.Name;
using Genesys.Extensions;

namespace Framework.Entity
{
    /// <summary>
    /// Customer Type view/http transport model, mainly for a key/value of ID/Name
    /// </summary>
    public class CustomerTypeModel : NameIDModel, ICustomerType
    {
        /// <summary>
        /// Common customer type keys used as an ID for the table column CustomerType.CustomerTypeKey
        /// </summary>
        public struct Types
        {
            public static Guid None { get; set; } = TypeExtension.DefaultGuid;
            public static Guid Standard { get; set; } = new Guid("BF3797EE-06A5-47F2-9016-369BEB21D944");
            public static Guid Premium { get; set; } = new Guid("36B08B23-0C1D-4488-B557-69665FD666E1");
            public static Guid Lifetime { get; set; } = new Guid("51A84CE1-4846-4A71-971A-CB610EEB4848");
        }
    }
}
