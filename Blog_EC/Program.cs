// See https://aka.ms/new-console-template for more information
using Blog_EC.Data;
using Blog_EC.Models;

using (var context = new BlogDataContext())
{
    var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    context.Tags.Add(tag);
    context.SaveChanges();
}