using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= UKERMASPC\\SQLEXPRESS;initial Catalog=egitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO tblCategory (categoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= UKERMASPC\\SQLEXPRESS;initial Catalog=egitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO tblProduct (productName, productPrice, productStatus) VALUES (@p1, @p2, @p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı.");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source= UKERMASPC\\SQLEXPRESS;initial Catalog=egitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM tblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= UKERMASPC\\SQLEXPRESS;initial Catalog=egitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM tblProduct WHERE productID = @productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName= Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= UKERMASPC\\SQLEXPRESS;initial Catalog=egitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("UPDATE tblProduct SET productName = @productName, productPrice = @productPrice WHERE productID = @productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme işlemi başarılı.");

            #endregion

            Console.Read();

        }
    }
}
