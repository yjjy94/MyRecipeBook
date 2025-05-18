namespace MyRecipeBook
{
    partial class FormAddRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRecipe));
            cb_CUISINE = new ComboBox();
            tb_TITLE_R = new TextBox();
            pb_RECIPE = new PictureBox();
            btn_CONFIRM = new Button();
            btn_LOAD_IMG = new Button();
            tb_RECIPE = new TextBox();
            tb_INGREDIENT = new TextBox();
            tb_QT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_ADD_INGR = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_RECIPE).BeginInit();
            SuspendLayout();
            // 
            // cb_CUISINE
            // 
            cb_CUISINE.FormattingEnabled = true;
            cb_CUISINE.Items.AddRange(new object[] { "한식", "양식", "기타" });
            cb_CUISINE.Location = new Point(99, 99);
            cb_CUISINE.Name = "cb_CUISINE";
            cb_CUISINE.Size = new Size(121, 23);
            cb_CUISINE.TabIndex = 0;
            // 
            // tb_TITLE_R
            // 
            tb_TITLE_R.Location = new Point(253, 99);
            tb_TITLE_R.Name = "tb_TITLE_R";
            tb_TITLE_R.Size = new Size(194, 23);
            tb_TITLE_R.TabIndex = 1;
            // 
            // pb_RECIPE
            // 
            pb_RECIPE.Location = new Point(478, 99);
            pb_RECIPE.Name = "pb_RECIPE";
            pb_RECIPE.Size = new Size(117, 89);
            pb_RECIPE.TabIndex = 2;
            pb_RECIPE.TabStop = false;
            // 
            // btn_CONFIRM
            // 
            btn_CONFIRM.BackColor = Color.FromArgb(255, 128, 128);
            btn_CONFIRM.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CONFIRM.ForeColor = Color.White;
            btn_CONFIRM.Location = new Point(297, 343);
            btn_CONFIRM.Name = "btn_CONFIRM";
            btn_CONFIRM.Size = new Size(98, 53);
            btn_CONFIRM.TabIndex = 3;
            btn_CONFIRM.Text = "레시피 생성";
            btn_CONFIRM.UseVisualStyleBackColor = false;
            btn_CONFIRM.Click += btn_CONFIRM_Click;
            // 
            // btn_LOAD_IMG
            // 
            btn_LOAD_IMG.BackColor = Color.FromArgb(255, 128, 128);
            btn_LOAD_IMG.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LOAD_IMG.ForeColor = Color.White;
            btn_LOAD_IMG.Location = new Point(482, 194);
            btn_LOAD_IMG.Name = "btn_LOAD_IMG";
            btn_LOAD_IMG.Size = new Size(113, 34);
            btn_LOAD_IMG.TabIndex = 4;
            btn_LOAD_IMG.Text = "선택";
            btn_LOAD_IMG.UseVisualStyleBackColor = false;
            btn_LOAD_IMG.Click += btn_LOAD_IMG_Click;
            // 
            // tb_RECIPE
            // 
            tb_RECIPE.Enabled = false;
            tb_RECIPE.Font = new Font("Hancom MalangMalang Regular", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            tb_RECIPE.ForeColor = Color.Maroon;
            tb_RECIPE.Location = new Point(253, 128);
            tb_RECIPE.Multiline = true;
            tb_RECIPE.Name = "tb_RECIPE";
            tb_RECIPE.Size = new Size(194, 209);
            tb_RECIPE.TabIndex = 5;
            tb_RECIPE.Text = "상세 레시피:";
            // 
            // tb_INGREDIENT
            // 
            tb_INGREDIENT.Location = new Point(99, 194);
            tb_INGREDIENT.Name = "tb_INGREDIENT";
            tb_INGREDIENT.Size = new Size(100, 23);
            tb_INGREDIENT.TabIndex = 6;
            // 
            // tb_QT
            // 
            tb_QT.Location = new Point(99, 246);
            tb_QT.Name = "tb_QT";
            tb_QT.Size = new Size(100, 23);
            tb_QT.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(99, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 8;
            label1.Text = "* 종류 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(496, 73);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 9;
            label2.Text = "* 이미지 선택";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Tomato;
            label3.Location = new Point(99, 176);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 10;
            label3.Text = "* 재료명";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(99, 228);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 11;
            label4.Text = "* 수량";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(253, 73);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 12;
            label5.Text = "* 제목";
            // 
            // btn_ADD_INGR
            // 
            btn_ADD_INGR.BackColor = Color.FromArgb(255, 128, 128);
            btn_ADD_INGR.Font = new Font("Hancom MalangMalang Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ADD_INGR.ForeColor = Color.White;
            btn_ADD_INGR.Location = new Point(111, 275);
            btn_ADD_INGR.Name = "btn_ADD_INGR";
            btn_ADD_INGR.Size = new Size(75, 33);
            btn_ADD_INGR.TabIndex = 13;
            btn_ADD_INGR.Text = "재료 추가";
            btn_ADD_INGR.UseVisualStyleBackColor = false;
            btn_ADD_INGR.Click += btn_ADD_INGR_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Hancom MalangMalang Regular", 9.749998F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(482, 234);
            button1.Name = "button1";
            button1.Size = new Size(113, 35);
            button1.TabIndex = 14;
            button1.Text = "이미지 검색";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormAddRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(679, 450);
            Controls.Add(button1);
            Controls.Add(btn_ADD_INGR);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_QT);
            Controls.Add(tb_INGREDIENT);
            Controls.Add(tb_RECIPE);
            Controls.Add(btn_LOAD_IMG);
            Controls.Add(btn_CONFIRM);
            Controls.Add(pb_RECIPE);
            Controls.Add(tb_TITLE_R);
            Controls.Add(cb_CUISINE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddRecipe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "새로운 레시피 추가!";
            ((System.ComponentModel.ISupportInitialize)pb_RECIPE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_CUISINE;
        private TextBox tb_TITLE_R;
        private PictureBox pb_RECIPE;
        private Button btn_CONFIRM;
        private Button btn_LOAD_IMG;
        private TextBox tb_RECIPE;
        private TextBox tb_INGREDIENT;
        private TextBox tb_QT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_ADD_INGR;
        private Button button1;
    }
}