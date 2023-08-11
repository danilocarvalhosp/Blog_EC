// See https://aka.ms/new-console-template for more information
using Blog_EC.Data;
using Blog_EC.Models;

using (var context = new BlogDataContext())
{
    // CREATE
    //var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    //context.Tags.Add(tag);
    //context.SaveChanges();

    // UPDATE
    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    tag.Name = ".NET";
    tag.Slug = "dotnet";
    context.Update(tag);
    context.SaveChanges();
}