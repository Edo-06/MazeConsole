using System.Diagnostics.Contracts;

namespace maze;
enum Category
{
    wall,
    path,
    obstacle,
    key,
    tramp,
}

class Cell 
{
        public Category category;
        public int type;

        public Cell(Category cat, int ty = 0)
        {
            category = cat;
            type = ty;
        }

        public void Print()
        {
            switch (category)
            {
                case Category.wall:
                    Console.Write("██");
                    break;
                case Category.path:
                    Console.Write("  ");
                    break;
                case Category.obstacle:
                    Console.Write("🔐");
                    break;
                case Category.key:
                    Console.Write("🗝️");
                    break;
                case Category.tramp:
                    Console.Write("💀");
                    break;
                
                
            }

        }
    
}

