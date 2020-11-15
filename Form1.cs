using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_3A713133
{
    public partial class Form1 : Form
    {
        MD5 md5 = MD5.Create();//建立一個MD5
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string input_str = tex.Text;
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] source = Encoding.Default.GetBytes(tex.Text);//將字串轉為Byte[]
            byte[] crypto = md5.ComputeHash(source);//進行MD5加密
            string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
            rich.Text = "輸出結果: "+"\n"+ result;
        }
    }
}
