// See https://aka.ms/new-console-template for more information
using SOA_5;

List<IMakeContent> contentMakers =new  List<IMakeContent>();
contentMakers.Add(new MakeInstContent());
contentMakers.Add(new MakePinterestContent());
contentMakers.Add(new MakeYoutubeContent());
foreach (var maker in contentMakers)
    maker.Post();

Console.WriteLine("Hello, World!");
