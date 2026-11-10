using SLib23T1020357.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLib23T1020357.DesktopApp.Properties.DataDictionary.Categories
{
    public partial class FormInputCategory : Form
    {
        private List<Category> _categories = new();

        public event EventHandler? CategoryAdded;
        public event EventHandler? CategoryUpdated;

        public FormInputCategory()
        {
            InitializeComponent();
        }

        public bool isAddMode { get; set; }

        public int CategoryId { get; set; }

        private async void FormInputCategory_Load(object? sender, EventArgs e)
        {
            try
            {
                _categories = await ServiceManager.Category.ListAsync();
                Category? editedCategory = null;
                if (!isAddMode)
                {
                    editedCategory = await ServiceManager.Category.GetAsync(CategoryId);
                }

                ConfigureParentCategories(editedCategory);
                if (isAddMode)
                {
                    Text = "Thêm mới thể loại";
                    chkIsActive.Checked = true;
                }
                else if (editedCategory != null)
                {
                    Text = "Cập nhật thông tin thể loại";
                    txtCategoryName.Text = editedCategory.CategoryName;
                    txtDescription.Text = editedCategory.Description;
                    chkIsActive.Checked = editedCategory.IsActive;
                    comboParentCategory.SelectedItem = comboParentCategory.Items
                        .Cast<CategoryOption>()
                        .FirstOrDefault(option => option.CategoryId == editedCategory.ParentCategoryId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin thể loại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ConfigureParentCategories(Category? editedCategory)
        {
            var excludedCategoryIds = new HashSet<int>();
            if (editedCategory != null)
            {
                excludedCategoryIds.Add(editedCategory.CategoryId);
                var categoriesToCheck = new Queue<int>();
                categoriesToCheck.Enqueue(editedCategory.CategoryId);

                while (categoriesToCheck.Count > 0)
                {
                    int parentId = categoriesToCheck.Dequeue();
                    foreach (var child in _categories.Where(category => category.ParentCategoryId == parentId))
                    {
                        if (excludedCategoryIds.Add(child.CategoryId))
                            categoriesToCheck.Enqueue(child.CategoryId);
                    }
                }
            }

            var options = new List<CategoryOption>
            {
                new(null, "Không có thể loại cha")
            };
            options.AddRange(_categories
                .Where(category => !excludedCategoryIds.Contains(category.CategoryId))
                .Select(category => new CategoryOption(category.CategoryId, category.CategoryName)));

            comboParentCategory.DisplayMember = nameof(CategoryOption.Name);
            comboParentCategory.ValueMember = nameof(CategoryOption.CategoryId);
            comboParentCategory.DataSource = options;
            comboParentCategory.SelectedIndex = 0;
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                var selectedParent = comboParentCategory.SelectedItem as CategoryOption;
                var category = new Category
                {
                    CategoryName = txtCategoryName.Text.Trim(),
                    ParentCategoryId = selectedParent?.CategoryId,
                    Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim(),
                    IsActive = chkIsActive.Checked
                };

                if (isAddMode)
                {
                    await ServiceManager.Category.AddAsync(category);
                    CategoryAdded?.Invoke(category, EventArgs.Empty);
                }
                else
                {
                    category.CategoryId = CategoryId;
                    if (!await ServiceManager.Category.UpdateAsync(category))
                    {
                        MessageBox.Show("Không tìm thấy thể loại cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    CategoryUpdated?.Invoke(category, EventArgs.Empty);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu thông tin thể loại:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private sealed class CategoryOption
        {
            public CategoryOption(int? categoryId, string name)
            {
                CategoryId = categoryId;
                Name = name;
            }

            public int? CategoryId { get; }
            public string Name { get; }
        }
    }
}
