﻿using htv5_mixer_control.Model.SQL_Class;
using java.util;
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
    public partial class ControlSubChooseSpecification : Form
    {
        public ControlSubChooseSpecification()
        {
            InitializeComponent();
        }

        public DataTable GetSpecListData(string keyword)
        {
            DataTable dt = new DataTable();
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            StringBuilder stringBuilder = new StringBuilder();
            if (!String.IsNullOrEmpty(keyword))
            {
                stringBuilder.Append("select specification_uuid, specification_code, specification_lot_no, create_date from specification_info where specification_code like '%" + keyword + "%' or specification_lot_no like '%" + keyword + "%' order by create_date desc");
            }
            else
            {
                stringBuilder.Append("select specification_uuid, specification_code, specification_lot_no, create_date from specification_info order by create_date desc");
            }
            sqlHTV5.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);
            return dt;
        }
        public DataTable GetSpecMaterialsData(string specUUID)
        {
            DataTable dt = new DataTable();
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("select * from specification_material_info where specification_uuid = '" + specUUID + "'");
            sqlHTV5.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);
            return dt;
        }

        public DataTable GetSpecProcessData(string specUUID)
        {
            DataTable dt = new DataTable();
            sqlHTV5ControlCon sqlHTV5 = new sqlHTV5ControlCon();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("select * from specification_process where specification_uuid = '" + specUUID + "' order by process_no asc");
            sqlHTV5.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);
            return dt;
        }

        private void LoadData2DTGV()
        {
            if (GetSpecListData(txbSearchSpec.Text.Trim()).Rows.Count > 0)
            {
                dtgvShowCreatedSpec.DataSource = GetSpecListData(txbSearchSpec.Text.Trim());
                dtgvShowCreatedSpec.Columns["specification_uuid"].Visible = false;
                dtgvShowCreatedSpec.Columns["specification_code"].HeaderText = "Mã quy cách";
                dtgvShowCreatedSpec.Columns["specification_lot_no"].HeaderText = "Số lô";
                dtgvShowCreatedSpec.Columns["create_date"].HeaderText = "Ngày tạo";
                dtgvShowCreatedSpec.Columns["create_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            
        }

        private void ControlSubChooseSpecification_Load(object sender, EventArgs e)
        {
            btnSearchSpec.ButtonText = "Tìm kiếm" + Environment.NewLine + "搜索";
            btnConfirm.ButtonText = "Xác nhận" + Environment.NewLine + "确认规格选择";
            LoadData2DTGV();
        }

        private void dtgvShowCreatedSpec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowCreatedSpec.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowCreatedSpec.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowCreatedSpec.Rows[selectedrowindex];
                SaveVariables.ControlSelectedSpecUUID = Convert.ToString(selectedRow.Cells["specification_uuid"].Value);
                if (GetSpecMaterialsData(SaveVariables.ControlSelectedSpecUUID).Rows.Count > 0)
                {
                    dtgvMaterialsInfo.DataSource = GetSpecMaterialsData(SaveVariables.ControlSelectedSpecUUID);
                    dtgvMaterialsInfo.Columns["uuid"].Visible = false;
                    dtgvMaterialsInfo.Columns["specification_uuid"].Visible = false;
                    dtgvMaterialsInfo.Columns["actual_weight"].Visible = false;
                    dtgvMaterialsInfo.Columns["create_date"].Visible = false;
                    dtgvMaterialsInfo.Columns["create_by"].Visible = false;
                    dtgvMaterialsInfo.Columns["update_date"].Visible = false;
                    dtgvMaterialsInfo.Columns["update_by"].Visible = false;
                    dtgvMaterialsInfo.Columns["delete_flag"].Visible = false;
                    dtgvMaterialsInfo.Columns["is_packed"].Visible = false;
                    dtgvMaterialsInfo.Columns["material_code"].HeaderText = "Mã liệu";
                    dtgvMaterialsInfo.Columns["material_lot_no"].HeaderText = "Số lot";
                    dtgvMaterialsInfo.Columns["weight"].HeaderText = "Trọng lượng";
                    dtgvMaterialsInfo.Columns["tolerance"].HeaderText = "Dung sai";
                }
                if (GetSpecProcessData(SaveVariables.ControlSelectedSpecUUID).Rows.Count > 0)
                {
                    dtgvProcessInfo.DataSource = GetSpecProcessData(SaveVariables.ControlSelectedSpecUUID);
                    dtgvProcessInfo.Columns["uuid"].Visible = false;
                    dtgvProcessInfo.Columns["specification_uuid"].Visible = false;
                    dtgvProcessInfo.Columns["is_running"].Visible = false;
                    dtgvProcessInfo.Columns["is_completed"].Visible = false;
                    dtgvProcessInfo.Columns["delete_flag"].Visible = false;
                    dtgvProcessInfo.Columns["process_no"].HeaderText = "STT";
                    dtgvProcessInfo.Columns["material_remark"].HeaderText = "Nội dung";
                    dtgvProcessInfo.Columns["set_speed"].HeaderText = "Tốc độ quay ban đầu";
                    dtgvProcessInfo.Columns["set_temperature"].HeaderText = "Nhiệt độ";
                    dtgvProcessInfo.Columns["set_time"].HeaderText = "Thời gian ban đầu";
                    dtgvProcessInfo.Columns["set_speed_2"].HeaderText = "Tốc độ quay sau";
                    dtgvProcessInfo.Columns["set_time_2"].HeaderText = "Thời gian sau";
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SaveVariables.ControlSelectedSpecUUID))
            {
                ControlSubScaleMaterial controlSubScaleMaterial = new ControlSubScaleMaterial();
                controlSubScaleMaterial.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quy cách muốn thực hiện!" + Environment.NewLine + "请选择您要实施的方法！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
