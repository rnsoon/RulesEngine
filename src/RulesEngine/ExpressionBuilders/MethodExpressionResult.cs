// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace RulesEngine.ExpressionBuilders
{
    public class MethodExpressionResult
    {
        public bool IsSuccess { get; set; }

        public IList<string> Coordinates { get; set; }
    }
}