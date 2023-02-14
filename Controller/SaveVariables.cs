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
        public static String SelectedMat { get; set; }
        public static DataTable MaterialList { get; set; }

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
        }
    }
}
