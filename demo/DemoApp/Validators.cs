// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using RulesEngine;
using RulesEngine.ExpressionBuilders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp
{
    public static class ValidateKeys
    {
        public const string MinimumLength = "{0}_minimum";
        public const string MaximumLength = "{0}_maximum";
        public const string BlackList = "{0}";
    }

    public static class Validators
    {
        public static MethodExpressionResult MinMaxLength(string sut, int minLength, int maxLength)
        {
            var coordinates = new List<string>();

            if (sut.Length < minLength)
                coordinates.Add($"{ValidateKeys.MinimumLength}");

            if (sut.Length > maxLength)
                coordinates.Add($"{ValidateKeys.MaximumLength}");

            return new MethodExpressionResult() { IsSuccess = coordinates.Count == 0, Coordinates = coordinates };
        }

        public static MethodExpressionResult NotIn(string sut, string blackList)
        {
            var coordinates = new List<string>();

            var list = blackList.Split(',').ToList();
            if (list.Contains(sut))
                coordinates.Add($"{ValidateKeys.BlackList}");

            return new MethodExpressionResult() { IsSuccess = coordinates.Count == 0, Coordinates = coordinates };
        }
    }
}