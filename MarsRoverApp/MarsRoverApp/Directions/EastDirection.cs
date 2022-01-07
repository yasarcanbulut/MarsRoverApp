using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    class EastDirection : DirectionBase
    {
        public EastDirection(Coordinate Coordinates) : base(Coordinates) { }

        public override bool MoveForward(PlateauCoordinates plateauCoordinates)
        {
            if (!CheckRoverLimits(plateauCoordinates))
                return false;

            Coordinates.X = Coordinates.X + 1;
            return true;
        }

        public override DirectionBase TurnLeft()
        {
            return new NorthDirection(Coordinates);
        }

        public override DirectionBase TurnRight()
        {
            return new SouthDirection(Coordinates);
        }

        public override string GetDirection()
        {
            return DirectionConst.East;
        }

        public override bool CheckRoverLimits(PlateauCoordinates plateauCoordinates)
        {
            if (plateauCoordinates.xMax == Coordinates.X)
                return false;

            return true;
        }
    }
}
