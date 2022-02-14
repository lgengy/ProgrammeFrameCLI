using System.Collections.Generic;

namespace ProgrammeFrameCLI.Entity
{
    public class EntityAvailableUtil
    {
        private string _Name;
        private string _Description;
        private string _Detail;
        private string _ClassFullPath;

        public string Name { get => _Name; set => _Name = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string Detail { get => _Detail; set => _Detail = value; }
        public string ClassFullPath { get => _ClassFullPath; set => _ClassFullPath = value; }

        public override bool Equals(object obj)
        {
            return obj is EntityAvailableUtil util &&
                   _Name == util._Name;
        }

        public override int GetHashCode()
        {
            return 944813493 + EqualityComparer<string>.Default.GetHashCode(_Name);
        }
    }
}
