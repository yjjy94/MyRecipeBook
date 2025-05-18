using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyRecipeBook
{
    public partial class FormMain : Form
    {
        private List<Recipe> recipeList = new List<Recipe>();
        private string recipeFilePath = "recipes.txt"; // File path for saving recipes

        public FormMain()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);

            chkList_VEG.CheckOnClick = true;
            chkList_MEAT.CheckOnClick = true;
            chkList_SAUCE.CheckOnClick = true;

            chkList_VEG.ItemCheck += IngredientCheckedChanged;
            chkList_MEAT.ItemCheck += IngredientCheckedChanged;
            chkList_SAUCE.ItemCheck += IngredientCheckedChanged;
        }

        private void IngredientCheckedChanged(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => UpdateRecipeDisplay()));
        }


        public class Ingredient
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Quantity { get; set; }
            public DateTime ExpireDate { get; set; }

            public Ingredient(string name, string type, int quantity, DateTime expireDate)
            {
                Name = name;
                Type = type;
                Quantity = quantity;
                ExpireDate = expireDate;
            }

            public override string ToString()
            {
                return $"{Name}: {Quantity} ({ExpireDate:yy/MM/dd})";
            }
        }
        public class Recipe
        {
            public string Title { get; set; }
            public string Category { get; set; }
            public List<RecipeIngredient> RequiredIngredients { get; set; }
            public Image RecipeImage { get; set; }
            public string ImagePath { get; set; } // Store image file path

            public Recipe(string title, string category, Image image = null)
            {
                Title = title;
                Category = category;
                RecipeImage = image ?? SystemIcons.Information.ToBitmap();
                RequiredIngredients = new List<RecipeIngredient>();
            }

            public void AddIngredient(string name, int quantity)
            {
                RequiredIngredients.Add(new RecipeIngredient(name, quantity));
            }


            public bool HasAnyMatchingIngredient(List<Ingredient> available)
            {
                foreach (var req in RequiredIngredients)
                {
                    foreach (var ing in available)
                    {
                        if (ing.Name.Trim().ToLower() == req.Name.Trim().ToLower())
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }


        public class RecipeIngredient
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public RecipeIngredient(string name, int quantity)
            {
                Name = name;
                Quantity = quantity;
            }
            public override string ToString()
            {
                return $"{Name}:{Quantity}";
            }

        }

        private void btn_ADD_RECIPE_Click(object sender, EventArgs e)
        {
            FormAddRecipe form = new FormAddRecipe();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Recipe addedRecipe = form.NewRecipe;
                recipeList.Add(addedRecipe);
                UpdateRecipeDisplay();
            }
        }

        private void btn_SHOWALL_Click(object sender, EventArgs e)
        {
            flowKorean.Controls.Clear();
            flowWestern.Controls.Clear();
            flowETC.Controls.Clear();

            List<Ingredient> available = GetCheckedIngredients();

            foreach (Recipe recipe in recipeList)
            {
                Panel panel = CreateRecipePanel(recipe);

                switch (recipe.Category)
                {
                    case "한식":
                        flowKorean.Controls.Add(panel);
                        break;
                    case "양식":
                        flowWestern.Controls.Add(panel);
                        break;
                    case "기타":
                        flowETC.Controls.Add(panel);
                        break;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadRecipesFromFile(); // Load saved recipes
            LoadIngredientsFromFile(); // Load saved ingredients
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRecipesToFile(); // Save recipes on close
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_TODAY.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void UpdateRecipeDisplay()
        {
            flowKorean.Controls.Clear();
            flowWestern.Controls.Clear();
            flowETC.Controls.Clear();

            // Get the list of checked ingredients
            List<Ingredient> available = GetCheckedIngredients();

            // Loop through the recipe list and only show the recipes that can be made
            foreach (Recipe recipe in recipeList)
            {
                // Check if the recipe can be made with the selected ingredients
                if (recipe.HasAnyMatchingIngredient(available))
                {
                    Panel panel = CreateRecipePanel(recipe);

                    // Add the recipe to the corresponding category
                    switch (recipe.Category)
                    {
                        case "한식":
                            flowKorean.Controls.Add(panel);
                            break;
                        case "양식":
                            flowWestern.Controls.Add(panel);
                            break;
                        case "기타":
                            flowETC.Controls.Add(panel);
                            break;
                    }
                }
            }
        }

        private Panel CreateRecipePanel(Recipe recipe)
        {
            Panel panel = new Panel();
            panel.Width = 120;
            panel.Height = 140;
            panel.Margin = new Padding(10);

            PictureBox pb = new PictureBox();
            pb.Image = recipe.RecipeImage;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Width = 120;
            pb.Height = 100;
            pb.Tag = recipe;
            pb.Click += RecipeImage_Click;

            Label lbl = new Label();
            lbl.Text = recipe.Title;
            lbl.Dock = DockStyle.Bottom;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(pb);
            panel.Controls.Add(lbl);

            return panel;
        }

        private void RecipeImage_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Recipe recipe = (Recipe)pb.Tag;

            FormRecipeDetail detailForm = new FormRecipeDetail(recipe);
            detailForm.ShowDialog();
        }

        private void LoadRecipesFromFile()
        {
            if (!File.Exists(recipeFilePath)) return;

            string[] lines = File.ReadAllLines(recipeFilePath);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 4) continue;

                string title = parts[0];
                string category = parts[1];
                string ingredientsRaw = parts[2];
                string imagePath = parts[3];  // This is the saved image path

                // Load the image from file path, or use a default image if it doesn't exist
                Image image = File.Exists(imagePath) ? Image.FromFile(imagePath) : SystemIcons.Information.ToBitmap();

                // Create recipe and assign loaded data
                Recipe recipe = new Recipe(title, category, image) { ImagePath = imagePath };

                // Load ingredients for the recipe
                string[] ingredients = ingredientsRaw.Split(',');
                foreach (var item in ingredients)
                {
                    string[] ingParts = item.Split(':');
                    if (ingParts.Length != 2) continue;

                    string ingName = ingParts[0];
                    int qty = int.Parse(ingParts[1]);
                    recipe.AddIngredient(ingName, qty);
                }

                // Add loaded recipe to the list
                recipeList.Add(recipe);
            }
        }
        private void btn_ADD_Click(object sender, EventArgs e)
        {
            string type = cb_TYPE.Text;
            string name = tb_NAME.Text;
            int quantity = int.Parse(num_QT.Text);
            DateTime expire = dateTimePicker1.Value.Date;

            Ingredient item = new Ingredient(name, type, quantity, expire);

            switch (type)
            {
                case "야채 및 과일류":
                    chkList_VEG.Items.Add(item);
                    RefreshCheckListSorted(chkList_VEG);
                    chkList_VEG.Invalidate();
                    break;
                case "고기류":
                    chkList_MEAT.Items.Add(item);
                    RefreshCheckListSorted(chkList_MEAT);
                    chkList_MEAT.Invalidate();
                    break;
                case "소스 및 기타":
                    chkList_SAUCE.Items.Add(item);
                    RefreshCheckListSorted(chkList_SAUCE);
                    chkList_SAUCE.Invalidate();
                    break;
                default:
                    MessageBox.Show("항목을 다시 확인하세요.");
                    break;
            }

            // Save the ingredients after adding a new one
            SaveIngredientsToFile();
        }

        private void RefreshCheckListSorted(CheckedListBox checklist)
        {
            List<Ingredient> items = new List<Ingredient>();

            foreach (var item in checklist.Items)
                if (item is Ingredient ing)
                    items.Add(ing);

            items.Sort((a, b) => a.ExpireDate.CompareTo(b.ExpireDate));

            checklist.Items.Clear();
            foreach (var ing in items)
                checklist.Items.Add(ing);
        }


        private string ingredientFilePath = "ingredients.txt"; // File path for saving ingredients

        private void SaveIngredientsToFile()
        {
            StringBuilder sb = new StringBuilder();

            // Save vegetables
            foreach (var item in chkList_VEG.Items)
            {
                if (item is Ingredient ingredient)
                {
                    sb.AppendLine($"{ingredient.Name}|{ingredient.Type}|{ingredient.Quantity}|{ingredient.ExpireDate:yyyy-MM-dd}");
                }
            }

            // Save meats
            foreach (var item in chkList_MEAT.Items)
            {
                if (item is Ingredient ingredient)
                {
                    sb.AppendLine($"{ingredient.Name}|{ingredient.Type}|{ingredient.Quantity}|{ingredient.ExpireDate:yyyy-MM-dd}");
                }
            }

            // Save sauces
            foreach (var item in chkList_SAUCE.Items)
            {
                if (item is Ingredient ingredient)
                {
                    sb.AppendLine($"{ingredient.Name}|{ingredient.Type}|{ingredient.Quantity}|{ingredient.ExpireDate:yyyy-MM-dd}");
                }
            }

            // Write to file
            File.WriteAllText(ingredientFilePath, sb.ToString());
        }


        private void LoadIngredientsFromFile()
        {
            if (!File.Exists(ingredientFilePath)) return;


            string[] lines = File.ReadAllLines(ingredientFilePath);

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 4) continue;

                string name = parts[0];
                string type = parts[1];
                int quantity = int.Parse(parts[2]);
                DateTime expireDate = DateTime.Parse(parts[3]);

                Ingredient ingredient = new Ingredient(name, type, quantity, expireDate);

                // Add the ingredient to the appropriate checklist
                switch (type)
                {
                    case "야채 및 과일류":
                        chkList_VEG.Items.Add(ingredient);
                        break;
                    case "고기류":
                        chkList_MEAT.Items.Add(ingredient);
                        break;
                    case "소스 및 기타":
                        chkList_SAUCE.Items.Add(ingredient);
                        break;
                    default:
                        // Handle other types if necessary
                        break;
                }
            }
        }



        private void SaveRecipesToFile()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var recipe in recipeList)
            {
                sb.AppendLine($"{recipe.Title}|{recipe.Category}|{string.Join(",", recipe.RequiredIngredients)}|{recipe.ImagePath}");
            }
            File.WriteAllText(recipeFilePath, sb.ToString());
        }

        private List<Ingredient> GetCheckedIngredients()
        {
            List<Ingredient> available = new List<Ingredient>();

            // Add ingredients from checked checklists (you can modify based on your ingredient structure)
            available.AddRange(GetCheckedIngredientsFromList(chkList_VEG));
            available.AddRange(GetCheckedIngredientsFromList(chkList_MEAT));
            available.AddRange(GetCheckedIngredientsFromList(chkList_SAUCE));

            return available;
        }

        private List<Ingredient> GetCheckedIngredientsFromList(CheckedListBox chkList)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            foreach (var item in chkList.CheckedItems)
            {
                ingredients.Add(item as Ingredient);  // Ensure that the item is an Ingredient type
            }
            return ingredients;
        }


        public void ReloadIngredients()
        {
            chkList_VEG.Items.Clear();
            chkList_MEAT.Items.Clear();
            chkList_SAUCE.Items.Clear();

            LoadIngredientsFromFile(); // This will repopulate the lists
        }

        private void btn_DELETE_RECIPE_Click(object sender, EventArgs e)
        {
            string titleToDelete = Microsoft.VisualBasic.Interaction.InputBox("삭제할 레시피 제목을 입력하세요:", "레시피 삭제");

            if (string.IsNullOrWhiteSpace(titleToDelete)) return;

            // Find recipe by title (ignore case/whitespace)
            Recipe toRemove = recipeList.Find(r => r.Title.Trim().ToLower() == titleToDelete.Trim().ToLower());

            if (toRemove != null)
            {
                recipeList.Remove(toRemove);
                SaveRecipesToFile();
                UpdateRecipeDisplay();
            }
            else
            {
                MessageBox.Show("레시피를 찾을 수 없습니다.");
            }
        }

        private void btn_DELETE_INGREDIENT_Click(object sender, EventArgs e)
        {
            CheckedListBox targetList = null;

            // Determine which list is currently selected (you can customize this logic)
            if (chkList_VEG.SelectedIndex != -1) targetList = chkList_VEG;
            else if (chkList_MEAT.SelectedIndex != -1) targetList = chkList_MEAT;
            else if (chkList_SAUCE.SelectedIndex != -1) targetList = chkList_SAUCE;

            if (targetList != null && targetList.SelectedItem != null)
            {
                targetList.Items.Remove(targetList.SelectedItem);
                SaveIngredientsToFile();  // Save updated ingredients
                ReloadIngredients();      // Refresh all lists from file
            }
            else
            {
                MessageBox.Show("삭제할 재료를 선택하세요.");
            }
        }
    }
}
