using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    class SouthDirection : DirectionBase
    {
        public SouthDirection(Coordinate Coordinates) : base(Coordinates) { }

        public override bool MoveForward(PlateauCoordinates plateauCoordinates)
        {
            if (!CheckRoverLimits(plateauCoordinates))
                return false;

            Coordinates.Y = Coordinates.Y - 1;
            return true;
        }

        public override DirectionBase TurnLeft()
        {
            return new EastDirection(Coordinates);
        }

        public override DirectionBase TurnRight()
        {
            return new WestDirection(Coordinates);
        }

        public override string GetDirection()
        {
            return DirectionConst.South;
        }

        public override bool CheckRoverLimits(PlateauCoordinates plateauCoordinates)
        {
            if (plateauCoordinates.yMin == Coordinates.Y)
                return false;

            return true;
        }
    }
}
