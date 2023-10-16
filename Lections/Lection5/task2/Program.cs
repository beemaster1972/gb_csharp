void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo directory = new DirectoryInfo(path);
  DirectoryInfo[] catalogs = directory.GetDirectories();
  foreach (DirectoryInfo catalog in catalogs)
  {
    Console.WriteLine($"{indent} [{catalog.Name}]");
    FileInfo[] files = directory.GetFiles();
    foreach (FileInfo file in files)
      Console.WriteLine($"{indent + " "} {file.Name}");
    CatalogInfo(catalog.FullName, indent + "  ");
  }
}

string path = "/home/beemaster/gb/GB_csharp/Lections/";
CatalogInfo(path);
