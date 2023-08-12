// See https://aka.ms/new-console-template for more information
using Blog_EC.Data;
using Blog_EC.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new BlogDataContext())
{
    // CREATE
    //var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    //context.Tags.Add(tag);
    //context.SaveChanges();

    // UPDATE
    //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    //tag.Name = ".NET";
    //tag.Slug = "dotnet";
    //context.Update(tag);
    //context.SaveChanges();

    // DELETE
    //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    //context.Remove(tag);
    //context.SaveChanges();

    // TOLIST
    //var tags = context.Tags.ToList();
    //foreach (var item in tags)
    //{
    //    Console.WriteLine(item.Name);
    //}

    // ASNOTRACKING
        // Leitura sempre com ASNOTRACKING / Não utilizar com UPDATE e DELETE
    var tags = context
        .Tags
        .AsNoTracking ()
        .ToList();
    foreach (var item in tags)
    {
        Console.WriteLine(item.Name);
    }
}