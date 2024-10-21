
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace User.Managament.API.Services;

public class ApplicationDbContext: IdentityDbContext{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        
    }

    protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
    }
    

}