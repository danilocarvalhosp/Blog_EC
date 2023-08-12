using Blog_EC.Data;
using Blog_EC.Models;

using var context = new BlogDataContext();

var posts = context.PostWithTagsCount.ToList();
foreach (var item in posts)
{
    Console.WriteLine($"{item.Name} - {item.Count}");
}