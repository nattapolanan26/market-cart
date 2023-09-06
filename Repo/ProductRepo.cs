using System;
using System.Data;
using Dapper;
using resfull_api_demo.Model;
using resfull_api_demo.Model.Data;

namespace resfull_api_demo.Repo
{
	public class ProductRepo: IProductRepo
    {
		private readonly DapperDBContext context;

		public ProductRepo(DapperDBContext context)
		{
			this.context = context;
		}

 
        public async Task<List<Product>> GetAll()
		{
			string query = "Select * From product";
			using (var connection = this.context.CreateConnection())
			{
				//var list = await connection.QueryAsync<Stock, Product, Stock>(query,
				//(product, stock) =>
				//{
				//	product.product_id = stock.product_id;
				//	return product;
				//},
				//splitOn: "product_id");

    //            list.ToList().ForEach(stock => Console.WriteLine($"Product: {stock.products}, Category: {product.product_total}"));

                var list = await connection.QueryAsync<Product>(query);

				return list.ToList();
			}
		}
    }
}

