using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace testwinform
{
    public partial class PersonalRegister : Form
    {
        public PersonalRegister()
        {
            InitializeComponent();// 初始化组件
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PersonalRegister_MouseUp(object sender, MouseEventArgs e)
        {
            //  收到鼠标右击
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point pos = new Point(e.X, e.Y);
                this.ContextMenu.Show(pos);// 显示上下文菜单
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selecticon_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfiledlg = new OpenFileDialog();// 显示选择文件对话框
            if(opfiledlg.ShowDialog()==DialogResult.OK)
            {
                int index = 7;
                pictureBox1.Image = Image.FromFile(opfiledlg.FileName);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, "头像：" + opfiledlg.FileName);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opfiledlg = new OpenFileDialog();// 显示选择文件对话框
            if (opfiledlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfiledlg.FileName);
            }
        }

        private void setfont_Click(object sender, EventArgs e)
        {
            FontDialog fondlg = new FontDialog();// 显示字体设置对话框
            if (fondlg.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Font = fondlg.Font;
            }
        }

        private void setcolor_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.ForeColor = colordlg.Color;
            }
        }

        private void openfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                PersonalRegister newform = new PersonalRegister();
                FileStream file = new FileStream(ofdlg.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(file);
                newform.Show();
                newform.listBox1.Items.Clear();
                // name
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.textBox1.Text = msg.Substring(3);
                // 血型
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "A")
                {
                    newform.comboBox1.SelectedIndex = 0;
                }
                else if (msg.Substring(3) == "B")
                {
                    newform.comboBox1.SelectedIndex = 1;
                }
                else if (msg.Substring(3) == "O")
                {
                    newform.comboBox1.SelectedIndex = 2;
                }
                else if (msg.Substring(3) == "AB")
                {
                    newform.comboBox1.SelectedIndex = 3;
                }
                // 性别
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "男")
                {
                    newform.gender_boy.Checked = true;
                }

                if (msg.Substring(3) == "女")
                {
                    newform.gender_girl.Checked = true;
                }
                // 生日
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                //newform.dateTimePicker1.Value = DateTime.ParseExact( msg.Substring(3),"yyyy-MM-dd", CultureInfo.CurrentCulture);

                // 兴趣爱好
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.IndexOf("唱歌") != -1)
                {
                    newform.checkBox1.Checked = true;
                }
                if (msg.IndexOf("爬山") != -1)
                {
                    newform.checkBox2.Checked = true;
                }
                if (msg.IndexOf("看书") != -1)
                {
                    newform.checkBox3.Checked = true;
                }
                if (msg.IndexOf("打球") != -1)
                {
                    newform.checkBox4.Checked = true;
                }
                // 籍贯
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);

                // 个人简介
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.richTextBox2.Text = msg.Substring(5);

                // 照片
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Length > 3)
                    newform.pictureBox1.Image = Image.FromFile(msg.Substring(3));

            }
        }

        private void openfontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fondlg = new FontDialog();// 显示字体设置对话框
            if (fondlg.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Font = fondlg.Font;
            }
        }

        private void opencolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.ForeColor = colordlg.Color;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, "姓名：" + textBox1.Text);
          
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, "血型：" + comboBox1.Text);
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 2;
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, "生日：" + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }

        private void gender_boy_MouseDown(object sender, MouseEventArgs e)
        {
            int index = 3;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, "性别：" + gender_boy.Text);
        }

        private void gender_girl_MouseDown(object sender, MouseEventArgs e)
        {
            int index = 3;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, "性别：" + gender_girl.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 4;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = "爱好：";
            if (checkBox1.Checked)
            {
                str += "唱歌 ";
            }
            if (checkBox2.Checked)
            {
                str += "爬山 ";
            }
            if (checkBox3.Checked)
            {
                str += "看书 ";
            }
            if (checkBox4.Checked)
            {
                str += "打球 ";
            }
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, str);
        }

        private void treeView1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 5;
        }

        private void treeView1_Leave(object sender, EventArgs e)
        {
            string str = "籍贯：";
            int index = listBox1.SelectedIndex;
            str += treeView1.SelectedNode.Text;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, str);
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 6;
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            string str = "个人简介：";
            int index = listBox1.SelectedIndex;
            str += richTextBox2.Text;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, str);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            if (frm1.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfdlg.OverwritePrompt = true;
                if (sfdlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdlg.FileName);
                    foreach (object item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine(listBox1.Font);
                    sw.WriteLine(listBox1.ForeColor);
                    sw.Flush();
                    sw.Close();
                }
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfdlg.OverwritePrompt = true;
            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfdlg.FileName);
                foreach (object item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.WriteLine(listBox1.Font);
                sw.WriteLine(listBox1.ForeColor);
                sw.Flush();
                sw.Close();
            }
        }

        private void newNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegister prform = new PersonalRegister();
            prform.Show();
        }

        private void closeCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            if (frm1.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfdlg.OverwritePrompt = true;
                if (sfdlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdlg.FileName);
                    foreach (object item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine(listBox1.Font);
                    sw.WriteLine(listBox1.ForeColor);
                    sw.Flush();
                    sw.Close();
                }
            }
            this.Close();
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            if (frm1.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfdlg.OverwritePrompt = true;
                if (sfdlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdlg.FileName);
                    foreach (object item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine(listBox1.Font);
                    sw.WriteLine(listBox1.ForeColor);
                    sw.Flush();
                    sw.Close();
                }
            }
            this.Close();
        }

        private void fileFCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegister prform = new PersonalRegister();
            prform.Show();
        }

        private void blankBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegister prform = new PersonalRegister();
            prform.Show();
        }

        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                PersonalRegister newform = new PersonalRegister();
                FileStream file = new FileStream(ofdlg.FileName,FileMode.Open);
                StreamReader sr = new StreamReader(file);
                newform.Show();
                newform.listBox1.Items.Clear();
                // name
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.textBox1.Text = msg.Substring(3);
                // 血型
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "A")
                {
                    newform.comboBox1.SelectedIndex = 0;
                }
                else if (msg.Substring(3) == "B")
                {
                    newform.comboBox1.SelectedIndex = 1;
                }
                else if (msg.Substring(3) == "O")
                {
                    newform.comboBox1.SelectedIndex = 2;
                }
                else if (msg.Substring(3) == "AB")
                {
                    newform.comboBox1.SelectedIndex = 3;
                }
                // 性别
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "男")
                {
                    newform.gender_boy.Checked=true;
                }

                if (msg.Substring(3) == "女")
                {
                    newform.gender_girl.Checked = true;
                }
                // 生日
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                //newform.dateTimePicker1.Value = DateTime.ParseExact( msg.Substring(3),"yyyy-MM-dd", CultureInfo.CurrentCulture);

                // 兴趣爱好
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.IndexOf("唱歌")!=-1)
                {
                    newform.checkBox1.Checked = true;
                }
                if (msg.IndexOf("爬山") != -1)
                {
                    newform.checkBox2.Checked = true;
                }
                if (msg.IndexOf("看书") != -1)
                {
                    newform.checkBox3.Checked = true;
                }
                if (msg.IndexOf("打球") != -1)
                {
                    newform.checkBox4.Checked = true;
                }
                // 籍贯
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);

                // 个人简介
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.richTextBox2.Text = msg.Substring(5);

                // 照片
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Length>3) 
                newform.pictureBox1.Image = Image.FromFile(msg.Substring(3));
                
            }
        }

        private void projectPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegister prform = new PersonalRegister();
            prform.Show();
        }

        private void addnewitemWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalRegister prform = new PersonalRegister();
            prform.Show();
        }

        private void addexistingitemGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                PersonalRegister newform = new PersonalRegister();
                FileStream file = new FileStream(ofdlg.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(file);
                newform.Show();
                newform.listBox1.Items.Clear();
                // name
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.textBox1.Text = msg.Substring(3);
                // 血型
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "A")
                {
                    newform.comboBox1.SelectedIndex = 0;
                }
                else if (msg.Substring(3) == "B")
                {
                    newform.comboBox1.SelectedIndex = 1;
                }
                else if (msg.Substring(3) == "O")
                {
                    newform.comboBox1.SelectedIndex = 2;
                }
                else if (msg.Substring(3) == "AB")
                {
                    newform.comboBox1.SelectedIndex = 3;
                }
                // 性别
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "男")
                {
                    newform.gender_boy.Checked = true;
                }

                if (msg.Substring(3) == "女")
                {
                    newform.gender_girl.Checked = true;
                }
                // 生日
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                //newform.dateTimePicker1.Value = DateTime.ParseExact( msg.Substring(3),"yyyy-MM-dd", CultureInfo.CurrentCulture);

                // 兴趣爱好
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.IndexOf("唱歌") != -1)
                {
                    newform.checkBox1.Checked = true;
                }
                if (msg.IndexOf("爬山") != -1)
                {
                    newform.checkBox2.Checked = true;
                }
                if (msg.IndexOf("看书") != -1)
                {
                    newform.checkBox3.Checked = true;
                }
                if (msg.IndexOf("打球") != -1)
                {
                    newform.checkBox4.Checked = true;
                }
                // 籍贯
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);

                // 个人简介
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.richTextBox2.Text = msg.Substring(5);

                // 照片
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Length > 3)
                    newform.pictureBox1.Image = Image.FromFile(msg.Substring(3));

            }
        }

        private void addprojDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                PersonalRegister newform = new PersonalRegister();
                FileStream file = new FileStream(ofdlg.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(file);
                newform.Show();
                newform.listBox1.Items.Clear();
                // name
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.textBox1.Text = msg.Substring(3);
                // 血型
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "A")
                {
                    newform.comboBox1.SelectedIndex = 0;
                }
                else if (msg.Substring(3) == "B")
                {
                    newform.comboBox1.SelectedIndex = 1;
                }
                else if (msg.Substring(3) == "O")
                {
                    newform.comboBox1.SelectedIndex = 2;
                }
                else if (msg.Substring(3) == "AB")
                {
                    newform.comboBox1.SelectedIndex = 3;
                }
                // 性别
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Substring(3) == "男")
                {
                    newform.gender_boy.Checked = true;
                }

                if (msg.Substring(3) == "女")
                {
                    newform.gender_girl.Checked = true;
                }
                // 生日
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                //newform.dateTimePicker1.Value = DateTime.ParseExact( msg.Substring(3),"yyyy-MM-dd", CultureInfo.CurrentCulture);

                // 兴趣爱好
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.IndexOf("唱歌") != -1)
                {
                    newform.checkBox1.Checked = true;
                }
                if (msg.IndexOf("爬山") != -1)
                {
                    newform.checkBox2.Checked = true;
                }
                if (msg.IndexOf("看书") != -1)
                {
                    newform.checkBox3.Checked = true;
                }
                if (msg.IndexOf("打球") != -1)
                {
                    newform.checkBox4.Checked = true;
                }
                // 籍贯
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);

                // 个人简介
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                newform.richTextBox2.Text = msg.Substring(5);

                // 照片
                msg = sr.ReadLine();
                newform.listBox1.Items.Add(msg);
                if (msg.Length > 3)
                    newform.pictureBox1.Image = Image.FromFile(msg.Substring(3));

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
