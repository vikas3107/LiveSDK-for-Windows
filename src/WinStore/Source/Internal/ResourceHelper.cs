// ------------------------------------------------------------------------------
// Copyright 2014 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ------------------------------------------------------------------------------

namespace Microsoft.Live
{
    using System;

#if SILVERLIGHT
    using System.Resources;

    internal static class ResourceHelper
    {
        private static readonly ResourceManager resourceManager;

        static ResourceHelper()
        {
            resourceManager = new ResourceManager(typeof(Resources));
        }

        public static string GetString(string name)
        {
            return resourceManager.GetString(name);
        }
    }
#else

    using Windows.ApplicationModel.Resources.Core;

    internal static class ResourceHelper
    {
        public static string GetString(string name)
        {
            return ResourceManager.Current.MainResourceMap.GetValue("ms-resource:///Microsoft.Live/Resources/" + name).ValueAsString;
        }
    }
#endif
}
