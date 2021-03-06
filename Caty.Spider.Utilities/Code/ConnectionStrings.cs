﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Caty.Spider.Utilities
{
    public class ConnectionStrings
    {
        /// <summary>
        /// 获取连接节点值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConnectionValue(string key)
        {
            if(ConfigurationManager.ConnectionStrings[key] != null)
            {
                return EncodeAndDecode.DecodeBase64(ConfigurationManager.ConnectionStrings[key].ConnectionString);
                //return ConfigurationManager.ConnectionStrings[key].ConnectionString;
            }
            return string.Empty;
        }

        public static void UpdateConnectionStringsConfig(string key,string conString)
        {
            bool isModified = false; //记录该连接字符串是否已经存在
            if(ConfigurationManager.ConnectionStrings[key] != null)
            {
                isModified = true;
            }
            //新建一个连接字符串实例
            conString = EncodeAndDecode.EncodeBase64(conString);
            ConnectionStringSettings mySettings = new ConnectionStringSettings(key, conString);
            // 打开可执行的配置文件
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //如果连接字符串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(key);
            }
            //将新的连接字符串添加到配置文件中
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            //保存对配置文件所做的更改
            config.Save(ConfigurationSaveMode.Modified);
            //强制重新载入配置文件的ConnectionString配置节
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static string GetArgsValue(string key)
        {
            if(ConfigurationManager.AppSettings[key] != null)
            {
                return ConfigurationManager.AppSettings[key];
            }
            return string.Empty;
        }

        public static void UpdateArgsValue(string key ,string value)
        {
            bool isModified = false;
            if(ConfigurationManager.AppSettings[key] != null)
            {
                isModified = true;
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (isModified)
            {
                config.AppSettings.Settings.Remove(key);
            }
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
