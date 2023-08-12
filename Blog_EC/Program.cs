// See https://aka.ms/new-console-template for more information
using Blog_EC.Data;
using Blog_EC.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

#region Trabalhando com Sub Conjunto
//var user = new User
//{
//    Name = "André Baltieri",
//    Slug = "andrebaltieri",
//    Email = "andre@balta.io",
//    Bio = "9x Microsoft MVP",
//    Image = "https://balta.io",
//    PasswordHash = "123456789"
//};

//var category = new Category
//{
//    Name = "Backend",
//    Slug = "backend"
//};

//var post = new Post
//{
//    Author = user,
//    Category = category,
//    Body = "<p>Hello world</p>",
//    Slug = "comecando-com-ef-core",
//    Summary = "Neste artigo vamos aprender EF Core",
//    Title = "Começando com EF Core",
//    CreateDate = DateTime.Now,
//    LastUpdateDate = DateTime.Now,
//};

//context.Posts.Add(post);
//context.SaveChanges();
#endregion

var posts = context
    .Posts
    .Where (x => x.AuthorId == 1)
    .Include (x => x.Author)
    .AsNoTracking()
    .OrderByDescending(x => x.LastUpdateDate)
    .ToList();

foreach (var post in posts)
    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");