using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    /// <summary>
    /// Enum for Rover position, Face Direction and Move
    /// Can move this enum region to rover class, I put it seperate for code clearity
    /// </summary>
    #region enums

    enum RotatePosition
    {
        Left,
        Right
    }

    enum RoverFaceDirection
    {
        North,
        East,
        South,
        West
    }

    enum RoverMove
    {
        Forward
        //Add Backward here for future extension
    }

    #endregion enums


    /// <summary>
    /// Structure to keep walking rover position on landscape Grid
    /// </summary>
    struct structRoverCurrentPostion
    {
        //landscape limits
        int minX; int minY; int maxX; int maxY;

        //x-corrdinate
        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (value >= minX && value <= maxX)
                {
                    _x = value;
                }
            }
        }

        //y-corrdinate
        private int _y;
        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= minY && value <= maxY)
                {
                    _y = value;
                }
            }
        }

        /// <summary>
        /// Constructor to intialize rover walking position and limits on landscape Grid
        /// </summary>
        /// <param name="x">Starting x position</param>
        /// <param name="y">Starting y position</param>
        /// <param name="minX">Min x </param>
        /// <param name="minY"></param>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        public structRoverCurrentPostion(int x = 0, int y = 0 , int minX = 0, int minY = 0, int maxX = 4, int maxY = 4)
        {
            _x = x;
            _y = y;
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            
            
        }

        public override string ToString()
        {
            return string.Format("Rover current cordinates(x,y) are ({0},{1})", X, Y);
        }
    }
      

    class Rover
    {

        #region properties and Strut

        public structRoverCurrentPostion roverCurrentPosition;

        private RoverFaceDirection _roverFaceDirection;
        public RoverFaceDirection RoverCurrentFaceDirection
        {
            get { return _roverFaceDirection; }
            set
            {
                if (value < RoverFaceDirection.North)
                {
                    _roverFaceDirection = RoverFaceDirection.West;
                }
                else if (value > RoverFaceDirection.West)
                {
                    _roverFaceDirection = RoverFaceDirection.North;
                }
                else
                {
                    _roverFaceDirection = value;
                }

            }
        }
               
        #endregion properties and Strut

    
        #region singleton Instance

        //singleton private instante
        private static Rover _rover;
      
        private Rover(int x, int y, LandscapeGrid landScapeGrid)
        {
            roverCurrentPosition = new structRoverCurrentPostion(0, 0, landScapeGrid.minCordinateX, landScapeGrid.minCordinateY, landScapeGrid.maxCordinateX, landScapeGrid.maxCordinateY);
            
        }

        public static Rover Create(int startPositionX, int startPostionY, LandscapeGrid landScapeGrid)
        {
            if (_rover == null)
            {
                _rover = new Rover(startPositionX, startPostionY, landScapeGrid);
            }

            return _rover;
        }


        #endregion singleton Instance


        #region Rover Actions

        /// <summary>
        /// Rover action to move its direction to North, East, South, West
        /// </summary>
        /// <param name="rotatePosition"></param>
        public void Rotate(RotatePosition rotatePosition)
        {
            if (rotatePosition == RotatePosition.Right)
            {
                RoverCurrentFaceDirection += 1;
            }
            else if (rotatePosition == RotatePosition.Left)
            {
                RoverCurrentFaceDirection -= 1;
            }
        }

        /// <summary>
        /// Rover action to Move for Forward, extend here for backword
        /// </summary>
        /// <param name="roverMove"></param>
        public void Move(RoverMove roverMove)
        {
            if (roverMove == RoverMove.Forward)
            {
                switch (RoverCurrentFaceDirection)
                {
                    case RoverFaceDirection.North:
                        {
                            roverCurrentPosition.Y += 1;
                            break;
                        }
                    case RoverFaceDirection.East:
                        {
                            roverCurrentPosition.X += 1;
                            break;
                        }
                    case RoverFaceDirection.South:
                        {
                            roverCurrentPosition.Y -= 1;
                            break;
                        }
                    case RoverFaceDirection.West:
                        {
                            roverCurrentPosition.X -= 1;
                            break;
                        }
                }
            }
        }

        #endregion Rover Actions

    }
}
