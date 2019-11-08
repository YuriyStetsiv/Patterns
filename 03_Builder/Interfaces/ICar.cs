using System.Collections.Generic;

namespace _03_Builder.Interfaces
{
    //Classes constructed by different builders 
    //don’t have to belong to the same class hierarchy or interface.
    public interface ICar
    {
        public string Name { get; set; }
        public List<string> Details { get; set; }

    }
}
