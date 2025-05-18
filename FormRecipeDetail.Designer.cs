namespace MyRecipeBook
{
    partial class FormRecipeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecipeDetail));
            pb_DETAIL = new PictureBox();
            lbl_CUISINE_DETAIL = new Label();
            lbl_TITLE_DETAIL = new Label();
            lbl_RECIPE_DETAIL = new Label();
            btn_MAKE = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_DETAIL).BeginInit();
            SuspendLayout();
            // 
            // pb_DETAIL
            // 
            pb_DETAIL.Location = new Point(31, 237);
            pb_DETAIL.Name = "pb_DETAIL";
            pb_DETAIL.Size = new Size(195, 122);
            pb_DETAIL.TabIndex = 0;
            pb_DETAIL.TabStop = false;
            // 
            // lbl_CUISINE_DETAIL
            // 
            lbl_CUISINE_DETAIL.AutoSize = true;
            lbl_CUISINE_DETAIL.BackColor = Color.Transparent;
            lbl_CUISINE_DETAIL.Font = new Font("Hancom MalangMalang Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CUISINE_DETAIL.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_CUISINE_DETAIL.Location = new Point(104, 179);
            lbl_CUISINE_DETAIL.Name = "lbl_CUISINE_DETAIL";
            lbl_CUISINE_DETAIL.Size = new Size(46, 25);
            lbl_CUISINE_DETAIL.TabIndex = 1;
            lbl_CUISINE_DETAIL.Text = "한식";
            // 
            // lbl_TITLE_DETAIL
            // 
            lbl_TITLE_DETAIL.AutoSize = true;
            lbl_TITLE_DETAIL.BackColor = Color.Transparent;
            lbl_TITLE_DETAIL.Font = new Font("Hancom MalangMalang Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TITLE_DETAIL.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_TITLE_DETAIL.Location = new Point(366, 48);
            lbl_TITLE_DETAIL.Name = "lbl_TITLE_DETAIL";
            lbl_TITLE_DETAIL.Size = new Size(54, 31);
            lbl_TITLE_DETAIL.TabIndex = 2;
            lbl_TITLE_DETAIL.Text = "제목";
            // 
            // lbl_RECIPE_DETAIL
            // 
            lbl_RECIPE_DETAIL.AutoSize = true;
            lbl_RECIPE_DETAIL.BackColor = Color.Transparent;
            lbl_RECIPE_DETAIL.Font = new Font("Hancom MalangMalang Regular", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RECIPE_DETAIL.Location = new Point(278, 157);
            lbl_RECIPE_DETAIL.Name = "lbl_RECIPE_DETAIL";
            lbl_RECIPE_DETAIL.Size = new Size(34, 20);
            lbl_RECIPE_DETAIL.TabIndex = 3;
            lbl_RECIPE_DETAIL.Text = "재료";
            // 
            // btn_MAKE
            // 
            btn_MAKE.BackColor = Color.IndianRed;
            btn_MAKE.Font = new Font("Hancom MalangMalang Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btn_MAKE.ForeColor = Color.White;
            btn_MAKE.Location = new Point(454, 98);
            btn_MAKE.Name = "btn_MAKE";
            btn_MAKE.Size = new Size(89, 51);
            btn_MAKE.TabIndex = 4;
            btn_MAKE.Text = "만들기";
            btn_MAKE.UseVisualStyleBackColor = false;
            btn_MAKE.Click += btn_MAKE_Click;
            // 
            // FormRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(555, 371);
            Controls.Add(btn_MAKE);
            Controls.Add(lbl_RECIPE_DETAIL);
            Controls.Add(lbl_TITLE_DETAIL);
            Controls.Add(lbl_CUISINE_DETAIL);
            Controls.Add(pb_DETAIL);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRecipeDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "레시피";
            ((System.ComponentModel.ISupportInitialize)pb_DETAIL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_DETAIL;
        private Label lbl_CUISINE_DETAIL;
        private Label lbl_TITLE_DETAIL;
        private Label lbl_RECIPE_DETAIL;
        private Button btn_MAKE;
    }
}