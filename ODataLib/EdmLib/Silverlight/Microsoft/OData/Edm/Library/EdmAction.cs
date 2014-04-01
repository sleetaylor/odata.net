//   OData .NET Libraries
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 

//   Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

//   THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

//   See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.

namespace Microsoft.OData.Edm.Library
{
    /// <summary>
    /// Represents an EDM action.
    /// </summary>
    public class EdmAction : EdmOperation, IEdmAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdmAction"/> class.
        /// </summary>
        /// <param name="namespaceName">Namespace of the action.</param>
        /// <param name="name">Name of the action.</param>
        /// <param name="returnType">Return type of the action.</param>
        public EdmAction(string namespaceName, string name, IEdmTypeReference returnType)
            : base(namespaceName, name, returnType)
        {
        }
    }
}