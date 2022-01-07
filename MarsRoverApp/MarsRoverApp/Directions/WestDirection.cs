using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    class WestDirection : DirectionBase
    {
        public WestDirection(Coordinate Coordinates) : base(Coordinates) { }

        public override bool MoveForward(PlateauCoordinates plateauCoordinates)
        {
            if (!CheckRoverLimits(plateauCoordinates))
                return false;

            Coordinates.X = Coordinates.X - 1;
            return true;
        }

        public override DirectionBase TurnLeft()
        {
            return new SouthDirection(Coordinates);
        }

        public override DirectionBase TurnRight()
        {
            return new NorthDirection(Coordinates);
        }

        public override string GetDirection()
        {
            return DirectionConst.West;
        }

        public override bool CheckRoverLimits(PlateauCoordinates plateauCoordinates)
        {
            if (plateauCoordinates.xMin == Coordinates.X)
                return false;

            return true;
        }
    }
}
