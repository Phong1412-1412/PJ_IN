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
            HienTHiTenPhong();
            lb_GT.Text = Connect_SQL_IN.TongGiuongTrong().ToString();
            lb_GU.Text = Connect_SQL_IN.TongGiuongUse().ToString();
            lb_TongG.Text = Connect_SQL_IN.TongGiuong().ToString();
            HienThiGiuong();
        }

        //---------------------------------Create giường bệnh---------------------------------
        public void HienThiGiuong()
        {
            int x = 50;
            int y = 75;
            for(int i = 1; i <= Connect_SQL_IN.TongGiuong(); i++)
            {
                Button giuong = new Button();
                giuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                giuong.BackgroundImage = global::Object_detect.Properties.Resources.bet_remove_bg;
                giuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                giuong.ForeColor = System.Drawing.Color.White;
                giuong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                giuong.Location = new System.Drawing.Point(x, y);
                giuong.Name = "button4";
                giuong.Size = new System.Drawing.Size(125, 101);
                giuong.TabIndex = 91;
                giuong.Text = "Number:";
                giuong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                giuong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
                giuong.UseVisualStyleBackColor = false;
                this.panel_Gương.Controls.Add(giuong);
                Connect_SQL_IN.HienThiTTGiuong(giuong,i);
                x += 160;
                if (i % 5 == 0)
                {
                    x = 50;
                    y += 160;
                }


            }
        }
        //---------------------------------END: create giường bệnh----------------------------

        public void HienTHiTenPhong()
        {
            Connect_SQL_IN.HienThiCBB("SELECT MaPhong, TenPhong FROM phong","MaPhong","TenPhong",cbb_TenPhong);
        }

        private void cbb_TenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbb_TenPhong.SelectedValue.ToString());
        }
    }
}
