using System;
namespace resfull_api_demo.Model
{
	public interface IProductRepo
    {
		Task<List<Product>> GetAll();

		//Task<Product> Getbycode(int code);

		//Task<string> Create(Product employee);

		//Task<string> Update(Product employee, int code);

		//Task<string> Delete(int code);
	}
}

