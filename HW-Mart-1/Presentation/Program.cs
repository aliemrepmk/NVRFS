using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities;

// PROGRAMMING LANGUAGES REPOSITORY //

IProgrammingLanguageService programmingLanguageService = new ProgrammingLanguageManager(new InMemoryProgrammingLanguageRepository());
Console.WriteLine("Programming language repository is available.");

Console.WriteLine("\nCurrent programming languages: ");
List<ProgrammingLanguage> languages = programmingLanguageService.GetAllLanguages();
foreach(var temp in languages)
{
    Console.WriteLine(temp.name);
}

Console.Write("\nEnter the name of the programming language you want to add to the repository: ");
string language = Console.ReadLine();
programmingLanguageService.AddLanguage(new ProgrammingLanguage(Guid.NewGuid(), language));

Console.WriteLine("\nProgramming language added succesfully. Current programming languages: ");
languages = programmingLanguageService.GetAllLanguages();
foreach (var temp in languages)
{
    Console.WriteLine(temp.name);
}

// TECHNOLOGY REPOSITORY //

ITechnologyService technologyService = new TechnologyManager(new EFTechnologyRepository());
Console.WriteLine("\n\nTechnology repository is available.");

Console.WriteLine("\nCurrent technologies with ID: ");
List<Technology> technologies = technologyService.GetAllTechnologies();     // technologyService.GetAllTechnologies
foreach (var temp in technologies)
{
    Console.WriteLine(temp.name + " - " + temp.language.name + " - " + temp.Id);
}

Console.Write("\nEnter the name of the technology you want to add to the repository: ");
string technology = Console.ReadLine();

Console.Write("Enter the language of the technology you want to add to the repository: ");
string techLanguage = Console.ReadLine();
technologyService.AddTechnology(new Technology(Guid.NewGuid(), technology, new ProgrammingLanguage(Guid.NewGuid(), techLanguage)));     // technologyService.AddTechnology

Console.WriteLine("\nTechnology added succesfully. Current technologies with ID: ");
technologies = technologyService.GetAllTechnologies();      // technologyService.GetAllTechnologies
foreach (var temp in technologies)
{
    Console.WriteLine(temp.name + " - " + temp.language.name + " - " + temp.Id);
}

Console.Write("\nEnter the ID of the technology you want to delete: ");
Guid tempId = new Guid(Console.ReadLine());
technologyService.DeleteTechnology(tempId);     // technologyService.DeleteTechnology

Console.WriteLine("\nTechnology deleted succesfully. Current technologies with ID: ");
technologies = technologyService.GetAllTechnologies();      // technologyService.GetAllTechnologies
foreach (var temp in technologies)
{
    Console.WriteLine(temp.name + " - " + temp.language.name + " - " + temp.Id);
}

Console.Write("\nEnter the ID of the technology you want to update: ");
tempId = new Guid(Console.ReadLine());
Technology? tempTech = technologyService.GetById(tempId);    // technologyService.GetById
if (!((tempTech.name is not null) && (tempTech.language.name is not null)))
{
    Console.WriteLine("Couldn't find the technology in the repository.");
}

Console.Write("\nEnter the new name of the technology: ");
string techNewName = Console.ReadLine();
technologyService.UpdateTechnology(tempId, techNewName);     // technologyService.UpdateTechnology

Console.WriteLine("\nTechnology updated succesfully. Current technologies with ID: ");
technologies = technologyService.GetAllTechnologies();      // technologyService.GetAllTechnologies
foreach (var temp in technologies)
{
    Console.WriteLine(temp.name + " - " + temp.language.name + " - " + temp.Id);
}