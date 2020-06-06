﻿using NLog;
using RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using System.Web.Services;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3
{
    /// <summary>
    /// Summary description for OptionObjectService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class OptionObjectService : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            return "v.1.0.0";
        }

        [WebMethod]
        public OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            OptionObject returnOptionObject = new OptionObject();
            string scriptName = parameter != null ? parameter.Split(',')[0] : "";
            logger.Debug("Script '" + scriptName + "' requested.");

            switch (scriptName)
            {
                case "DisableAllFields":
                    returnOptionObject = DisableAllFields.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode0":
                    returnOptionObject = GetErrorCode0.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode1":
                    returnOptionObject = GetErrorCode1.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode2":
                    returnOptionObject = GetErrorCode2.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode3":
                    returnOptionObject = GetErrorCode3.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode4":
                    returnOptionObject = GetErrorCode4.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode5":
                    returnOptionObject = GetErrorCode5.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetErrorCode6":
                    returnOptionObject = GetErrorCode6.RunScript(optionObject);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "GetFieldValue":
                    returnOptionObject = GetFieldValue.RunScript(optionObject, parameter);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                case "SetFieldValue":
                    returnOptionObject = SetFieldValue.RunScript(optionObject, parameter);
                    logger.Debug("Script '" + scriptName + "' returned.");
                    break;
                default:
                    logger.Warn("ScriptName '" + scriptName + "' does not match an existing script.");
                    returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);
                    break;
            }

            return returnOptionObject;
        }
    }
}
