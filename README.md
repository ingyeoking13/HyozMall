# Hyoz Mall

## Entity Framework & Model & database  
### 1. set `appsettings.json`  

````json
"ConnectionStrings": {
    "DevelopmentConnection": "Server=(LocalDb)\\MSSQLLocalDB;Database=HyozMallClothesDB;Trusted_Connection=True;MultipleActiveResultSets=True"
}
````

### 2. create `ApplicationDbContext.cs`

````C#
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
````

and then add following statement at `ConfigurationServices` in `Startup.cs`
````C#
services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevelopmentConnection")));
````


### 3. create data skeleton 

````C#
public class Clothes
{
    [Key]
    public int Id { get; set; }

    [Display(Name ="옷 이름")]
    public string Name { get; set; }
    [Display(Name ="디자이너")]
    public string Designer { get; set; }
    [Display(Name ="가격")]
    public int KRW { get; set; }
}
````
 
#### 4. open package manger console  

add migration. should be followed useful name.    
> add-migration AddClothesToDatabase   

update databse.   
> update-database


