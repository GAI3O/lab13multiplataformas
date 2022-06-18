using System.IO;
using Xamarin.Forms;
using Lab13.Droid.Implementations;
using Lab13.Interfaces;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab13.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}
