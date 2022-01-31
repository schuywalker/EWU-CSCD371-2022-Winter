using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    internal class InMemoryStore : IStore
    {
        public void Save(ISavable item)
        {
            item = item ?? throw new ArgumentNullException(nameof(item));
        }
    
        public ISavable? Item { get; private set; }

    }
}
