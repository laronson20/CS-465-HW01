//I don't want to mess up my code this close to the deadline, so I'll just comment my thoughts/suggestions throughout the code. (Sorry!)

//The final issue for this was that the program wasn't adding all of the coordinates to the tuple list, so I couldn't compare 
//the "current" location to those in the list to see if the coordinate had already been passed by (and, thus, the robot had
//made a square). My thoughts are that I could add a while loop within each case that adds each coordinate as the x or y value
//is incremented by 1. a third variable, i, would act as a counter to determine how many times x or y would be incremented.

public class SquareRobot : IRobot
{
    public bool Move(int[] commands)
    {
        foreach(var command in commands)
        {
            //int i = 0;
            switch(_direction){
                case Direction.North: 
                    //while (int <= command)
                    //{ 
                        // _y += 1;
                        //_coordinates.Add(new Tuple<int, int>(_x, _y))
                        //int += 1;
                    //}
                    // i = 0;
                    //( ^^ instead of line 25)
                    _y += command;
                    break;
                case Direction.East:
                    //while (int <= command)
                    //{ 
                        // _x += 1;
                        //_coordinates.Add(new Tuple<int, int>(_x, _y))
                        //int += 1;
                    //}
                    // i = 0;
                    //( ^^ instead of line 36)
                    _x += command;
                    break;
                case Direction.South:
                    //while (int <= command)
                    //{ 
                        // _y -= 1;
                        //_coordinates.Add(new Tuple<int, int>(_x, _y))
                        //int += 1;
                    //}
                    // i = 0;
                    //( ^^ instead of line 47)
                    _y -= command;
                    break;
                case Direction.West:
                    //while (int <= command)
                    //{ 
                        // _x -= 1;
                        //_coordinates.Add(new Tuple<int, int>(_x, _y))
                        //int += 1;
                    //}
                    // i = 0;
                    //( ^^ instead of line 58)
                    _x -= command;
                    break;    
            }
            ReturnDirection();
            if (_coordinates.Contains(new Tuple<int, int>(_x, _y)))
                return true;
            _coordinates.Add(new Tuple<int, int>(_x , _y));
        }
        return false;
        
    }

    private List<Tuple<int, int>> _coordinates = new List<Tuple<int, int>>();
    private int _x = 0;
    private int _y = 0;
    private Direction _direction = Direction.North;

    enum Direction{
        North, East, South, West
    };

    private void ReturnDirection(){
        if (_direction == Direction.North) _direction = Direction.East;
        else if (_direction == Direction.East) _direction = Direction.South;
        else if (_direction == Direction.South) _direction = Direction.West;
        else _direction = Direction.North;
    }
}