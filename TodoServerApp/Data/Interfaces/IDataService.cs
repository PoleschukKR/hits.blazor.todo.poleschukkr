namespace TodoServerApp.Data.Interfaces
{
	public interface IDataService
	{
		 Task<IEnumerable<TaskItem>> GetTaskItemAsync();	
	}
}
