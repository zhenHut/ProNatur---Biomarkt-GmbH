﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur___Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {
        private readonly SqlConnection _databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\bobom\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int _lastSelectedProductKey;

        public ProductsScreen()
        {
            InitializeComponent();



            ShowProducts();

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (textBoxProductName.Text == string.Empty
                || textBoxProductBrand.Text == string.Empty
                || comboBoxProductCategory.Text == string.Empty
                || textBoxProductPrice.Text == string.Empty)

            {
                MessageBox.Show("Bitte Fülle alle Werte aus");
                return;
            }


            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;

            //float productPrice = float.Parse(textBoxProductPrice.Text);
            decimal productPrice = 0;
            bool isValidPrice = decimal.TryParse(textBoxProductPrice.Text, out productPrice);

            if (!isValidPrice)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Preis ein.");
                return;
            }

            // query optimiert
            //string query = string.Format("insert into Products values ('{0}','{1}','{2}',{3})", productName, productBrand, productCategory, productPrice);
            //string querys = $"insert into Products values ('{productName}','{productBrand}','{productCategory}','{productPrice}')";
            string query = "INSERT INTO Products (Name, Brand, Category, Price) VALUES (@productName, @productBrand, @productCategory, @productPrice)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ProductName", productName),
                new SqlParameter("@ProductBrand", productBrand),
                new SqlParameter("@ProductCategory", productCategory),
                new SqlParameter("@ProductPrice", productPrice)
            };
            ExecuteQuery(query, parameters);


            ClearAllFields();
            ShowProducts();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (_lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string query = "update Products set Name=@ProductName, " +
                "Brand= @ProductBrand, Category= @ProductCategory, Price=@ProductPrice where Id=@ProductId";

            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            int productId = _lastSelectedProductKey;
            decimal productPrice = 0;
            bool isValidPrice = decimal.TryParse(textBoxProductPrice.Text, out productPrice);

            if (!isValidPrice)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Preis ein.");
                return;
            }

            List<SqlParameter> parameterList = new List<SqlParameter>
            {

                new SqlParameter("@ProductName", productName),
                new SqlParameter("@ProductBrand", productBrand),
                new SqlParameter("@ProductCategory", productCategory),
                new SqlParameter("@ProductPrice", productPrice),
                new SqlParameter("@ProductId",_lastSelectedProductKey)

            };

            ExecuteQuery(query, parameterList);

            ShowProducts();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (_lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus.");
                return;
            }
            string query = "Delete from Products where Id=@ProductId";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ProductId",_lastSelectedProductKey)
            };
            ExecuteQuery(query, parameters);
            ClearAllFields();
            ShowProducts();
        }

        private void ClearAllFields()
        {
            textBoxProductName.Clear();
            textBoxProductBrand.Clear();
            textBoxProductPrice.Clear();
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
        }

        private void ExecuteQuery(string query, List<SqlParameter> parametersList)
        {
            _databaseConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, _databaseConnection))
            {

                if (parametersList.Count == 0)
                {
                    MessageBox.Show("");
                    return;
                }
                foreach (var parameter in parametersList)
                    sqlCommand.Parameters.Add(parameter);

                sqlCommand.ExecuteNonQuery();
            }
            _databaseConnection.Close();
        }

        private void ShowProducts()
        {
            _databaseConnection.Open();
            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, _databaseConnection);

            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];

            productsDGV.Columns[0].Visible = false;

            _databaseConnection.Close();
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();

            _lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
