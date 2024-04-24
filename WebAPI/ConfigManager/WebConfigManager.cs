﻿#region Namespace
using ConfigManager.Interfaces;
using Microsoft.Extensions.Configuration;
#endregion

namespace ConfigManager
{
    #region WebConfigManager
    /// <summary>
    /// WebConfigManager
    /// </summary>
    public class WebConfigManager : Interfaces.IConfigurationManager
    {
        #region Variables
        /// <summary>
        /// configuration
        /// </summary>
        private IConfiguration configuration { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_configuration"></param>
        public WebConfigManager(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        #endregion

        #region Public Methods

        #region GetConfigValue
        /// <summary>
        /// GetConfigValue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetConfigValue(string key)
        {
            string value = configuration.GetSection("AppSettings").GetSection(key).Value.ToString();

            return value;
        }
        #endregion

        #region GetConnectionString
        /// <summary>
        /// GetConnectionString
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            string value = configuration.GetSection("ConnectionStrings").GetSection("DBConnectionString").Value.ToString();

            return value;
        }
        #endregion

        #region GetJWTConfig
        /// <summary>
        /// GetJWTConfig
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetJWTConfig(string key)
        {
            string value = configuration.GetSection("Jwt").GetSection(key).Value.ToString();

            return value;
        }
        #endregion

        #region GetEmailConfig
        /// <summary>
        /// GetEmailConfig
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetEmailConfig(string key)
        {
            string value = configuration.GetSection("Email").GetSection(key).Value.ToString();

            return value;
        }
        #endregion

        #endregion
    }
    #endregion
}
