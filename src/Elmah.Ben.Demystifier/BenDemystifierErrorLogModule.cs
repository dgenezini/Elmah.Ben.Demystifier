#region License, Terms and Author(s)
//
// Elmah.Ben.Demystifier Http Modules for Elmah
// Copyright (c) 2018 Daniel Genezini. All rights reserved.
//
//  Author(s):
//
//      Daniel Genezini
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Diagnostics;
using System.Web;

namespace Elmah.Ben.Demystifier
{
    /// <summary>
    /// HTTP module implementation that uses Ben.Demystifier and logs unhandled exceptions in an
    /// ASP.NET Web application to an error log.
    /// </summary>

    public class BenDemystifierErrorLogModule : ErrorLogModule
    {
        /// <summary>
        /// Logs an exception and its context to the error log.
        /// </summary>

        protected override void LogException(Exception e, HttpContext context)
        {
            if (e == null)
                throw new ArgumentNullException("e");
            
            base.LogException(e.Demystify(), context);
        }
    }
}
