namespace lesson_7;

public class User
{
	public Guid UserId { get; private set; }
	public string UserName { get; set; }


	private string carNum;
	public string CarNum
	{
		get { return carNum; }
		set
		{
			if (value.Length >= 6)
			{
				carNum = value;
			}
		}
	}
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public User()
	{
		UserId = Guid.NewGuid();
	}
}
