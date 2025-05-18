using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static MyRecipeBook.FormMain;

namespace MyRecipeBook
{
    public partial class FormAddRecipe : Form
    {
        private List<RecipeIngredient> ingredientList = new List<RecipeIngredient>();
        public Recipe NewRecipe { get; private set; }

        public FormAddRecipe()
        {
            InitializeComponent();
            pb_RECIPE.SizeMode = PictureBoxSizeMode.StretchImage;
            tb_RECIPE.AppendText("\n");
        }

        private void btn_LOAD_IMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Optionally, you can copy the image to a new folder (e.g., a dedicated images folder)
                string newImagePath = Path.Combine("RecipeImages", Path.GetFileName(imagePath));

                // Ensure the folder exists
                if (!Directory.Exists("RecipeImages"))
                {
                    Directory.CreateDirectory("RecipeImages");
                }

                // Copy the image to the new folder
                File.Copy(imagePath, newImagePath, true);

                // Now set the image path and the image itself
                pb_RECIPE.Image = Image.FromFile(newImagePath);

                // Store the path in a class property or in NewRecipe later
                pb_RECIPE.Tag = newImagePath;  // Storing the path in Tag for later use
            }
        }

        private void btn_ADD_INGR_Click(object sender, EventArgs e)
        {
            string name = tb_INGREDIENT.Text.Trim();
            string qtyText = tb_QT.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(qtyText))
            {
                MessageBox.Show("필요한 (*)필드들을 채워주세요");
                return;
            }

            if (!int.TryParse(qtyText, out int quantity))
            {
                MessageBox.Show("수량은 숫자만 됩니다");
                return;
            }

            // Add to the list
            ingredientList.Add(new RecipeIngredient(name, quantity));

            // Show in tb_RECIPE
            tb_RECIPE.AppendText($"{Environment.NewLine}{name} - {quantity}");

            // Clear fields
            tb_INGREDIENT.Clear();
            tb_QT.Clear();
        }

        private void btn_CONFIRM_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(tb_RECIPE.Text) ||
                pb_RECIPE.Image == null ||
                pb_RECIPE.Tag == null)
            {
                MessageBox.Show("필요한 (*)필드들을 채워주세요");
                return;
            }

            // Create the recipe
            string imagePath = pb_RECIPE.Tag.ToString();  // Retrieve the saved image path
            NewRecipe = new Recipe(tb_TITLE_R.Text, cb_CUISINE.SelectedItem.ToString(), pb_RECIPE.Image)
            {
                ImagePath = imagePath  // Store the image path in the Recipe object
            };

            // Add ingredients from list
            foreach (var ing in ingredientList)
            {
                NewRecipe.AddIngredient(ing.Name, ing.Quantity);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = tb_TITLE_R.Text.Trim(); // or any textbox or string
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            string query = Uri.EscapeDataString(keyword + " image");
            string url = $"https://www.google.com/search?tbm=isch&q={query}";

            try
            {
                // This will open in the default browser (usually Chrome if set as default)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening browser: " + ex.Message);
            }
        }
    }
}
