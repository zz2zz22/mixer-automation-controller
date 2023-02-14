using com.sun.org.apache.xalan.@internal.xsltc.compiler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htv5_mixer_control
{
    public class SaveVariables
    {
        public static String OperatorUUID { get; set; }
        public static String SelectedMatUUID { get; set; }
        public static String SelectedProcessUUID { get; set; }


        public static DataTable MaterialList { get; set; }
        public static DataTable ProcessList { get; set; }

        public static void addMatColumn()
        {
            MaterialList = new DataTable();
            DataColumn matCol;

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "uuid";
            MaterialList.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "mat_name";
            MaterialList.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "lot_no";
            MaterialList.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.Double");
            matCol.ColumnName = "weight";
            MaterialList.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.Double");
            matCol.ColumnName = "tolerance";
            MaterialList.Columns.Add(matCol);
        }
        public static void ResetTempMat()
        {
            MaterialList.Clear();
            MaterialList.AcceptChanges();
            MaterialList = null;
        }


        public static void addProcessColumn()
        {
            ProcessList = new DataTable();
            DataColumn processCol;

            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.String");
            processCol.ColumnName = "uuid";
            ProcessList.Columns.Add(processCol);

            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.String");
            processCol.ColumnName = "process_no";
            ProcessList.Columns.Add(processCol);

            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.String");
            processCol.ColumnName = "remark";
            ProcessList.Columns.Add(processCol);

            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.Double");
            processCol.ColumnName = "speed";
            ProcessList.Columns.Add(processCol);

            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.Double");
            processCol.ColumnName = "temperature";
            ProcessList.Columns.Add(processCol);
            
            processCol = new DataColumn();
            processCol.DataType = Type.GetType("System.Double");
            processCol.ColumnName = "time";
            ProcessList.Columns.Add(processCol);
        }

        public static void ResetTempProcess()
        {
            ProcessList.Clear();
            ProcessList.AcceptChanges();
            ProcessList = null;
        }
    }
}
