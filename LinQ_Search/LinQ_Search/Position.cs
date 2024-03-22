using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Search
{
    class Position
    {
        public int positionID { get; set; }
        public string posName { get; set; }

        public static List<Position> getPositions()
        {
            return new List<Position>()
            {
                new Position { positionID = 1, posName = "Manager"},
                new Position { positionID = 2, posName = "Developer"},
                new Position { positionID = 3, posName = "Designer"},
                new Position { positionID = 4, posName = "Tester"},
            };
        }
    }
}
