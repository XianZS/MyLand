using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Stu.Instance.PicturePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.Filter = "jpeg 文件(*.jpg)|*.jpg|bmp 文件(*.bmp) | *.bmp | gif 文件(*.gif) | *.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "选择学生照片";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            Stu.Instance.PicturePath = path;
            pictureBox1.Image = Image.FromFile(Stu.Instance.PicturePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stu.Instance.info += "学号:" + textBox1.Text.ToString() + "\n" + "姓名:" + textBox2.Text.ToString() + "\n";
            foreach(Control control in groupBox2.Controls)
            {
                if ((control as RadioButton).Checked == true)
                {
                    Stu.Instance.info += "性别" + (control as RadioButton).Text + "\n";
                }
            }
            Stu.Instance.info += "出生日期" + dateTimePicker1.Text.ToString() + "\n";
            Stu.Instance.info += "专业" + comboBox1.Text.ToString() + "\n";
            Stu.Instance.info += "奖惩情况:" + listBox1.Text.ToString() + "\n";
            foreach(Control control1 in groupBox3.Controls)
            {
                if((control1 as CheckBox).Checked == true)
                {
                    Stu.Instance.info += "爱好:" + (control1 as CheckBox).Text + "\n";
                }
            }
            Stu.Instance.info += "备注信息:" + textBox3.Text.ToString();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
