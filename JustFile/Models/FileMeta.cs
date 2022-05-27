using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
namespace JustFile.Models
{
    /// <summary>
    /// Model that contains all meta info about a physical file in file system
    /// </summary>
    public class FileMeta
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Path {get;set;}
        public string? Url {get;set;}
        [NotMapped]
        public string FullPath {get {
            return System.IO.Path.Join(Path, Name);
            }}
        [NotMapped]
        public bool Exists {get {
            return File.Exists(FullPath);
        }}
    }
}