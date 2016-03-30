﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.FunctionalTests.TestModels.ComplexNavigationsModel
{
    public class ComplexNavigationGlobalization
    {
        public string Text { get; set; }
        public ComplexNavigationLanguage Language { get; set; }
    }
}
