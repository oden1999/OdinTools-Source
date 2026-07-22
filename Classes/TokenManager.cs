using System;
using System.IO;

namespace OdinTools.Classes
{
    /// <summary>
    /// TokenManager - provides GitHub tokens for API access.
    /// Replaces the external TokenProvider.dll dependency.
    /// Token is read from odin_token.txt file in application directory.
    /// </summary>
    public static class TokenManager
    {
        private static string _cachedToken;
        private static string _tokenFilePath;

        /// <summary>
        /// Gets the token file path.
        /// </summary>
        private static string GetTokenFilePath()
        {
            if (_tokenFilePath != null)
                return _tokenFilePath;

            _tokenFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "odin_token.txt"
            );
            return _tokenFilePath;
        }

        /// <summary>
        /// Returns the GitHub token for accessing the gamesFixes repository.
        /// Reads from odin_token.txt file or environment variable.
        /// </summary>
        public static string GetGithubToken()
        {
            if (_cachedToken != null)
                return _cachedToken;

            string tokenFile = GetTokenFilePath();
            
            if (File.Exists(tokenFile))
            {
                _cachedToken = File.ReadAllText(tokenFile).Trim();
                if (!string.IsNullOrEmpty(_cachedToken))
                    return _cachedToken;
            }

            // Fallback: try environment variable
            _cachedToken = Environment.GetEnvironmentVariable("ODIN_GITHUB_TOKEN");
            
            if (string.IsNullOrEmpty(_cachedToken) || _cachedToken.Length < 10)
            {
                // Note to user: Create odin_token.txt in app folder with your GitHub PAT
                _cachedToken = "REPLACE_WITH_YOUR_GITHUB_PAT";
            }

            return _cachedToken;
        }

        /// <summary>
        /// Returns the GitHub token for accessing the onlineFixes repository.
        /// Uses the same token as both repos are under the same account.
        /// </summary>
        public static string GetGithubFixToken()
        {
            return GetGithubToken();
        }
    }
}
