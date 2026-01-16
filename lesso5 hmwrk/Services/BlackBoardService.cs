using lesso5_hmwrk.Models;
namespace lesso5_hmwrk.Services;

public class BlackBoardService : IBlackBoardServices
{
    List<BlackBoard> BlackBoards;

    public BlackBoardService()
    {
        BlackBoards = new List<BlackBoard>();
    }

    public Guid AddBlackBoard(BlackBoard blackBoard)
    {
        blackBoard.BBId = Guid.NewGuid();
        BlackBoards.Add(blackBoard);
        return blackBoard.BBId;
    }

    public bool DeleteBlackBoard(Guid BlackBoardId)
    {
        foreach (var blackBoard in BlackBoards)
        {
            if (blackBoard.BBId == BlackBoardId)
            {
                BlackBoards.Remove(blackBoard);
                return true;
            }
        }
        return false;
    }

    public bool UpdateBlackBoard(BlackBoard newBlackBoards)
    {
        foreach (BlackBoard blackBoard in BlackBoards)
        {
            if (newBlackBoards.BBId == blackBoard.BBId)
            {
                blackBoard.SubjectBB = newBlackBoards.SubjectBB;
                blackBoard.TopicBB = newBlackBoards.TopicBB;
                blackBoard.TeacherName = newBlackBoards.TeacherName;
                return true;
            }
        }
        return false;
    }
    public List<BlackBoard> GetAllBlackBoards()
    {
        return BlackBoards;
    }

    public BlackBoard? GetByIdBlackBoards(Guid blackBoardId)
    {
        foreach (var blackBoard in BlackBoards)
        {
            if (blackBoard.BBId == blackBoardId)
            {
                return blackBoard;
            }
        }
        return null;
    }





}
