 using Microsoft.EntityFrameworkCore;
   using BookManager.Data;

   public void ConfigureServices(IServiceCollection services)
   {
       services.AddDbContext<BookContext>(options =>
           options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), 
           new MySqlServerVersion(new Version(8, 0, 21)))); 

       services.AddControllersWithViews();
   }