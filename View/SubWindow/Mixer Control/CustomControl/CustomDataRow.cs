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
    public partial class CustomDataRow : UserControl
    {
        public CustomDataRow(string uuid, string matCode, string weight, string tolerance, string status)
        {
            InitializeComponent();
            lbUUID.Text = uuid;
            lbMatCode.Text = matCode;
            lbWeight.Text = weight;
            lbTolerane.Text = tolerance;
            lbStatus.Text = status;
            if (status == "OK")
            {
                panelStatus.BackColor = Color.Yellow;
                lbStatus.ForeColor = Color.Black;
            }
            else
            {
                panelStatus.BackColor = Color.Red;
                lbStatus.ForeColor = Color.White;
            }
        }

        private void CustomDataRow_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Height = 60;
        }

        public string GetUUID
        {
            get
            {
                return lbUUID.Text;
            }

            set
            {
                lbUUID.Text = value;
            }
        }

        public string GetCode
        { 
            get
            {
                return lbMatCode.Text;
            }

            set
            {
                lbMatCode.Text = value;
            }
        }

        class CusDataRowControlCollection : ControlCollection
        {
            CustomDataRow owner;

            public CusDataRowControlCollection(CustomDataRow owner) : base(owner)
            {
                this.owner = owner;
            }

            public override void Add(Control value)
            {
                base.Add(value);
                value.Click += Value_Click;
            }

            private void Value_Click(object sender, EventArgs e)
            {
                owner.OnClick(EventArgs.Empty);
            }
        }

        protected override ControlCollection CreateControlsInstance()
        {
            return new CusDataRowControlCollection(this);
        }
    }
}
