using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace htv5_mixer_control
{
    public class UploadMain
    {
        public static string specUUID;
        public static DateTime date;
        public static string insertSpecificationInfo(string specCode, string lotNo, string empCode)
        {
            date = DateTime.Now;
            specUUID = UUIDGenerator.getAscId();
            StringBuilder insertSI = new StringBuilder();
            insertSI.Append("insert into specification_info ");
            insertSI.Append("(specification_uuid, specification_code, specification_lot_no, create_date, create_by, update_date, update_by, delete_flag) ");
            insertSI.Append(" values ");
            insertSI.Append("('" + specUUID + "', '" + specCode + "', '" + lotNo + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + empCode + "', NULL, NULL, '0')");
            return insertSI.ToString();
        }
        public static string insertSpecMaterials(DataTable matDT, int i, string empCode)
        {
            StringBuilder insertSM = new StringBuilder();
            insertSM.Append("insert into specification_material_info ");
            insertSM.Append("(uuid, specification_uuid, material_code, material_lot_no, weight, tolerance, ");
            insertSM.Append("actual_weight, create_date, create_by, update_date, update_by, delete_flag) ");
            insertSM.Append(" values ");
            insertSM.Append("( '" + matDT.Rows[i]["uuid"].ToString() + "', '" + specUUID + "', '" + matDT.Rows[i]["mat_name"].ToString() + "', N'" + matDT.Rows[i]["lot_no"].ToString() + "', '" + matDT.Rows[i]["weight"].ToString() + "', '" + matDT.Rows[i]["tolerance"].ToString() + "', ");
            insertSM.Append("NULL, '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + empCode + "', NULL, NULL, '0')");
            return insertSM.ToString();
        }

        public static string insertSpecProcess(DataTable processDT, int i, string empCode)
        {
            string speed = processDT.Rows[i]["speed"].ToString();
            string temperature = processDT.Rows[i]["temperature"].ToString();
            string time = processDT.Rows[i]["time"].ToString();
            if (String.IsNullOrEmpty(speed))
                speed = "NULL";
            if (String.IsNullOrEmpty(temperature))
                temperature = "NULL";
            if (String.IsNullOrEmpty(time))
                time = "NULL";

            StringBuilder insertSP = new StringBuilder();
            insertSP.Append("insert into specification_process ");
            insertSP.Append("(uuid, specification_uuid, process_no, is_running, is_completed, set_speed, set_temperature, set_time, delete_flag, material_remark)");
            insertSP.Append(" values ");
            insertSP.Append("('" + processDT.Rows[i]["uuid"].ToString() + "', '" + specUUID + "', '" + (i+1).ToString() + "', 1, 1, " + speed + ", " + temperature + ", " + time + ", 0, N'" + processDT.Rows[i]["remark"].ToString() + "')");
            return insertSP.ToString();
        }

        public static void transactionSupportUploadData(DataTable matDT, DataTable processDT, string specCode, string lotNo, string empCode)
        {

            string cmdISI = UploadMain.insertSpecificationInfo(specCode, lotNo, empCode);
            string cmdISM, cmdISP;
            SqlConnection conn = DatabaseUtils.GetHTV5ControlDBConnection();
            SqlTransaction trans = null;
            SqlCommand cmdMS = new SqlCommand();
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();
                cmdMS.Transaction = trans;
                cmdMS.Connection = conn;
                if (!String.IsNullOrEmpty(cmdISI))
                {
                    cmdMS.CommandText = cmdISI;
                    cmdMS.ExecuteNonQuery();
                }
                else
                {
                    throw new ArgumentException("SI Command text cannot null");
                }

                for (int i = 0; i < matDT.Rows.Count; i++)
                {
                    cmdISM = UploadMain.insertSpecMaterials(matDT, i, empCode);
                    if (!String.IsNullOrEmpty(cmdISM))
                    {
                        cmdMS.CommandText = cmdISM;
                        cmdMS.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new ArgumentException("SM command text cannot null");
                    }
                }
                for (int j = 0; j < processDT.Rows.Count; j++)
                {
                    cmdISP = UploadMain.insertSpecProcess(processDT, j, empCode);
                    if (!String.IsNullOrEmpty(cmdISP))
                    {
                        cmdMS.CommandText = cmdISP;
                        cmdMS.ExecuteNonQuery();
                    }
                    else { throw new ArgumentException("SP command text cannot null"); }
                }
                trans.Commit();
                MessageBox.Show("Succesfully saved data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu dữ liệu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trans.Rollback();
            }
        }
    }
}
