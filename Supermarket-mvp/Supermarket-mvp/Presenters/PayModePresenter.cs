using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private ICategoryView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(ICategoryView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;

            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBinldingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false){
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            view.IsEdit = true;
        }

        private void DeleteSelectPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)payModeBindingSource.Current;

                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode Deleted Successfully";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred. Could not Delete Pay Mode";
            }
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode Edited Succesfuly";
                }
                else {
                    repository.Add(payMode);
                    view.Message = "PayMode Added Succesfuly";
                }
                view.IsEdit = true;
                loadAllPayModeList();
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
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
