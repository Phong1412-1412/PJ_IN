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
        // -------------------------------------------------------- END CREATE BUTTON -----------------------------------------------//
        public void CreateButton()
        {
            int x = 24;
            int y = 50;
            for(int i=1;i<=Connect_SQL_IN.TongGiuong();i++)
            {
                Button Giuong = new Button();
                // 
                Giuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                Giuong.BackgroundImage = global::Object_detect.Properties.Resources.bet_remove_bg;
                Giuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Giuong.ForeColor = System.Drawing.Color.White;
                Giuong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                Giuong.Location = new System.Drawing.Point(x, y);
                Giuong.Name = "button15";
                Giuong.Size = new System.Drawing.Size(125, 101);
                Giuong.TabIndex = 120;
                Giuong.Text = "Number:";
                Giuong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                Giuong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
                Giuong.UseVisualStyleBackColor = false;

                this.panel_Giuong.Controls.Add(Giuong);
                Connect_SQL_IN.HienThiThongTinGiuong(Giuong,i,lb_Phong);
                Connect_SQL_IN.TenPhong(lb_Phong);
                x += 175;
                if (i % 5 == 0)
                {
                    x = 24;
                    y += 175;
                }

            }    
        }
        public void bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            string search = bt.Text.ToString();
        }
        // -------------------------------------------------------- END CREATE BUTTON -----------------------------------------------//
        private void Statistics_of_hospital_beds_Load(object sender, EventArgs e)
        {

        }

        private void Statistics_of_hospital_beds_Load_1(object sender, EventArgs e)
        {
            lb_TongG.Text = Connect_SQL_IN.TongGiuong().ToString();
            lb_GUse.Text = Connect_SQL_IN.TongGiuongUse().ToString();
            lb_GTrong.Text = Connect_SQL_IN.TongGiuongTrong().ToString();
            CreateButton();
        }
    }
}
