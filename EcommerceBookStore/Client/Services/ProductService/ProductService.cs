﻿using EcommerceBookStore.Shared;

namespace EcommerceBookStore.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http) 
        {
            _http = http;
        }
        // List to store products
        public List<Product> Products { get; set; } = new List<Product>();
        // A message to display while loading products
        public string Message { get; set; } = "Loading products...";
        // The current page of products
        public int CurrentPage { get; set; } = 1;
        // The total number of pages
        public int PageCount { get; set; } = 0;
        // The last search text used
        public string LastSearchText { get; set; } = string.Empty;

        // Event to notify when products have changed
        public event Action ProductsChanged;

        // Method to retrieve product details by ID
        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            // Check if a category URL is provided; if not, retrieve all products
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product/featured") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            // If the result is not null and contains data, update the Products list
            if (result != null && result.Data != null)
                Products = result.Data;

            CurrentPage = 1;
            PageCount = 0;

            // If no products were found, set an appropriate message
            if (Products.Count == 0)
                Message = "No products found";
            // Invoke the ProductsChanged event to notify of changes
            ProductsChanged.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            // Retrieve search suggestions for the provided search text
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");
            return result.Data;
        }

        public async Task SearchProducts(string searchText, int page)
        {
            LastSearchText = searchText;
            // Retrieve products that match the provided search text
            var result = await _http.GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/search/{searchText}/{page}");
            // If the result is not null and contains data, update the Products list, CurrentPage, and PageCount
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            // If no products were found, display a message
            if (Products.Count == 0) Message = "No products found.";
            // Notify listeners that products have changed
            ProductsChanged?.Invoke();

        }
    }
}
