using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProviderPresenter
    {
        private IProviderView view;
        private IProviderRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProviderModel> providerList;
        public ProviderPresenter(IProviderView view, IProviderRepository repository)
        {
            this.providerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;

            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBinldingSource(providerBindingSource);

            loadAllProviderList();

            this.view.Show();
        }

        private void loadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            var provider = (ProviderModel)providerBindingSource.Current;

            view.ProviderNit = provider.Nit.ToString();
            view.ProviderName = provider.Name;
            view.ProviderAddress = provider.Addres;
            view.ProviderNumber = provider.Number;

            view.IsEdit = true;
        }

        private void DeleteSelectProvider(object? sender, EventArgs e)
        {
            try
            {
                var provider = (ProviderModel)providerBindingSource.Current;

                repository.Delete(provider.Nit);
                view.IsSuccessful = true;
                view.Message = "Provider Deleted Successfully";
                loadAllProviderList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred. Could not Delete Pay Mode";
            }
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            var provider = new ProviderModel();
            provider.Nit = Convert.ToInt32(view.ProviderNit);
            provider.Name = view.ProviderName;
            provider.Addres = view.ProviderAddress;
            provider.Number = view.ProviderNumber;

            try
            {
                new Common.ModelDataValidation().validate(provider);
                if (view.IsEdit)
                {
                    repository.Edit(provider);
                    view.Message = "Provider Edited Succesfuly";
                }
                else
                {
                    repository.Add(provider);
                    view.Message = "Provider Added Succesfuly";
                }
                view.IsEdit = true;
                loadAllProviderList();
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
            view.ProviderNit = "";
            view.ProviderName = "";
            view.ProviderAddress = "";
            view.ProviderNumber = "";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
