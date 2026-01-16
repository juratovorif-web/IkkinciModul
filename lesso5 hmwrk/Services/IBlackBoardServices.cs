using lesso5_hmwrk.Models;
namespace lesso5_hmwrk.Services;

public interface IBlackBoardServices
{
    public Guid AddBlackBoard(BlackBoard blackBoard);
    public bool UpdateBlackBoard(BlackBoard blackBoard);
    public bool DeleteBlackBoard(Guid blackBoardId);
    public BlackBoard? GetByIdBlackBoards(Guid blackBoardId);
    public List<BlackBoard> GetAllBlackBoards();

}

