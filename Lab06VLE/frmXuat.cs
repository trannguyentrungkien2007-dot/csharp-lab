using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Array_LTW
{
    public partial class frmXuat : Form
    {
        //Automatic Property
        public int SoDong { get; set; }
        public int SoCot { get; set; }
        //Field
        int h = 35, margin = 5;
        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();//khởi tạo Form & control
                                  //Gán số dòng, số cột
            this.SoDong = dong;
            this.SoCot = cot;
            //Thêm các control vào form
            Button btn = null;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button();
                    btn.Width = h; btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    //gắn sự kiện cho button
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);
                    this.Controls.Add(btn);
                }
            }
        //chỉnh lại kích thước form
        this.ClientSize = new Size(SoCot * (h + margin + 1), SoDong * (h + margin +1));
        }
        private void HoChuotLenButton(object sender, EventArgs e)
        {
            this.Text = (sender as Button).Tag.ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
        public frmXuat()
        {
            InitializeComponent();
        }

        private void frmXuat_Load(object sender, EventArgs e)
        {

        }
    }
}
