using Models.ModelBoard;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class BoardBSS
    {
        public static int AddBoard(Board user)
        {

            return BoardDD.AddBoard(user);
        }

        public static Board GetBoard(int IdBoard)
        {

            return BoardDD.GetBoard(IdBoard);
        }

        public static void RemoveUserBoard(int IdBoard, int IdUser)
        {

            BoardDD.RemoveUserBoard(IdBoard,IdUser);
        }
        public static void UpdateBoard(Board board)
        {

            BoardDD.UpdateBoard(board);
        }

        public static void AddSprintBoard(int IdSprint, int IdBoard)
        {
            BoardDD.AddSprintBoard(IdSprint, IdBoard);
        }
        
        public static void AddUserBoard(int IdBoard, int IdUser)
        {
            BoardDD.AddUserBoard(IdBoard, IdUser);
        }

    }
}
