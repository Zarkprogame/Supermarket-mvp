using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;

            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBinldingSource(productBindingSource);

            loadAllProductList();

            this.view.Show();
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.CategoryId = product.CategoryId.ToString();
            view.IsEdit = true;
        }

        private void DeleteSelectProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product Deleted Successfully";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred. Could not Delete Pay Mode";
            }
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Price = Convert.ToInt32(view.ProductPrice);
            product.Stock = Convert.ToInt32(view.ProductStock);
            product.CategoryId = Convert.ToInt32(view.CategoryId);

            try
            {
                new Common.ModelDataValidation().validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product Edited Succesfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product Added Succesfuly";
                }
                view.IsEdit = true;
                loadAllProductList();
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
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "0";
            view.ProductStock = "0";
            view.CategoryId = "0";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
