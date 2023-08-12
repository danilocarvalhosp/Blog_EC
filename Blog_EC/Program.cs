using Blog_EC.Data;
using Blog_EC.Models;

var user = new User
{
    Name = "André Baltieri",
    Slug = "andrebaltieri",
    GitHub = "andrebaltieri",
    Email = "andre@balta.io",
    Bio = "9x Microsoft MVP",
    Image = "https://balta.io",
    PasswordHash = "123098457"
};

using var context = new BlogDataContext();
context.Users.Add(user);
context.SaveChanges();
