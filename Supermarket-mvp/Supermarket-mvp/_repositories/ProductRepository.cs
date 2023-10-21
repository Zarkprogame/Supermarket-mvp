using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
            FeedComboBoxCategory();
        }
        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Product VALUES (@name, @price, @stock, @category)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@category", SqlDbType.Int).Value = productModel.CategoryId;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                                        SET Product_Name = @name,
                                        Product_Price = @price
                                        Product_Stock = @stock
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productModel.Price;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var ProductList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (int)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.CategoryId = (int)reader["Category_Id"];
                        ProductList.Add(productModel);

                    }
                }
            }
            return ProductList;
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var ProductList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;
            string productPrice = value;
            string productStock = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                        WHERE Product_Id = @id or Product_Name LIKE @name + '%' or Product_Price LIKE @price + '%' or Product_Stock LIKE @stock + '%'
                                        ORDER BY Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productPrice;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productStock;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (int)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModel.CategoryId = (int)reader["Category_Id"];
                        ProductList.Add(productModel);

                    }
                }
            }
            return ProductList;
        }
        public void FeedComboBoxCategory()
        {
            ProductView.comboBoxCategoryId.Items.Clear();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetInt32("Category_Id") + "  -  " + reader.GetString("Category_Name");
                        ProductView.comboBoxCategoryId.Items.Add(item);
                    }
                }
            }
        }
    }
}
