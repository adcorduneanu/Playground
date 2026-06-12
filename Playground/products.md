# Stocks

## Context
You are given the following domain models:

```cs
public class ProductStock
{
    public Product Product { get; set; }
    public int Quantity { get; set; } 
}
 
public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
```

Assume you are inside a service class that has an injected DbContext:
```cs
public class StockService
{
    private readonly DbContext dbContext;

    public StockService(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}
```

> The DbContext does not expose any DbSet<ProductStock> or DbSet<Product> properties.

## Task
### Details
Write a query that returns the all quantities from ProductStock.

### Requirements
Do not load any Product entities.
Explain why your solution is preferable from a performance perspective.
Explain what SQL you would expect Entity Framework Core to generate.

## Time Limit
3-4 minutes