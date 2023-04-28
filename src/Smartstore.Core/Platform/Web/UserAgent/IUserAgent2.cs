﻿#nullable enable

namespace Smartstore.Core.Web
{
    /// <summary>
    /// Provides parsed and materialized user agent information.
    /// </summary>
    public interface IUserAgent2
    {
        /// <summary>
        /// The raw user agent string.
        /// </summary>
        string UserAgent { get; set; }

        /// <summary>
        /// Type of user agent, see <see cref="UserAgentType"/>
        /// </summary>
        UserAgentType Type { get; }

        /// <summary>
        /// Name of user agent, e.g. "Chrome", "Edge", "Firefox", "Opera Mobile", "Googlebot" etc.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Version of user agent.
        /// </summary>
        SemanticVersion? Version { get; }

        /// <summary>
        /// Platform/OS of user agent, see <see cref="UserAgentPlatform"/>.
        /// </summary>
        UserAgentPlatform Platform { get; }

        /// <summary>
        /// Device name of agent, e.g. "Android", "Apple iPhone", "BlackBerry", "Samsung", "PlayStation", "Windows CE" etc.
        /// </summary>
        UserAgentDevice Device { get; }

        /// <summary>
        /// Checks whether the user agent supports the WebP image type.
        /// </summary>
        bool SupportsWebP { get; }
    }
}