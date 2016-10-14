﻿using System;
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Messaging
{
    public enum ReceiveMode
    {
        /// <summary>Specifies the PeekLock receive mode. This is the default value for <see cref="Microsoft.ServiceBus.Messaging.ReceiveMode" />.</summary>
        PeekLock,
        /// <summary>Specifies the ReceiveAndDelete receive mode.</summary>
        ReceiveAndDelete
    }
}
