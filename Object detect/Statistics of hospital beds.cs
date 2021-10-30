using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_detect
{
    public partial class Statistics_of_hospital_beds : Form
    {
        public Statistics_of_hospital_beds()
        {
            InitializeComponent();
        }

        private void Statistics_of_hospital_beds_Load(object sender, EventArgs e)
        {
            lb_GT.Text = Connect_SQL_IN.TongGiuongTrong().ToString();
            lb_GU.Text = Connect_SQL_IN.TongGiuongUse().ToString();
            lb_TongG.Text = Connect_SQL_IN.TongGiuong().ToString();
        }


    }
}
