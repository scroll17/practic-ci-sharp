namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.halfSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popHalfSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popNormalSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popDoubleSizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.halfBtn = new System.Windows.Forms.ToolStripButton();
            this.normalBtn = new System.Windows.Forms.ToolStripButton();
            this.doubleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ExitBtn = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolItem,
            this.saveAsItem,
            this.closeToolItem,
            this.exitToolStripMenuItem1,
            this.exitToolItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolItem
            // 
            this.openToolItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolItem.Image")));
            this.openToolItem.Name = "openToolItem";
            this.openToolItem.Size = new System.Drawing.Size(156, 26);
            this.openToolItem.Text = "Open";
            this.openToolItem.Click += new System.EventHandler(this.openToolItem_Click);
            // 
            // saveAsItem
            // 
            this.saveAsItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsItem.Image")));
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.Size = new System.Drawing.Size(130, 22);
            this.saveAsItem.Text = "SaveAs";
            this.saveAsItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolItem
            // 
            this.closeToolItem.Image = global::WindowsFormsApp1.Properties.Resources.pin;
            this.closeToolItem.Name = "closeToolItem";
            this.closeToolItem.Size = new System.Drawing.Size(130, 22);
            this.closeToolItem.Text = "Close";
            this.closeToolItem.Click += new System.EventHandler(this.closeToolItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolItem
            // 
            this.exitToolItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolItem.Image")));
            this.exitToolItem.Name = "exitToolItem";
            this.exitToolItem.ShortcutKeyDisplayString = "";
            this.exitToolItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolItem.Text = "Exit";
            this.exitToolItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.halfSizeItem,
            this.normalSizeItem,
            this.doubleSizeItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolBarToolStripMenuItem.Text = "ToolBar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.toolBarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // halfSizeItem
            // 
            this.halfSizeItem.BackColor = System.Drawing.Color.SkyBlue;
            this.halfSizeItem.Name = "halfSizeItem";
            this.halfSizeItem.Size = new System.Drawing.Size(152, 22);
            this.halfSizeItem.Text = "Half size ";
            this.halfSizeItem.Click += new System.EventHandler(this.halfSizeItem_Click);
            // 
            // normalSizeItem
            // 
            this.normalSizeItem.BackColor = System.Drawing.Color.MistyRose;
            this.normalSizeItem.Name = "normalSizeItem";
            this.normalSizeItem.Size = new System.Drawing.Size(152, 22);
            this.normalSizeItem.Text = "Normal size";
            this.normalSizeItem.Click += new System.EventHandler(this.normalSizeItem_Click);
            // 
            // doubleSizeItem
            // 
            this.doubleSizeItem.BackColor = System.Drawing.Color.Gold;
            this.doubleSizeItem.Name = "doubleSizeItem";
            this.doubleSizeItem.Size = new System.Drawing.Size(152, 22);
            this.doubleSizeItem.Text = "Double size ";
            this.doubleSizeItem.Click += new System.EventHandler(this.doubleSizeItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formNameToolStripMenuItem,
            this.newDialogToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // formNameToolStripMenuItem
            // 
            this.formNameToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.formNameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formNameToolStripMenuItem.Name = "formNameToolStripMenuItem";
            this.formNameToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.formNameToolStripMenuItem.Text = "Set new FormName";
            this.formNameToolStripMenuItem.Click += new System.EventHandler(this.formNameToolStripMenuItem_Click);
            // 
            // newDialogToolStripMenuItem
            // 
            this.newDialogToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.newDialogToolStripMenuItem.Name = "newDialogToolStripMenuItem";
            this.newDialogToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newDialogToolStripMenuItem.Text = "Open New Dialog";
            this.newDialogToolStripMenuItem.Click += new System.EventHandler(this.newDialogToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popHalfSizeItem,
            this.popNormalSizeItem,
            this.popDoubleSizeItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(138, 70);
            // 
            // popHalfSizeItem
            // 
            this.popHalfSizeItem.Name = "popHalfSizeItem";
            this.popHalfSizeItem.Size = new System.Drawing.Size(137, 22);
            this.popHalfSizeItem.Text = "Half size";
            this.popHalfSizeItem.Click += new System.EventHandler(this.halfSizeToolStripMenuItem_Click);
            // 
            // popNormalSizeItem
            // 
            this.popNormalSizeItem.Checked = true;
            this.popNormalSizeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.popNormalSizeItem.Name = "popNormalSizeItem";
            this.popNormalSizeItem.Size = new System.Drawing.Size(137, 22);
            this.popNormalSizeItem.Text = "Normal size";
            this.popNormalSizeItem.Click += new System.EventHandler(this.popNormalSizeItem_Click);
            // 
            // popDoubleSizeItem
            // 
            this.popDoubleSizeItem.Name = "popDoubleSizeItem";
            this.popDoubleSizeItem.Size = new System.Drawing.Size(137, 22);
            this.popDoubleSizeItem.Text = "Double size ";
            this.popDoubleSizeItem.Click += new System.EventHandler(this.popDoubleSizeItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "С:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = "С:\\";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.halfBtn,
            this.normalBtn,
            this.doubleBtn,
            this.toolStripButton1,
            this.toolStripTextBox1,
            this.ExitBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(24, 24);
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(24, 24);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // halfBtn
            // 
            this.halfBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.halfBtn.Enabled = false;
            this.halfBtn.Image = ((System.Drawing.Image)(resources.GetObject("halfBtn.Image")));
            this.halfBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.halfBtn.Name = "halfBtn";
            this.halfBtn.Size = new System.Drawing.Size(24, 24);
            this.halfBtn.Text = "Half";
            this.halfBtn.Click += new System.EventHandler(this.halfBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.normalBtn.Enabled = false;
            this.normalBtn.Image = ((System.Drawing.Image)(resources.GetObject("normalBtn.Image")));
            this.normalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(24, 24);
            this.normalBtn.Tag = "";
            this.normalBtn.Text = "Normal";
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // doubleBtn
            // 
            this.doubleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doubleBtn.Enabled = false;
            this.doubleBtn.Image = ((System.Drawing.Image)(resources.GetObject("doubleBtn.Image")));
            this.doubleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(24, 24);
            this.doubleBtn.Text = "Double";
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(76, 27);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 24);
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(502, 184);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(501, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(501, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 561);
            this.ContextMenuStrip = this.MenuStrip;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolItem;
        public System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem halfSizeItem;
        private System.Windows.Forms.ToolStripMenuItem normalSizeItem;
        private System.Windows.Forms.ToolStripMenuItem doubleSizeItem;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem popHalfSizeItem;
        private System.Windows.Forms.ToolStripMenuItem popNormalSizeItem;
        private System.Windows.Forms.ToolStripMenuItem popDoubleSizeItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton halfBtn;
        private System.Windows.Forms.ToolStripButton normalBtn;
        private System.Windows.Forms.ToolStripButton doubleBtn;
        private System.Windows.Forms.ToolStripButton ExitBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem newDialogToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
    }
}

