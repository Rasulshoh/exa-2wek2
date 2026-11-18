// / Main d = new Main();
// System.Console.WriteLine(d.Abs(-7.5));
// System.Console.WriteLine(d.Abs(-7));
// System.Console.WriteLine(d.Pow(2, 3));
// System.Console.WriteLine(d.Sqrt(16));
// System.Console.WriteLine(d.Max(3, 7));
// System.Console.WriteLine(d.Min(3, 7));

//task 2
List<Post> posts = new List<Post>();

Post post1 = new Post();
post1.Title="Zaboni barnomasozi";
post1.LikeCount=1;
post1.Coment("Ekclent");
post1.Publish();


Post post2 = new Post();

post2.Title="Zaboni barnomasozi";
post2.LikeCount=1;
post2.Coment("Ekclent");
post2.Publish();

Post post3 = new Post();

post3.Title="Zaboni barnomasozi";
post3.LikeCount=1;
post3.Coment("Ekclent");
post3.Publish();


Post post4 = new Post();

post4.Title="Zaboni barnomasozi";
post4.LikeCount=1;
post4.Coment("Ekclent");
post4.Publish();

Post post5 = new Post();

post5.Title="Zaboni barnomasozi";
post5.LikeCount=1;
post5.Coment("Ekclent");
post5.Publish();

List<Post> postes = new List<Post>{post1, post2, post3, post4, post5};

foreach (var item in postes)
{
    System.Console.WriteLine($" Title: {item.Title}  Decribtion: {item.Description} Like: {item.LikeCount}");
}

