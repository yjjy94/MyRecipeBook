using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static MyRecipeBook.FormMain;

namespace MyRecipeBook
{
    public partial class FormRecipeDetail : Form
    {
        private Recipe recipe;

        public FormRecipeDetail(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;
            lbl_TITLE_DETAIL.Text = recipe.Title;
            pb_DETAIL.Image = recipe.RecipeImage;
            pb_DETAIL.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_RECIPE_DETAIL.Text = GetIngredientList(recipe);
            lbl_CUISINE_DETAIL.Text = recipe.Category;
        }

        private string GetIngredientList(Recipe recipe)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ing in recipe.RequiredIngredients)
            {
                sb.AppendLine($"- {ing.Name}: {ing.Quantity}");
            }
            return sb.ToString();
        }


        //private void btn_MAKE_Click(object sender, EventArgs e)
        //{
        //    List<RecipeIngredient> requiredIngredients = GetRecipeIngredients();
        //    List<Ingredient> allIngredients = LoadIngredientsFromFile();

        //    // Check if all required ingredients are available in sufficient quantity
        //    foreach (var reqIng in requiredIngredients)
        //    {
        //        var matchingIngs = allIngredients
        //            .Where(ing => ing.Name.Trim().ToLower() == reqIng.Name.Trim().ToLower())
        //            .ToList();

        //        int totalAvailable = matchingIngs.Sum(i => i.Quantity);

        //        if (totalAvailable < reqIng.Quantity)
        //        {
        //            MessageBox.Show($"재료 부족: {reqIng.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //    }

        //    // Deduct required quantities using soon-to-expire ingredients first
        //    foreach (var reqIng in requiredIngredients)
        //    {
        //        int remainingToDeduct = reqIng.Quantity;

        //        var matchingIngs = allIngredients
        //            .Where(i => i.Name.Trim().ToLower() == reqIng.Name.Trim().ToLower())
        //            .OrderBy(i => i.ExpireDate) // Use soon-to-expire first
        //            .ToList();

        //        foreach (var ing in matchingIngs)
        //        {
        //            if (remainingToDeduct <= 0) break;

        //            if (ing.Quantity <= remainingToDeduct)
        //            {
        //                remainingToDeduct -= ing.Quantity;
        //                ing.Quantity = 0;
        //            }
        //            else
        //            {
        //                ing.Quantity -= remainingToDeduct;
        //                remainingToDeduct = 0;
        //            }
        //        }
        //    }

        //    // Remove used-up ingredients
        //    allIngredients.RemoveAll(i => i.Quantity <= 0);

        //    // Save updated inventory
        //    SaveIngredientsToFile(allIngredients);

        //    // Optional: reload UI if needed
        //    FormMain mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
        //    if (mainForm != null)
        //    {
        //        mainForm.ReloadIngredients();
        //    }

        //    MessageBox.Show("만들기 성공! 재고를 업데이트 했습니다!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void btn_MAKE_Click(object sender, EventArgs e)
        {
            List<RecipeIngredient> requiredIngredients = GetRecipeIngredients();
            List<Ingredient> allIngredients = LoadIngredientsFromFile();
            List<string> insufficientIngredients = new List<string>(); // To collect insufficient ingredients

            // Check if all required ingredients are available in sufficient quantity
            foreach (var reqIng in requiredIngredients)
            {
                var matchingIngs = allIngredients
                    .Where(ing => ing.Name.Trim().ToLower() == reqIng.Name.Trim().ToLower())
                    .ToList();

                int totalAvailable = matchingIngs.Sum(i => i.Quantity);

                if (totalAvailable < reqIng.Quantity)
                {
                    insufficientIngredients.Add(reqIng.Name); // Add missing ingredient to the list
                }
            }

            if (insufficientIngredients.Any()) // If there are any insufficient ingredients
            {
                string missingIngredients = string.Join("\n", insufficientIngredients); // Join them into a single string
                MessageBox.Show($"재료 부족:\n{missingIngredients}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deduct required quantities using soon-to-expire ingredients first
            foreach (var reqIng in requiredIngredients)
            {
                int remainingToDeduct = reqIng.Quantity;

                var matchingIngs = allIngredients
                    .Where(i => i.Name.Trim().ToLower() == reqIng.Name.Trim().ToLower())
                    .OrderBy(i => i.ExpireDate) // Use soon-to-expire first
                    .ToList();

                foreach (var ing in matchingIngs)
                {
                    if (remainingToDeduct <= 0) break;

                    if (ing.Quantity <= remainingToDeduct)
                    {
                        remainingToDeduct -= ing.Quantity;
                        ing.Quantity = 0;
                    }
                    else
                    {
                        ing.Quantity -= remainingToDeduct;
                        remainingToDeduct = 0;
                    }
                }
            }

            // Remove used-up ingredients
            allIngredients.RemoveAll(i => i.Quantity <= 0);

            // Save updated inventory
            SaveIngredientsToFile(allIngredients);

            // Optional: reload UI if needed
            FormMain mainForm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.ReloadIngredients();
            }

            MessageBox.Show("만들기 성공! 재고를 업데이트 했습니다!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<RecipeIngredient> GetRecipeIngredients()
        {
            List<RecipeIngredient> requiredIngredients = new List<RecipeIngredient>();

            // Assuming that the Recipe class has a list of required ingredients
            foreach (var req in recipe.RequiredIngredients)
            {
                requiredIngredients.Add(req);
            }

            return requiredIngredients;
        }

        private List<Ingredient> LoadIngredientsFromFile()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            if (File.Exists("ingredients.txt"))
            {
                string[] lines = File.ReadAllLines("ingredients.txt");

                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length < 4) continue;

                    string name = parts[0];
                    string type = parts[1];
                    int quantity = int.Parse(parts[2]);
                    DateTime expireDate = DateTime.Parse(parts[3]);

                    ingredients.Add(new Ingredient(name, type, quantity, expireDate));
                }
            }

            return ingredients;
        }

        private void SaveIngredientsToFile(List<Ingredient> ingredients)
        {
            StringBuilder sb = new StringBuilder();

            // Save all ingredients to the file
            foreach (var ingredient in ingredients)
            {
                sb.AppendLine($"{ingredient.Name}|{ingredient.Type}|{ingredient.Quantity}|{ingredient.ExpireDate:yyyy-MM-dd}");
            }

            // Write the updated ingredient list back to the file
            File.WriteAllText("ingredients.txt", sb.ToString());
        }
    }

}
