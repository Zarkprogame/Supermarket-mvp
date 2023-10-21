using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource CategoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.CategoryBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;

            this.view.EditEvent += LoadSelectCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBinldingSource(CategoryBindingSource);

            loadAllCategoryList();

            this.view.Show();
        }

        private void loadAllCategoryList()
        {
            categoryList = repository.GetAll();
            CategoryBindingSource.DataSource = categoryList;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            CategoryBindingSource.DataSource = categoryList;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectCategoryToEdit(object? sender, EventArgs e)
        {
            var category = (CategoryModel)CategoryBindingSource.Current;

            view.CategoryId = category.Id.ToString();
            view.CategoryName = category.Name;
            view.CategoryDescription = category.Description;

            view.IsEdit = true;
        }

        private void DeleteSelectCategory(object? sender, EventArgs e)
        {
            try
            {
                var category = (CategoryModel)CategoryBindingSource.Current;

                repository.Delete(category.Id);
                view.IsSuccessful = true;
                view.Message = "Category Deleted Successfully";
                loadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred. Could not Delete Pay Mode";
            }
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var category = new CategoryModel();
            category.Id = Convert.ToInt32(view.CategoryId);
            category.Name = view.CategoryName;
            category.Description = view.CategoryDescription;

            try
            {
                new Common.ModelDataValidation().validate(category);
                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Category Edited Succesfuly";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Category Added Succesfuly";
                }
                view.IsEdit = true;
                loadAllCategoryList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryDescription = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
