using Blog_EC.Data;
using Blog_EC.Models;

using var context = new BlogDataContext();

//context.Users.Add(new User{
//    Bio = "9x Microsoft MVP",
//    Email = "danilo@balta.io",
//    Image = "https://balta.io",
//    Name = "Danilo Carvalho",
//    PasswordHash = "1234",
//    Slug = "danilo-carvalho"
//});
//context.SaveChanges();

var user = context.Users.FirstOrDefault();
var post = new Post
{
    Author = user,
    Body = "Meu artigo",
    Category = new Category
    {
        Name = "Frontend",
        Slug = "front-end"
    },
    CreateDate = DateTime.Now,
    // LastUpdateDate =
    Slug = "meu-artigo",
    Summary = "Neste artigo vamos conferir...",
    Title = "Meu artigo"
};
context.Posts.Add(post);
context.SaveChanges();
