﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

namespace Edna.Bindings.LtiAdvantage.Models
{
    public class LoginParams
    {
        public string TargetLinkUri { get; set; }
        public string LoginHint { get; set; }
        public string LtiMessageHint { get; set; }
    }
}