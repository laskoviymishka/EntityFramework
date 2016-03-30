﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using JetBrains.Annotations;
using Microsoft.Data.Entity.ChangeTracking.Internal;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Query.Internal;
using Microsoft.Data.Entity.Utilities;
using Remotion.Linq.Clauses;

namespace Microsoft.Data.Entity.Query.ExpressionVisitors.Internal
{
    public class InMemoryEntityQueryableExpressionVisitorFactory : IEntityQueryableExpressionVisitorFactory
    {
        private readonly IModel _model;
        private readonly IKeyValueFactorySource _keyValueFactorySource;
        private readonly IMaterializerFactory _materializerFactory;

        public InMemoryEntityQueryableExpressionVisitorFactory(
            [NotNull] IModel model,
            [NotNull] IKeyValueFactorySource keyValueFactorySource,
            [NotNull] IMaterializerFactory materializerFactory)
        {
            Check.NotNull(model, nameof(model));
            Check.NotNull(keyValueFactorySource, nameof(keyValueFactorySource));
            Check.NotNull(materializerFactory, nameof(materializerFactory));

            _model = model;
            _keyValueFactorySource = keyValueFactorySource;
            _materializerFactory = materializerFactory;
        }

        public virtual ExpressionVisitor Create(
            EntityQueryModelVisitor queryModelVisitor, IQuerySource querySource)
            => new InMemoryEntityQueryableExpressionVisitor(
                _model,
                _keyValueFactorySource,
                _materializerFactory,
                Check.NotNull(queryModelVisitor, nameof(queryModelVisitor)),
                querySource);
    }
}
