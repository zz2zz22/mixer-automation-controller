using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htv5_mixer_control
{
    public class ToolSupport
    {
        public static bool checkAdmin(string EmpUUID)
        {
            sqlSOFTCon sqlSOFT = new sqlSOFTCon();
            if (EmpUUID != String.Empty)
            {
                string rs = sqlSOFT.sqlExecuteScalarString("select user_permission from base_user_info where uuid = '" + EmpUUID + "'");
                if (rs == "admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else
                return false;
        }
        public static bool checkAccount(string username, string password)
        {
            sqlSOFTCon sqlSOFT = new sqlSOFTCon();
            if (username != String.Empty && password != String.Empty)
            {
                string rsu = sqlSOFT.sqlExecuteScalarString("select distinct user_name from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                if (rsu != String.Empty)
                {

                    string rsp = sqlSOFT.sqlExecuteScalarString("select user_password from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                    if (rsp != String.Empty) {
                        if (rsp == password) {
                            SaveVariables.OperatorUUID = sqlSOFT.sqlExecuteScalarString("select distinct uuid from base_user_info where user_name = '" + username + "' and account_app = 'HTV5-Controller'");
                            return true; 
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false;}
            }else { return false;}
        }
    }
}
