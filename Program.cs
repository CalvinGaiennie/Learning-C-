// Array CRUD

// Create
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

// Read

// foreach(var rat in favoriteRats)
// {
//     Console.WriteLine(rat);
// };

// Update
// favoriteRats[0] = "Fancy Rat";
// LINQ - 

var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"));

foreach(var rat in newFavoriteRats)
{
    Console.WriteLine(rat);
};

// Delete
// gimme