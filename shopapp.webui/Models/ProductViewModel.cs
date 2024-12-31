using shopapp.entity;
using System.Collections.Generic;

public class PageInfo
{
    public int TotalItems { get; set; }
    public int ItemsPerPage { get; set; }
    public int CurrentPage { get; set; }
    public string CurrentCategory { get; set; }
    public int TotalPages()
    {
        return (int)System.Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
public class ProductListViewModel
{
    public PageInfo PageInfo { get; set; }
    public List<Product> Products { get; set; }
}