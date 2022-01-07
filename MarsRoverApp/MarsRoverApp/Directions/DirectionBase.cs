using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    public abstract class DirectionBase
    {
        public Coordinate Coordinates { get; private set; }
        public DirectionBase(Coordinate Coordinates)
        {
            this.Coordinates = Coordinates;
        }
        public abstract bool MoveForward(PlateauCoordinates plateauCoordinates);
        public abstract DirectionBase TurnLeft();
        public abstract DirectionBase TurnRight();
        public abstract bool CheckRoverLimits(PlateauCoordinates plateauCoordinates);
        public abstract string GetDirection();
    }
}
