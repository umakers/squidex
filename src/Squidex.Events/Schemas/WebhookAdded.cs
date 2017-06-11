﻿// ==========================================================================
//  WebhookAdded.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using Squidex.Infrastructure;

namespace Squidex.Events.Schemas
{
    [TypeName("WebhookAddedEvent")]
    public sealed class WebhookAdded : SchemaEvent
    {
        public Guid Id { get; set; }

        public Uri Url { get; set; }

        public string SecurityToken { get; set; }
    }
}
