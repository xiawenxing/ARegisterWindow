namespace testwinform
{
    partial class PersonalRegister
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("南京");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("苏州");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("镇江");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("江苏", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("杭州");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("宁波");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("乌镇");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("浙江", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalRegister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileFCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addnewitemWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addexistingitemGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addprojDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opencolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openfontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opencolorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.name = new System.Windows.Forms.Label();
            this.bloodtype = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.birthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gender_boy = new System.Windows.Forms.RadioButton();
            this.gender_girl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.selecticon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ok = new System.Windows.Forms.Button();
            this.setfont = new System.Windows.Forms.Button();
            this.setcolor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dlgDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNToolStripMenuItem,
            this.openOToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeCToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addnewitemWToolStripMenuItem,
            this.addexistingitemGToolStripMenuItem,
            this.addprojDToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitXToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newNToolStripMenuItem
            // 
            this.newNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectPToolStripMenuItem,
            this.fileFCtrlNToolStripMenuItem,
            this.blankBToolStripMenuItem});
            this.newNToolStripMenuItem.Name = "newNToolStripMenuItem";
            this.newNToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.newNToolStripMenuItem.Text = "新建(&N)";
            this.newNToolStripMenuItem.Click += new System.EventHandler(this.newNToolStripMenuItem_Click);
            // 
            // projectPToolStripMenuItem
            // 
            this.projectPToolStripMenuItem.Checked = true;
            this.projectPToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.projectPToolStripMenuItem.Name = "projectPToolStripMenuItem";
            this.projectPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.projectPToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.projectPToolStripMenuItem.Text = "项目(&P)";
            this.projectPToolStripMenuItem.Click += new System.EventHandler(this.projectPToolStripMenuItem_Click);
            // 
            // fileFCtrlNToolStripMenuItem
            // 
            this.fileFCtrlNToolStripMenuItem.Name = "fileFCtrlNToolStripMenuItem";
            this.fileFCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileFCtrlNToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fileFCtrlNToolStripMenuItem.Text = "文件(&F)";
            this.fileFCtrlNToolStripMenuItem.Click += new System.EventHandler(this.fileFCtrlNToolStripMenuItem_Click);
            // 
            // blankBToolStripMenuItem
            // 
            this.blankBToolStripMenuItem.Name = "blankBToolStripMenuItem";
            this.blankBToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.blankBToolStripMenuItem.Text = "空白解决方案(&B)";
            this.blankBToolStripMenuItem.Click += new System.EventHandler(this.blankBToolStripMenuItem_Click);
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.openOToolStripMenuItem.Text = "打开(&O)";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.saveToolStripMenuItem.Text = "另存为";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeCToolStripMenuItem
            // 
            this.closeCToolStripMenuItem.Name = "closeCToolStripMenuItem";
            this.closeCToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.closeCToolStripMenuItem.Text = "关闭(&C)";
            this.closeCToolStripMenuItem.Click += new System.EventHandler(this.closeCToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 6);
            // 
            // addnewitemWToolStripMenuItem
            // 
            this.addnewitemWToolStripMenuItem.Name = "addnewitemWToolStripMenuItem";
            this.addnewitemWToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addnewitemWToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addnewitemWToolStripMenuItem.Text = "添加新项(&W)";
            this.addnewitemWToolStripMenuItem.Click += new System.EventHandler(this.addnewitemWToolStripMenuItem_Click);
            // 
            // addexistingitemGToolStripMenuItem
            // 
            this.addexistingitemGToolStripMenuItem.Name = "addexistingitemGToolStripMenuItem";
            this.addexistingitemGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8)));
            this.addexistingitemGToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addexistingitemGToolStripMenuItem.Text = "添加现有项(&G)";
            this.addexistingitemGToolStripMenuItem.Click += new System.EventHandler(this.addexistingitemGToolStripMenuItem_Click);
            // 
            // addprojDToolStripMenuItem
            // 
            this.addprojDToolStripMenuItem.Name = "addprojDToolStripMenuItem";
            this.addprojDToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.addprojDToolStripMenuItem.Text = "添加项目(&D)";
            this.addprojDToolStripMenuItem.Click += new System.EventHandler(this.addprojDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 6);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitXToolStripMenuItem.Text = "退出(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // dlgDToolStripMenuItem
            // 
            this.dlgDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openfileToolStripMenuItem,
            this.openfontToolStripMenuItem,
            this.opencolorToolStripMenuItem});
            this.dlgDToolStripMenuItem.Name = "dlgDToolStripMenuItem";
            this.dlgDToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.dlgDToolStripMenuItem.Text = "常用对话框操作(&D)";
            // 
            // openfileToolStripMenuItem
            // 
            this.openfileToolStripMenuItem.Name = "openfileToolStripMenuItem";
            this.openfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.openfileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openfileToolStripMenuItem.Text = "打开文件对话框";
            this.openfileToolStripMenuItem.Click += new System.EventHandler(this.openfileToolStripMenuItem_Click);
            // 
            // openfontToolStripMenuItem
            // 
            this.openfontToolStripMenuItem.Name = "openfontToolStripMenuItem";
            this.openfontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.openfontToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openfontToolStripMenuItem.Text = "打开字体对话框";
            this.openfontToolStripMenuItem.Click += new System.EventHandler(this.openfontToolStripMenuItem_Click);
            // 
            // opencolorToolStripMenuItem
            // 
            this.opencolorToolStripMenuItem.Name = "opencolorToolStripMenuItem";
            this.opencolorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.opencolorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.opencolorToolStripMenuItem.Text = "设置颜色对话框";
            this.opencolorToolStripMenuItem.Click += new System.EventHandler(this.opencolorToolStripMenuItem_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openfileToolStripMenuItem1,
            this.openfontToolStripMenuItem1,
            this.opencolorToolStripMenuItem1});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(161, 70);
            this.ContextMenu.Text = "上下文菜单";
            // 
            // openfileToolStripMenuItem1
            // 
            this.openfileToolStripMenuItem1.Name = "openfileToolStripMenuItem1";
            this.openfileToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.openfileToolStripMenuItem1.Text = "打开文件对话框";
            // 
            // openfontToolStripMenuItem1
            // 
            this.openfontToolStripMenuItem1.Name = "openfontToolStripMenuItem1";
            this.openfontToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.openfontToolStripMenuItem1.Text = "设置颜色对话框";
            // 
            // opencolorToolStripMenuItem1
            // 
            this.opencolorToolStripMenuItem1.Name = "opencolorToolStripMenuItem1";
            this.opencolorToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(572, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 3;
            this.name.Text = "姓名：";
            // 
            // bloodtype
            // 
            this.bloodtype.AutoSize = true;
            this.bloodtype.Location = new System.Drawing.Point(12, 87);
            this.bloodtype.Name = "bloodtype";
            this.bloodtype.Size = new System.Drawing.Size(41, 12);
            this.bloodtype.TabIndex = 4;
            this.bloodtype.Text = "血型：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.comboBox1.Location = new System.Drawing.Point(60, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(15, 126);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(41, 12);
            this.birthday.TabIndex = 7;
            this.birthday.Text = "生日：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Enter += new System.EventHandler(this.dateTimePicker1_Enter);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // gender_boy
            // 
            this.gender_boy.AutoSize = true;
            this.gender_boy.Location = new System.Drawing.Point(17, 162);
            this.gender_boy.Name = "gender_boy";
            this.gender_boy.Size = new System.Drawing.Size(47, 16);
            this.gender_boy.TabIndex = 11;
            this.gender_boy.TabStop = true;
            this.gender_boy.Text = "男孩";
            this.gender_boy.UseVisualStyleBackColor = true;
            this.gender_boy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gender_boy_MouseDown);
            // 
            // gender_girl
            // 
            this.gender_girl.AutoSize = true;
            this.gender_girl.Location = new System.Drawing.Point(88, 162);
            this.gender_girl.Name = "gender_girl";
            this.gender_girl.Size = new System.Drawing.Size(47, 16);
            this.gender_girl.TabIndex = 12;
            this.gender_girl.TabStop = true;
            this.gender_girl.Text = "女孩";
            this.gender_girl.UseVisualStyleBackColor = true;
            this.gender_girl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gender_girl_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 119);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "兴趣爱好：";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 16);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "打球";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "看书";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "爬山";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "唱歌";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(175, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "籍贯";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 21);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node00";
            treeNode1.Text = "南京";
            treeNode2.Name = "Node01";
            treeNode2.Text = "苏州";
            treeNode3.Name = "Node02";
            treeNode3.Text = "镇江";
            treeNode4.Name = "Node0";
            treeNode4.Text = "江苏";
            treeNode5.Name = "节点10";
            treeNode5.Text = "杭州";
            treeNode6.Name = "Node11";
            treeNode6.Text = "宁波";
            treeNode7.Name = "Node12";
            treeNode7.Text = "乌镇";
            treeNode8.Name = "Node1";
            treeNode8.Text = "浙江";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(112, 83);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Enter += new System.EventHandler(this.treeView1_Enter);
            this.treeView1.Leave += new System.EventHandler(this.treeView1_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Location = new System.Drawing.Point(17, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 164);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "个人简介";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(270, 137);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.Enter += new System.EventHandler(this.richTextBox2_Enter);
            this.richTextBox2.Leave += new System.EventHandler(this.richTextBox2_Leave);
            // 
            // selecticon
            // 
            this.selecticon.Location = new System.Drawing.Point(344, 42);
            this.selecticon.Name = "selecticon";
            this.selecticon.Size = new System.Drawing.Size(97, 23);
            this.selecticon.TabIndex = 16;
            this.selecticon.Text = "选择一个头像";
            this.selecticon.UseVisualStyleBackColor = true;
            this.selecticon.Click += new System.EventHandler(this.selecticon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(493, 175);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(40, 22);
            this.ok.TabIndex = 18;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // setfont
            // 
            this.setfont.Location = new System.Drawing.Point(353, 409);
            this.setfont.Name = "setfont";
            this.setfont.Size = new System.Drawing.Size(75, 23);
            this.setfont.TabIndex = 20;
            this.setfont.Text = "设置字体";
            this.setfont.UseVisualStyleBackColor = true;
            this.setfont.Click += new System.EventHandler(this.setfont_Click);
            // 
            // setcolor
            // 
            this.setcolor.Location = new System.Drawing.Point(447, 408);
            this.setcolor.Name = "setcolor";
            this.setcolor.Size = new System.Drawing.Size(75, 23);
            this.setcolor.TabIndex = 21;
            this.setcolor.Text = "设置颜色";
            this.setcolor.UseVisualStyleBackColor = true;
            this.setcolor.Click += new System.EventHandler(this.setcolor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "***欢迎光临！***";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "姓名：",
            "血型：",
            "生日：",
            "性别：",
            "兴趣爱好：",
            "籍贯：",
            "个人简介：",
            "头像："});
            this.listBox1.Location = new System.Drawing.Point(344, 215);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 172);
            this.listBox1.TabIndex = 23;
            // 
            // PersonalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 562);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.setcolor);
            this.Controls.Add(this.setfont);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selecticon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gender_girl);
            this.Controls.Add(this.gender_boy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bloodtype);
            this.Controls.Add(this.name);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonalRegister";
            this.Text = "个人信息登记";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PersonalRegister_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileFCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addnewitemWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addexistingitemGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addprojDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dlgDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openfontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opencolorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openfontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opencolorToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label bloodtype;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton gender_boy;
        private System.Windows.Forms.RadioButton gender_girl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button selecticon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button setfont;
        private System.Windows.Forms.Button setcolor;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

