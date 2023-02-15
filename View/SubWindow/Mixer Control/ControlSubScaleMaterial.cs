using htv5_mixer_control.Model.SQL_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htv5_mixer_control
{
    public partial class ControlSubScaleMaterial : Form
    {
        public ControlSubScaleMaterial()
        {
            InitializeComponent();
        }
        private DataTable GetMaterialData(string specUUID)
        {
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            DataTable dt = new DataTable();
            sqlHTV5.sqlDataAdapterFillDatatable("select * from specification_material_info where specification_uuid = '" + specUUID + "'", ref dt);
            return dt;
        }

        private void ControlSubScaleMaterial_Load(object sender, EventArgs e)
        {
            DataTable dt = GetMaterialData(SaveVariables.ControlSelectedSpecUUID);
            for(int i = 0; i < dt.Rows.Count; i ++)
            {
                CustomDataRow customData = new CustomDataRow(dt.Rows[i]["uuid"].ToString(), dt.Rows[i]["material_code"].ToString(), dt.Rows[i]["weight"].ToString(), dt.Rows[i]["tolerance"].ToString(), "N/A");
                flpMaterialList.Controls.Add(customData);
            }
        }
    }
}
