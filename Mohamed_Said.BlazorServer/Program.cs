using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mohamed_Said.BlazorServer.Components;
using Mohamed_Said.BlazorServer.Components.Account;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Core.Services;
using Mohamed_Said.Core.Services.Mappings;
using Mohamed_Said.Infrastructure.Data.DbContexts;
using Mohamed_Said.Infrastructure.Data.Identity;
using Mohamed_Said.Infrastructure.Data.UnitOfWork;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString,
    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)); // apply no tracking globally for all queries in this context for read-only scenarios, not for write operations like Add, Update, Delete, etc.
    // This Line to Make EFCore Create the Migrations in the Infrastructure Project 
    // and It tells EF Core explicitly: "Hey, look for the migrations in the assembly where ApplicationDbContext is defined."


builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(connectionString,
    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); // This Line to Make EFCore Create the Migrations in the Infrastructure Project 
    // and It tells EF Core explicitly: "Hey, look for the migrations in the assembly where AppIdentityDbContext is defined."


builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

//builder.Services.AddTransient(typeof(IBaseRepository<>),typeof(BaseRepository<>)); // Register the generic repository

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // Register the UnitOfWork
builder.Services.AddScoped<ICertificationService, CertificationService>(); // Register the Certification Service
builder.Services.AddScoped<ICourseService, CourseService>(); // Register the Course Service
builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>(); // Register the CourseCategory Service
builder.Services.AddScoped<IBlogCategoryService, BlogCategoryService>(); // Register the BlogCategory Service
builder.Services.AddScoped<IBlogSubCategoryService, BlogSubCategoryService>(); // Register the BlogSubCategory Service
builder.Services.AddScoped<ICourseLinkService, CourseLinkService>(); // Register the CourseLink Service
builder.Services.AddScoped<IExperienceService, ExperienceService>(); // Register the Experience Service
builder.Services.AddScoped<IProjectService, ProjectService>(); // Register the Project Service
builder.Services.AddScoped<IMessageService, MessageService>(); // Register the Message Service
builder.Services.AddScoped<ISkillCategoryService, SkillCategoryService>(); // Register the SkillCategory Service
builder.Services.AddScoped<ISkillService, SkillService>(); // Register the Skill Service
builder.Services.AddScoped<IContactIconService, ContactIconService>(); // Register the ContactIcon Service
builder.Services.AddScoped<IAdminService, AdminService>(); // Register the Admin Service



builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly); // Register AutoMapper 

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStatusCodePagesWithReExecute("/NotFound"); // Use a custom page for 404 Not Found errors

app.UseAuthorization();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
