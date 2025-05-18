namespace MyRecipeBook
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            btn_DELETE_INGREDIENT = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cb_TYPE = new ComboBox();
            btn_ADD = new Button();
            dateTimePicker1 = new DateTimePicker();
            num_QT = new NumericUpDown();
            tb_NAME = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            flowKorean = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            flowWestern = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            flowETC = new FlowLayoutPanel();
            chkList_VEG = new CheckedListBox();
            chkList_MEAT = new CheckedListBox();
            chkList_SAUCE = new CheckedListBox();
            btn_ADD_RECIPE = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_TODAY = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_SHOWALL = new Button();
            btn_DELETE_RECIPE = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_QT).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_DELETE_INGREDIENT);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cb_TYPE);
            groupBox1.Controls.Add(btn_ADD);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(num_QT);
            groupBox1.Controls.Add(tb_NAME);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox1.Location = new Point(32, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "재료 등록";
            // 
            // btn_DELETE_INGREDIENT
            // 
            btn_DELETE_INGREDIENT.BackColor = Color.Tomato;
            btn_DELETE_INGREDIENT.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DELETE_INGREDIENT.ForeColor = Color.White;
            btn_DELETE_INGREDIENT.Location = new Point(233, 94);
            btn_DELETE_INGREDIENT.Name = "btn_DELETE_INGREDIENT";
            btn_DELETE_INGREDIENT.Size = new Size(84, 43);
            btn_DELETE_INGREDIENT.TabIndex = 10;
            btn_DELETE_INGREDIENT.Text = "삭제";
            btn_DELETE_INGREDIENT.UseVisualStyleBackColor = false;
            btn_DELETE_INGREDIENT.Click += btn_DELETE_INGREDIENT_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(395, 45);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 9;
            label8.Text = "유통기한";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(303, 45);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 8;
            label7.Text = "수량";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(193, 45);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 7;
            label6.Text = "재료명";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(52, 45);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 6;
            label5.Text = "카테고리";
            // 
            // cb_TYPE
            // 
            cb_TYPE.ForeColor = Color.IndianRed;
            cb_TYPE.FormattingEnabled = true;
            cb_TYPE.Items.AddRange(new object[] { "야채 및 과일류", "고기류", "소스 및 기타" });
            cb_TYPE.Location = new Point(16, 65);
            cb_TYPE.Name = "cb_TYPE";
            cb_TYPE.Size = new Size(121, 23);
            cb_TYPE.TabIndex = 5;
            cb_TYPE.Text = "야채 및 과일류";
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.Tomato;
            btn_ADD.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ADD.ForeColor = Color.White;
            btn_ADD.Location = new Point(124, 94);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(84, 43);
            btn_ADD.TabIndex = 4;
            btn_ADD.Text = "등록";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += btn_ADD_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.IndianRed;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(255, 192, 192);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 0, 0);
            dateTimePicker1.CalendarTitleForeColor = Color.IndianRed;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(361, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // num_QT
            // 
            num_QT.ForeColor = Color.IndianRed;
            num_QT.Location = new Point(283, 65);
            num_QT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_QT.Name = "num_QT";
            num_QT.Size = new Size(72, 23);
            num_QT.TabIndex = 2;
            num_QT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_NAME
            // 
            tb_NAME.ForeColor = Color.IndianRed;
            tb_NAME.Location = new Point(143, 65);
            tb_NAME.Name = "tb_NAME";
            tb_NAME.Size = new Size(134, 23);
            tb_NAME.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(661, 40);
            label1.Name = "label1";
            label1.Size = new Size(151, 39);
            label1.TabIndex = 1;
            label1.Text = "RECIPE";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(661, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(312, 423);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowKorean);
            tabPage1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(304, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "한식";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowKorean
            // 
            flowKorean.BackColor = Color.PapayaWhip;
            flowKorean.Dock = DockStyle.Fill;
            flowKorean.Location = new Point(3, 3);
            flowKorean.Name = "flowKorean";
            flowKorean.Size = new Size(298, 389);
            flowKorean.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowWestern);
            tabPage2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(304, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "양식";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowWestern
            // 
            flowWestern.BackColor = Color.PapayaWhip;
            flowWestern.Dock = DockStyle.Fill;
            flowWestern.Location = new Point(3, 3);
            flowWestern.Name = "flowWestern";
            flowWestern.Size = new Size(298, 389);
            flowWestern.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(flowETC);
            tabPage3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(304, 395);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "기타";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowETC
            // 
            flowETC.BackColor = Color.PapayaWhip;
            flowETC.Dock = DockStyle.Fill;
            flowETC.Location = new Point(3, 3);
            flowETC.Name = "flowETC";
            flowETC.Size = new Size(298, 389);
            flowETC.TabIndex = 0;
            // 
            // chkList_VEG
            // 
            chkList_VEG.BackColor = Color.PapayaWhip;
            chkList_VEG.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkList_VEG.FormattingEnabled = true;
            chkList_VEG.Location = new Point(32, 269);
            chkList_VEG.Name = "chkList_VEG";
            chkList_VEG.Size = new Size(198, 256);
            chkList_VEG.TabIndex = 3;
            // 
            // chkList_MEAT
            // 
            chkList_MEAT.BackColor = Color.PapayaWhip;
            chkList_MEAT.FormattingEnabled = true;
            chkList_MEAT.Location = new Point(236, 269);
            chkList_MEAT.Name = "chkList_MEAT";
            chkList_MEAT.Size = new Size(198, 256);
            chkList_MEAT.TabIndex = 4;
            // 
            // chkList_SAUCE
            // 
            chkList_SAUCE.BackColor = Color.PapayaWhip;
            chkList_SAUCE.FormattingEnabled = true;
            chkList_SAUCE.Location = new Point(440, 269);
            chkList_SAUCE.Name = "chkList_SAUCE";
            chkList_SAUCE.Size = new Size(198, 256);
            chkList_SAUCE.TabIndex = 5;
            // 
            // btn_ADD_RECIPE
            // 
            btn_ADD_RECIPE.BackColor = Color.Transparent;
            btn_ADD_RECIPE.BackgroundImage = (Image)resources.GetObject("btn_ADD_RECIPE.BackgroundImage");
            btn_ADD_RECIPE.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ADD_RECIPE.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ADD_RECIPE.Location = new Point(805, 40);
            btn_ADD_RECIPE.Name = "btn_ADD_RECIPE";
            btn_ADD_RECIPE.Size = new Size(47, 45);
            btn_ADD_RECIPE.TabIndex = 6;
            btn_ADD_RECIPE.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ADD_RECIPE.UseVisualStyleBackColor = false;
            btn_ADD_RECIPE.Click += btn_ADD_RECIPE_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(72, 238);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 7;
            label2.Text = "야채 및 과일류";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(315, 238);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 8;
            label3.Text = "고기류";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(481, 238);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 9;
            label4.Text = "소스 및 기타";
            // 
            // lbl_TODAY
            // 
            lbl_TODAY.AutoSize = true;
            lbl_TODAY.BackColor = Color.Transparent;
            lbl_TODAY.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TODAY.ForeColor = Color.OrangeRed;
            lbl_TODAY.Location = new Point(188, 20);
            lbl_TODAY.Name = "lbl_TODAY";
            lbl_TODAY.Size = new Size(20, 25);
            lbl_TODAY.TabIndex = 10;
            lbl_TODAY.Text = "-";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_SHOWALL
            // 
            btn_SHOWALL.BackColor = Color.Tomato;
            btn_SHOWALL.Font = new Font("Microsoft Sans Serif", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SHOWALL.ForeColor = Color.White;
            btn_SHOWALL.Location = new Point(911, 35);
            btn_SHOWALL.Name = "btn_SHOWALL";
            btn_SHOWALL.Size = new Size(87, 55);
            btn_SHOWALL.TabIndex = 11;
            btn_SHOWALL.Text = "전체 보기";
            btn_SHOWALL.UseVisualStyleBackColor = false;
            btn_SHOWALL.Click += btn_SHOWALL_Click;
            // 
            // btn_DELETE_RECIPE
            // 
            btn_DELETE_RECIPE.BackColor = Color.Transparent;
            btn_DELETE_RECIPE.BackgroundImage = (Image)resources.GetObject("btn_DELETE_RECIPE.BackgroundImage");
            btn_DELETE_RECIPE.BackgroundImageLayout = ImageLayout.Stretch;
            btn_DELETE_RECIPE.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DELETE_RECIPE.Location = new Point(858, 40);
            btn_DELETE_RECIPE.Name = "btn_DELETE_RECIPE";
            btn_DELETE_RECIPE.Size = new Size(47, 45);
            btn_DELETE_RECIPE.TabIndex = 12;
            btn_DELETE_RECIPE.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_DELETE_RECIPE.UseVisualStyleBackColor = false;
            btn_DELETE_RECIPE.Click += btn_DELETE_RECIPE_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1074, 550);
            Controls.Add(btn_DELETE_RECIPE);
            Controls.Add(btn_SHOWALL);
            Controls.Add(lbl_TODAY);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_ADD_RECIPE);
            Controls.Add(chkList_SAUCE);
            Controls.Add(chkList_MEAT);
            Controls.Add(chkList_VEG);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "나의 냉장고 지킴이";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_QT).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cb_TYPE;
        private Button btn_ADD;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown num_QT;
        private TextBox tb_NAME;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flowKorean;
        private TabPage tabPage2;
        private FlowLayoutPanel flowWestern;
        private CheckedListBox chkList_VEG;
        private CheckedListBox chkList_MEAT;
        private CheckedListBox chkList_SAUCE;
        private TabPage tabPage3;
        private FlowLayoutPanel flowETC;
        private Button btn_ADD_RECIPE;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_TODAY;
        private System.Windows.Forms.Timer timer1;
        private Button btn_SHOWALL;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btn_DELETE_RECIPE;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_DELETE_INGREDIENT;
    }
}
