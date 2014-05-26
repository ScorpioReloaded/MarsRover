using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class LandscapeGrid
    {
        /// <summary>
        /// Landscape Grid where all reborts walk on, and currently Rover will walk over this.
        /// </summary>
        private static LandscapeGrid _landscapeGrid;

        public int minCordinateX = 0;
        public int minCordinateY = 0;
        public int maxCordinateX = 4;
        public int maxCordinateY = 4;

        private LandscapeGrid()
        {
        }

        //Constructor with paramenters and default value
        public static LandscapeGrid Create(int minCordinateX = 0, int minCordinateY = 0, int maxCordinateX = 4, int maxCordinateY = 4)
        {
            if (_landscapeGrid == null)
            {
                _landscapeGrid = new LandscapeGrid();
            }

            _landscapeGrid.minCordinateX = minCordinateX;
            _landscapeGrid.minCordinateY = minCordinateY;
            _landscapeGrid.maxCordinateX = maxCordinateX;
            _landscapeGrid.maxCordinateY = maxCordinateY;

            return _landscapeGrid;
        }
    }
}
